// Developer Express Code Central Example:
// How to collapse large editors in the detail view
// 
// Sometimes when your detail view contains a lot of editors, it is necessary to
// effectively use the space on the page. For example, usually editors in which
// collection properties are shown take a lot of space. You can reduce the space if
// you provide the capability to collapse large editors.
// In this example, I show
// how to put a large editor into the ASPxNavBar
// (ms-help://DevExpress.AspNet/clsDevExpressWebASPxNavBarASPxNavBartopic.htm)
// control that can expand/collapse its groups.
// 
// See Also:
// Access Editor
// Settings (ms-help://DevExpress.Xaf/CustomDocument2729.htm)
// 
// You can find sample updates and versions for different programming languages here:
// http://www.devexpress.com/example=E1499

namespace WebSolution.Module {
    partial class WebSolutionModule {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            // 
            // WebSolutionModule
            // 
            this.AdditionalExportedTypes.Add(typeof(DevExpress.Persistent.BaseImpl.Person));
            this.RequiredModuleTypes.Add(typeof(DevExpress.ExpressApp.SystemModule.SystemModule));
            this.RequiredModuleTypes.Add(typeof(DevExpress.ExpressApp.Objects.BusinessClassLibraryCustomizationModule));

        }

        #endregion
    }
}
