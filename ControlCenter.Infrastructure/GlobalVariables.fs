namespace ControlCenter.Infrastructure

open System
open System.Collections.ObjectModel

// According to historical reasons, use System.Single in stead of float

type BaseAddresses() =
    member this.PlayerAdr : int64 = 0L                  //DWord Ptr
    member this.PlayerAdr2: int64 = 0L                  //DWord Ptr
    member this.CurrCarAdr: int64 = 0L                  //DWord Ptr
    member this.Msg1Adr: int64 = 0L                     //AsciiA
    member this.MoneyAdr: int64 = 0L                    //DWord
    member this.FatStatAdr: int64 = 0L                  //Float
    member this.StaminaStatAdr: int64 = 0L              //Float
    member this.MuscleStatAdr: int64 = 0L               //Float
    member this.MaxHealthStatAdr: int64 = 0L            //Float
    member this.EnergyStatAdr: int64 = 0L               //DWord
    member this.WeaponProfStatAdr: int64 array = [||]   //Float
    member this.HotCoffeeAdr: int64 = 0L                //Byte (bit flip)
    member this.VehicleProfAdr: int64 array = [||]      //Car,Bike,Cycle,Pilot DWord
    member this.LungCapacityAdr: int64 = 0L             //Float
    member this.GamblingStatAdr: int64 = 0L             //Float
    member this.OpenedIslandsAdr: int64 = 0L            //DWord (0 to 4 islands)
    member this.GFStatAdr: int64 array = [||]           //DWord (0-100) //Denise/Michelle/Helena/Katie/Barbara/Millie
    member this.GFProgressAdr: int64 array = [||]       //DWord (0-100) //Denise/Michelle/Helena/Katie/Barbara/Millie
    member this.CheatCountAdr: int64 = 0L               //DWord
    member this.CheatStatAdr: int64 = 0L                //DWord
    member this.cNeverWantedAdr : int64 = 0L            //Byte
    member this.cNeverGetHungryAdr : int64 = 0L         //Byte
    member this.cInfHealthAdr : int64 = 0L              //Byte
    member this.cInfOxygenAdr : int64 = 0L              //Byte
    member this.cInfAmmoAdr : int64 = 0L                //Byte
    member this.cInfRunAdr: int64 = 0L                  //Byte
    member this.cFireproofAdr: int64 = 0L               //Byte
    member this.cMegaPunchAdr : int64 = 0L              //Byte
    member this.cMegaJumpAdr : int64 = 0L               //Byte
    member this.cMaxRespectAdr : int64 = 0L             //Byte
    member this.cMaxSexAppealAdr : int64 = 0L           //Byte
    member this.cFastCarsAdr : int64 = 0L               //Byte
    member this.cCheapCarsAdr : int64 = 0L              //Byte
    member this.cTankModeAdr: int64 = 0L                //Byte
    member this.cCheatsAdr: int64 array = [||]         //Byte//Never Wanted=0//Never Get Hungry=1//Infinite Health=2//Infinite Oxygen=3//Infinite Ammo=4//Tank Mode=5
                                            //Mega Punch=6//Mega Jump=7//Max Respect=8//Max Sex Appeal=9//Fast Cars=10//Cheap Cars=11//Infinite Run=12//Fireproof=13
                                            //Perfect Handling=14//Decreased Traffic=15//Huge Bunny Hop=16//Cars Have Nitro=17//Boats can Fly=18//Cars can Fly=19
    member this.DaysInGameAdr : int64 = 0L              //Long
    member this.CurrHourAdr : int64 = 0L                //Byte
    member this.CurrMinuteAdr : int64 = 0L              //Byte
    member this.CurrWeekdayAdr : int64 = 0L             //Byte
    member this.GameSpeedMsAdr: int64 = 0L              //Long
    member this.GameSpeedPctAdr: int64 = 0L             //Float
    member this.CodeInjectJumpAdr: int64 = 0L
    member this.CodeInjectCodeAdr: int64 = 0L
    member this.CodeInjectJump_OneHitKillAdr: int64 = 0L
    member this.CodeInjectCode_OneHitKillAdr: int64 = 0L
    member this.CodeInjectNOP_FreezeTimerUpAdr: int64 = 0L
    member this.CodeInjectNOP_FreezeTimerDownAdr: int64 = 0L
    member this.CarSpawnAdr: int64 = 0L
    member this.WeaponSpawnAdr: int64 array = [||]
    member this.WeatherLockAdr: int64 = 0L
    member this.WeatherToGoAdr: int64 = 0L
    member this.WeatherCurrentAdr: int64 = 0L

