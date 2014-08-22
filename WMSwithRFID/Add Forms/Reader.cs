using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using System.Threading;
//using Szaat.RFID.CSharpAPI;
using System.Runtime.InteropServices;
using MySql.Data.MySqlClient;
using WMSwithRFID.Domain_Classes;

namespace WMSwithRFID
{
    public partial class Reader : Form
    {

        //state for connection
        public bool connectionState = false;

        public IntPtr pHandle = IntPtr.Zero;

        /// <summary>
        /// Read Tag Thread
        /// </summary>
        Thread readThread = null;

        /// <summary>
        /// Read Tag Status
        /// </summary>
        bool readTagStatus = false;


        /// <summary>
        /// Tag Information Buffer
        /// </summary>
        Antenna revMsgLine = new Antenna();

        /// <summary>
        /// Operating type
        /// </summary>
        int SAAT_CODE_TYPE = 0;

        /// <summary>
        /// Antenna No.
        /// </summary>
        byte sAntenna = 0;

        /// <summary>
        /// Read Tag Type
        /// </summary>
        int SAAT_READ_TYPE = 1;


        public Reader()
        {
            System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
            //loadReadRFID();
            LoadFinishedProducts();
            LoadProuductionLinesCB();
            LoadProductCB();
        }

        /// <summary>
        /// Initializing
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>


        /// <summary>
        /// Display record, sound indicate
        /// </summary>
        /// <param name="beepMessage"></param>
        /// <param name="beepType"></param>
        private void ShowResult(string beepMessage, Win32.BeepType beepType)
        {
            lstResult.Items.Add(beepMessage);
            lstResult.SelectedIndex = lstResult.Items.Count - 1;
        }

        // Update button status
        private void updateButtons()
        {

            openConnectionBtn.Enabled = !connectionState;//open connection button is now disabled
            closeConnectionBtn.Enabled = connectionState;//close connection button is now enabled

            startReadingBtn.Enabled = !readTagStatus && connectionState;
            stopReadingBtn.Enabled = readTagStatus && connectionState;

        }


        /// <summary>
        /// Clear Result
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClearResult_Click(object sender, EventArgs e)
        {
            lstResult.Items.Clear();
        }


        /// <summary>
        /// Open Connect
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        private void openConnectionBtn_Click(object sender, EventArgs e)
        {

            bool initialize = false;

            //1.COM Parameter Initialization
            //initialize = RFIDAPI.SAAT_COMInit(out pHandle, 0x00, cbxCom.SelectedItem.ToString(), 19200);
            initialize = RFIDAPI.SAAT_USBInit(out pHandle, 0x00, cbxCom.SelectedItem.ToString(), 19200);


            if (!initialize)
            {
                ShowResult("Failed to initialized!", Win32.BeepType.Failure);
                return;
            }

            // 2.Connect
            connectionState = RFIDAPI.SAAT_Open(pHandle);
            if (!connectionState)
            {
                ShowResult("Failed to connect!", Win32.BeepType.Failure);
                return;
            }

            ShowResult("Succeeded to connect", Win32.BeepType.Success);
            updateButtons();

        }

        private bool CloseConn()
        {
            if (pHandle == IntPtr.Zero)
            {
                return true;
            }

            readTagStatus = false;
            bool bRet = RFIDAPI.SAAT_Close(pHandle);
            if (bRet)
            {
                pHandle = IntPtr.Zero;
            }
            return bRet;
        }
        /// <sumCmary>
        /// Close connection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCloseConn_Click(object sender, EventArgs e)
        {
            connectionState = !CloseConn();
            if (connectionState)
            {
                ShowResult("Failed to disconnect!", Win32.BeepType.Failure);
                return;
            }

            ShowResult("succeeded to disconnect!", Win32.BeepType.Success);
            updateButtons();
        }

        /// <summary>
        /// Start Reading
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReadCards_Click(object sender, EventArgs e)
        {
            // Setup Timer to Update the received information
            if (readThread != null)
            {
                if (readThread.IsAlive)
                {
                    readThread.Abort();
                    readThread.Join();
                }
            }


            if (!sendReadTagCommand())
            {
                ShowResult("Failed to send read command!", Win32.BeepType.Success);
                return;
            }

            readTagStatus = true;
            timerUpdateListView.Enabled = true;
            // revMsgLine.ClearAntennaDetails();

            ShowResult("Start Reading!", Win32.BeepType.Success);
            updateButtons();

            readThread = new Thread(new ThreadStart(receivedTagInformationThread));
            readThread.Start();
        }



        /// <summary>
        /// Thread of Receive tag information 
        /// </summary>
        private void receivedTagInformationThread()
        {
            int receivedTagResult = 0;

            AntennaDetails receivedAntennaDetails = new AntennaDetails();

            while (readTagStatus)
            {
                receivedTagResult = receivedTagInfo(ref receivedAntennaDetails);
                if (receivedTagResult == 1)//Get tag information
                {
                    revMsgLine.AddAntennaDetails(receivedAntennaDetails);
                }
            }
        }

        /// <summary>
        /// Send read-tag command function
        /// </summary>
        /// <returns></returns>
        public bool sendReadTagCommand()
        {
            byte SAAT_SCAN_TRIES = 3;

            switch (SAAT_CODE_TYPE)
            {
                case 0://Read EPC Code
                    return RFIDAPI.SAAT_6CReadEPCCode(pHandle, sAntenna, (byte)SAAT_READ_TYPE, SAAT_SCAN_TRIES);
                case 1://Read TID Code
                    return RFIDAPI.SAAT_6CReadTIDCode(pHandle, sAntenna, (byte)SAAT_READ_TYPE, SAAT_SCAN_TRIES);
                case 2://Read UID Code
                    return RFIDAPI.SAAT_6BReadUIDCode(pHandle, sAntenna, (byte)SAAT_READ_TYPE);
            }
            return false;
        }

