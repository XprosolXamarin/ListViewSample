using ListViewSample.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Xml.Schema;
using Xamarin.Forms;

namespace ListViewSample.ViewModels
{
    public class BillViewModel : INotifyPropertyChanged
    {
       

        public ObservableCollection<BillModel> Bills { get; set; } = new ObservableCollection<BillModel>();
       
        public BillViewModel()
        {

            Bills.Add(new BillModel
            {
                Name = "Mobile",
               
                Details = "254546",
                RPP = 10500,
                purchasedQty=1,
                ImageUrl = "images.jpg",
                totalpurchased = 3



            });
            Bills.Add(new BillModel
            {
                Name = "Mobile",

                Details = "254546",
                RPP = 1055,
                purchasedQty = 1,
                ImageUrl = "images.jpg",
                totalpurchased = 3400

            });
            Bills.Add(new BillModel
            {
                Name = "Mobile",

                Details = "254546",
                RPP = 10000,
                purchasedQty = 1,
                ImageUrl = "images.jpg",
                totalpurchased = 344


            });
            Bills.Add(new BillModel
            {
                Name = "Mobile",

                Details = "254546",
                RPP = 10000,
                purchasedQty = 1,
                ImageUrl = "images.jpg",
                totalpurchased=340


            }) ;

            TotalFun();


        }

        public void TotalFun()
        {
            BillModel product = new BillModel();
            product.TotalBill = product.totalpurchased++;

        }

        public Command<BillModel> IncreaseQtyCommand
        {
            get
            {
                return new Command<BillModel>((BillModel product) =>
                {
                    product.purchasedQty += 1;
                   product.totalpurchased = product.totalpurchased * product.purchasedQty;
                });
            }
        }
        public Command<BillModel> DecreaseQtyCommand
        {
            get
            {
                return new Command<BillModel>((BillModel product) =>
                {
                    product.totalpurchased = product.totalpurchased / product.purchasedQty;
                    product.purchasedQty -= 1;
                  
                });
            }
        }
        public Command<BillModel> RemoveItem
        {
            get
            {
                return new Command<BillModel> ((BillModel product) =>
                {
                    Bills.Remove(product);
                });
            }
        }
        public Command Confrimorder
        {
            get
            {
                return new Command(() =>
                {
                    Application.Current.MainPage.Navigation.PushAsync(new MainPage());
                });
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