type GTASALocation() =
    member this.sngXcoord : Single = 0.f
    member this.sngYcoord : Single = 0.f
    member this.sngZcoord : Single = 0.f

type GTASASpeed() = 
    member this.sngXSpeed: Single = 0.f
    member this.sngYSpeed: Single = 0.f
    member this.sngZSpeed: Single = 0.f
 

type GTASASpin() = 
    member this.sngXSpin : Single = 0.f
    member this.sngYSpin : Single = 0.f
    member this.sngZSpin : Single = 0.f
 

type GTASAPosData() =
    member this.sngXGrad : Single = 0.f
    member this.sngYGrad : Single = 0.f
    member this.sngZgrad : Single = 0.f
    member this.sngzReserve1 : Single = 0.f
    member this.sngXlooking : Single = 0.f
    member this.sngYlooking : Single = 0.f
    member this.sngZlooking : Single = 0.f

type GTASAGarage() =
    member this.sngXcoord : Single = 0.f
    member this.sngYcoord : Single = 0.f
    member this.sngZcoord : Single = 0.f
    member this.lngHandling : int64 = 0L
    member this.intSpecials : int = 0
    member this.intCarCode : int = 0
    member this.intTuneArr : int array = [||]
    member this.bytMajorColor : byte = 0uy
    member this.bytMinorColor : byte = 0uy
    member this.bytTuneArr : byte array = [||]
    member this.lngAngle : int64 = 0L

type GTASAFullGarage() =
    
    member this.ParkingSlots : GTASAGarage array = [||]

type GTASAGarageAdr() = 
    member this.lngXCoordAdr : int64 = 0L               // Use only XCoord Adr when reading/writing
    member this.lngYcoordAdr : int64 = 0L               // complete package of 64 bytes
    member this.lngZcoordAdr : int64 = 0L
    member this.lngSpecialsAdr : int64 = 0L
    member this.lngCarCodeAdr : int64 = 0L
    member this.lngMajorColorAdr : int64 = 0L
    member this.lngMinorColorAdr : int64 = 0L
    member this.lngDoorStateAdr : int64 = 0L            // Garage Door State Reads byte: 0:closed 1:open 2:closing 3:opening
    member this.lngAngleAdr : int64 = 0L
    member this.isDoorInMiddleState : bool = false      // true if opening and closing
 

type cParkingOrdinals =
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

type GTASAGarageDimensions() = 
    member this.sngXpos     :  Single = 0.f
    member this.sngYpos     :  Single = 0.f
    member this.sngZpos     :  Single = 0.f
    member this.sngWidth    :  Single = 0.f   //bereinigt!
    member this.sngLength   :  Single = 0.f   //bereinigt!
    member this.sngXGrad    :  Single = 0.f
    member this.sngYGrad    :  Single = 0.f
    member this.sngZgrad    :  Single = 0.f
    member this.sngAbsDegrees      :  Single = 0.f   //Absolute Degrees
    member this.isWide :  bool = false
    member this.lngLookFront :  int64 = 0L
    member this.lngLookLeft :  int64 = 0L
    member this.lngLookFrontLeft :  int64 = 0L

type GTASAColor = { Rgb : int; ColorCode : int; Description : string}

type GTASACarParking() =  //Array Ordinal as CarCode (from 400 to 611), and 399 as (none)
    member this.strCarName :  string = ""
    member this.strCartype :  string = ""
    member this.isParkable :  bool = false
    member this.sngCarWidth :  Single = 0.f
    member this.sngCarLength :  Single = 0.f
    member this.sngCarHeight :  Single = 0.f
    member this.isBike :  bool = false
    member this.isLong :  bool = false
    member this.MinorColor :  byte = 0uy
    member this.MajorColor :  byte = 0uy
    member this.isHasMods :  bool = false
    member this.sModsArr :  string = ""
    member this.iHandling :  int64 = 0L
    member this.isRCCar :  bool = false
 

