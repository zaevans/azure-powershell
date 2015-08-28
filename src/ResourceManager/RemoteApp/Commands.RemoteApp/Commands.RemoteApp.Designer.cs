﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.Azure.Commands.RemoteApp {
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
    internal class Commands_RemoteApp {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Commands_RemoteApp() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Microsoft.Azure.Commands.RemoteApp.Commands.RemoteApp", typeof(Commands_RemoteApp).Assembly);
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
        ///   Looks up a localized string similar to RemoteApp account not found.
        /// </summary>
        internal static string AccountNotFoundBySubscriptionId {
            get {
                return ResourceManager.GetString("AccountNotFoundBySubscriptionId", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An application with this alias already exists..
        /// </summary>
        internal static string ApplicationExists {
            get {
                return ResourceManager.GetString("ApplicationExists", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No application with this alias exists..
        /// </summary>
        internal static string ApplicationNotFound {
            get {
                return ResourceManager.GetString("ApplicationNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to RemoteApp collection name: {0} not found.
        /// </summary>
        internal static string CollectionNotFoundByNameFormat {
            get {
                return ResourceManager.GetString("CollectionNotFoundByNameFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No billing plans found for RemoteApp account.
        /// </summary>
        internal static string NoBillingPlansFound {
            get {
                return ResourceManager.GetString("NoBillingPlansFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No locations found for RemoteApp account.
        /// </summary>
        internal static string NoLocationsFound {
            get {
                return ResourceManager.GetString("NoLocationsFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to RemoteApp session with UserUpn: {0} not found.
        /// </summary>
        internal static string SessionNotFoundByUserUpnFormat {
            get {
                return ResourceManager.GetString("SessionNotFoundByUserUpnFormat", resourceCulture);
            }
        }
    }
}
