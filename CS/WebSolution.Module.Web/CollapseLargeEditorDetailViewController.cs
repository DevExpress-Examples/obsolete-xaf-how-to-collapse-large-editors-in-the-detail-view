using System;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Editors;
using System.Web.UI;
using DevExpress.Web.ASPxNavBar;

namespace WebSolution.Module.Web {
    public class CollapseLargeEditorDetailViewController : ViewController {
        public CollapseLargeEditorDetailViewController() {
            TargetViewType = ViewType.DetailView;
        }
        protected override void OnViewControlsCreated() {
            base.OnViewControlsCreated();
            DetailView dv = (DetailView)View;
            foreach (ViewItem item in dv.Items) {
                Control control = (Control)item.Control;
                Control parent = control.Parent;
                if (parent != null) {
                    if (item is ListPropertyEditor && dv.ViewEditMode == ViewEditMode.View) {
                        ASPxNavBar navbar = new ASPxNavBar();
                        int index = parent.Controls.IndexOf(control);
                        parent.Controls.RemoveAt(index);
                        parent.Controls.AddAt(index, navbar);
                        NavBarGroup group = new NavBarGroup(string.Empty);
                        group.ExpandButtonPosition = ExpandButtonPosition.Left;
                        group.ContentTemplate = new NavBarGroupContentTemplate(control);
                        navbar.Groups.Add(group);
                    }
                }
            }
        }
    }
    public class NavBarGroupContentTemplate : ITemplate {
        public NavBarGroupContentTemplate(Control templateControl)
            : base() {
            templateControlCore = templateControl;
        }
        private Control templateControlCore = null;
        public Control TemplateControl {
            get {
                return templateControlCore;
            }
        }
        public void InstantiateIn(Control container) {
            if (TemplateControl != null) {
                container.Controls.Add(TemplateControl);
            }
        }
    }
}