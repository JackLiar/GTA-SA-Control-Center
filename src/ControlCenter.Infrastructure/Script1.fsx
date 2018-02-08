
// Create GTASAColors.xml
//let mutable location = @"D:\Documents\Code\Github\JackWzh\GTA SA Control Center\GTA SA Control Center\Resources\Data\GTASAColors.xml"

//let mutable file = new System.IO.StreamReader (location)
//let mutable writer = System.Xml.XmlWriter.Create("D:\Documents\Code\Github\JackWzh\GTA SA Control Center\GTA SA Control Center\Resources\Data\Datatest.xml")
//writer.WriteStartDocument()
//writer.WriteStartElement("Colors")

//let mutable line = file.ReadLine()
//while line <> null
//    do writer.WriteStartElement("Colors")
//       let mutable result = System.Text.RegularExpressions.Regex.Matches(line, @"\d{1,3},\d{1,3},\d{1,3}")
//       if result.Count <> 0 then
//          writer.WriteAttributeString("rgb", result.[0].ToString())
//          printfn "%A" result.[0]

//       result <- System.Text.RegularExpressions.Regex.Matches(line, @"#\s\d{1,3}")
//       if result.Count <> 0 then
//          result <- System.Text.RegularExpressions.Regex.Matches(result.[0].ToString(), @"\d{1,3}")
//          printfn "%A" result.[0]
//          writer.WriteAttributeString("id", result.[0].ToString())

//       result <- System.Text.RegularExpressions.Regex.Matches(line, @"[a-z]+\.?[a-z]*(\s[a-z]+)*")
//       if result.Count <> 0 then
//          writer.WriteAttributeString("ToolTipText", result.[0].ToString())
//          printfn "%A" result.[0]
//       line <- file.ReadLine()
//       writer.WriteEndElement()
//file.Close()
//writer.WriteEndElement()
//writer.WriteEndDocument()
//writer.Close()

// Create GTASACars.xml
open System
let location = @"D:\Documents\Code\Github\JackWzh\GTA SA Control Center\GTA SA Control Center\Resources\Data\GTASAData.dat"
let file = new System.IO.StreamReader (location)
let mutable writer = System.Xml.XmlWriter.Create("D:\Documents\Code\Github\JackWzh\GTA SA Control Center\GTA SA Control Center\Resources\Data\GTASACars.xml")
writer.WriteStartDocument()
writer.WriteStartElement("Cars")

let mutable line ="'"
while line.Contains("Id") = false
    do line <- file.ReadLine()
line <- file.ReadLine()
try
    while line <> null && line.Contains("GTASACars") = false
        do writer.WriteStartElement("Car")
           printfn "%s" line
           let mutable result = System.Text.RegularExpressions.Regex.Matches(line, @"\d+(,|\b)")
           if result.Count <> 0 then
              writer.WriteAttributeString("Id", result.[0].ToString().TrimEnd(','))
              writer.WriteAttributeString("Dim.X", result.[1].ToString().TrimEnd(','))
              writer.WriteAttributeString("Dim.Y", result.[2].ToString().TrimEnd(','))
              writer.WriteAttributeString("Dim.Z", result.[3].ToString().TrimEnd(','))
              writer.WriteAttributeString("hHandling", result.[4].ToString().TrimEnd(','))
              writer.WriteAttributeString("isParkable", result.[5].ToString().TrimEnd(','))
              writer.WriteAttributeString("MinorColor", result.[6].ToString().TrimEnd(','))
              writer.WriteAttributeString("MajorColor", result.[7].ToString().TrimEnd(','))

           result <- System.Text.RegularExpressions.Regex.Matches(line, @"[a-zA-Z]+,")
           if result.Count <> 0 then
              writer.WriteAttributeString("CarName", result.[0].ToString().TrimEnd(','))
              writer.WriteAttributeString("Type", result.[1].ToString().TrimEnd(','))

           result <- System.Text.RegularExpressions.Regex.Matches(line, @"(\w{3,3};)+\w{3,3}")
           if result.Count <> 0 then
              writer.WriteAttributeString("AllowedModifications", result.[0].ToString())
           line <- file.ReadLine()
           writer.WriteEndElement()
with
    | :? Exception as e -> printfn "%A" e

file.Close()
writer.WriteEndElement()
writer.WriteEndDocument()
writer.Close()