//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace phd_project_net_framework.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "17.2.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::NationalInstruments.DAQmx.AnalogEdgeStartTriggerSlope triggerSlope {
            get {
                return ((global::NationalInstruments.DAQmx.AnalogEdgeStartTriggerSlope)(this["triggerSlope"]));
            }
            set {
                this["triggerSlope"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::NationalInstruments.DAQmx.AIAccelerometerSensitivityUnits sensitivityUnits {
            get {
                return ((global::NationalInstruments.DAQmx.AIAccelerometerSensitivityUnits)(this["sensitivityUnits"]));
            }
            set {
                this["sensitivityUnits"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::NationalInstruments.DAQmx.AITerminalConfiguration terminalConfiguration {
            get {
                return ((global::NationalInstruments.DAQmx.AITerminalConfiguration)(this["terminalConfiguration"]));
            }
            set {
                this["terminalConfiguration"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::NationalInstruments.DAQmx.AIExcitationSource excitationSource {
            get {
                return ((global::NationalInstruments.DAQmx.AIExcitationSource)(this["excitationSource"]));
            }
            set {
                this["excitationSource"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::NationalInstruments.DAQmx.AICoupling inputCoupling {
            get {
                return ((global::NationalInstruments.DAQmx.AICoupling)(this["inputCoupling"]));
            }
            set {
                this["inputCoupling"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string physicalChannel {
            get {
                return ((string)(this["physicalChannel"]));
            }
            set {
                this["physicalChannel"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("10000")]
        public double Rate {
            get {
                return ((double)(this["Rate"]));
            }
            set {
                this["Rate"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("-10")]
        public double MinVal {
            get {
                return ((double)(this["MinVal"]));
            }
            set {
                this["MinVal"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("10")]
        public double MaxVal {
            get {
                return ((double)(this["MaxVal"]));
            }
            set {
                this["MaxVal"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("10.64")]
        public double Sensitivity {
            get {
                return ((double)(this["Sensitivity"]));
            }
            set {
                this["Sensitivity"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("1000")]
        public int Samples {
            get {
                return ((int)(this["Samples"]));
            }
            set {
                this["Samples"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("APFI0")]
        public string triggerSource {
            get {
                return ((string)(this["triggerSource"]));
            }
            set {
                this["triggerSource"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public double triggerLevel {
            get {
                return ((double)(this["triggerLevel"]));
            }
            set {
                this["triggerLevel"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public double Hysteresis {
            get {
                return ((double)(this["Hysteresis"]));
            }
            set {
                this["Hysteresis"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0.002")]
        public double excitationValue {
            get {
                return ((double)(this["excitationValue"]));
            }
            set {
                this["excitationValue"] = value;
            }
        }
    }
}
