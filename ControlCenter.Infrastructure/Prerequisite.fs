namespace ControlCenter.Infrastructure

module Prerequisite =
    open System
    open System.IO
    open System.Resources
    open System.Reflection
    open System.Globalization
    open System.Collections
    open System.Linq
    open System.Xml
    open System.Drawing

    let iniFilePath = AppDomain.CurrentDomain.BaseDirectory + "GTASAConsole.ini"
    let datFilePath = AppDomain.CurrentDomain.BaseDirectory + "GTASAData.dat"
    let cfgFilePath = AppDomain.CurrentDomain.BaseDirectory + "GTASAConfig.dat"
    let picFileName = AppDomain.CurrentDomain.BaseDirectory + "GTASACarPics.dat"
    let cheatFileName = AppDomain.CurrentDomain.BaseDirectory + "GTASACheats.dat"
    let locsFileName = AppDomain.CurrentDomain.BaseDirectory + "GTASALocs.dat"

    /// Get specific resources from resource
    let GetResource =
        let rm = ResourceManager("ControlCenter.Infrastructure.Resources", Assembly.GetExecutingAssembly())
        let resourceSet = rm.GetResourceSet(CultureInfo.CurrentUICulture, true, true) :> IEnumerable
        fun name -> resourceSet.Cast<DictionaryEntry>().FirstOrDefault(fun r -> (string)r.Key = name).Value

    /// Check whether GTASAConsole.ini exists, if not generate it from resources;
    let RegenerateIni =
        let ini = GetResource "GTASAConsole" :?> string
        File.WriteAllText(".\GTASAConsole.ini", ini)

    let RegenerateDat name =
        let data = GetResource name :?> byte array
        File.WriteAllBytes(@".\" + name + ".dat", data)
    
    /// Get Colors from GTASAColors.xml
    let ParseColors() =
        let mutable result : GTASAColor list = []
        let RgbString2RbgLong (rgbStr: string) =
            let rgbInt = rgbStr.Split(',') |> Array.map Int32.Parse
            let temp = rgbInt.[0].ToString("X2") + rgbInt.[1].ToString("X2")+ rgbInt.[2].ToString("X2")
            Convert.ToInt32(temp, 16)

        let doc = new XmlDocument()
        doc.Load(".\GTASAColors.xml")
        for node in doc.SelectSingleNode("Colors").ChildNodes do
            let color = { Rgb = RgbString2RbgLong node.Attributes.["Rgb"].Value;
                ColorCode = Int32.Parse node.Attributes.["Id"].Value;
                Description = node.Attributes.["ToolTip"].Value
                }
            result <- color :: result
        result.Reverse().ToArray()
    
    /// Check prerequisites and generate missing prerequisites
    let Check() =
        if not (File.Exists(iniFilePath)) then RegenerateIni
        if not (File.Exists(datFilePath)) then RegenerateDat "GTASAData"

        let temp = ParseColors()
        GlobalVariables.GTASAColors <- ParseColors()

        if not (File.Exists(cfgFilePath)) then RegenerateDat "GTASAConfig"
        if not (File.Exists(picFileName)) then RegenerateDat "GTASACarPics"
        if not (File.Exists(cheatFileName)) then RegenerateDat "GTASACheats"
        if not (File.Exists(locsFileName)) then RegenerateDat "GTASALocs"