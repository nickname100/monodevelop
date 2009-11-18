// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace MonoDevelop.Ide.Gui.Dialogs {
    
    public partial class ConfirmProjectDeleteDialog {
        
        private Gtk.VBox vbox2;
        
        private Gtk.Label label1;
        
        private Gtk.RadioButton radioDeleteAll;
        
        private Gtk.Alignment alignment1;
        
        private Gtk.Label labelProjectDir;
        
        private Gtk.RadioButton radioDeleteSel;
        
        private Gtk.Alignment alignment2;
        
        private Gtk.ScrolledWindow GtkScrolledWindow;
        
        private Gtk.TreeView fileList;
        
        private Gtk.Button buttonCancel;
        
        private Gtk.Button buttonOk;
        
        protected virtual void Build() {
            Stetic.Gui.Initialize(this);
            // Widget MonoDevelop.Ide.Gui.Dialogs.ConfirmProjectDeleteDialog
            this.Name = "MonoDevelop.Ide.Gui.Dialogs.ConfirmProjectDeleteDialog";
            this.Title = Mono.Unix.Catalog.GetString("Delete Project");
            this.WindowPosition = ((Gtk.WindowPosition)(4));
            this.Modal = true;
            // Internal child MonoDevelop.Ide.Gui.Dialogs.ConfirmProjectDeleteDialog.VBox
            Gtk.VBox w1 = this.VBox;
            w1.Name = "dialog1_VBox";
            w1.BorderWidth = ((uint)(2));
            // Container child dialog1_VBox.Gtk.Box+BoxChild
            this.vbox2 = new Gtk.VBox();
            this.vbox2.Name = "vbox2";
            this.vbox2.Spacing = 6;
            this.vbox2.BorderWidth = ((uint)(6));
            // Container child vbox2.Gtk.Box+BoxChild
            this.label1 = new Gtk.Label();
            this.label1.Name = "label1";
            this.label1.Xalign = 0F;
            this.label1.LabelProp = Mono.Unix.Catalog.GetString("Please select which files and folders you want to delete:");
            this.vbox2.Add(this.label1);
            Gtk.Box.BoxChild w2 = ((Gtk.Box.BoxChild)(this.vbox2[this.label1]));
            w2.Position = 0;
            w2.Expand = false;
            w2.Fill = false;
            // Container child vbox2.Gtk.Box+BoxChild
            this.radioDeleteAll = new Gtk.RadioButton(Mono.Unix.Catalog.GetString("Delete the project file and the whole project directory:"));
            this.radioDeleteAll.CanFocus = true;
            this.radioDeleteAll.Name = "radioDeleteAll";
            this.radioDeleteAll.DrawIndicator = true;
            this.radioDeleteAll.UseUnderline = true;
            this.radioDeleteAll.Group = new GLib.SList(System.IntPtr.Zero);
            this.vbox2.Add(this.radioDeleteAll);
            Gtk.Box.BoxChild w3 = ((Gtk.Box.BoxChild)(this.vbox2[this.radioDeleteAll]));
            w3.Position = 1;
            w3.Expand = false;
            w3.Fill = false;
            // Container child vbox2.Gtk.Box+BoxChild
            this.alignment1 = new Gtk.Alignment(0.5F, 0.5F, 1F, 1F);
            this.alignment1.Name = "alignment1";
            this.alignment1.LeftPadding = ((uint)(30));
            // Container child alignment1.Gtk.Container+ContainerChild
            this.labelProjectDir = new Gtk.Label();
            this.labelProjectDir.Name = "labelProjectDir";
            this.labelProjectDir.Xalign = 0F;
            this.labelProjectDir.LabelProp = "label2";
            this.alignment1.Add(this.labelProjectDir);
            this.vbox2.Add(this.alignment1);
            Gtk.Box.BoxChild w5 = ((Gtk.Box.BoxChild)(this.vbox2[this.alignment1]));
            w5.Position = 2;
            w5.Expand = false;
            w5.Fill = false;
            // Container child vbox2.Gtk.Box+BoxChild
            this.radioDeleteSel = new Gtk.RadioButton(Mono.Unix.Catalog.GetString("Delete the following files and folders:"));
            this.radioDeleteSel.CanFocus = true;
            this.radioDeleteSel.Name = "radioDeleteSel";
            this.radioDeleteSel.DrawIndicator = true;
            this.radioDeleteSel.UseUnderline = true;
            this.radioDeleteSel.Group = this.radioDeleteAll.Group;
            this.vbox2.Add(this.radioDeleteSel);
            Gtk.Box.BoxChild w6 = ((Gtk.Box.BoxChild)(this.vbox2[this.radioDeleteSel]));
            w6.Position = 3;
            w6.Expand = false;
            w6.Fill = false;
            // Container child vbox2.Gtk.Box+BoxChild
            this.alignment2 = new Gtk.Alignment(0.5F, 0.5F, 1F, 1F);
            this.alignment2.Name = "alignment2";
            this.alignment2.LeftPadding = ((uint)(30));
            // Container child alignment2.Gtk.Container+ContainerChild
            this.GtkScrolledWindow = new Gtk.ScrolledWindow();
            this.GtkScrolledWindow.Name = "GtkScrolledWindow";
            this.GtkScrolledWindow.ShadowType = ((Gtk.ShadowType)(1));
            // Container child GtkScrolledWindow.Gtk.Container+ContainerChild
            this.fileList = new Gtk.TreeView();
            this.fileList.CanFocus = true;
            this.fileList.Name = "fileList";
            this.fileList.HeadersVisible = false;
            this.GtkScrolledWindow.Add(this.fileList);
            this.alignment2.Add(this.GtkScrolledWindow);
            this.vbox2.Add(this.alignment2);
            Gtk.Box.BoxChild w9 = ((Gtk.Box.BoxChild)(this.vbox2[this.alignment2]));
            w9.Position = 4;
            w1.Add(this.vbox2);
            Gtk.Box.BoxChild w10 = ((Gtk.Box.BoxChild)(w1[this.vbox2]));
            w10.Position = 0;
            // Internal child MonoDevelop.Ide.Gui.Dialogs.ConfirmProjectDeleteDialog.ActionArea
            Gtk.HButtonBox w11 = this.ActionArea;
            w11.Name = "dialog1_ActionArea";
            w11.Spacing = 10;
            w11.BorderWidth = ((uint)(5));
            w11.LayoutStyle = ((Gtk.ButtonBoxStyle)(4));
            // Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
            this.buttonCancel = new Gtk.Button();
            this.buttonCancel.CanDefault = true;
            this.buttonCancel.CanFocus = true;
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.UseStock = true;
            this.buttonCancel.UseUnderline = true;
            this.buttonCancel.Label = "gtk-cancel";
            this.AddActionWidget(this.buttonCancel, -6);
            Gtk.ButtonBox.ButtonBoxChild w12 = ((Gtk.ButtonBox.ButtonBoxChild)(w11[this.buttonCancel]));
            w12.Expand = false;
            w12.Fill = false;
            // Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
            this.buttonOk = new Gtk.Button();
            this.buttonOk.CanDefault = true;
            this.buttonOk.CanFocus = true;
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.UseStock = true;
            this.buttonOk.UseUnderline = true;
            this.buttonOk.Label = "gtk-delete";
            this.AddActionWidget(this.buttonOk, -5);
            Gtk.ButtonBox.ButtonBoxChild w13 = ((Gtk.ButtonBox.ButtonBoxChild)(w11[this.buttonOk]));
            w13.Position = 1;
            w13.Expand = false;
            w13.Fill = false;
            if ((this.Child != null)) {
                this.Child.ShowAll();
            }
            this.DefaultWidth = 512;
            this.DefaultHeight = 387;
            this.Show();
            this.radioDeleteAll.Toggled += new System.EventHandler(this.OnRadioDeleteAllToggled);
        }
    }
}