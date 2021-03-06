﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Deployer.UI.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Deployer.UI.Properties.Resources", typeof(Resources).Assembly);
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
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The downloaded files have been deleted successfully.
        /// </summary>
        public static string DownloadedFolderDeleted {
            get {
                return ResourceManager.GetString("DownloadedFolderDeleted", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The &apos;Downloaded&apos; folder hasn&apos;t been found..
        /// </summary>
        public static string DownloadedFolderNotFound {
            get {
                return ResourceManager.GetString("DownloadedFolderNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Nothing to delete.
        /// </summary>
        public static string DownloadedFolderNotFoundTitle {
            get {
                return ResourceManager.GetString("DownloadedFolderNotFoundTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Error.
        /// </summary>
        public static string ErrorTitle {
            get {
                return ResourceManager.GetString("ErrorTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Sorry, but your Windows 10 installation is too old to run WOA Deployer. 
        ///
        ///This application needs at least Windows 10 Creators Update (15063).
        ///
        ///Please, update your system using Windows Update before using it..
        /// </summary>
        public static string IncompatibleWindows10Build {
            get {
                return ResourceManager.GetString("IncompatibleWindows10Build", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Incompatible Windows 10 build.
        /// </summary>
        public static string IncompatibleWindows10BuildTitle {
            get {
                return ResourceManager.GetString("IncompatibleWindows10BuildTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid WIM file.
        /// </summary>
        public static string InvalidWimFile {
            get {
                return ResourceManager.GetString("InvalidWimFile", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The selected .WIM file doesn&apos;t contain any image for ARM64. Please, select a .wim file that targets this architecture..
        /// </summary>
        public static string WimFileNoValidArchitecture {
            get {
                return ResourceManager.GetString("WimFileNoValidArchitecture", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Windows Images.
        /// </summary>
        public static string WimFilesFilter {
            get {
                return ResourceManager.GetString("WimFilesFilter", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Deployment successful.
        /// </summary>
        public static string WindowsDeployedSuccessfullyTitle {
            get {
                return ResourceManager.GetString("WindowsDeployedSuccessfullyTitle", resourceCulture);
            }
        }
    }
}
