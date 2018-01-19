namespace ControlCenter.Infrastructure

open System
open System.Collections.ObjectModel

// According to historical reasons, use System.Single in stead of float

type BaseAddress = {
    PlayerAdr : int64;                  //DWord Ptr
    PlayerAdr2: int64;                  //DWord Ptr
    CurrCarAdr : int64;                  //DWord Ptr
    Msg1Adr : int64;                     //AsciiA
    MoneyAdr : int64;                    //DWord
    FatStatAdr : int64;                  //Float
    StaminaStatAdr : int64;              //Float
    MuscleStatAdr : int64;               //Float
    MaxHealthStatAdr : int64;            //Float
    EnergyStatAdr : int64;               //DWord
    WeaponProfStatAdr : int64 array;   //Float
    HotCoffeeAdr : int64;                //Byte (bit flip)
    VehicleProfAdr : int64 array;      //Car,Bike,Cycle,Pilot DWord
    LungCapacityAdr : int64;             //Float
    GamblingStatAdr : int64;             //Float
    OpenedIslandsAdr : int64;            //DWord (0 to 4 islands)
    GFStatAdr : int64 array;           //DWord (0-100) //Denise/Michelle/Helena/Katie/Barbara/Millie
    GFProgressAdr : int64 array;       //DWord (0-100) //Denise/Michelle/Helena/Katie/Barbara/Millie
    CheatCountAdr : int64;               //DWord
    CheatStatAdr : int64;                //DWord
    cNeverWantedAdr : int64;            //Byte
    cNeverGetHungryAdr : int64;         //Byte
    cInfHealthAdr : int64;              //Byte
    cInfOxygenAdr : int64;              //Byte
    cInfAmmoAdr : int64;                //Byte
    cInfRunAdr: int64;                  //Byte
    cFireproofAdr: int64;               //Byte
    cMegaPunchAdr : int64;              //Byte
    cMegaJumpAdr : int64;               //Byte
    cMaxRespectAdr : int64;             //Byte
    cMaxSexAppealAdr : int64;           //Byte
    cFastCarsAdr : int64;               //Byte
    cCheapCarsAdr : int64;              //Byte
    cTankModeAdr : int64;                //Byte
    cCheatsAdr : int64 array;         //Byte//Never Wanted=0//Never Get Hungry=1//Infinite Health=2//Infinite Oxygen=3//Infinite Ammo=4//Tank Mode=5
                                           //Mega Punch=6//Mega Jump=7//Max Respect=8//Max Sex Appeal=9//Fast Cars=10//Cheap Cars=11//Infinite Run=12//Fireproof=13
                                           //Perfect Handling=14//Decreased Traffic=15//Huge Bunny Hop=16//Cars Have Nitro=17//Boats can Fly=18//Cars can Fly=19
    DaysInGameAdr : int64;              //Long
    CurrHourAdr : int64;                //Byte
    CurrMinuteAdr : int64;              //Byte
    CurrWeekdayAdr : int64;             //Byte
    GameSpeedMsAdr : int64;              //Long
    GameSpeedPctAdr : int64;             //Float
    CodeInjectJumpAdr : int64;
    CodeInjectCodeAdr : int64;
    CodeInjectJump_OneHitKillAdr : int64;
    CodeInjectCode_OneHitKillAdr : int64;
    CodeInjectNOP_FreezeTimerUpAdr : int64;
    CodeInjectNOP_FreezeTimerDownAdr : int64;
    CarSpawnAdr : int64;
    WeaponSpawnAdr : int64 array;
    WeatherLockAdr : int64;
    WeatherToGoAdr : int64;
    WeatherCurrentAdr : int64}
    
type GTASALocation = { xCoord : Single; yCoord : Single; zCoord : Single;}

type GTASASpeed = { xSpeed : Single; ySpeed : Single; zSpeed : Single;}

type GTASASpin = { xSpin : Single; ySpin : Single; zSpin : Single}

