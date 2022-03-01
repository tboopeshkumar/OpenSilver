﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace System.Windows.Input.Manipulations {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Runtime.OpenSilver.System.Windows.Input.Manipulations.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to Value of {0} is outside of the allowed range..
        /// </summary>
        internal static string ArgumentOutOfRange {
            get {
                return ResourceManager.GetString("ArgumentOutOfRange", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The value of {0} cannot be changed while the inertia processor is running..
        /// </summary>
        internal static string CannotChangeParameterDuringInertia {
            get {
                return ResourceManager.GetString("CannotChangeParameterDuringInertia", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Value of {0} must be either NaN, or a finite value greater than or equal to 1..
        /// </summary>
        internal static string IllegalPivotRadius {
            get {
                return ResourceManager.GetString("IllegalPivotRadius", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Either {0}, or {1} and {2}, needs to be specified..
        /// </summary>
        internal static string InertiaParametersUnspecified1and2 {
            get {
                return ResourceManager.GetString("InertiaParametersUnspecified1and2", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Either {0} or {1} needs to be specified..
        /// </summary>
        internal static string InertiaParametersUnspecified2 {
            get {
                return ResourceManager.GetString("InertiaParametersUnspecified2", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to InitialRadius should be a finite number, greater than or equal to 1..
        /// </summary>
        internal static string InertiaProcessorInvalidRadius {
            get {
                return ResourceManager.GetString("InertiaProcessorInvalidRadius", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Timestamp values must not decrease..
        /// </summary>
        internal static string InvalidTimestamp {
            get {
                return ResourceManager.GetString("InvalidTimestamp", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to At least one of the following must be specified: linear velocity ({0} or {1}), angular velocity ({2}), or expansion velocity ({3} or {4})..
        /// </summary>
        internal static string NoInertiaVelocitiesSpecified {
            get {
                return ResourceManager.GetString("NoInertiaVelocitiesSpecified", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Currently, only proportional expansion is supported. {0} must equal {1}..
        /// </summary>
        internal static string OnlyProportionalExpansionSupported {
            get {
                return ResourceManager.GetString("OnlyProportionalExpansionSupported", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Value of {0} must be finite..
        /// </summary>
        internal static string ValueMustBeFinite {
            get {
                return ResourceManager.GetString("ValueMustBeFinite", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Value of {0} must be finite and non-negative..
        /// </summary>
        internal static string ValueMustBeFiniteNonNegative {
            get {
                return ResourceManager.GetString("ValueMustBeFiniteNonNegative", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Value of {0} must be finite or NaN..
        /// </summary>
        internal static string ValueMustBeFiniteOrNaN {
            get {
                return ResourceManager.GetString("ValueMustBeFiniteOrNaN", resourceCulture);
            }
        }
    }
}
