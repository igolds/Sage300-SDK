﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sage.CA.SBS.ERP.Sage300.GL.Resources.Process {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class PeriodEndMaintenanceResx {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal PeriodEndMaintenanceResx() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Sage.CA.SBS.ERP.Sage300.GL.Resources.Process.PeriodEndMaintenanceResx", typeof(PeriodEndMaintenanceResx).Assembly);
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
        ///   Looks up a localized string similar to Delete Fiscal Set History.
        /// </summary>
        public static string DeleteFiscalSet {
            get {
                return ResourceManager.GetString("DeleteFiscalSet", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Delete Inactive Accounts.
        /// </summary>
        public static string DeleteInactive {
            get {
                return ResourceManager.GetString("DeleteInactive", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Delete Transaction Detail History.
        /// </summary>
        public static string DeleteTransaction {
            get {
                return ResourceManager.GetString("DeleteTransaction", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to G/L Period End Maintenance.
        /// </summary>
        public static string Entity {
            get {
                return ResourceManager.GetString("Entity", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This option removes all transaction history older than year {0}..
        /// </summary>
        public static string RemoveDetailHist {
            get {
                return ResourceManager.GetString("RemoveDetailHist", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This option deletes all fiscal sets older than year {0}..
        /// </summary>
        public static string RemoveSummaryHist {
            get {
                return ResourceManager.GetString("RemoveSummaryHist", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This option removes all deleted and posted batches and sets the next batch number to 1. You will not be able to view batches on the Batch List screen..
        /// </summary>
        public static string ResetAllBatches {
            get {
                return ResourceManager.GetString("ResetAllBatches", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Reset Batch Numbers.
        /// </summary>
        public static string ResetBatchNumbers {
            get {
                return ResourceManager.GetString("ResetBatchNumbers", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Use this screen to reset batch numbers and delete unneeded accounts, transaction details and fiscal sets..
        /// </summary>
        public static string UIDescription {
            get {
                return ResourceManager.GetString("UIDescription", resourceCulture);
            }
        }
    }
}