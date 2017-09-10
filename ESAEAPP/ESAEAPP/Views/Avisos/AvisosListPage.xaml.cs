using ESAEAPP.Controller;
using ESAEAPP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ESAEAPP.Views.Avisos
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AvisosListPage : ContentPage
    {
        AvisoApiController avisos;

        public AvisosListPage()
        {
            InitializeComponent();

            avisos = new AvisoApiController();

            avisosListView.ItemsSource = avisos.ListaAvisos;

            avisosListView.ItemTapped += async (sender, e) => {
                var item = e.Item as Aviso;

                //send object to new page
                await Navigation.PushAsync(new AvisoPage(item));

                avisosListView.SelectedItem = null;
            };
        }
    }
}