using MelonLoader;
using System.Reflection;
using System.Resources;
using System.Runtime.InteropServices;

[assembly: AssemblyTitle(Random_slowmo.BuildInfo.Name)]
[assembly: AssemblyDescription("")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany(Random_slowmo.BuildInfo.Company)]
[assembly: AssemblyProduct(Random_slowmo.BuildInfo.Name)]
[assembly: AssemblyCopyright("Created by " + Random_slowmo.BuildInfo.Author)]
[assembly: AssemblyTrademark(Random_slowmo.BuildInfo.Company)]
[assembly: AssemblyCulture("")]
[assembly: ComVisible(false)]
//[assembly: Guid("")]
[assembly: AssemblyVersion(Random_slowmo.BuildInfo.Version)]
[assembly: AssemblyFileVersion(Random_slowmo.BuildInfo.Version)]
[assembly: NeutralResourcesLanguage("en")]
[assembly: MelonInfo(typeof(Random_slowmo.RandomSlowmo), Random_slowmo.BuildInfo.Name, Random_slowmo.BuildInfo.Version, Random_slowmo.BuildInfo.Author, Random_slowmo.BuildInfo.DownloadLink)]


// Create and Setup a MelonModGame to mark a Mod as Universal or Compatible with specific Games.
// If no MelonModGameAttribute is found or any of the Values for any MelonModGame on the Mod is null or empty it will be assumed the Mod is Universal.
// Values for MelonModGame can be found in the Game's app.info file or printed at the top of every log directly beneath the Unity version.
[assembly: MelonGame(null, null)]