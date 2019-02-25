using DevExpress.XtraEditors;
using System;
using DevExpress.XtraEditors.Controls;
using System.Drawing;
using AnlasYazilim.Software.UI.Win.Forms.Interfaces;
using System.ComponentModel;

namespace AnlasYazilim.Software.UI.Win.Forms.UserControls.Controls
{

    [ToolboxItem(true)] // ToolBox içerisinde gözükmesini sağlar.

    public class MyButtonEdit : ButtonEdit, IStatusBarKisaYol
    {
      
        public MyButtonEdit()
        {
            //yazılabilir olmasını kapatıyoruz.
            Properties.TextEditStyle = TextEditStyles.DisableTextEditor;
            //focuslandığı zaman arkaplan rengini değişmesini sağlıyoruz.
            Properties.AppearanceFocused.BackColor=Color.LightCyan;

        }

        public override bool EnterMoveNextControl { get; set; } = true; 
        public string StatusBarAciklama { get; set; } // Tanımlama
        public string StatusBarKisayol { get; set; } // Tanımlama
        public string StatusBarKisayolAciklama { get; set; } // Tanımlama
        // public string StatusBarKisayol { get; set; } = "F4 :";  -- Sabit Değer Tanımlama Örnek
        // Tanımlamalara Interfaces içerisinden bağlantı yapacağız.

        #region IdEventGetSetMethod
        //  public long? Id { get; set; }

        private long? _id;

        [Browsable(false)] // Pro

        public long? Id
        {
            get => _id;
            set
            {
                var oldValue = _id; // Eski Id Önceki Id Değeri Almak için Kullandığımız Yöntem !
                var newValue = value; // Value yani yeni Id değerini almış oldu.

                if (newValue == oldValue)
                {
                    return;
                }
                else
                {
                    _id = value;
                    // IDChanged Eventimizi tetiklemiş olduk. Eski ve Yeni değerini döndürmüş olduk.
                }

                //  IdChanged?.Invoke(this, new IdChangedEventArgs(oldValue, newValue)); // Null dönmesi durumuna yönelik bunuda kullanabiliriz. Şimdilik IdChanged = delegate{}'i kullanacağız.

                IdChanged(this, new IdChangedEventArgs(oldValue, newValue));
            }
        }
        public event EventHandler<IdChangedEventArgs> IdChanged = delegate { };

        #endregion // Detaylı Açıklama

        // public event EventHandler IdChanged; -- Event tanımalama !
        // Id değiştikçe kendi tanımladığımız Args Kullanmamızı sağlayacak.

        public class IdChangedEventArgs : EventArgs
        {
            public IdChangedEventArgs(long? oldValue,long? newValue)
            {
                OldValue = oldValue;
                NewValue = newValue;
            }

            public long? OldValue { get; } // Eski Değer Gösterme 
            public long? NewValue { get; } // Yeni Değer Gösterme 
        }

    }
}
