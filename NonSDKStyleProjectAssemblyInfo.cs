// <copyright file="CommonAssemblyInfo.cs" company="Oleg Sych">
//  Copyright © Oleg Sych. All Rights Reserved.
// </copyright>

using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

#if DEBUG
[assembly: AssemblyConfiguration("Debug")]
#else
[assembly: AssemblyConfiguration("Release")]
#endif 

[assembly: AssemblyProduct(T4Toolbox.AssemblyInfo.Product)]
[assembly: AssemblyDescription(T4Toolbox.AssemblyInfo.Description)]
[assembly: AssemblyCompany("Oleg Sych")]
[assembly: AssemblyCopyright("Copyright © Oleg Sych. All Rights Reserved.")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]
[assembly: AssemblyVersion(T4Toolbox.AssemblyInfo.Version)]
[assembly: AssemblyFileVersion(T4Toolbox.AssemblyInfo.Version)]
[assembly: NeutralResourcesLanguage("en-US")]

