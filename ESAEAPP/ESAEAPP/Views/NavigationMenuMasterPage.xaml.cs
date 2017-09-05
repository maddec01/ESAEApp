using ESAEAPP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ESAEAPP.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NavigationMenuMasterPage : ContentPage
    {
        public ListView MenuListView { get { return menuListView; } }

        public NavigationMenuMasterPage()
        {
            InitializeComponent();

            var masterPageItems = new List<MasterPageItem>();

            //add items to menu list
            masterPageItems.Add(new MasterPageItem
            {
                Title = "Perfil",
                IconSource = "user.png"
            });
            

            masterPageItems.Add(new MasterPageItem
            {
                Title = "ESAE",
                IconSource = "esae.png"
            });

            masterPageItems.Add(new MasterPageItem
            {
                Title = "Cursos",
                IconSource = "cursos.png"
            });

            masterPageItems.Add(new MasterPageItem
            {
                Title = "Avisos",
                IconSource = "avisos.png"
            });

            masterPageItems.Add(new MasterPageItem
            {
                Title = "Eventos",
                IconSource = "eventos.png"
            });

            masterPageItems.Add(new MasterPageItem
            {
                Title = "Contactos",
                IconSource = "contacts.png"
            });

            menuListView.ItemsSource = masterPageItems;
        }
    }
}