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

using DevExpress.ExpressApp.Updating;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using DevExpress.ExpressApp;
using DevExpress.Persistent.BaseImpl;

namespace WebSolution.Module {
    public class Updater : ModuleUpdater {
        public Updater(IObjectSpace objectSpace, Version currentDBVersion) : base(objectSpace, currentDBVersion) { }
        public override void UpdateDatabaseAfterUpdateSchema() {
            base.UpdateDatabaseAfterUpdateSchema();

            Person p = ObjectSpace.FindObject<Person>(CriteriaOperator.Parse("FirstName = ?", "Click here to open the detail view"));
            if (p == null) {
                p = new Person(Session);
                p.FirstName = "Click here to open the detail view";
                p.Save();
            }
        }
    }
}
