﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HedgeModManager.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("HedgeModManager.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to HedgeModManager.
        /// </summary>
        internal static string ApplicationTitle {
            get {
                return ResourceManager.GetString("ApplicationTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to HedgeModManager could not find a game executable in its startup directory. 
        ///HedgeModManager can attempt to look for your game and install itself automatically.
        ///.
        /// </summary>
        internal static string CannotFindExecutableText {
            get {
                return ResourceManager.GetString("CannotFindExecutableText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A &quot;mods&quot; folder must exist within your game installation directory for HedgeModManager to correctly function. Would you like to create one?.
        /// </summary>
        internal static string CannotFindModsDirectoryText {
            get {
                return ResourceManager.GetString("CannotFindModsDirectoryText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [CPKREDIR]
        ///; Lines starting with ; are comments and are ignored
        ///Enabled=1
        ///PlaceTocAtEnd=1
        ///HandleCpksWithoutExtFiles=0
        ///;LogType=console
        ///LogFile=&quot;cpkredir.log&quot;
        ///ReadBlockSizeKB=4096
        ///ModsDbIni=&quot;mods\ModsDB.ini&quot;
        ///EnableSaveFileRedirection=1
        ///SaveFileFallback=&quot;cpkredir.sav&quot;
        ///SaveFileOverride=
        ///.
        /// </summary>
        internal static string cpkredirINI {
            get {
                return ResourceManager.GetString("cpkredirINI", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Byte[].
        /// </summary>
        internal static byte[] Disable_Blue_Trail {
            get {
                object obj = ResourceManager.GetObject("Disable_Blue_Trail", resourceCulture);
                return ((byte[])(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Byte[].
        /// </summary>
        internal static byte[] Disable_FxPipeline {
            get {
                object obj = ResourceManager.GetObject("Disable_FxPipeline", resourceCulture);
                return ((byte[])(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Byte[].
        /// </summary>
        internal static byte[] Enable_Blue_Trail {
            get {
                object obj = ResourceManager.GetObject("Enable_Blue_Trail", resourceCulture);
                return ((byte[])(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Byte[].
        /// </summary>
        internal static byte[] Enable_FxPipeline {
            get {
                object obj = ResourceManager.GetObject("Enable_FxPipeline", resourceCulture);
                return ((byte[])(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An error occured! See &quot;HedgeModManager.log&quot; for more info..
        /// </summary>
        internal static string ExceptionPiracyText {
            get {
                return ResourceManager.GetString("ExceptionPiracyText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An error occured! See &quot;HedgeModManager.log&quot; for more info and report the file if possible..
        /// </summary>
        internal static string ExceptionText {
            get {
                return ResourceManager.GetString("ExceptionText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} executable has not yet been patched for use with CPKREDIR, which is required to load mods.
        ///Would you like to patch the executable now?.
        /// </summary>
        internal static string ExecutableNotPatchedText {
            get {
                return ResourceManager.GetString("ExecutableNotPatchedText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Byte[].
        /// </summary>
        internal static byte[] ForcesModLoader {
            get {
                object obj = ResourceManager.GetObject("ForcesModLoader", resourceCulture);
                return ((byte[])(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to https://github.com/thesupersonic16/HedgeModManager/raw/master/HedgeModManager/res/codes/ForcesModLoader.dll.sha256.
        /// </summary>
        internal static string ForcesModLoaderHashURL {
            get {
                return ResourceManager.GetString("ForcesModLoaderHashURL", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to https://github.com/thesupersonic16/HedgeModManager/raw/master/HedgeModManager/res/codes/ForcesModLoader.dll.
        /// </summary>
        internal static string ForcesModLoaderURL {
            get {
                return ResourceManager.GetString("ForcesModLoaderURL", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to We have updated the command for GameBanana&apos;s 1-Click Install.
        ///To complete the update we will need to restart HedgeModManager as Admin..
        /// </summary>
        internal static string GameBananaRegUpdateText {
            get {
                return ResourceManager.GetString("GameBananaRegUpdateText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Icon similar to (Icon).
        /// </summary>
        internal static System.Drawing.Icon icon {
            get {
                object obj = ResourceManager.GetObject("icon", resourceCulture);
                return ((System.Drawing.Icon)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap icon96 {
            get {
                object obj = ResourceManager.GetObject("icon96", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The mod &quot;{0}&quot; has an invalid includeDir ({1})
        ///Do you want HedgeModManager to attempt to fix this?.
        /// </summary>
        internal static string InvalidIncludeDirText {
            get {
                return ResourceManager.GetString("InvalidIncludeDirText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The currently installed loader doesn&apos;t match the version Hedge Mod Manager&apos;s Github, Unless you know what you are doing, Click &quot;Reinstall Loader&quot;.
        /// </summary>
        internal static string LoaderMismatchText {
            get {
                return ResourceManager.GetString("LoaderMismatchText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The loader for {0} currently isn&apos;t installed, would you like to install it now?.
        /// </summary>
        internal static string LoaderNotInstalled {
            get {
                return ResourceManager.GetString("LoaderNotInstalled", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to There&apos;s a newer version of {0} available!
        ///
        ///Do you want to update from version {1} to {2}? ({3}).
        /// </summary>
        internal static string ModUpdateText {
            get {
                return ResourceManager.GetString("ModUpdateText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No codes were found. Would you like HedgeModManager to download codes from it&apos;s database?.
        /// </summary>
        internal static string NoCodesText {
            get {
                return ResourceManager.GetString("NoCodesText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to HedgeModManager can not check for updates for {0} because it has no update server..
        /// </summary>
        internal static string NoUpdateServerAndURLText {
            get {
                return ResourceManager.GetString("NoUpdateServerAndURLText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to HedgeModManager can not check for updates for {0} because it has no update server.
        ///
        ///However, this mod does have a website.
        ///    Do you want to open it and check for updates manually?
        ///        URL: {1}.
        /// </summary>
        internal static string NoUpdateServerText {
            get {
                return ResourceManager.GetString("NoUpdateServerText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to We have detected that you&apos;re using a pirated copy of {0}. Please purchase {0} off the Steam store..
        /// </summary>
        internal static string PiracyText {
            get {
                return ResourceManager.GetString("PiracyText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Byte[].
        /// </summary>
        internal static byte[] SonicGenerationsCodeLoader {
            get {
                object obj = ResourceManager.GetObject("SonicGenerationsCodeLoader", resourceCulture);
                return ((byte[])(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to https://github.com/thesupersonic16/HedgeModManager/raw/master/HedgeModManager/res/codes/SonicGenerationsCodeLoader.dll.sha256.
        /// </summary>
        internal static string SonicGenerationsCodeLoaderHashURL {
            get {
                return ResourceManager.GetString("SonicGenerationsCodeLoaderHashURL", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to https://github.com/thesupersonic16/HedgeModManager/raw/master/HedgeModManager/res/codes/SonicGenerationsCodeLoader.dll.
        /// </summary>
        internal static string SonicGenerationsCodeLoaderURL {
            get {
                return ResourceManager.GetString("SonicGenerationsCodeLoaderURL", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Byte[].
        /// </summary>
        internal static byte[] update {
            get {
                object obj = ResourceManager.GetObject("update", resourceCulture);
                return ((byte[])(obj));
            }
        }
    }
}
