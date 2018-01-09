using System;
using System.Windows.Controls;
using Prism.Mvvm;

namespace ControlCenter.ViewModels
{
    internal class MainWindowViewModel : BindableBase
    {
        #region Fields & Properties

        private long _execBuffer;
        private bool _weatherLock;
        private long _lockWeatherTo;
        private string _licensePlate;
        private bool _fixLicensePlate;
        private bool _fixBrassKnukel;
        private bool[] _fixWeaponSlots;
        private long[] _fixWeaponId;
        private long[] _fixWeaponAmmo;
        private bool _isControlRcCars;
        private int _msgShowCtr; // how many times to show run gta msg
        private bool _isAutoInject; // if car wpanwer code should be auto-injected or not
        private int _injectMsgCtr; // counter to show injection messages
        private byte[] _notInjectedJump; // has the original asm code of gta_sa, version dependant
        private byte[] _notInjectedCode; // used to write &H0 on code inject location
        private byte[] _injectedJump; // has the jump asm statement, gta sa version dependant
        private byte[] _injectedCode; // has the asm code, gta sa version dependant
        private byte[] _injectCheck; // used as buffer to check if code is injected or not
        private byte[] _notInjectedJumpOneHitKill;
        private byte[] _notInjectedCodeOneHitKill;
        private byte[] _bInjectedJumpOneHitKill;
        private byte[] _bInjectedCodeOneHitKill;
        private byte[] _bInjectCheckOneHitKill; //used as buffer to check if code is injected or not
        private int _iOrgFreezeTimerUp;
        private int _iOrgFreezeTimerDown;
        private bool _isInternInjectCheck;
        private bool _isRestartCar; //restart car if stalled
        private bool _isInjected; //if spawner code is injected or not
        private bool _isOrgScm; //if it is original scm or not
        private bool _isTimerClick; //if is hook timer refresh click or not
        private DateTime _dtGameDateTime; //mirror of game date time
        private DateTime _dtBaseDateTime; //mirror to clng(DateSerial(1991,5,1))-1
        private string[] _sWeekdays; //Sunday to Saturday 1 to 7
        private bool _isMsgShown; //if info msg on gta sa syncronization has been shown or not
        private bool[] _isDirty; //dirty status of Cheats/Locations/Shortcuts
        private int _iLocBoxSize; //Location Box Size (8/12/16)
        private float _sZoomLevel; //Location Map Zoom Level (0.5 to 2.0)
        private float _xOffset; //Location Map X Offset
        private float _yOffset; //Location Map Y Offset
        private float _minOffsetX; //Location Map Minimum X Offset
        private float _minOffsetY; //Location Map Minimum Y Offset
        private float _maxOffsetX; //Location Map Maximum X Offset
        private float _maxOffsetY; //Location Map Maximum Y Offset
        private float _gtAtoPix; //Location Map GTA Coord to Pixels multiplier
        private float _pixToGta; //Location Map Pixels to GTA Coord multiplier (1/sngGTAtoPix)
        private string[] _cheatUid; //Cheats to CheatCombo Listindex Array
        private string[] _locUid; //Locations to LocationCombo Listindex Array
        private string _strCarType; //Current Car Type (car, bike, mtruck, plane etc)
        private bool _isInternalClick; //to enable internally click checkboxes etc.
        private int _intConsoleCounter; //for..next loops in console timer
        private bool _isHasNewCar; //if Player has changed car or not
        private bool _isHasCar; //if Player is in Car or not
        private bool _isHadCar; //if player has got off car, but not got in a new car
        private long _lngHookBuffer; //Buffer for Read/Write by hook timer
        private float _fltHookBuffer; //Buffer for Read/Write by hook timer
        private byte _bytHookBuffer; //Buffer for Read/Write by hook timer
        private long _lastPid; //Last Found Process-Id of GTASA (to compare)
        private float _carHealth; //CarHealth Buffer for tmrConsole
        private int _pressedExtKey; //Keyboard mirror for PressedExtKey
        private int _pressedKey; //Keyboard mirror for PressedKey
        private int _shorcutCount; //Count of Shortcuts to check in tmrConsole
        private float _execWriteBuffer; //Buffers for ExecuteConsoleCommand
        private int _execCounter; //Buffers for ExecuteConsoleCommand
        private int _spinSeconds; //Seconds/Timerticks to lock VisualStyleElement.Spin in Heli-Mode
        private int _hookCounter; //allg. Counter for tmrHook
        private bool _isLockHealth; //mirror of chkPlayerStats(0).value
        private bool _isLockArmor; //mirror of chkPlayerStats(1).value
        private bool _isLockFat; //mirror of chkPlayerStats(3).value
        private bool _isLockStamina; //mirror of chkPlayerStats(4).value
        private bool _isLockMuscle; //mirror of chkPlayerStats(5).value
        private bool _isLockDrivingProf;
        private bool _isLockBikingProf;
        private bool _isLockCyclingProf;
        private bool _isLockPilotProf;
        private bool _isLockLungStat;
        private bool _isLockGamblingStat;
        private bool _isFixPed; //mirror of chkPlayerStats(10).value
        private float _lockHealthTo; //mirror of scrPlayerStats(0).value
        private float _lockArmorTo; //mirror of scrPlayerStats(1).value
        private float _lockFatTo; //mirror of scrPlayerStats(1).value
        private float _lockStaminaTo; //mirror of scrPlayerStats(1).value
        private float _lockMuscleTo; //mirror of scrPlayerStats(1).value
        private long _lockDrivingProfTo;
        private long _lockBikingProfTo;
        private long _lockCyclingProfTo;
        private long _lockPilotProfTo;
        private long _lockLungStatTo;
        private float _lockGamblingStatTo;
        private bool _isFlightAssistance; //mirror of chkCarDynamics(8).Value
        private bool _isPedFlightAssistance;
        private bool _isAutoLockCarDoors; //mirror of chkCarDynamics(1).value AND optCardoors(1).value
        private bool _isLockEngineHealth; //mirror of chkCarDynamics(3).value
        private float _lockEngineHealthTo; //mirror of scrCarDynamics(1).value
        private int _fallSeconds; //For Downwards flight
        private bool _isGtasAiconic; //If GTASA is minimized or not
        private long _lastGtasaHwnd; //To enable a delay timer for GTA to start fully
        private float _assistFlightBy; //Flight Assistance level
        private float _pedAssistFlightBy;
        private bool _isDontExplode; //mirror of chkDontBurn(1).value
        private bool _isDontBurn; //mirror of chkDontBurn(0).value
        private int _playerDrivesCar; //ordinal of current car
        private double _massNormalizer; //Normalization of Mass to Grip and Suspension values by changing Mass of Car
        private bool _isHasFeedback; //If Signal Feedback or not
        private int _waitBeforeHook; //Seconds to wait for GTASA to start
        private int _refreshFormValues; //integer to refresh form values 2 times if GTASA is minimized
        private string[] _markLocations; //Mark Location and WarpToLocation string Array for LocData, 0 to 3
        private float _absoluteDegrees; //What is my placement in absolute degrees
        private long _readReturn; //If the ReadMemory successful was or not
        private string _onScreenText; //On-Screen Display MediaTypeNames.Text
        private bool _isPreventWheelDamage; // Mirror to prevent wheel damage
        private int _warpNextHitDelayCount; //delay counter for warp next location console command
        private int _gameTimeChangeCount; //delay counter for game time advance/revert
        private bool _isSafeCheats;
        private bool[] _isLockGf;
        private long[] _lngLockGFto;

        #endregion

        #region Methods

        private void OnTxtCommandWeaponAmmoValidate(bool cancel, TextBox tb)
        {
            try
            {
                if (Int16.TryParse(tb.Text, out short result))
                {
                    if (result < 0)
                    {
                        tb.Text = "0";
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                tb.Text = "0";
            }
        }

        private void OnChkWeatherLockCommand(CheckBox cb)
        {
            if (_isInternalClick)
            {
                return;
            }
            if (cb.IsChecked != null)
            {
                _weatherLock = (bool) cb.IsChecked;
            }
            //_lockWeatherTo = 
        }
    }

        #endregion
    
}