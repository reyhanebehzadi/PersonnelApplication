﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Jamsaz.PersonnlsApplication.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.9.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("atlas")]
        public string ServerName {
            get {
                return ((string)(this["ServerName"]));
            }
            set {
                this["ServerName"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("JamsazERPLite")]
        public string InitialCatalog {
            get {
                return ((string)(this["InitialCatalog"]));
            }
            set {
                this["InitialCatalog"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("temp")]
        public string ProviderString {
            get {
                return ((string)(this["ProviderString"]));
            }
            set {
                this["ProviderString"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("\\\\atlas\\Personnel Manager Software\\Template\\")]
        public string PathTemplate {
            get {
                return ((string)(this["PathTemplate"]));
            }
            set {
                this["PathTemplate"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("\\\\atlas\\Personnel Pictures\\")]
        public string PathPersonnelsImage {
            get {
                return ((string)(this["PathPersonnelsImage"]));
            }
            set {
                this["PathPersonnelsImage"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=atlas;Initial Catalog=JamsazERPLite;Integrated Security=True")]
        public string JamsazERPLiteConnectionString {
            get {
                return ((string)(this["JamsazERPLiteConnectionString"]));
            }
            set {
                this["JamsazERPLiteConnectionString"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("\\\\ATLAS\\Personnel Manager Software\\ConnectionString\\")]
        public string PathConnectionString {
            get {
                return ((string)(this["PathConnectionString"]));
            }
            set {
                this["PathConnectionString"] = value;
            }
        }
    }
}