type GTASAPosData = { xGrad : Single; yGrad : Single; zgrad : Single; zReserve1 : Single; xlooking : Single; ylooking : Single; zlooking : Single}

type GTASAGarage = {
     xCoord : Single;
     yCoord : Single;
     zCoord : Single;
     Handling : int64;
     Specials : int;
     CarCode : int;
     iTuneArr : int array;
     MajorColor : byte;
     MinorColor : byte;
     TuneArr : byte array;
     Angle : int64;}

type GTASAFullGarage = { ParkingSlots : GTASAGarage array}

type GTASAGarageAdr = { 
     lngXCoordAdr : int64;               // Use only XCoord Adr when reading/writing
     lngYcoordAdr : int64;               // complete package of 64 bytes
     lngZcoordAdr : int64;
     lngSpecialsAdr : int64;
     lngCarCodeAdr : int64;
     lngMajorColorAdr : int64;
     lngMinorColorAdr : int64;
     lngDoorStateAdr : int64;            // Garage Door State Reads byte: 0:closed 1:open 2:closing 3:opening
     lngAngleAdr : int64;
     isDoorInMiddleState : bool}      // true if opening and closing
 

type ParkingOrdinals =
    iJohnson = 0 //Los Santos
    |iElCorona = 1
    |iSantaBeach = 2
    |iMulHolland = 3
    |iPalomino = 4
    |iPrickle = 5  //Los Venturas
    |iWhitewood = 6
    |iRedsands = 7
    |iRockshore = 8
    |iDillimore = 9  //Bone County
    |iFortCarson = 10
    |iVerdant = 11
    |iVerdantAir = 12
    |iCalton = 13  //San Fierro
    |iParadiso = 14
    |iDoherty = 15
    |iHashbury = 16

type GTASAGarageDimensions = { xPos : Single; yPos : Single;zPos : Single;
    width : Single; length : Single;   //bereinigt!
    xGrad : Single; yGrad : Single; zgrad : Single;
    absDegrees      :  Single;   //Absolute Degrees
    isWide :  bool;
    lookFront : int64; lookLeft : int64; lookFrontLeft : int64}

type GTASAColor = { Rgb : int; ColorCode : int; Description : string}

type GTASACarParking ={  //Array Ordinal as CarCode (from 400 to 611), and 399 as (none)
     strCarName :  string;
     strCartype :  string;
     isParkable :  bool;
     sngCarWidth :  Single;
     sngCarLength :  Single;
     sngCarHeight :  Single;
     isBike :  bool;
     isLong :  bool;
     MinorColor :  byte;
     MajorColor :  byte;
     isHasMods :  bool;
     sModsArr :  string;
     iHandling :  int64;
     isRCCar :  bool;}
 

type GTASAPlayerAdr = { 
     lngObjectStart :  int64;
     lngPositionPtr :  int64;   //this is actually objectstart + 20 offset
     lngPlayerPosAdr :  int64;  //this is the let mutableue of lngPositionPtr
     lngXposAdr :  int64;       //these let mutableues are calculated from the let mutableue of lngPositionPtr with offsets
     lngYposAdr :  int64;
     lngZposAdr :  int64;
     lngAngleAdr :  int64;      //offset 1372, Angle in Bogenmass
     lngHealthAdr :  int64;
     lngMaxHealthAdr :  int64;
     lngArmorAdr :  int64;
     lngLastCarAdr :  int64;
     lngLastBoatAdr :  int64;
     lngSpecialsAdr :  int64;
     lngPedSpeedAdr :  int64;
     lngBrassKnucklesAdr :  int64;
     lngWeaponsAdr :  int64 array;  //addresses for 0-10 combo weapons
     lngWeaponSlotAdr :  int64;
     lngWeaponIDAdr :  int64;
     lngDetonatorAdr :  int64;}
 