        /// <summary>
        /// Receive tag information function
        /// </summary>
        /// <param name="receivedAntennaDetails">Struct for storing tag information</param>
        /// <returns></returns>
        public int receivedTagInfo(ref AntennaDetails revMsg)
        {
            byte sLength = 255;     // 
            string sData = "";
            byte[] btData = new byte[255];
            int bResult = 0;

            try
            {
                switch (SAAT_CODE_TYPE)
                {
                    case 0:
                        bResult = RFIDAPI.SAAT_6CRevEPCMsg(pHandle, out sAntenna, btData, out sLength);
                        break;
                    case 1:
                        bResult = RFIDAPI.SAAT_6CRevTIDMsg(pHandle, out sAntenna, btData, out sLength);
                        break;
                    case 2:
                        bResult = RFIDAPI.SAAT_6BRevUIDMsg(pHandle, out sAntenna, btData, out sLength);
                        break;
                }
            }
            catch
            {

            }

            if (bResult == 1 && sLength != 255)
            {
                //MessageBox.Show("" + sAntenna);
                revMsg.antennaNo = (int)sAntenna;
                for (byte bytei = 0; bytei < sLength; bytei++)
                    sData += btData[bytei].ToString("X2");
                revMsg.epcCode = sData;
                revMsg.nRepeatTime = 1;
                // MessageBox.Show("" + revMsg.nRepeatTime);
            }

            if (revMsg.antennaNo == 1 && revMsg.nRepeatTime == 1)
            {
                revMsg.nRepeatTime = revMsg.nRepeatTime - 1;

                WMScontext wms1 = new WMScontext();


                var epcCount = (from epc in wms1.FinishedProducts where epc.EPC == sData select epc).Count();
                if (epcCount == 0)
                {
                    FinishedProduct fp1 = new FinishedProduct
                    {

                        DateManufactured = DateTime.Now,
                        Status = (Status)Enum.Parse(typeof(Status), "OntheMove"),
                        EPC = sData
                    };

                    wms1.FinishedProducts.Add(fp1);
                    wms1.SaveChanges();
                }
            }
            if (revMsg.antennaNo == 2 && revMsg.nRepeatTime == 1)
            {
                revMsg.nRepeatTime = revMsg.nRepeatTime - 1;

                WMScontext wms = new WMScontext();
                var epcCount = (from epc in wms.FinishedProducts where epc.EPC == sData select epc).Count();
                if (epcCount == 0)
                {
                    FinishedProduct fp = new FinishedProduct
                    {

                        DateManufactured = DateTime.Now,
                        Status = (Status)Enum.Parse(typeof(Status), "Stored"),
                        EPC = sData
                    };

                    wms.FinishedProducts.Add(fp);
                    wms.SaveChanges();
                }
            }
            return bResult;
        }

        /// <summary>
        /// Stop Read Tag
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStopReadCards_Click(object sender, EventArgs e)
        {
            // Stop Timer
            timerUpdateListView.Enabled = false;

            //Terminate Thread
            if (readThread.IsAlive)
            {
                readThread.Abort();
                readThread.Join();
            }

            // Stop Read Tag
            if (RFIDAPI.SAAT_PowerOff(pHandle))
            {
                ShowResult("Stop Read Tag!", Win32.BeepType.Success);
            }
            else
            {
                MessageBox.Show("Failed to Stop Read Tag!");
            }

            // Clear
            readTagStatus = false;
            updateButtons();
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Exit();
        }

        /// <summary>
        /// Exit The System
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExit_Click(object sender, EventArgs e)
        {
            Exit();
        }

        /// <summary>
        /// 
        /// </summary>
        private void Exit()
        {
            try
            {
                if (readThread.IsAlive) readThread.Abort();
            }
            catch { }

            System.Diagnostics.Process[] LocalPro = System.Diagnostics.Process.GetProcessesByName("ProcessName");
            if (LocalPro.Length > 0)
            {
                foreach (System.Diagnostics.Process a in LocalPro) { a.Kill(); }
            }
            Application.Exit();
        }

        private void LoadFinishedProducts()
        {
            WMScontext wms = new WMScontext();
            var q = from prod in wms.FinishedProducts
                    select new
                    {
                        prod.DateManufactured,
                        prod.EPC,
                        prod.Status
                    };
            dataGridView1.DataSource = q.ToList();
        }

        private void timerUpdateListView_Tick(object sender, EventArgs e)
        {
            LoadFinishedProducts();
        }

        private void dataGridView1_MouseHover(object sender, EventArgs e)
        {
            timerUpdateListView.Enabled = false;
        }

        private void dataGridView1_MouseLeave(object sender, EventArgs e)
        {
            timerUpdateListView.Enabled = true;
        }

        private void LoadProuductionLinesCB()
        {
            ProductionLine productionLine = new ProductionLine();
            productLineCB.DataSource = productionLine.getAllProductionLineQuery();
            productLineCB.DisplayMember = "Production Line No.";
            productLineCB.ValueMember = "ID";
        }

        private void LoadProductCB()
        {
            Product product = new Product();
            productCB.DataSource = product.GetAllProductQuery();
            productCB.DisplayMember = "Name";
            productCB.ValueMember = "ID";

        }
    }
}