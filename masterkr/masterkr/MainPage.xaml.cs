using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace masterkr
{
    public partial class MainPage : MasterDetailPage
    {
        public MainPage()
        {
            InitializeComponent();
            infa.ItemsSource = GetMenuList();
            var homepage = typeof(view.glav);
            Detail = new NavigationPage((Page)Activator.CreateInstance(homepage));
            IsPresented = false;
        }
        public List<menuitems> GetMenuList()
        {
            var list = new List<menuitems>();
            list.Add(new menuitems()
            {
                Text = "AUDI",
                Detail = "Все о AUDI",
                Kartina = "audi.png",
                Trgtstr = typeof(view.audi)
            });
            list.Add(new menuitems()
            {
                Text = "BMW",
                Detail = "Все о BMW",
                Kartina = "bmw.png",
                Trgtstr = typeof(view.bmw)
            });
            list.Add(new menuitems()
            {
                Text = "MERCEDES",
                Detail = "Все о MERCEDES",
                Kartina = "mercedes.png",
                Trgtstr = typeof(view.mercedes)
            });
            return list;
        }

        private void infa_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var selected = (menuitems)e.SelectedItem;
            Type selectedpage = selected.Trgtstr;
            Detail = new NavigationPage((Page)Activator.CreateInstance(selectedpage));
            IsPresented = false;
        }
    }
}
