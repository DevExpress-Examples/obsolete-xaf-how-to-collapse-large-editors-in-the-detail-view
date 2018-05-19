using System;

using DevExpress.ExpressApp.Updating;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using DevExpress.Persistent.BaseImpl;

namespace WebSolution.Module {
    public class Updater : ModuleUpdater {
        public Updater(Session session, Version currentDBVersion) : base(session, currentDBVersion) { }
        public override void UpdateDatabaseAfterUpdateSchema() {
            base.UpdateDatabaseAfterUpdateSchema();

            Person p = Session.FindObject<Person>(CriteriaOperator.Parse("FirstName = ?", "Click here to open the detail view"));
            if (p == null) {
                p = new Person(Session);
                p.FirstName = "Click here to open the detail view";
                p.Save();
            }
        }
    }
}
