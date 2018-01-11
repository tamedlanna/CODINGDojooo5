using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace CODINGDojooo5.ViewModel
{
    public class ItemVm : ViewModelBase
    {
        public string Desription { get; set; }
        public string AgeRecom { get; set; }
        public BitmapImage Image { get; set; }

        public ObservableCollection<ItemVm> Items { get; set; }

       

        public int NoOfParts
        {
            get {
                if (Items != null)
                {
                    return Items.Count;
                }
                else {
                    return 0;
                }
            }
        }

        public ItemVm(string description, BitmapImage image, string agerecom) {
            Desription = description;
            
            Image = image;
            AgeRecom = agerecom;
        }

        public void AddItem(ItemVm item) {
            if (Items == null) {
                Items = new ObservableCollection<ItemVm>();
            }

            Items.Add(item);
        }

    }
}
