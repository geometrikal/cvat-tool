// See https://aka.ms/new-console-template for more information
using System.CommandLine;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

// Command line arguments
RootCommand rootCommand = new RootCommand("Scale bounding boxes in CVAT for Video 1.1 annotation format");

// Input
var inputOption = new Option<FileInfo>( 
    new string[] { "--input", "-i" },
    "The path to the annotations xml that is to be converted");
rootCommand.AddOption(inputOption);

// Output
var outputOption = new Option<FileInfo>(
    new string[] { "--output", "-o" },
    "The path to save the new annotations file");
rootCommand.AddOption(outputOption);

// Scale
var scaleOption = new Option<decimal>(
    new string[] { "--scale", "-s" },
    "Amount to scale the annotation dimensions");
rootCommand.AddOption(scaleOption);

rootCommand.SetHandler((FileInfo i, FileInfo o, decimal s) =>
{
    Console.WriteLine("CVAT annotation scaler");
    Console.WriteLine("----------------------");
    Console.WriteLine(i.FullName);
    Console.WriteLine(o.FullName);
    Console.WriteLine(s);

    var serializer = new XmlSerializer(typeof(annotations));

    using (var stream = new FileStream(i.FullName, FileMode.Open))
    using (var writer = XmlWriter.Create(o.FullName, new XmlWriterSettings() { Indent = true }))
    {
        annotations anns = (annotations)serializer.Deserialize(stream);
        foreach (var track in anns.track)
        {
            foreach (var box in track.box)
            {
                Console.WriteLine($"Track: {track.id}, Box: {box.xtl} {box.ytl} {box.xbr} {box.ybr}");
                box.xtl *= s;
                box.ytl *= s;
                box.xbr *= s;
                box.ybr *= s;
            }
        }
        serializer.Serialize(writer, anns);
    }
}, inputOption, outputOption, scaleOption);

return rootCommand.Invoke(args);