type GTASAPlayerAdr() = 
    member this.lngObjectStart :  int64 = 0L
    member this.lngPositionPtr :  int64 = 0L   //this is actually objectstart + 20 offset
    member this.lngPlayerPosAdr :  int64 = 0L  //this is the let mutableue of lngPositionPtr
    member this.lngXposAdr :  int64 = 0L       //these let mutableues are calculated from the let mutableue of lngPositionPtr with offsets
    member this.lngYposAdr :  int64 = 0L
    member this.lngZposAdr :  int64 = 0L
    member this.lngAngleAdr :  int64 = 0L      //offset 1372, Angle in Bogenmass
    member this.lngHealthAdr :  int64 = 0L
    member this.lngMaxHealthAdr :  int64 = 0L
    member this.lngArmorAdr :  int64 = 0L
    member this.lngLastCarAdr :  int64 = 0L
    member this.lngLastBoatAdr :  int64 = 0L
    member this.lngSpecialsAdr :  int64 = 0L
    member this.lngPedSpeedAdr :  int64 = 0L
    member this.lngBrassKnucklesAdr :  int64 = 0L
    member this.lngWeaponsAdr :  int64 array = [||]  //addresses for 0-10 combo weapons
    member this.lngWeaponSlotAdr :  int64 = 0L
    member this.lngWeaponIDAdr :  int64 = 0L
    member this.lngDetonatorAdr :  int64 = 0L
 

type GTASAWeaponSlotData() = 
    member this.lngWeaponID :  int64 = 0L
    member this.lngWas1 :  int64 = 0L
    member this.lngLoadedAmmo :  int64 = 0L
    member this.lngTotalAmmo :  int64 = 0L
 

type GTASACarAdr() = 
    member this.isUsable :  bool = false     //if this adr block actually and still belongs to a car or not (gtasa addresses cars and peds in the same manner!!)
    member this.isRCCar :  bool = false
    member this.lngObjectStart :  int64 = 0L   //this object start is equal to player object start if player is not in car !!!!
    member this.lngPositionPtr :  int64 = 0L   //this is actually objectstart + 20 offset
    member this.lngCarPosAdr :  int64 = 0L     //this is the let mutableue that is read from lngPositionPtr
    member this.lngCarLocAdr :  int64 = 0L     //these let mutableues are calculated from lngPositionPtr with offsets
    member this.lngCarIDAdr :  int64 = 0L      //saved in HiWord of a long let mutableue. We point to the integer offset: 34
    member this.lngSpecialsAdr :  int64 = 0L   //bit coded specials as integer will be read from this location (obj start + 66 offset)
    member this.lngCarSpeedAdr :  int64 = 0L   //objstart + 68
    member this.lngCarSpinAdr :  int64 = 0L    //objstart + 80
    member this.lngCarWeightAdr :  int64 = 0L  //objstart + 140
    member this.lngBikeWheelAdr :  int64 = 0L  //objstart + vc:812???
    member this.lngStalledAdr :  int64 = 0L    //objstart + 1064
    member this.lngCarColorAdr :  int64 = 0L   //objstart + 1076
    member this.lngSirenTimeAdr :  int64 = 0L  //objstart + 1116
    member this.lngCarDamageAdr :  int64 = 0L  //objstart + 1216
    member this.lngCarTrailerAdr :  int64 = 0L //objstart + 1224 (dynamic. gets the pointer if car has trailer, otherwise 0)
    member this.lngCarLastTrailerPtr :  int64 = 0L //this is the mirror to the trailer, in case the trailer is temporarily not anymore attached)
    member this.lngCarDoorAdr :  int64 = 0L    //objstart + 1272
    member this.lngLicensePlateAdr :  int64 = 0L //objstart + 1416 -> read let mutableue + 16
    member this.lngCarWheelAdr :  int64 = 0L   //objstart + 1444
    member this.lngBurnTimerAdr :  int64 = 0L  //objstart + 2276 float in ms that counts up until car explodes
    member this.lngCarDetachPosAdr :  int64 = 0L //according to car or bike, different offsets...
    member this.lngBikeDetachPosAdr :  int64 = 0L //according to car or bike, different offsets...
 

type GTASAConsoleCommand() = 
    member this.Command :  int = 0
    member this.Description :  string = ""
    member this.Data :  string = ""
    member this.DataPage :  int = 0
 

