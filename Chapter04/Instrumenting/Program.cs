﻿using System.Diagnostics;
using Microsoft.Extensions.Configuration;

string logPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory), "log.txt");

Console.WriteLine($"Writing to: {logPath}");

TextWriterTraceListener logFile = new(File.CreateText(logPath));

Trace.Listeners.Add(logFile);

Debug.WriteLine("Debug says, I am watching!");
Trace.WriteLine("Trace says, I am watching!");

#if DEBUG
// Text writer is buffered, so this option calls Flush() on all listeners after writing.
Trace.AutoFlush = true;
#endif

string settingsFile = "appsettings.json";

string settingPath = Path.Combine(Directory.GetCurrentDirectory(), settingsFile);

Console.WriteLine("Processing: {0}", settingPath);
Console.WriteLine("--{0} contents--", settingsFile);
Console.WriteLine(File.ReadAllText(settingPath));
Console.WriteLine("------");

ConfigurationBuilder builder = new();
builder.SetBasePath(Directory.GetCurrentDirectory());

builder.AddJsonFile(settingsFile, optional: false, reloadOnChange: true);

IConfigurationRoot configuration = builder.Build();

TraceSwitch ts = new(
    displayName: "PacktSwitch",
    description: "This switch is set via a JSON config");

configuration.GetSection("PacktSwitch").Bind(ts);

Console.WriteLine($"Trace switch value: {ts.Value}");
Console.WriteLine($"Trace switch level: {ts.Level}");

Trace.WriteLineIf(ts.TraceError, "Trace Error");
Trace.WriteLineIf(ts.TraceWarning, "Trace warning");
Trace.WriteLineIf(ts.TraceInfo, "Trace Information");
Trace.WriteLineIf(ts.TraceVerbose, "Trace Verbose");

// --------------------------
int unitsInStock = 12;
LogSourceDetails(unitsInStock > 10);

// Close the text file (also flushes) and release resources
Debug.Close();
Trace.Close();

Console.WriteLine("Press Enter to exit");
Console.ReadLine();