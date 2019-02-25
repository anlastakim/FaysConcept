using AnlasYazilim.Software.UI.Win.Forms.Interfaces;
using DevExpress.Utils;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.BandedGrid;
using DevExpress.XtraEditors.Mask;
using DevExpress.XtraGrid.Views.Base;
using System.Drawing;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Registrator;
using System.ComponentModel;

namespace AnlasYazilim.OgrenciTakip.UI.Win.Forms.UserControls.Grid
{

    [ToolboxItem(true)]

    public class MyBandedGridControl : GridControl
    {

        protected override BaseView CreateDefaultView()
        {
            var view = (MyBandedGridView)CreateView("MyBandedGridView");
            
            #region RenkAyarları

            view.Appearance.HeaderPanel.ForeColor = Color.Maroon;
            view.Appearance.ViewCaption.ForeColor = Color.Maroon;
            view.Appearance.FooterPanel.ForeColor = Color.Maroon;

            #endregion

            #region BandPanelAyarları

            view.Appearance.BandPanel.ForeColor = Color.DarkBlue; // Banded Panel Renk
            view.Appearance.BandPanel.Font = new Font(new FontFamily("Tahoma"), 8.25f, FontStyle.Bold); // Banded Pabel Font
            view.Appearance.BandPanel.TextOptions.HAlignment = HorzAlignment.Center; // Banded Paneli Ortala
            view.BandPanelRowHeight = 40; // Banded Panel Yükseklik

            #endregion

            #region ViewGenelAyarları

            view.Appearance.HeaderPanel.TextOptions.HAlignment = HorzAlignment.Center;
            view.Appearance.FooterPanel.TextOptions.HAlignment = HorzAlignment.Far;
            view.Appearance.FooterPanel.Font = new Font(new FontFamily("Tahoma"), 8.25f, FontStyle.Bold);

            view.OptionsMenu.EnableColumnMenu = false;
            view.OptionsMenu.EnableFooterMenu = false;
            view.OptionsMenu.EnableGroupPanelMenu = false;

            view.OptionsNavigation.EnterMoveNextColumn = true; // Column içinde enter basıldığı zaman bir sonraki hücreye geçmesi için.
            view.OptionsPrint.AutoWidth = false;
            view.OptionsPrint.PrintFooter = false;
            view.OptionsPrint.PrintGroupFooter = false;

            view.OptionsView.ShowAutoFilterRow = true;
            view.OptionsView.ShowViewCaption = true;
            view.OptionsView.ShowGroupPanel = false;

            view.OptionsView.ColumnAutoWidth = false; // Otomatik olarak Column genişliği ayarlanmasın.
            view.OptionsView.RowAutoHeight = true;
            view.OptionsView.HeaderFilterButtonShowMode = FilterButtonShowMode.Button;

            #endregion

            #region BandedGridColumnYorum
            //var idColumn = new BandedGridColumn
            //{
            //    Caption = "Id",
            //    FieldName = "Id",
            //    OptionsColumn = { AllowEdit = false, ShowInCustomizationForm=false }
            //}; 
            #endregion

            #region idColumnsProperties

             var idColumn = new[]
             {
                    new BandedGridColumn{
                    Caption = "Id",
                    FieldName = "Id",
                    OptionsColumn = { AllowEdit = false, ShowInCustomizationForm = false }

                    },
                    new BandedGridColumn{
                        Caption="Code",
                        FieldName="Code",
                        Visible=true,
                        OptionsColumn = { AllowEdit=false },
                        AppearanceCell = { TextOptions = { HAlignment = HorzAlignment.Center }, Options = { UseTextOptions = true } }

                    }
                };

            #endregion

            view.Columns.AddRange(idColumn);
            return view;

        }

        protected override void RegisterAvailableViewsCore(InfoCollection collection)
        {
            base.RegisterAvailableViewsCore(collection);
            collection.Add(new MyBandedGridInfoRegistrator());
        }

        private class MyBandedGridInfoRegistrator : BandedGridInfoRegistrator
        {
            public override string ViewName => "MyBandedGridView";

            public override BaseView CreateView(GridControl grid)=> new MyBandedGridView(grid);

        }

    }

    public class MyBandedGridView : BandedGridView, IStatusBarKisaYol, Language
    {
        #region Properties

        public string Language { get; set; }
        public string StatusBarKisayol { get; set; }
        public string StatusBarKisayolAciklama { get; set; }
        public string StatusBarAciklama { get; set; }

        #endregion


        public MyBandedGridView() {}

        public MyBandedGridView(GridControl ownerGrid) : base(ownerGrid){}

        protected override void OnColumnChangedCore(GridColumn column)
        {
            base.OnColumnChangedCore(column);

            if (column.ColumnEdit == null) return;
            if (column.ColumnEdit.GetType() == typeof(RepositoryItemDateEdit))
            {
                column.AppearanceCell.TextOptions.HAlignment = HorzAlignment.Center;
                ((RepositoryItemDateEdit)column.ColumnEdit).Mask.MaskType = MaskType.DateTimeAdvancingCaret;
            }
        }

        protected override GridColumnCollection CreateColumnCollection()
        {
            return new MyGridColumnCollection(this);
        }

        private class MyGridColumnCollection : BandedGridColumnCollection
        {
            public MyGridColumnCollection(ColumnView view) : base(view) { }

            protected override GridColumn CreateColumn()
            {
                var column = new BandedGridColumn();
                column.OptionsColumn.AllowEdit = false;
                return column;
            }
        }
    }

    public class MyBandedGridColumn : BandedGridColumn, IStatusBarKisaYol, Language
    {
        #region Properties

        public string Language { get; set; }
        public string StatusBarKisayol { get; set; }
        public string StatusBarKisayolAciklama { get; set; }
        public string StatusBarAciklama { get; set; } 
        
        #endregion


    }
}
