using AnlasYazilim.Software.UI.Win.Forms.Interfaces;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System.ComponentModel;
using DevExpress.Utils;
using DevExpress.XtraEditors.Mask;
using DevExpress.XtraGrid.Views.Base;
using System.Drawing;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Registrator;
using DevExpress.XtraGrid.Design;

namespace AnlasYazilim.OgrenciTakip.UI.Win.Forms.UserControls.Grid
{
    [ToolboxItem(true)]

    public class MyGridControl:GridControl
    {
        protected override BaseView CreateDefaultView()
        {
            var view = (GridView)CreateView("MyGridView");
            view.Appearance.ViewCaption.ForeColor = Color.Maroon; // Görünen GridView Adının Yazı Rengini Ayarlar.
            view.Appearance.HeaderPanel.ForeColor = Color.Maroon; // Panel Başlık Yazı Rengini Ayarlar.
            view.Appearance.HeaderPanel.TextOptions.HAlignment = HorzAlignment.Center;
            view.Appearance.FooterPanel.ForeColor = Color.Maroon; // Alt Panelin Yazı Rengini Ayarlar.
            view.Appearance.FooterPanel.Font = new Font(new FontFamily("Tahoma"), 8.25f, FontStyle.Bold);

            view.OptionsMenu.EnableColumnMenu = false;
            view.OptionsMenu.EnableFooterMenu = false;
            view.OptionsMenu.EnableGroupPanelMenu = false;

            view.OptionsNavigation.EnterMoveNextColumn = true;
            view.OptionsPrint.AutoWidth = false; // Yazıcıya Mevcut Boyutta Gönderir Büyütmez.
            view.OptionsPrint.PrintFooter = false; // Alt kısımları Yazıcıya Göndermez.
            view.OptionsPrint.PrintGroupFooter = false;

            view.OptionsView.ShowViewCaption = true; // Gridview Adını Gösterir.
            view.OptionsView.ShowAutoFilterRow = true; // Gridview üzerindeki Filtre Durumu
            view.OptionsView.ShowGroupPanel = false; // Gridview üzerindeki Detaylı Arama Durumu
            view.OptionsView.ColumnAutoWidth = false; // Columnların Belirlerdiğimiz Boyutlarda Kalmasını Sağlar.
            view.OptionsView.RowAutoHeight = true; // Enter Tuşuna Basıldıkça Aşağıya Göre Boyut Büyütür.

            view.OptionsView.HeaderFilterButtonShowMode = FilterButtonShowMode.Button; // ColumnHeader Üzerindeki Filtrelerin Görünümünü Button Yapar. 


            var idColumn = new MyGridColumn
            {
                Caption = "Id",
                FieldName = "Id"
            };
            idColumn.OptionsColumn.AllowEdit = false; // Atadığımız Değerleri Okumaya Yarıyor.
            idColumn.OptionsColumn.ShowInCustomizationForm = false; // Column Özelleştirilme Ekranı İçindede Görünmesin.
            view.Columns.Add(idColumn);

            var codeColumn = new MyGridColumn
            {
                Caption = "Code",
                FieldName = "Code"
            };
            codeColumn.OptionsColumn.AllowEdit = false;
            codeColumn.Visible = true;
            codeColumn.AppearanceCell.TextOptions.HAlignment = HorzAlignment.Center;
            codeColumn.AppearanceCell.Options.UseTextOptions = true; // Değerleri Yaptığımız Ayarlara Gibi Göstermek İçin.
            view.Columns.Add(codeColumn);

            return view;
        }

        protected override void RegisterAvailableViewsCore(InfoCollection collection)
        {
            base.RegisterAvailableViewsCore(collection);
            collection.Add(new MyGridInfoRegistrator());

        }

        private class MyGridInfoRegistrator : GridInfoRegistrator
        {
            public override string ViewName => "MyGridView";
            public override BaseView CreateView(GridControl grid) => new MyGridView(grid);

            //public override BaseViewPainter CreatePainter(BaseView view) => new MyGridView(view);

        }
    }

    public class MyGridView : GridView,IStatusBarKisaYol,Language
    {
      
        #region Properties
        public string Language { get; set; }
        public string StatusBarAciklama { get; set; }
        public string StatusBarKisayol { get; set; }
        public string StatusBarKisayolAciklama { get; set; }
        #endregion

        public MyGridView() { }

        public MyGridView(GridControl ownerGrid) : base(ownerGrid) { }

        protected override void OnColumnChangedCore(GridColumn column)
        {
            base.OnColumnChangedCore(column);

            if (column.ColumnEdit == null) return;
            if (column.ColumnEdit.GetType() == typeof(RepositoryItemDateEdit))
            {
                column.AppearanceCell.TextOptions.HAlignment = HorzAlignment.Center; // Datagridview içinde değerin yazısını ortalayarak getirecek.
                ((RepositoryItemDateEdit)column.ColumnEdit).Mask.MaskType = MaskType.DateTimeAdvancingCaret;
            }
        }

        protected override GridColumnCollection CreateColumnCollection()
        {
            return new MyGridColumnCollection(this);

        }

        private class MyGridColumnCollection : GridColumnCollection
        {
            public MyGridColumnCollection(ColumnView view) : base(view) { }

            protected override GridColumn CreateColumn()
            {
                var column = new MyGridColumn();
                column.OptionsColumn.AllowEdit=false;
                return column;

            }
        }
    }


    public class MyGridColumn : GridColumn,IStatusBarKisaYol,Language
    {
        #region Properties
        public string Language { get; set; }
        public string StatusBarAciklama { get; set; }
        public string StatusBarKisayol { get; set; }
        public string StatusBarKisayolAciklama { get; set; } 
        #endregion

    }
}
