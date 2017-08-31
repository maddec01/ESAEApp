using ESAEAPP.Controller;
using ESAEAPP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ESAEAPP.Views.Eventos
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EventosListPage : ContentPage
    {
        EventoApiController eventos;
        
        public EventosListPage()
        {
            InitializeComponent();

            eventos = new EventoApiController();

            eventosListView.ItemsSource = eventos.ListaEventos;

            eventosListView.ItemTapped += async (sender, e) => {
                var item = e.Item as Evento;

                await Navigation.PushAsync(new EventoPage(item));

                eventosListView.SelectedItem = null;
            };
        }
    }
}