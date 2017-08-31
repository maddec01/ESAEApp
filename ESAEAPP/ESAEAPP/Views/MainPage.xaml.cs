using ESAEAPP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ESAEAPP.Views
{
    public partial class MainPage : MasterDetailPage
    {
        NavigationMenuMasterPage masterPage;
        NavigationPage _navPage = new NavigationPage();

        public MainPage()
        {
            masterPage = new NavigationMenuMasterPage();
            Master = masterPage;
            Detail = _navPage;
            _navPage.PushAsync(new WelcomePage());

            App.esaeapp = this;

            masterPage.MenuListView.ItemSelected += OnItemSelected;
        }

        void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as MasterPageItem;

            Detail = _navPage;

            if (item != null)
            {
                // clean stack
                _navPage.Navigation.PopAsync();

                if (item.Title == "LOGIN")
                {
                    _navPage.PushAsync(new Aluno.AlunoLogin());
                }

                else if (item.Title == "ESAE")
                {
                    _navPage.PushAsync(new ESAE.AboutPage());
                }

                else if (item.Title == "Cursos")
                {
                    _navPage.PushAsync(new Cursos.CursosListPage());
                }

                else if (item.Title == "Avisos")
                {
                    _navPage.PushAsync(new Avisos.AvisosListPage());
                }

                else if (item.Title == "Eventos")
                {
                    _navPage.PushAsync(new Eventos.EventosListPage());
                }

                else if (item.Title == "Contactos")
                {
                    _navPage.PushAsync(new ESAE.ContactPage());
                }
            }

            masterPage.MenuListView.SelectedItem = null;
            IsPresented = false;
        }
    }
}
