using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace WMSwithRFID
{
    class RFIDAPI
    {
        [DllImport("RFIDAPI.dll", EntryPoint = "SAAT_TCPInit")]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool SAAT_TCPInit(out IntPtr pHandle, string pHostName, int nsocketPort);

        [DllImport("RFIDAPI.dll", EntryPoint = "SAAT_COMInit")]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool SAAT_COMInit(out IntPtr pHandle, byte nBusAddr, string pComNum, int nBaud);

        [DllImport("RFIDAPI.dll", EntryPoint = "SAAT_USBInit")]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool SAAT_USBInit(out IntPtr pHandle, byte nBusAddr, string pUSBNum, int nBaud);

        [DllImport("RFIDAPI.dll", EntryPoint = "SAAT_Open")]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool SAAT_Open(IntPtr pHandle);

        [DllImport("RFIDAPI.dll", EntryPoint = "SAAT_Close")]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool SAAT_Close(IntPtr pHandle);

        [DllImport("RFIDAPI.dll", EntryPoint = "SAAT_SysInfSet")]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool SAAT_SysInfSet(IntPtr pHandle, byte nType, byte[] pParm, byte nLen);

        [DllImport("RFIDAPI.dll", EntryPoint = "SAAT_SysInfQuery")]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool SAAT_SysInfQuery(IntPtr pHandle, byte nType, IntPtr pPara, ref byte pLen);

        [DllImport("RFIDAPI.dll", EntryPoint = "SAAT_WorkModeSet")]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool SAAT_WorkModeSet(IntPtr pHandle, byte nType);

        [DllImport("RFIDAPI.dll", EntryPoint = "SAAT_SysTest")]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool SAAT_SysTest(IntPtr pHandle, byte nType, byte bAntenna, byte[] pTestParm, byte nLen);

        [DllImport("RFIDAPI.dll", EntryPoint = "SAAT_ParmOp")]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool SAAT_ParmOp(IntPtr pHandle, byte nType, byte nStartAddrr, byte nLen, byte[] pData, ref byte pDataLen);

        [DllImport("RFIDAPI.dll", EntryPoint = "SAAT_RFParaSet")]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool SAAT_RFParaSet(IntPtr pHandle, byte nType, byte nParaLen, byte[] pPara);

        [DllImport("RFIDAPI.dll", EntryPoint = "SAAT_RFParaQuery")]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool SAAT_RFParaQuery(IntPtr pHandle, byte nType, byte[] pPara, ref byte pLen);

        [DllImport("RFIDAPI.dll", EntryPoint = "SAAT_CommunicatParaSet")]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool SAAT_CommunicatParaSet(IntPtr pHandle, byte nType, ref byte pPara, byte nLen);

        [DllImport("RFIDAPI.dll", EntryPoint = "SAAT_CommunicatParaQuery")]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool SAAT_CommunicatParaQuery(IntPtr pHandle, byte nType, ref byte pPara, ref byte pLen);

        [DllImport("RFIDAPI.dll", EntryPoint = "SAAT_NetParaSet")]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool SAAT_NetParaSet(IntPtr pHandle, byte nType, byte[] pPara, byte nLen);

        [DllImport("RFIDAPI.dll", EntryPoint = "SAAT_NetParaQuery")]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool SAAT_NetParaQuery(IntPtr pHandle, byte nType, byte[] pPara, ref byte pLen);

        [DllImport("RFIDAPI.dll", EntryPoint = "SAAT_TagOpParaSet")]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool SAAT_TagOpParaSet(IntPtr pHandle, byte nType, byte[] pPara, byte pLen);

        [DllImport("RFIDAPI.dll", EntryPoint = "SAAT_TagOpParaQuery")]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool SAAT_TagOpParaQuery(IntPtr pHandle, byte nType, byte[] pPara, ref byte pLen);

        [DllImport("RFIDAPI.dll", EntryPoint = "SAATExtendBroadParaSet")]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool SAATExtendBroadParaSet(IntPtr pHandle, byte nType, byte pSendChunnel);

        [DllImport("RFIDAPI.dll", EntryPoint = "SAAT_ExtendBroadParaQuery")]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool SAAT_ExtendBroadParaQuery(IntPtr pHandle, byte nType, byte[] pPara, ref byte pLen);

        [DllImport("RFIDAPI.dll", EntryPoint = "SAAT_TotalAntennaParmQuery")]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool SAAT_TotalAntennaParmQuery(IntPtr pHandle, byte[] szAntennaPara, ref byte pLen);

        [DllImport("RFIDAPI.dll", EntryPoint = "SAAT_AntennaParmQuery")]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool SAAT_AntennaParmQuery(IntPtr pHandle, byte nAntenna, ref byte pAntennaEnable, ref byte pAntennaPower, ref byte pAntennaQueryTime);

        [DllImport("RFIDAPI.dll", EntryPoint = "SAAT_AntennaParmSet")]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool SAAT_AntennaParmSet(IntPtr pHandle, byte[] pPara, byte nLen);

        [DllImport("RFIDAPI.dll", EntryPoint = "SAAT_SetAntennaPortEnable")]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool SAAT_SetAntennaPortEnable(IntPtr pHandle, byte nAntenna, byte nEnable);

        [DllImport("RFIDAPI.dll", EntryPoint = "SAAT_SetAntennaPower")]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool SAAT_SetAntennaPower(IntPtr pHandle, byte nAntenna, byte nPower);

        [DllImport("RFIDAPI.dll", EntryPoint = "SAAT_SetAntennaTime")]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool SAAT_SetAntennaTime(IntPtr pHandle, byte nAntenna, byte nTime);

        [DllImport("RFIDAPI.dll", EntryPoint = "SAAT_PowerOff")]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool SAAT_PowerOff(IntPtr pHandle);

        [DllImport("RFIDAPI.dll", EntryPoint = "SAAT_GetErrorMessage")]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool SAAT_GetErrorMessage(IntPtr pHandle, byte[] szMsg, int nLen);

        [DllImport("RFIDAPI.dll", EntryPoint = "SAAT_CarrierWaveOp")]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool SAAT_CarrierWaveOp(IntPtr pHandle, byte nType, byte nPort);

        [DllImport("RFIDAPI.dll", EntryPoint = "SAAT_IOOperate")]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool SAAT_IOOperate(IntPtr pHandle, byte nPort, byte nState);

        [DllImport("RFIDAPI.dll", EntryPoint = "SAAT_IOStateQuery")]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool SAAT_IOStateQuery(IntPtr pHandle, ref byte pState);

        [DllImport("RFIDAPI.dll", EntryPoint = "SAAT_6BTagSelect")]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool SAAT_6BTagSelect(IntPtr pHandle, byte nType, byte nStartAddr, byte nDataBite, byte[] btData);

        [DllImport("RFIDAPI.dll", EntryPoint = "SAAT_6BReadUIDCode")]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool SAAT_6BReadUIDCode(IntPtr pHandle, byte nAntenna, byte nType);

        [DllImport("RFIDAPI.dll", EntryPoint = "SAAT_6BRevUIDMsg")]
        public static extern int SAAT_6BRevUIDMsg(IntPtr pHandle, out byte nAntenna, byte[] pUIDData,
                                                out byte nUIDLen);

        [DllImport("RFIDAPI.dll", EntryPoint = "SAAT_6BReadUserData")]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool SAAT_6BReadUserData(IntPtr pHandle, byte nAntenna, byte nType, byte[] pTagID,
            byte nStartAddr, byte nReadLen, byte[] pdata, byte dataLen);

        [DllImport("RFIDAPI.dll", EntryPoint = "SAAT_6BWriteUserData")]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool SAAT_6BWriteUserData(IntPtr pHandle, byte nAntenna, byte nType, byte[] pTagID,
            byte nStartAddrr, byte[] pValue, ref byte nLen);

        [DllImport("RFIDAPI.dll", EntryPoint = "SAAT_6BTagLock")]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool SAAT_6BTagLock(IntPtr pHandle, byte nAntenna, byte nType, byte[] pTagID, byte nStartAddrr, byte nLen);

        [DllImport("RFIDAPI.dll", EntryPoint = "SAAT_6CTagSelect")]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool SAAT_6CTagSelect(IntPtr pHandle, byte nBank, byte nStartAddr, byte MaskBit,
            byte[] btData, byte Datalength, byte nSessionZone, byte nActiveFlag, byte nCutFlag);

        [DllImport("RFIDAPI.dll", EntryPoint = "SAAT_6CReadEPCCode")]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool SAAT_6CReadEPCCode(IntPtr pHandle, byte nAntenna, byte nType,
            byte nTagCount);

        [DllImport("RFIDAPI.dll", EntryPoint = "SAAT_6CRevEPCMsg")]
        public static extern int SAAT_6CRevEPCMsg(IntPtr pHandle, out byte nAntenna, byte[] pEPCData,
            out byte nEPCLen);

        [DllImport("RFIDAPI.dll", EntryPoint = "SAAT_6CReadTIDCode")]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool SAAT_6CReadTIDCode(IntPtr pHandle, byte nAntenna, byte nType, byte nTagCount);

        [DllImport("RFIDAPI.dll", EntryPoint = "SAAT_6CRevTIDMsg")]
        public static extern int SAAT_6CRevTIDMsg(IntPtr pHandle, out byte nAntenna, byte[] pTIDData, out byte nTIDLen);

        [DllImport("RFIDAPI.dll", EntryPoint = "SAAT_6CWriteEPCCode")]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool SAAT_6CWriteEPCCode(IntPtr pHandle, byte nAntenna, byte nType,
            byte[] pAccessPWD, byte[] pWriteData, byte nLen);

        [DllImport("RFIDAPI.dll", EntryPoint = "SAAT_6CReadUserData")]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool SAAT_6CReadUserData(IntPtr pHandle, byte nAntenna, byte StartAddr,
            byte nLength, byte[] UserData, byte nDataLen);

        [DllImport("RFIDAPI.dll", EntryPoint = "SAAT_6CWriteUserData")]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool SAAT_6CWriteUserData(IntPtr pHandle, byte nAntenna, byte nType,
            byte[] pAccessPWD, byte nStartAddr, byte[] pWriteData, byte nLen);

        [DllImport("RFIDAPI.dll", EntryPoint = "SAAT_6CWriteBankData")]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool SAAT_6CWriteBankData(IntPtr pHandle, byte nAntenna, byte nType, byte[] pAccessPWD,
            byte nBank, byte[] pWriteData, byte nLen);

        [DllImport("RFIDAPI.dll", EntryPoint = "SAAT_6CClearBankData")]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool SAAT_6CClearBankData(IntPtr pHandle, byte nAntenna, byte nType, byte[] pAccessPWD,
            byte nBank, byte nStartAddr, byte nLen);

        [DllImport("RFIDAPI.dll", EntryPoint = "SAAT_6CAccessPWDSet")]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool SAAT_6CAccessPWDSet(IntPtr pHandle, byte nAntenna, byte nType, byte[] pOrgPWD, byte[] pNewPWD);

        [DllImport("RFIDAPI.dll", EntryPoint = "SAAT_6CDestroyPWDSet")]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool SAAT_6CDestroyPWDSet(IntPtr pHandle, byte nAntenna, byte nType, byte[] pAccessPWD, byte[] pDestroyPWD);

        [DllImport("RFIDAPI.dll", EntryPoint = "SAAT_6CTagLock")]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool SAAT_6CTagLock(IntPtr pHandle, byte nAntenna, byte[] pAccessPWD, byte nType, byte nBank);

        [DllImport("RFIDAPI.dll", EntryPoint = "SAAT_6CTagKill")]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool SAAT_6CTagKill(IntPtr pHandle, byte nAntenna, byte[] pDestroyPWD, byte[] pEPC, int nEPCLen);

        [DllImport("RFIDAPI.dll", EntryPoint = "SAAT_6CEASFlagSet")]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool SAAT_6CEASFlagSet(IntPtr pHandle, byte nAntenna, byte nType, byte[] pAccessPwd, int nEASFlag);

        [DllImport("RFIDAPI.dll", EntryPoint = "SAAT_6CEASMonitorEnable")]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool SAAT_6CEASMonitorEnable(IntPtr pHandle, byte nAntenna, byte nType, byte[] pAccesssPwd, byte nSetEAS, byte nMonitorType);

        [DllImport("RFIDAPI.dll", EntryPoint = "SAAT_Copyright")]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool SAAT_Copyright(out IntPtr pHandle, StringBuilder copyright);

        [DllImport("RFIDAPI.dll", EntryPoint = "SAAT_HeartSend")]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool SAAT_HeartSend(IntPtr pHandle);
    }
}
