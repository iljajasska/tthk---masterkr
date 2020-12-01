using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace masterkr.view
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class mercedes : ContentPage
    {
        public mercedes()
        {
            InitializeComponent();
        }
        void picker_SelectedIndexChanged(object sender, EventArgs e)
        {
            header.Text = "Модель: " + picker.Items[picker.SelectedIndex];
        }
    }
}