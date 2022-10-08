using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace COMMLIB
{
    using System.Runtime.InteropServices;

    public enum SCARD_SCOPE : uint
    {
        SCARD_SCOPE_USER = 0x00000000,
        SCARD_SCOPE_TERMINAL = 0x00000001,
        SCARD_SCOPE_SYSTEM = 0x00000002
    }
    public enum SCARD_PROTOCOLS : int
    {
        SCARD_PROTOCOL_UNDEFINED = 0,
        SCARD_PROTOCOL_T0 = 1,
        SCARD_PROTOCOL_T1 = 2,
        SCARD_PROTOCOL_RAW = 0x10000
    }

    public enum SCARD_SHAREMODE : int
    {
        SCARD_SHARE_EXCLUSIVE = 1,
        SCARD_SHARE_SHARED = 2,
        SCARD_SHARE_DIRECT = 3
    }


    public enum SCARD_DISPOSITION : int
    {
        SCARD_LEAVE_CARD = 0,
        SCARD_RESET_CARD = 1,
        SCARD_UNPOWER_CARD = 2,
        SCARD_EJECT_CARD = 3
    }

    public struct SCARD_IO_REQUEST
    {
        public SCARD_PROTOCOLS dwProtocol;
        public int cbPciLength;
    }

    public enum SCARD_STATUS : int
    {
        SCARD_UNKNOWN = 0,
        SCARD_ABSENT = 1,
        SCARD_PRESENT = 2,
        SCARD_SWALLOWED = 3,
        SCARD_POWERED = 4,
        SCARD_NEGOTIABLE = 5,
        SCARD_SPECIFIC = 6

    }


    public enum SCARD_ERROR : uint
    {
        SCARD_SUCCESS = 0,
        SCARD_F_INTERNAL_ERROR = 0x80100001,
        SCARD_E_CANCELLED = 0x80100002,
        SCARD_E_INVALID_HANDLE = 0x80100003,
        SCARD_E_INVALID_PARAMETER = 0x80100004,
        SCARD_E_INVALID_TARGET = 0x80100005,
        SCARD_E_NO_MEMORY = 0x80100006,
        SCARD_F_WAITED_TOO_LONG = 0x80100007,
        SCARD_E_INSUFFICIENT_BUFFER = 0x80100008,
        SCARD_E_UNKNOWN_READER = 0x80100009,
        SCARD_E_TIMEOUT = 0x8010000A,
        SCARD_E_SHARING_VIOLATION = 0x8010000B,
        SCARD_E_NO_SMARTCARD = 0x8010000C,
        SCARD_E_UNKNOWN_CARD = 0x8010000D,
        SCARD_E_CANT_DISPOSE = 0x8010000E,
        SCARD_E_PROTO_MISMATCH = 0x8010000F,
        SCARD_E_NOT_READY = 0x80100010,
        SCARD_E_INVALID_VALUE = 0x80100011,
        SCARD_E_SYSTEM_CANCELLED = 0x80100012,
        SCARD_F_COMM_ERROR = 0x80100013,
        SCARD_F_UNKNOWN_ERROR = 0x80100014,
        SCARD_E_INVALID_ATR = 0x80100015,
        SCARD_E_NOT_TRANSACTED = 0x80100016,
        SCARD_E_READER_UNAVAILABLE = 0x80100017,
        SCARD_P_SHUTDOWN = 0x80100018,
        SCARD_E_PCI_TOO_SMALL = 0x80100019,
        SCARD_E_READER_UNSUPPORTED = 0x8010001A,
        SCARD_E_DUPLICATE_READER = 0x8010001B,
        SCARD_E_CARD_UNSUPPORTED = 0x8010001C,
        SCARD_E_NO_SERVICE = 0x8010001D,
        SCARD_E_SERVICE_STOPPED = 0x8010001E,
        SCARD_E_UNEXPECTED = 0x8010001F,
        SCARD_E_ICC_INSTALLATION = 0x80100020,
        SCARD_E_ICC_CREATEORDER = 0x80100021,
        SCARD_E_UNSUPPORTED_FEATURE = 0x80100022,
        SCARD_E_DIR_NOT_FOUND = 0x80100023,
        SCARD_E_FILE_NOT_FOUND = 0x80100024,
        SCARD_E_NO_DIR = 0x80100025,
        SCARD_E_NO_FILE = 0x80100026,
        SCARD_E_NO_ACCESS = 0x80100027,
        SCARD_E_WRITE_TOO_MANY = 0x80100028,
        SCARD_E_BAD_SEEK = 0x80100029,
        SCARD_E_INVALID_CHV = 0x8010002A,
        SCARD_E_UNKNOWN_RES_MNG = 0x8010002B,
        SCARD_E_NO_SUCH_CERTIFICATE = 0x8010002C,
        SCARD_E_CERTIFICATE_UNAVAILABLE = 0x8010002D,
        SCARD_E_NO_READERS_AVAILABLE = 0x8010002E,
        SCARD_E_COMM_DATA_LOST = 0x8010002F,
        SCARD_E_NO_KEY_CONTAINER = 0x80100030,
        SCARD_E_SERVER_TOO_BUSY = 0x80100031,
        SCARD_W_UNSUPPORTED_CARD = 0x80100065,
        SCARD_W_UNRESPONSIVE_CARD = 0x80100066,
        SCARD_W_UNPOWERED_CARD = 0x80100067,
        SCARD_W_RESET_CARD = 0x80100068,
        SCARD_W_REMOVED_CARD = 0x80100069,
        SCARD_W_SECURITY_VIOLATION = 0x8010006A,
        SCARD_W_WRONG_CHV = 0x8010006B,
        SCARD_W_CHV_BLOCKED = 0x8010006C,
        SCARD_W_EOF = 0x8010006D,
        SCARD_W_CANCELLED_BY_USER = 0x8010006E,
        SCARD_W_CARD_NOT_AUTHENTICATED = 0x8010006F

    }

    public class PCSCDLL
    {
        /// <summary>
        /// Load dynamic library
        /// </summary>
        /// <param name="dllName">Dynamic library name</param>
        /// <returns>Dynamic library entry pointer</returns>
        [DllImport("kernel32.dll")]
        public static extern IntPtr LoadLibrary(string dllName);

        /// <summary>
        /// Get method address in dynamic library
        /// </summary>
        /// <param name="hModule">Dynamic library load address</param>
        /// <param name="procedureName">Method name</param>
        /// <returns>Method address</returns>
        [DllImport("kernel32.dll")]
        public static extern IntPtr GetProcAddress(IntPtr hModule, string procedureName);

        /// <summary>
        /// Fred dynamic library
        /// </summary>
        /// <param name="hModule">Dynamic library load address</param>
        /// <returns>Whether the release was successful</returns>
        [DllImport("kernel32.dll")]
        public static extern bool FreeLibrary(IntPtr hModule);


        public enum SCARD_SCPOE : int
        {
            USER = 0x00000000,
            TERMAINAL = 0x00000001,
            SYSTEM = 0x00000002
        }

   

        /// <summary>
        /// Create a reader device management context
        /// </summary>
        /// <param name="dwScope">Available range of card reader, SCARD_SCPOE.USER is the current user,
        /// TERMINAL is unknown, SYSTEM is all users of the current system</param>
        /// <param name="reserverd1">Reserved, must be 0</param>
        /// <param name="reserverd2">Reserved, must be 0</param>
        /// <param name="hContext">Incoming and outgoing parameters, device manager handle</param>
        /// <returns></returns>
        [DllImport("WinSCard.dll")]
        public static extern int SCardEstablishContext(UInt32 dwScope
                                                      , int reserverd1
                                                      , int reserverd2
                                                      , out int hContext);

        /// <summary>
        /// Back to card reader list
        /// </summary>
        /// <param name="hContext">Device manager handle</param>
        /// <param name="mszGroups">Useless parameters, just send null</param>
        /// <param name="mszReaders">Device name collection</param>
        /// <param name="mszReadersSize">Device name collection total length</param>
        /// <returns>If it returns 0, it means that the card reader is successfully acquired</returns>
        [DllImport("WinSCard.dll")]
        public static extern int SCardListReaders(int hContext
                                                , byte[] mszGroups
                                                , byte[] mszReaders
                                                , ref int mszReadersSize);

   
        /// <summary>
        /// Card connection
        /// </summary>
        /// <param name="hContext">Device handle</param>
        /// <param name="szReader">Card reader name</param>
        /// <param name="dwShareMode">Card common mode</param>
        /// <param name="dwProtocols">Protocol usage model</param>
        /// <param name="hCard">Card connection handle</param>
        /// <param name="activeProtocol">Card operation protocol</param>
        /// <returns></returns>
        [DllImport("WinSCard.dll")]
        public static extern uint SCardConnect(int hContext
                                             , string szReader
                                             , SCARD_SHAREMODE dwShareMode
                                             , SCARD_PROTOCOLS dwProtocols
                                             , ref int hCard
                                             , ref SCARD_PROTOCOLS activeProtocol);


        /// <summary>
        /// Set card status
        /// </summary>
        /// <param name="hCard">Card handle</param>
        /// <param name="szReaderName">Device name</param>
        /// <param name="hContent">Device handle</param>
        /// <param name="pdwState">Card status</param>
        /// <param name="pdwProtocol">Protocol used by the card</param>
        /// <param name="ATR">ATR string</param>
        /// <param name="length">ATR string length</param>
        /// <returns></returns>
        [DllImport("WinSCard.dll")]
        public static extern int SCardStatus(int hCard
                                            , string szReaderName
                                            , ref int hContent
                                            , ref int pdwState
                                            , ref int pdwProtocol
                                            , byte[] ATR
                                            , ref int length);


        /// <summary>
        /// Get card status
        /// </summary>
        /// <param name="hCard">Card handle</param>
        /// <param name="pdwState">Card status</param>
        /// <param name="pdwProtocol">Protocol used by the card</param>
        /// <param name="ATR">ATR string</param>
        /// <param name="length">ATR string length</param>
        /// <returns></returns>
        [DllImport("WinSCard.dll")]
        public static extern uint SCardState(int hCard
                                            , ref SCARD_STATUS pdwState
                                            , ref SCARD_PROTOCOLS pdwProtocol
                                            , byte[] ATR
                                            , ref int length);



        /// <summary>
        /// Send data to the card
        /// </summary>
        /// <param name="hCard">Card handle</param>
        /// <param name="pioSendPci">Pointer to the protocol header structure of the instruction</param>
        /// <param name="pbSendBuffer">Write card data</param>
        /// <param name="cbSendLength">Write card data length</param>
        /// <param name="pioRecvPci"></param>
        /// <param name="pbRecvBuffer">Return data</param>
        /// <param name="pcbRecvLength"></param>
        /// <returns></returns>
        [DllImport("WinSCard.dll")]
        public static extern uint SCardTransmit(
                                 int hCard,
                                 ref SCARD_IO_REQUEST pioSendPci,
                                 byte[] pbSendBuffer,
                                 int cbSendLength,
                                 ref SCARD_IO_REQUEST pioRecvPci,
                                 byte[] pbRecvBuffer,
                                 ref int pcbRecvLength
            );

        //[DllImport("PcscScard.dll")]
        [DllImport(@"PcscScard.dll", EntryPoint = "MySCardTransmit", SetLastError = true, CharSet = CharSet.Ansi, ExactSpelling = false, CallingConvention = CallingConvention.Cdecl)]
        public static extern int MySCardTransmit(
                                int hCard,
                                byte[] pbSendBuffer,
                                int cbSendLength,
                                byte[] pbRecvBuffer,
                                ref int pcbRecvLength
           );

        /// <summary>
        /// Release connection
        /// </summary>
        /// <param name="hCard">Reference value obtained by calling SCardConnect</param>
        /// <param name="dwDisposition">
        /// SCARD_LEAVE_CARD = 0; Do nothing with the card
        /// SCARD_RESET_CARD = 1; Card reset
        /// SCARD_UNPOWER_CARD = 2; Power down the card
        /// SCARD_EJECT_CARD = 3; Eject card
        /// </param>
        /// <returns>
        /// </returns>
        [DllImport("WinSCard.dll")]
        public static extern int SCardDisconnect(
                                 int hCard,
                                 int dwDisposition
            );

        /// <summary>
        /// Release resources
        /// </summary>
        /// <param name="hContext">Resource handle</param>
        /// <returns></returns>
        [DllImport("WinSCard.dll")]
        public static extern int SCardReleaseContext(
                                 int hContext
            );

        [DllImport("WinSCard.dll")]
        public static extern int SCardBeginTransaction(int hContext);

    }

    public class PCSCDEV
    {
        private string errMsg = "";
        
        private static IntPtr SCARD_PCI_T0;
        private static IntPtr SCARD_PCI_T1;
        private static IntPtr SCARD_PCI_RAW;
        private const int SCARD_SUCCESS = 0;


        /// <summary>
        /// Context handle
        /// </summary>
        private int hContext = 0;
        public bool isConnectCard = false;
#if true
        /// <summary>
        /// Card handle
        /// </summary>
        private int hCard = 0;
        /// <summary>
        /// Transmission protocol used by the card
        /// </summary>
        private SCARD_PROTOCOLS activeProtocol = 0;
        /// <summary>
        /// Card reader name used
        /// </summary>
        private string activeReaderName = "";
#endif
        public int runResult = -1;     //Whether the interface is initialized or running successfully

        public PCSCDEV()
        {
            if (SCARD_PCI_T0 == IntPtr.Zero || SCARD_PCI_T1 == IntPtr.Zero ||
                SCARD_PCI_RAW == IntPtr.Zero)
            {
                IntPtr hWinSCardDll = IntPtr.Zero;
                try
                {
                    hWinSCardDll = PCSCDLL.LoadLibrary("WinSCard.dll");

                    if (hWinSCardDll == IntPtr.Zero)
                    {
                        errMsg = "Loading WinsCard.dll failed!";
  
                        throw new Exception(errMsg);
                    }

                    if (SCARD_PCI_T0 == IntPtr.Zero)
                    {
                        SCARD_PCI_T0 = PCSCDLL.GetProcAddress(hWinSCardDll, "g_rgSCardT0Pci");

                        if (SCARD_PCI_T0 == IntPtr.Zero)
                        {
                            errMsg = "Failed to get SCARD_PCI_T0 address, please check the loading of WinsCard.dll!";
                           
                            throw new Exception(errMsg);
                        }
                    }

                    if (SCARD_PCI_T1 == IntPtr.Zero)
                    {
                        SCARD_PCI_T1 = PCSCDLL.GetProcAddress(hWinSCardDll, "g_rgSCardT1Pci");

                        if (SCARD_PCI_T1 == IntPtr.Zero)
                        {
                            errMsg = "Failed to get SCARD_PCI_T1 address, please check WinsCard.dll!";
                            
                            throw new Exception(errMsg);
                        }
                    }

                    if (SCARD_PCI_RAW == IntPtr.Zero)
                    {
                        SCARD_PCI_RAW = PCSCDLL.GetProcAddress(hWinSCardDll, "g_rgSCardRawPci");

                        if (SCARD_PCI_RAW == IntPtr.Zero)
                        {
                            errMsg = "Failed to get SCARD_PCI_RAW address, please check WinsCard.dll loading!";

                            throw new Exception(errMsg);
                        }
                    }
                    PCSCDLL.FreeLibrary(hWinSCardDll);
                }
                catch (Exception e)
                {
                    throw new Exception(e.Message);
                }
                finally
                {
                    if (hWinSCardDll != IntPtr.Zero)
                    {
                        PCSCDLL.FreeLibrary(hWinSCardDll);
                    }
                }
            }
        }


        public List<string> initPcsc_dev()
        {
           
        //Get device context handle
             runResult = PCSCDLL.SCardEstablishContext(0, 0, 0, out hContext);

            if (runResult != SCARD_SUCCESS)
            {
                return null;
            }

            if (hContext == 0)
            {
                return null;
            }
            int mszReaderSize = 0;
            //Get the list of readers, the first time used to get the length of the string
            runResult = PCSCDLL.SCardListReaders(hContext, null, null, ref mszReaderSize);

            if (runResult != SCARD_SUCCESS)
            {
                return null;
            }

            List<string> readerList = new List<string>();

            byte[] reads = new byte[mszReaderSize];

            //Get card reader list
            runResult = PCSCDLL.SCardListReaders(hContext, null, reads, ref mszReaderSize);

            if (runResult != SCARD_SUCCESS)
            {
                return null;
            }

            ASCIIEncoding encoding = new ASCIIEncoding();
            string strBuffer = encoding.GetString(reads);

            char nullChar = '\0';

            int len = mszReaderSize;
            int index = 0;

            while (strBuffer[0] != nullChar)
            {
                index = strBuffer.IndexOf(nullChar);
                string reader = strBuffer.Substring(0, index);
                len = len - (reader.Length + 1);
                strBuffer = strBuffer.Substring(index + 1, len);
                readerList.Add(reader);
            }

            return readerList;
        }


        public int iniCPUCard(string reader)
        {
          
            if (hContext == 0)
            {
                //         errMsg = "Failed to get device context handle. The device needs to be initialized before the card is initialized！";
                //        throw new Exception(errMsg);
                return -1;
            }

            isConnectCard = false;

            runResult = (int)PCSCDLL.SCardConnect(hContext, reader, SCARD_SHAREMODE.SCARD_SHARE_SHARED,
                                    SCARD_PROTOCOLS.SCARD_PROTOCOL_T0 | SCARD_PROTOCOLS.SCARD_PROTOCOL_T1, ref hCard, ref activeProtocol);

            if (runResult != SCARD_SUCCESS)
            {
                
                return runResult;
            }
            else
            {
                activeReaderName = reader;
                isConnectCard = true;
            }
            

            if (!isConnectCard)
            {
                //            errMsg = "No cards found！";
                //           throw new Exception(errMsg);
                return -1;
            }

           

            //cardstate
            SCARD_STATUS state = SCARD_STATUS.SCARD_UNKNOWN;
            SCARD_PROTOCOLS protocol = SCARD_PROTOCOLS.SCARD_PROTOCOL_UNDEFINED;
            string stratr = "";
            byte[] atr = new byte[100];
            int atrlen = 100;
            runResult = (int)PCSCDLL.SCardState(hCard, ref state, ref protocol, atr, ref atrlen);

            if (runResult != SCARD_SUCCESS)
            {
                //     errMsg = "Get card reader list, error code is： " + runResult.ToString("X");
                //    throw new Exception(errMsg);
                return -1;
            }

            if (state != SCARD_STATUS.SCARD_SPECIFIC)
            {
                // errMsg = "Card status is illegal! Connection failed！";
                //throw new Exception(errMsg);
                return -1;
            }

            return 0;
        }

        

        public byte[] pcsc_WriteRead(byte []buffer, int count)
        {
            SCARD_IO_REQUEST ioSendPci, ioRecPci;
            ioSendPci.dwProtocol = activeProtocol;
            ioSendPci.cbPciLength = 8;
            ioRecPci = ioSendPci;

            int ret = -1;
            byte[] receiveMessageByte = new byte[256];
            int receiveLength = 256;
            /*      
                    ret = (int)PCSCDLL.MySCardTransmit(hCard           
                                                    , buffer
                                                    , count
                                                    , receiveMessageByte, ref receiveLength);
               */
            ret = (int)PCSCDLL.SCardTransmit(hCard, ref ioSendPci, buffer, count, ref ioRecPci, receiveMessageByte, ref receiveLength);
            if (ret != SCARD_SUCCESS)
            {
                return null;
            }

            byte[] retBuff = new byte[receiveLength];

            for (int i = 0; i < receiveLength; i++)
            {
                retBuff[i] = receiveMessageByte[i];
            }
            return retBuff;
        }


        public void closePcsc_dev()
        {
            
            if (hCard != 0)
            {
               PCSCDLL.SCardDisconnect(hCard, 1);
			   hCard = 0;
            }
            
            if (hContext != 0)
            {
               PCSCDLL.SCardReleaseContext(hContext);
                hContext = 0;
            }
            
        }
        public void closePcsc_card()
        {
            if (hCard != 0)
            {
                PCSCDLL.SCardDisconnect(hCard, 1);
                hCard = 0;
            }
        }


        private static byte[] StringToByteSequence(string sourceString)
        {
            int i = 0, n = 0;
            int j = (sourceString.Length) / 2;

            byte[] a = new byte[j];
            for (i = 0, n = 0; n < j; i += 2, n++)
            {
                a[n] = Convert.ToByte(sourceString.Substring(i, 2), 16);
            }
            return a;
        }


    }
}
