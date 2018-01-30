namespace ControlCenter.Infrastructure

module Prerequisite =
    open System
    open System.IO
    open System.Resources
    open System.Reflection
    open System.Globalization
    open System.Collections
    open System.Linq
    open System.Text

    let internal prerequisites = ["GTASACarPics"; "GTASACars"; "GTASACarTypes"; "GTASACheats"; "GTASAColors"; "GTASALocations"; "GTASAShortcuts"; "GTASAWeapons"]

    /// Get specific resources from resource
    let internal GetResource =
        let rm = ResourceManager("Resources", Assembly.GetExecutingAssembly())
        let resourceSet = rm.GetResourceSet(CultureInfo.CurrentUICulture, true, true) :> IEnumerable
        fun name -> resourceSet.Cast<DictionaryEntry>().FirstOrDefault(fun r -> (string)r.Key = name).Value

    /// Check whether GTASAConsole.ini exists, if not generate it from resources;
    let internal RegenerateXml name =
        let xml = GetResource name :?> string
        File.WriteAllText(@".\" + name + ".xml", xml)
    
    /// Check prerequisites and generate missing prerequisites
    let Check() =
        prerequisites
            |> List.iter (fun p ->
                let _sb = new StringBuilder()
                let name = _sb.Append(AppDomain.CurrentDomain.BaseDirectory).Append(p).Append(".xml").ToString()
                if not (File.Exists(name)) then RegenerateXml p)