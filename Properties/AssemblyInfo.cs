﻿using System.Reflection;
using System.Runtime.InteropServices;
using MelonLoader;
using RootsOfPachaCheatMod;
using BuildInfo = RootsOfPachaCheatMod.BuildInfo;

// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle("RootsOfPachaCheatMod")]
[assembly: AssemblyDescription("")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("")]
[assembly: AssemblyProduct("RootsOfPachaCheatMod")]
[assembly: AssemblyCopyright("Copyright ©  2023")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

// Setting ComVisible to false makes the types in this assembly not visible 
// to COM components.  If you need to access a type in this assembly from 
// COM, set the ComVisible attribute to true on that type.
[assembly: ComVisible(false)]

// The following GUID is for the ID of the typelib if this project is exposed to COM
[assembly: Guid("483625D8-E267-4A6F-BA7B-A5E37251FB2C")]

// Version information for an assembly consists of the following four values:
//
//      Major Version
//      Minor Version 
//      Build Number
//      Revision
//
// You can specify all the values or you can default the Build and Revision Numbers 
// by using the '*' as shown below:
// [assembly: AssemblyVersion("1.0.*")]
[assembly: AssemblyVersion("1.0.8.2")]
[assembly: AssemblyFileVersion("1.0.8.2")]

[assembly: MelonInfo(typeof(CheatMod), BuildInfo.Name, BuildInfo.Version, BuildInfo.Author)]
[assembly: MelonColor]

[assembly: MelonGame("Soda Den", "Roots of Pacha")]