type GTASAWeaponSlotData = {
     lngWeaponID :  int64;
     lngWas1 :  int64;
     lngLoadedAmmo :  int64;
     lngTotalAmmo :  int64;}
 

type GTASACarAdr = {
     isUsable :  bool;     //if this adr block actually and still belongs to a car or not (gtasa addresses cars and peds in the same manner!!)
     isRCCar :  bool;
     lngObjectStart :  int64;   //this object start is equal to player object start if player is not in car !!!!
     lngPositionPtr :  int64;   //this is actually objectstart + 20 offset
     lngCarPosAdr :  int64;     //this is the let mutableue that is read from lngPositionPtr
     lngCarLocAdr :  int64;     //these let mutableues are calculated from lngPositionPtr with offsets
     lngCarIDAdr :  int64;      //saved in HiWord of a long let mutableue. We point to the integer offset: 34
     lngSpecialsAdr :  int64;   //bit coded specials as integer will be read from this location (obj start + 66 offset)
     lngCarSpeedAdr :  int64;   //objstart + 68
     lngCarSpinAdr :  int64;    //objstart + 80
     lngCarWeightAdr :  int64;  //objstart + 140
     lngBikeWheelAdr :  int64;  //objstart + vc:812???
     lngStalledAdr :  int64;    //objstart + 1064
     lngCarColorAdr :  int64;   //objstart + 1076
     lngSirenTimeAdr :  int64;  //objstart + 1116
     lngCarDamageAdr :  int64;  //objstart + 1216
     lngCarTrailerAdr :  int64; //objstart + 1224 (dynamic. gets the pointer if car has trailer, otherwise 0)
     lngCarLastTrailerPtr :  int64; //this is the mirror to the trailer, in case the trailer is temporarily not anymore attached)
     lngCarDoorAdr :  int64;    //objstart + 1272
     lngLicensePlateAdr :  int64; //objstart + 1416 -> read let mutableue + 16
     lngCarWheelAdr :  int64;   //objstart + 1444
     lngBurnTimerAdr :  int64;  //objstart + 2276 float in ms that counts up until car explodes
     lngCarDetachPosAdr :  int64; //according to car or bike, different offsets...
     lngBikeDetachPosAdr :  int64;} //according to car or bike, different offsets...
 

type GTASAConsoleCommand = {
     Command :  int;
     Description :  string;
     Data :  string;
     DataPage :  int;}
 

type GTASAWarpCarPosData = { //60 Bytes
     XGrad :  Single;
     YGrad :  Single;
     ZGrad :  Single;
     Reserve1 :  Single;
     XLook :  Single;
     YLook :  Single;
     ZLook :  Single;
     Reserve2 :  Single;
     XWhat :  Single;
     YWhat :  Single;
     ZWhat :  Single;
     Reserve3 :  Single;
     XPos :  Single;
     YPos :  Single;
     ZPos :  Single;}
 

type GTASATurnCarDegreeData = { //44 Bytes
     XGrad :  Single;
     YGrad :  Single;
     ZGrad :  Single;
     Reserve1 :  Single;
     XLook :  Single;
     YLook :  Single;
     ZLook :  Single;
     Reserve2 :  Single;
     XWhat :  Single;
     YWhat :  Single;
     ZWhat :  Single;}
 

type GTASAScreenText = { CharValue :  byte }
 

type GTASASubMissionTimes = {
     lngAddresse :  int64;
     lngTimeLeft :  int64;}

type POINTAPI = { x :  int64; y :  int64;}

type RECT = { Left :  int64; Top :  int64; Right :  int64; Bottom :  int64; }

type WINDOWPLACEMENT = {
     Length :  int64;
     flags :  int64;
     showCmd :  int64;
     ptMinPosition : POINTAPI;
     ptMaxPosition : POINTAPI;
     rcNormalPosition : RECT;}

/// Cheats
type Cheat = {
     CheatString : string;
     Description : string;
     Folder : string;
     UID : string;}

