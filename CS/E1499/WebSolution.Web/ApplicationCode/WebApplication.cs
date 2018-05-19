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

using System;
using System.Collections.Generic;
using System.ComponentModel;
using DevExpress.ExpressApp.Web;

namespace WebSolution.Web {
    public partial class WebSolutionAspNetApplication : WebApplication {
        private DevExpress.ExpressApp.SystemModule.SystemModule module1;
        private DevExpress.ExpressApp.Web.SystemModule.SystemAspNetModule module2;
        private WebSolution.Module.WebSolutionModule module3;
        private WebSolution.Module.Web.WebSolutionAspNetModule module4;
        private DevExpress.ExpressApp.Objects.BusinessClassLibraryCustomizationModule module6;
        private DevExpress.ExpressApp.Validation.ValidationModule module5;

        public WebSolutionAspNetApplication() {
            InitializeComponent();
        }

        private void WebSolutionAspNetApplication_DatabaseVersionMismatch(object sender, DevExpress.ExpressApp.DatabaseVersionMismatchEventArgs e) {
            e.Updater.Update();
            e.Handled = true;
        }

        private void InitializeComponent() {
            this.module1 = new DevExpress.ExpressApp.SystemModule.SystemModule();
            this.module2 = new DevExpress.ExpressApp.Web.SystemModule.SystemAspNetModule();
            this.module3 = new WebSolution.Module.WebSolutionModule();
            this.module4 = new WebSolution.Module.Web.WebSolutionAspNetModule();
            this.module5 = new DevExpress.ExpressApp.Validation.ValidationModule();
            this.module6 = new DevExpress.ExpressApp.Objects.BusinessClassLibraryCustomizationModule();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // module5
            // 
            this.module5.AdditionalBusinessClasses.Add(typeof(DevExpress.Persistent.Validation.RuleSetValidationResult));
            this.module5.AdditionalBusinessClasses.Add(typeof(DevExpress.Persistent.Validation.RuleSetValidationResultItem));
            this.module5.AdditionalBusinessClasses.Add(typeof(DevExpress.Persistent.Validation.RulePropertyValueProperties));
            this.module5.AdditionalBusinessClasses.Add(typeof(DevExpress.Persistent.Validation.RuleRequiredFieldProperties));
            this.module5.AdditionalBusinessClasses.Add(typeof(DevExpress.Persistent.Validation.RuleFromBoolPropertyProperties));
            this.module5.AdditionalBusinessClasses.Add(typeof(DevExpress.Persistent.Validation.RuleRangeProperties));
            this.module5.AdditionalBusinessClasses.Add(typeof(DevExpress.Persistent.Validation.RuleValueComparisonProperties));
            this.module5.AdditionalBusinessClasses.Add(typeof(DevExpress.Persistent.Validation.RuleStringComparisonProperties));
            this.module5.AdditionalBusinessClasses.Add(typeof(DevExpress.Persistent.Validation.RuleRegularExpressionProperties));
            this.module5.AdditionalBusinessClasses.Add(typeof(DevExpress.Persistent.Validation.RuleCriteriaProperties));
            this.module5.AdditionalBusinessClasses.Add(typeof(DevExpress.Persistent.Validation.RuleSearchObjectProperties));
            this.module5.AdditionalBusinessClasses.Add(typeof(DevExpress.Persistent.Validation.RuleObjectExistsProperties));
            this.module5.AdditionalBusinessClasses.Add(typeof(DevExpress.Persistent.Validation.RuleUniqueValueProperties));
            this.module5.AdditionalBusinessClasses.Add(typeof(DevExpress.Persistent.Validation.RuleIsReferencedProperties));
            // 
            // WebSolutionAspNetApplication
            // 
            this.ApplicationName = "WebSolution";
            this.Modules.Add(this.module1);
            this.Modules.Add(this.module2);
            this.Modules.Add(this.module6);
            this.Modules.Add(this.module3);
            this.Modules.Add(this.module4);
            this.Modules.Add(this.module5);
            this.DatabaseVersionMismatch += new System.EventHandler<DevExpress.ExpressApp.DatabaseVersionMismatchEventArgs>(this.WebSolutionAspNetApplication_DatabaseVersionMismatch);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }
    }
}
