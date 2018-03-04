using System.Net.NetworkInformation;
using ControlCenter.Infrastructure.Models;

namespace ControlCenter.Infrastructure
{
    public static class Global
    {
        #region Boolean

        public static bool IsHasHandle;
        public static bool IsHasPlayer;
        public static bool IsCollectingGabage;
        public static bool IsCarPicsReady;

        #endregion

        #region Long

        public static long Hwnd;
        public static long Pid;
        public static long PHandle;
        public static long ReadBufferLong;
        public static long MemAddress;
        public static long ZSpeed;
        public static long CarAdr;
        public static long PreviousCarAdr;

        #endregion

        #region Integer

        public static int WriteBuffer;
        public static int ReadBufferInt;
        public static int Counter;
        public static int CharCounter;
        public static int SendOrdinal;
        public static int LastPickedColor;

        #endregion

        #region Byte

        public static byte ReadBufferByte;

        #endregion

        #region Float

        public static float ReadBufferFloat;
        public static float MMsPerTwipX;
        public static float MMsPerTwipY;

        #endregion

        #region String

        public static string Buffer;
        public static string TextLine;
        public static string IniFileName;
        public static string PicFileName;
        public static string DatFileName;
        public static string CfgFileName;
        public static string CheatFileName;
        public static string LocsFileName;

        #endregion

        #region Double

        public const double Pi = 3.14159265358979;

        #endregion

        #region Location

        public static Location[] WarpTraileerOffset;
        public static Location[] WarpBikeOffset;
        public static Location[] WarpCarOffset;
        public static Location[] WarpReadOffset;
        public static Location WarpCurrentPosition;
        public static Location WarpDetachablesLoc;
        public static Location WarpPlayerLoc;
        public static Location WarpPlayerLocBefore;
        public static Location CarPosition;
        public static Location PlayerPosition;

        #endregion

        #region Speed

        public static Speed SpeedBuffer;
        public static Speed SpeedHookBuffer;
        public static Speed ZeroSpeed;
        public static Speed SpeedWriteBuffer;
        public static Speed[] KickStartSpeed;
        public static Speed SpeedExecWriteBuffer;
        public static Speed SpeedConsoleBuffer;

        #endregion

        #region Spin

        public static Spin SpinBuffer;
        public static Spin SpinHookBuffer;
        public static Spin ZeroSpin;
        public static Spin SpinWriteBuffer;
        public static Spin SpinExecWriteBuffer;
        public static Spin SpinDelayedWriteBuffer;

        #endregion

        #region Posotion

        public static Position[] CarPlacement;
        public static Position CarFlipPlacement;
        private static Position playerFlipPlacement;
        public static Position CarFilpConsoleBuffer;

        #endregion

        #region Garage

        public static int[] ZeroTuneInt;
        public static Garage GarageHookBuffer;
        public static Garage[] GarageFullHookBuffer;

        public static GarageAdr[] GarageAddresses;

        public static GarageDemension[] GarageDimDemensions;

        #endregion

        #region Color

        public static Color[] Colors;

        #endregion

        #region CarParking

        public static CarParking[] ParkedCars;
        public static int[][] ParkedCarMatrix;
        public static int[][] GarageListMatrix;
        public static int[] SpwanCarMatrix;
        public static int[] SpwanListMatrix;

        #endregion

        #region WeaponSlotData

        public static WeaponSlotData PlayerWeapon;
        public static WeaponSlotData HookPlayerWeapon;
        public static WeaponSlotData ExecPlayerWeapon;
        public static WeaponSlotData ConsolePlayerWeapon;

        #endregion

        #region CarAddress

        public static CarAddress CurrentCar;
        public static CarAddress CurrentTrailer;
        public static CarAddress OldCarAddress;

        #endregion

        #region ConsoleCommand

        public static ConsoleCommand[] SonConsoleCommands;

        #endregion

        #region WarpCarPosData

        public static WarpCarPosData WarpCarPos;
        public static WarpCarPosData WarpCarPosBefore;
        public static WarpCarPosData WarpTrailerPos;
        public static WarpCarPosData WarpTrailerPosBefore;
        public static WarpCarPosData WarpTrailerExecBuffer;
        public static WarpCarPosData WarpCarExecBuffer;
        public static WarpCarPosData WarpPlayerExecBuffer;
        public static int CarIdForWarp;

        #endregion

        #region TurnCarDegreeData

        public static TurnCarDegreeData TurnCarExecBuffer;
        public static TurnCarDegreeData TurPedrExecBuffer;

        #endregion

        public static byte[] ScreenText;

        public static SubMissionTime[] SubMissionTimes;

        public static long[][] WeaponSlotMatrix;
        public static long[][] WeaponSlotCombo;

        public static long[] WeaponIdtoDataId;
        public static long[] DataIdtoWeaponId;

        public static WINDOWPLACEMENT Window;

        public const KEYEVENTF_KEYUP = &H2;
    }
}