type ShortCut = {
     UID : string;
     Folder : string;
     Description : string;
     Command : string;
     Category : int;
     ExtKeyCode : int;
     KeyCode : int;
     Data : string;
     IsActive : bool;
     ComboText : string;
     DataPage : int;
     DataDesc : string;}

type WarpLocs() =
    let mutable locData = ""
    let MakeSingle (value: string) =
        let value_new = value.Replace(',','.')
        let split_result = value_new.Split('.')
        if split_result.Length = 0 then single(split_result.[0])
        else single(single(split_result.[0]) + single(split_result.[1]) / (10.f ** single(split_result.Length)))
    member val Description = "" with get,set
    member val Folder = "" with get,set
    member val UID = "" with get,set
    member val Location = 0L with get,set
    member val XCoord = 0.f with get,set
    member val YCoord = 0.f with get,set
    member val ZCoord = 0.f with get,set
    member val Angle = 0.f with get,set
    member this.LocData
        with get() = locData
        and set(value) = locData <- value
                         let locs = locData.Split(';')
                         this.Location <- int64(locs.Length)
                         this.XCoord <- MakeSingle(locs.[0])
                         this.YCoord <- MakeSingle(locs.[1])
                         this.ZCoord <- MakeSingle(locs.[2])
                         this.Angle <- MakeSingle(locs.[3])
    member this.GetLocation index =
        let locs = this.LocData.Split(';')
        locs.[index]

