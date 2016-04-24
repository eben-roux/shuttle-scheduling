﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18449
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Shuttle.Esb.Scheduling {
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
    internal class SchedulingResources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal SchedulingResources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Shuttle.Esb.Scheduling.SchedulingResources", typeof(SchedulingResources).Assembly);
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
        ///   Looks up a localized string similar to Cron expression &apos;{0}&apos; is invalid since you cannot specify both day-of-month and day-of-week.  Specify one of the two as &apos;?&apos;..
        /// </summary>
        internal static string CronBothDaysSpecified {
            get {
                return ResourceManager.GetString("CronBothDaysSpecified", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to End value &apos;{0}&apos; is higher than the maximum permitted value of &apos;{1}&apos;..
        /// </summary>
        internal static string CronEndValueTooLarge {
            get {
                return ResourceManager.GetString("CronEndValueTooLarge", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to End value &apos;{0}&apos; is lower than the minimum permitted value of &apos;{1}&apos;..
        /// </summary>
        internal static string CronEndValueTooSmall {
            get {
                return ResourceManager.GetString("CronEndValueTooSmall", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Expression &apos;{0}&apos; is not valid..
        /// </summary>
        internal static string CronInvalidExpression {
            get {
                return ResourceManager.GetString("CronInvalidExpression", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A CronExpression must contain exactly 5 fields.  {0} fields have specified..
        /// </summary>
        internal static string CronInvalidFieldCount {
            get {
                return ResourceManager.GetString("CronInvalidFieldCount", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Specification expected candidate of type &apos;{0}&apos; but was &apos;{1}&apos;..
        /// </summary>
        internal static string CronInvalidSpecificationCandidate {
            get {
                return ResourceManager.GetString("CronInvalidSpecificationCandidate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No days specified in expression &apos;{0}&apos;.  You should not specify both day-of-month and day-of-week as &apos;?&apos;..
        /// </summary>
        internal static string CronNoDaysSpecified {
            get {
                return ResourceManager.GetString("CronNoDaysSpecified", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The start value may not be greater than the end value..
        /// </summary>
        internal static string CronStartValueLargerThanEndValue {
            get {
                return ResourceManager.GetString("CronStartValueLargerThanEndValue", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Start value &apos;{0}&apos; is higher than the maximum permitted value of &apos;{1}&apos;..
        /// </summary>
        internal static string CronStartValueTooLarge {
            get {
                return ResourceManager.GetString("CronStartValueTooLarge", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Start value &apos;{0}&apos; is lower than the minimum permitted value of &apos;{1}&apos;..
        /// </summary>
        internal static string CronStartValueTooSmall {
            get {
                return ResourceManager.GetString("CronStartValueTooSmall", resourceCulture);
            }
        }
    }
}