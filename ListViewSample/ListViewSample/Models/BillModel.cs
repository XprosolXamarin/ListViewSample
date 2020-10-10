using ListViewSample.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace ListViewSample.Models
{
    public class BillModel:BaseViewModel
    {
        public string Name { get; set; }
       
        public string Details { get; set; }
        public string ImageUrl { get; set; }
        public int RPP { get; set; }
        public int _purchasedQty { get; set; }

        public int purchasedQty
        {
            get 
            { 
                return _purchasedQty; 
            }
            set 
            { 
                if (value > 0)
                    _purchasedQty = value;
                else
                    _purchasedQty = 1; 
                base.OnPropertyChanged(); 
            }
        }

        public int _totalpurchased { get; set; }

        public int totalpurchased
        {
            get
            {
                return _totalpurchased;
            }
            set
            {
                if (value > 0)
                {

                   // value = totalpurchased * purchasedQty;
                    _totalpurchased = value;
                }
                else
                    _totalpurchased = 1;
                base.OnPropertyChanged();
            }
        }



        public int TotalBill { get; set; }
      


        public override string ToString()
        {
            return Name;
        }
    }
}
