using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WMSwithRFID
{
    public struct AntennaDetails
    {

        public string epcCode;
        public int antennaNo;
        public long nRepeatTime;
    }

    class Antenna
    {
        List<AntennaDetails> listAntennaDetails = new List<AntennaDetails>();

        public void AddAntennaDetails(AntennaDetails antennaDetails)
        {
            for (int i = 0; i < listAntennaDetails.Count; ++i)
            {
                if (listAntennaDetails[i].epcCode == antennaDetails.epcCode && listAntennaDetails[i].antennaNo == antennaDetails.antennaNo)
                {
                    // MessageBox.Show("" + antennaDetails.antennaNo);
                    AntennaDetails details = listAntennaDetails[i];
                    listAntennaDetails[i] = details;
                    return;
                }
            }
            listAntennaDetails.Add(antennaDetails);
        }

        //public AntennaDetails Get(int i)
        //{
        //    return listAntennaDetails[i];
        //}

        //public int TagCount
        //{
        //    get { return listAntennaDetails.Count; }
        //}
 
    }
}
