using ESAEAPP.Controller;
using ESAEAPP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ESAEAPP.Views.Cursos
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CursosListPage : ContentPage
    {
        CursoApiController cursos;

        public CursosListPage()
        {
            InitializeComponent();

            cursos = new CursoApiController();

            cursosListView.ItemsSource = cursos.ListaCursos;

            cursosListView.ItemTapped += async (sender, e) => {
                var item = e.Item as Curso;

                await Navigation.PushAsync(new CursoPage(item));

                cursosListView.SelectedItem = null;
            };
        }
    }
}