module Global =
    open System.IO
    open System.Linq
    open System.Text
    open System.Xml

    /// Get Colors from GTASAColors.xml
    let internal ParseColors() =

        let mutable result : GTASAColor list = []

        /// Convert rgb vector string to long int
        let RgbString2RbgLong (rgbStr: string) =
            let _sb = new StringBuilder()
            rgbStr.Split(',')
                |> Array.map Int32.Parse
                |> Array.map (fun i -> i.ToString("X2"))
                |> Array.iter (fun s -> _sb.Append(s) |> ignore)
            Convert.ToInt32(_sb.ToString(), 16)
        
        // Open the .xml file and generate a GTASAColor list
        let doc = new XmlDocument()
        try
            doc.Load(".\GTASAColors.xml")
        with
            | :? FileNotFoundException -> Prerequisite.RegenerateXml "GTASAColors"
            | _ as e -> printfn "%A" e
        
        doc.SelectSingleNode("Colors").ChildNodes.Cast<XmlNode>()
            |> Seq.iter (fun n ->
                let color = { Rgb = RgbString2RbgLong n.Attributes.["Rgb"].Value;
                    ColorCode = Int32.Parse n.Attributes.["Id"].Value;
                    Description = n.Attributes.["ToolTip"].Value}
                result <- color :: result)
        result.Reverse().ToArray()

    // Define Global Variables
    // immutable variables
    let GTASAColors : GTASAColor array = [||]

    // mutable variables
    //let mutable GTASABaseAdr : BaseAddress
    type Test = { mutable a : int option; b : int option }
    let mutable test = { a = None; b = None }
    let mutable IsCarPicsReady : bool = false
    // zero speed/spin
    let mutable ZeroSpeed : GTASASpeed = { xSpeed = 0.f; ySpeed = 0.f; zSpeed = 0.f}
    let mutable ZeroSpin : GTASASpin = { xSpin = 0.f; ySpin = 0.f; zSpin = 0.f}
    // kick
    let mutable KickStartSpeed : GTASASpeed list = [{ xSpeed = 0.f ; ySpeed = 1.f  ; zSpeed = 0.f};   // North
                                                   { xSpeed = 0.5f ; ySpeed = 0.5f ; zSpeed = 0.f};   // NorthEast
                                                   { xSpeed = 1.f  ; ySpeed = 0.f  ; zSpeed = 0.f};   // East
                                                   { xSpeed = 0.5f ; ySpeed = -0.5f; zSpeed = 0.f};   // SouthEast
                                                   { xSpeed = 0.f  ; ySpeed = -1.f ; zSpeed = 0.f};   // South
                                                   { xSpeed = -0.5f; ySpeed = -0.5f; zSpeed = 0.f};   // SouthWest
                                                   { xSpeed = -1.f ; ySpeed = 0.f  ; zSpeed = 0.f};   // West
                                                   { xSpeed = -0.5f; ySpeed = 0.5f ; zSpeed = 0.f}]   // NorthWest
    // Car placement
    let mutable GTASACarPlacements : GTASAPosData list = [
        {xGrad = 1.f   ; yGrad = 0.f   ; zgrad = 0.f; zReserve1 = 0.f; xlooking = 0.f   ; ylooking = 1.f   ; zlooking = 0.f};   // North
        {xGrad = 0.71f ; yGrad = -0.71f; zgrad = 0.f; zReserve1 = 0.f; xlooking = 0.71f ; ylooking = -0.71f; zlooking = 0.f};   // NorthEast
        {xGrad = 0.f   ; yGrad = -1.f  ; zgrad = 0.f; zReserve1 = 0.f; xlooking = 1.f   ; ylooking = 0.f   ; zlooking = 0.f};   // East
        {xGrad = -0.71f; yGrad = -0.71f; zgrad = 0.f; zReserve1 = 0.f; xlooking = 0.71f ; ylooking = -0.71f; zlooking = 0.f};   // SouthEast
        {xGrad = -1.f  ; yGrad = 0.f   ; zgrad = 0.f; zReserve1 = 0.f; xlooking = 0.f   ; ylooking = 1.f   ; zlooking = 0.f};   // South
        {xGrad = -0.71f; yGrad = 0.71f ; zgrad = 0.f; zReserve1 = 0.f; xlooking = -0.71f; ylooking = -0.71f; zlooking = 0.f};   // SouthWest
        {xGrad = 0.f   ; yGrad = 1.f   ; zgrad = 0.f; zReserve1 = 0.f; xlooking = -1.f  ; ylooking = 0.f   ; zlooking = 0.f};   // West
        {xGrad = 0.71f ; yGrad = 0.71f ; zgrad = 0.f; zReserve1 = 0.f; xlooking = -0.71f; ylooking = 0.71f ; zlooking = 0.f}]   // NorthWest

    // Garage details:
    let mutable GTASAGrageDims : GTASAGarageDimensions list = [
        // Johnson House Garage Dimensions:
        { xPos = 2508.263f; yPos = -1691.133f; zPos = 12.825f; width = -5.447f; length = -7.359f;
          xGrad = 0.f; yGrad = 1.f; zgrad = 0.f; absDegrees = 180.f; isWide = false;
          lookFront = (int64)0xFF6300; lookLeft = (int64)0xFF0063; lookFrontLeft = (int64)0xFF4646};

        // El Corona Garage Dimensions (4 Cars):
        { xPos = 1695.669f; yPos = -2088.671f; zPos = 12.817f; width = 6.429f; length = 9.921f;
          xGrad = 0.f; yGrad = -1.f; zgrad = 0.f; absDegrees = 0.f; isWide = false;
          lookFront = (int64)0xFF9D00; lookLeft = (int64)0xFF009D; lookFrontLeft = (int64)0xFFBABA};

        // Santa Maria Beach Garage Dimensions:
        { xPos = 319.666f; yPos = -1768.892f; zPos = 3.924f; width = 5.694f; length = 9.225f;
          xGrad = 0.f; yGrad = -1.f; zgrad = 0.f; absDegrees = 0.f; isWide = false;
          lookFront = (int64)0x19D00; lookLeft = (int64)0xFE009D; lookFrontLeft = (int64)0xFFBABA};

        // MulHolland Garage Dimensions:
        { xPos = 1355.3f; yPos = -626.038f; zPos = 108.403f; width = -3.557f; length = -7.922f;
          xGrad = -0.328f; yGrad = 0.945f; zgrad = 0.f; absDegrees = 200.f; isWide = false;
          lookFront = (int64)0xFF5EDE; lookLeft = (int64)0xFF205E; lookFrontLeft = (int64)0xFF5B28};

        // Palomino Garage Dimensions:
        { xPos = 2228.208f; yPos = 168.904f; zPos = 26.75f; width = 6.283f; length = 6.601f;
          xGrad = 0.f; yGrad = -1.f; zgrad = 0.f; absDegrees = 0.f; isWide = false;
          lookFront = (int64)0xFF9D00; lookLeft = (int64)0xFF009D; lookFrontLeft = (int64)0xFFBABA};

        // Prickle Pine Garage Dimensions:
        { xPos = 1278.783f; yPos = 2525.771f; zPos = 10.09f; width = 9.548f; length = 8.426f;
          xGrad = 1.f; yGrad = 0.f; zgrad = 0.f; absDegrees =  90.f; isWide = true;
          lookFront = (int64)0xFF0063; lookLeft = (int64)0xFF9D00; lookFrontLeft = (int64)0xFFBA46};

        // Whitewood Estates Garage Dimensions:
        { xPos = 929.566f; yPos = 2013.904f; zPos = 10.731f; width = 4.849f; length = 9.147f;
          xGrad = -1.f; yGrad = 0.f; zgrad = 0.f; absDegrees =  270.f; isWide = false;
          lookFront = (int64)0xFF009D; lookLeft = (int64)0xFF6300; lookFrontLeft = (int64)0xFF46BA};

        // Redsands West Garage Dimensions:
        { xPos = 1408.637f; yPos = 1904.526f; zPos = 10.731f; width = 4.784f; length = 8.799f;
          xGrad = -1.f; yGrad = 0.f; zgrad = 0.f; absDegrees =  270.f; isWide = false;
          lookFront = (int64)0xFF009D; lookLeft = (int64)0xFF6300; lookFrontLeft = (int64)0xFF46BA};

        // Rockshore West Garage Dimensions:
        { xPos = 2449.564f; yPos = 699.916f; zPos = 10.731f; width = 4.786f; length = 8.844f;
          xGrad = -1.f; yGrad = 0.f; zgrad = 0.f; absDegrees =  270.f; isWide = false;
          lookFront = (int64)0xFF009D; lookLeft = (int64)0xFF6300; lookFrontLeft = (int64)0xFF46BA};

        // Dillimore Garage Dimensions:
        { xPos = 783.948f; yPos = -492.412f; zPos = 16.614f; width = 4.263f; length = 7.236f;
          xGrad = 0.f; yGrad = -1.f; zgrad = 0.f; absDegrees =  0.f; isWide = false;
          lookFront = (int64)0xFF9D00; lookLeft = (int64)0xFF009D; lookFrontLeft = (int64)0xFFBABA};

        // Fort Carson Garage Dimensions:
        { xPos = -367.371f; yPos = 1194.711f; zPos = 18.843f; width = -10.599f; length = -7.849f;
          xGrad = 0.f; yGrad = -1.f; zgrad = 0.f; absDegrees =  0.f; isWide = true;
          lookFront = (int64)0xFF9D00; lookLeft = (int64)0xFF009D; lookFrontLeft = (int64)0xFFBABA};
    
        // Verdant Meadows Garage Dimensions:
        { xPos = 430.441f; yPos = 2550.134f; zPos = 15.458f; width = 7.445f; length = 12.537f;
          xGrad = -1.f; yGrad = 0.f; zgrad = 0.f; absDegrees = 270.f; isWide = true;
          lookFront = (int64)0xFF009D; lookLeft = (int64)0xFF6300; lookFrontLeft = (int64)0xFF46BA};
    
        // 'Verdant Meadows Airport Garage Dimensions:
        { xPos = 425.726f; yPos = 2475.778f; zPos = 15.77f; width = -43.576f; length = -43.575f;
          xGrad = 0.f; yGrad = 1.f; zgrad = 0.f; absDegrees =  180.f; isWide = true;
          lookFront = (int64)0xFF6300; lookLeft = (int64)0xFF0063; lookFrontLeft = (int64)0xFF4646};
        // Calton Heights Garage Dimensions:
        { xPos = -2102.171f; yPos = 896.776f; zPos = 75.973f; width = -6.292f; length = -7.258f;
          xGrad = 0.f; yGrad = 1.f; zgrad = 0.f; absDegrees =  180.f; isWide = false;
          lookFront = (int64)0xFF6300; lookLeft = (int64)0xFF0063; lookFrontLeft = (int64)0xFF4646};
    
        // Paradiso Garage Dimensions:
        { xPos = -2698.411f; yPos = 821.422f; zPos = 49.254f; width = 4.992f; length = 9.408f;
          xGrad = 0.f; yGrad = -1.f; zgrad = 0.f; absDegrees =  0.f; isWide = false;
          lookFront = (int64)0xFF9D00; lookLeft = (int64)0xFF009D; lookFrontLeft = (int64)0xFFBABA};
        
        // Dhoerty Garage Dimensions:
        { xPos = -2022.175f; yPos = 129.37f; zPos = 28.167f; width = -9.872f; length = -10.466f;
          xGrad = 0.f; yGrad = 1.f; zgrad = 0.f; absDegrees =  180.f; isWide = true;
          lookFront = (int64)0xFF6300; lookLeft = (int64)0xFF0063; lookFrontLeft = (int64)0xFF4646};
    
        // Hashbury Garage Dimensions:
        { xPos = -2454.243f; yPos = -117.352f; zPos = 25.391f; width = 14.355f; length = 11.148f;
          xGrad = -1.f; yGrad = 0.f; zgrad = 0.f; absDegrees =  270.f; isWide = true;
          lookFront = (int64)0xFF009D; lookLeft = (int64)0xFF6300; lookFrontLeft = (int64)0xFF46BA};
    ]
    
    // 
    let mutable WeaponSlotMatrix = Array2D.create 11 9 0
    WeaponSlotMatrix.[0, 1..8] <- [|2..9|]
    WeaponSlotMatrix.[1, 1..3] <- [|22..24|]
    WeaponSlotMatrix.[2, 1..3] <- [|25..27|]
    WeaponSlotMatrix.[3, 1..3] <- [|28; 29; 32|]
    WeaponSlotMatrix.[4, 1..2] <- [|30; 31|]
    WeaponSlotMatrix.[5, 1..2] <- [|33; 34|]
    WeaponSlotMatrix.[6, 1..4] <- [|35..38|]
    WeaponSlotMatrix.[7, 1..4] <- Array.concat [ [|16..18|]; [|39|] ]
    WeaponSlotMatrix.[8, 1..3] <- [|41..43|]
    WeaponSlotMatrix.[9, 1..6] <- Array.concat [ [|14|]; [|10..13|]; [|15|] ]
    WeaponSlotMatrix.[10, 1..3] <- [|44..46|]

    let mutable WeaponSlotCombo = Array2D.create 46 2 0
    WeaponSlotCombo.[2..9, 1] <- [|1..8|]
    WeaponSlotCombo.[22..24, 0] <- Array.create 3 1

    let mutable ZeroTune : int list = []

    // Define Global Functions
    let rec QuickSort list =
        match list with
        | [] -> []
        | item :: subList ->
            let smallerSorted = List.filter (fun x -> x <= item) subList |> QuickSort
            let biggerSorted = List.filter (fun x -> x > item) subList |> QuickSort
            smallerSorted @ [item] @ biggerSorted
