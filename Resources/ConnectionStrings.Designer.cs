//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Resources {
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
    public class ConnectionStrings {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal ConnectionStrings() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Resources.ConnectionStrings", typeof(ConnectionStrings).Assembly);
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
        ///   Looks up a localized string similar to server=localhost;database=NewDb;user=root;password=;Persist Security Info=False.
        /// </summary>
        public static string MySqlConnection {
            get {
                return ResourceManager.GetString("MySqlConnection", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Data Source=Application.sqlite.
        /// </summary>
        public static string SqlLiteConnection {
            get {
                return ResourceManager.GetString("SqlLiteConnection", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to server=(localdb)\\MSSQLLocalDB;database=CostDatabase;Trusted_Connection=true.
        /// </summary>
        public static string SqlLocalConnection {
            get {
                return ResourceManager.GetString("SqlLocalConnection", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to server=.;database=PortFolioDb;user=sa;password=09030924381531;Persist Security Info=False.
        /// </summary>
        public static string SqlServerConnectionSa {
            get {
                return ResourceManager.GetString("SqlServerConnectionSa", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Server=.;Database=PortFolioDbe;Trusted_Connection=True;.
        /// </summary>
        public static string SqlServerConnectionWindows {
            get {
                return ResourceManager.GetString("SqlServerConnectionWindows", resourceCulture);
            }
        }
    }
}
