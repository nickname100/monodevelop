// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace JavaBinding {
    
    
    internal partial class GlobalOptionsPanelWidget {
        
        private Gtk.VBox vbox70;
        
        private Gtk.Label label96;
        
        private Gtk.HBox hbox63;
        
        private Gtk.Label label100;
        
        private Gtk.Table table9;
        
        private Gtk.Entry compilerPathEntry;
        
        private Gtk.HBox hbox64;
        
        private Gtk.ComboBox compilerCombo;
        
        private MonoDevelop.Components.FolderEntry ikvmPathEntry;
        
        private Gtk.Label label101;
        
        private Gtk.Label label98;
        
        private Gtk.Label label99;
        
        private Gtk.Label label97;
        
        private Gtk.HBox hbox65;
        
        private Gtk.Label label102;
        
        private Gtk.Table table10;
        
        private Gtk.Entry classpathEntry;
        
        private Gtk.Label label103;
        
        protected virtual void Build() {
            Stetic.Gui.Initialize(this);
            // Widget JavaBinding.GlobalOptionsPanelWidget
            Stetic.BinContainer.Attach(this);
            this.Name = "JavaBinding.GlobalOptionsPanelWidget";
            // Container child JavaBinding.GlobalOptionsPanelWidget.Gtk.Container+ContainerChild
            this.vbox70 = new Gtk.VBox();
            this.vbox70.Name = "vbox70";
            this.vbox70.Spacing = 12;
            // Container child vbox70.Gtk.Box+BoxChild
            this.label96 = new Gtk.Label();
            this.label96.Name = "label96";
            this.label96.Xalign = 0F;
            this.label96.LabelProp = Mono.Addins.AddinManager.CurrentLocalizer.GetString("<b>Compiler</b>");
            this.label96.UseMarkup = true;
            this.vbox70.Add(this.label96);
            Gtk.Box.BoxChild w1 = ((Gtk.Box.BoxChild)(this.vbox70[this.label96]));
            w1.Position = 0;
            w1.Expand = false;
            w1.Fill = false;
            // Container child vbox70.Gtk.Box+BoxChild
            this.hbox63 = new Gtk.HBox();
            this.hbox63.Name = "hbox63";
            // Container child hbox63.Gtk.Box+BoxChild
            this.label100 = new Gtk.Label();
            this.label100.WidthRequest = 18;
            this.label100.Name = "label100";
            this.hbox63.Add(this.label100);
            Gtk.Box.BoxChild w2 = ((Gtk.Box.BoxChild)(this.hbox63[this.label100]));
            w2.Position = 0;
            w2.Expand = false;
            w2.Fill = false;
            // Container child hbox63.Gtk.Box+BoxChild
            this.table9 = new Gtk.Table(((uint)(3)), ((uint)(2)), false);
            this.table9.Name = "table9";
            this.table9.RowSpacing = ((uint)(6));
            this.table9.ColumnSpacing = ((uint)(6));
            // Container child table9.Gtk.Table+TableChild
            this.compilerPathEntry = new Gtk.Entry();
            this.compilerPathEntry.Name = "compilerPathEntry";
            this.compilerPathEntry.IsEditable = true;
            this.compilerPathEntry.InvisibleChar = '●';
            this.table9.Add(this.compilerPathEntry);
            Gtk.Table.TableChild w3 = ((Gtk.Table.TableChild)(this.table9[this.compilerPathEntry]));
            w3.TopAttach = ((uint)(2));
            w3.BottomAttach = ((uint)(3));
            w3.LeftAttach = ((uint)(1));
            w3.RightAttach = ((uint)(2));
            w3.YOptions = ((Gtk.AttachOptions)(0));
            // Container child table9.Gtk.Table+TableChild
            this.hbox64 = new Gtk.HBox();
            this.hbox64.Name = "hbox64";
            // Container child hbox64.Gtk.Box+BoxChild
            this.compilerCombo = new Gtk.ComboBox();
            this.compilerCombo.Name = "compilerCombo";
            this.hbox64.Add(this.compilerCombo);
            Gtk.Box.BoxChild w4 = ((Gtk.Box.BoxChild)(this.hbox64[this.compilerCombo]));
            w4.Position = 0;
            w4.Expand = false;
            w4.Fill = false;
            this.table9.Add(this.hbox64);
            Gtk.Table.TableChild w5 = ((Gtk.Table.TableChild)(this.table9[this.hbox64]));
            w5.TopAttach = ((uint)(1));
            w5.BottomAttach = ((uint)(2));
            w5.LeftAttach = ((uint)(1));
            w5.RightAttach = ((uint)(2));
            w5.YOptions = ((Gtk.AttachOptions)(4));
            // Container child table9.Gtk.Table+TableChild
            this.ikvmPathEntry = new MonoDevelop.Components.FolderEntry();
            this.ikvmPathEntry.Name = "ikvmPathEntry";
            this.table9.Add(this.ikvmPathEntry);
            Gtk.Table.TableChild w6 = ((Gtk.Table.TableChild)(this.table9[this.ikvmPathEntry]));
            w6.LeftAttach = ((uint)(1));
            w6.RightAttach = ((uint)(2));
            w6.XOptions = ((Gtk.AttachOptions)(4));
            w6.YOptions = ((Gtk.AttachOptions)(4));
            // Container child table9.Gtk.Table+TableChild
            this.label101 = new Gtk.Label();
            this.label101.Name = "label101";
            this.label101.Xalign = 0F;
            this.label101.LabelProp = Mono.Addins.AddinManager.CurrentLocalizer.GetString("Compiler command:");
            this.table9.Add(this.label101);
            Gtk.Table.TableChild w7 = ((Gtk.Table.TableChild)(this.table9[this.label101]));
            w7.TopAttach = ((uint)(2));
            w7.BottomAttach = ((uint)(3));
            w7.XOptions = ((Gtk.AttachOptions)(4));
            w7.YOptions = ((Gtk.AttachOptions)(0));
            // Container child table9.Gtk.Table+TableChild
            this.label98 = new Gtk.Label();
            this.label98.Name = "label98";
            this.label98.Xalign = 0F;
            this.label98.LabelProp = Mono.Addins.AddinManager.CurrentLocalizer.GetString("IKVM path:");
            this.table9.Add(this.label98);
            Gtk.Table.TableChild w8 = ((Gtk.Table.TableChild)(this.table9[this.label98]));
            w8.XOptions = ((Gtk.AttachOptions)(4));
            w8.YOptions = ((Gtk.AttachOptions)(0));
            // Container child table9.Gtk.Table+TableChild
            this.label99 = new Gtk.Label();
            this.label99.Name = "label99";
            this.label99.Xalign = 0F;
            this.label99.LabelProp = Mono.Addins.AddinManager.CurrentLocalizer.GetString("Java compiler:");
            this.table9.Add(this.label99);
            Gtk.Table.TableChild w9 = ((Gtk.Table.TableChild)(this.table9[this.label99]));
            w9.TopAttach = ((uint)(1));
            w9.BottomAttach = ((uint)(2));
            w9.XOptions = ((Gtk.AttachOptions)(4));
            w9.YOptions = ((Gtk.AttachOptions)(0));
            this.hbox63.Add(this.table9);
            Gtk.Box.BoxChild w10 = ((Gtk.Box.BoxChild)(this.hbox63[this.table9]));
            w10.Position = 1;
            this.vbox70.Add(this.hbox63);
            Gtk.Box.BoxChild w11 = ((Gtk.Box.BoxChild)(this.vbox70[this.hbox63]));
            w11.Position = 1;
            w11.Expand = false;
            w11.Fill = false;
            // Container child vbox70.Gtk.Box+BoxChild
            this.label97 = new Gtk.Label();
            this.label97.Name = "label97";
            this.label97.Xalign = 0F;
            this.label97.LabelProp = Mono.Addins.AddinManager.CurrentLocalizer.GetString("<b>Code Generation</b>");
            this.label97.UseMarkup = true;
            this.vbox70.Add(this.label97);
            Gtk.Box.BoxChild w12 = ((Gtk.Box.BoxChild)(this.vbox70[this.label97]));
            w12.Position = 2;
            w12.Expand = false;
            w12.Fill = false;
            // Container child vbox70.Gtk.Box+BoxChild
            this.hbox65 = new Gtk.HBox();
            this.hbox65.Name = "hbox65";
            // Container child hbox65.Gtk.Box+BoxChild
            this.label102 = new Gtk.Label();
            this.label102.WidthRequest = 18;
            this.label102.Name = "label102";
            this.hbox65.Add(this.label102);
            Gtk.Box.BoxChild w13 = ((Gtk.Box.BoxChild)(this.hbox65[this.label102]));
            w13.Position = 0;
            w13.Expand = false;
            w13.Fill = false;
            // Container child hbox65.Gtk.Box+BoxChild
            this.table10 = new Gtk.Table(((uint)(1)), ((uint)(2)), false);
            this.table10.Name = "table10";
            this.table10.RowSpacing = ((uint)(6));
            this.table10.ColumnSpacing = ((uint)(6));
            // Container child table10.Gtk.Table+TableChild
            this.classpathEntry = new Gtk.Entry();
            this.classpathEntry.Name = "classpathEntry";
            this.classpathEntry.IsEditable = true;
            this.classpathEntry.InvisibleChar = '●';
            this.table10.Add(this.classpathEntry);
            Gtk.Table.TableChild w14 = ((Gtk.Table.TableChild)(this.table10[this.classpathEntry]));
            w14.LeftAttach = ((uint)(1));
            w14.RightAttach = ((uint)(2));
            w14.YOptions = ((Gtk.AttachOptions)(0));
            // Container child table10.Gtk.Table+TableChild
            this.label103 = new Gtk.Label();
            this.label103.Name = "label103";
            this.label103.Xalign = 0F;
            this.label103.LabelProp = Mono.Addins.AddinManager.CurrentLocalizer.GetString("Classpath:");
            this.table10.Add(this.label103);
            Gtk.Table.TableChild w15 = ((Gtk.Table.TableChild)(this.table10[this.label103]));
            w15.XOptions = ((Gtk.AttachOptions)(4));
            w15.YOptions = ((Gtk.AttachOptions)(0));
            this.hbox65.Add(this.table10);
            Gtk.Box.BoxChild w16 = ((Gtk.Box.BoxChild)(this.hbox65[this.table10]));
            w16.Position = 1;
            this.vbox70.Add(this.hbox65);
            Gtk.Box.BoxChild w17 = ((Gtk.Box.BoxChild)(this.vbox70[this.hbox65]));
            w17.Position = 3;
            this.Add(this.vbox70);
            if ((this.Child != null)) {
                this.Child.ShowAll();
            }
            this.Show();
        }
    }
}