type GTASAWarpCarPosData() =  //60 Bytes
    member this.XGrad :  Single = 0.f
    member this.YGrad :  Single = 0.f
    member this.ZGrad :  Single = 0.f
    member this.Reserve1 :  Single = 0.f
    member this.XLook :  Single = 0.f
    member this.YLook :  Single = 0.f
    member this.ZLook :  Single = 0.f
    member this.Reserve2 :  Single = 0.f
    member this.XWhat :  Single = 0.f
    member this.YWhat :  Single = 0.f
    member this.ZWhat :  Single = 0.f
    member this.Reserve3 :  Single = 0.f
    member this.XPos :  Single = 0.f
    member this.YPos :  Single = 0.f
    member this.ZPos :  Single = 0.f
 

type GTASATurnCarDegreeData() =  //44 Bytes
    member this.XGrad :  Single = 0.f
    member this.YGrad :  Single = 0.f
    member this.ZGrad :  Single = 0.f
    member this.Reserve1 :  Single = 0.f
    member this.XLook :  Single = 0.f
    member this.YLook :  Single = 0.f
    member this.ZLook :  Single = 0.f
    member this.Reserve2 :  Single = 0.f
    member this.XWhat :  Single = 0.f
    member this.YWhat :  Single = 0.f
    member this.ZWhat :  Single = 0.f
 

type GTASAScreenText() =  //64 Bytes
    member this.CharValue :  byte = 0uy
 

type GTASASubMissionTimes() = 
    member this.lngAddresse :  int64 = 0L
    member this.lngTimeLeft :  int64 = 0L

type POINTAPI() =
    member this.x :  int64 = 0L
    member this.y :  int64 = 0L

type RECT() =
    member this.Left :  int64 = 0L
    member this.Top :  int64 = 0L
    member this.Right :  int64 = 0L
    member this.Bottom :  int64 = 0L

    

type WINDOWPLACEMENT() =
    member this.Length :  int64 = 0L
    member this.flags :  int64 = 0L
    member this.showCmd :  int64 = 0L
    member this.ptMinPosition : POINTAPI = new POINTAPI()
    member this.ptMaxPosition : POINTAPI = new POINTAPI()
    member this.rcNormalPosition : RECT = new RECT()

/// Cheats
type Cheat() =
    member this.CheatString : string = ""
    member this.Description : string = ""
    member this.Folder : string = ""
    member this.UID : string = ""

type ShortCut() =
    member this.UID : string = ""
    member this.Folder : string = ""
    member this.Description : string = ""
    member this.Command : string = ""
    member this.Category : int = 0
    member this.ExtKeyCode : int = 0
    member this.KeyCode : int = 0
    member this.Data : string = ""
    member this.IsActive : bool = false
    member this.ComboText : string = ""
    member this.DataPage : int = 0
    member this.DataDesc : string = ""

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

module GlobalVariables =
    open System.Collections
    open System.Globalization
    open System.IO
    open System.Linq
    open System.Reflection
    open System.Resources
    open System.Text
    open System.Xml

    /// Get specific resource from dll's resource
    let GetResource =
        let rm = ResourceManager("ControlCenter.Infrastructure.Resources", Assembly.GetExecutingAssembly())
        let resourceSet = rm.GetResourceSet(CultureInfo.CurrentUICulture, true, true) :> IEnumerable
        fun name -> resourceSet.Cast<DictionaryEntry>().FirstOrDefault(fun r -> (string)r.Key = name).Value

    /// Get Colors from GTASAColors.xml
    let ParseColors() =

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
        try
            let doc = new XmlDocument()
            doc.Load(".\GTASAColors.xml")
            doc.SelectSingleNode("Colors").ChildNodes.Cast<XmlNode>()
                |> Seq.iter (fun n ->
                    let color = { Rgb = RgbString2RbgLong n.Attributes.["Rgb"].Value;
                        ColorCode = Int32.Parse n.Attributes.["Id"].Value;
                        Description = n.Attributes.["ToolTip"].Value}
                    result <- color :: result)
        with
            | :? FileNotFoundException as e ->
                let xml = GetResource "GTASAColors" :?> string
                File.WriteAllText(".\GTASAColors.xml", xml)
            | _ as e -> printfn "%A" e
        result.Reverse().ToArray()

    let GTASAColors : GTASAColor array = [||]
