using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ESAEAPP.Views.ESAE
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ContactPage : ContentPage
    {
        public ContactPage()
        {
            InitializeComponent();
        }

        private void LinhaApoioBtn_Clicked(object sender, EventArgs e)
        {
            //Open phone app
            Device.OpenUri(new Uri("tel://808208030"));
        }
    }
}