namespace ControlCenter.Infrastructure

module Prerequisite =
    open System
    open System.IO
    open System.Resources
    open System.Reflection

    let RegenerateIni() =
        let assembly = Assembly.GetExecutingAssembly()
        let temp = assembly.GetManifestResourceNames()
        let stream = assembly.GetManifestResourceStream("ControlCenter.Infrastructure.Resources.resources")
        use filestream = File.Create(".\GTASAConsole.ini")
        stream.CopyTo(filestream)
        filestream.Close()
        true |> ignore

    let Check() =
        let iniFilePath = AppDomain.CurrentDomain.BaseDirectory + "GTASACC.ini"
        let datFilePath = AppDomain.CurrentDomain.BaseDirectory + "GTASAData.dat"
        let cfgFilePath = AppDomain.CurrentDomain.BaseDirectory + "GTASAConfig.dat"
        let picFileName = AppDomain.CurrentDomain.BaseDirectory + "GTASACarPics.dat"
        let cheatFileName = AppDomain.CurrentDomain.BaseDirectory + "GTASACheats.dat"
        let locsFileName = AppDomain.CurrentDomain.BaseDirectory + "GTASALocs.dat"

        if File.Exists(iniFilePath) = false then RegenerateIni()
        //if File.Exists(datFilePath) = false then RegenerateDat
        
