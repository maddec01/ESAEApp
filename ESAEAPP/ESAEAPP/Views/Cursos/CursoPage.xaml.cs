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
    public partial class CursoPage : ContentPage
    {
        public CursoPage(Curso _curso)
        {
            InitializeComponent();

            //design
            var stack = new StackLayout { Padding = new Thickness(5, 10) };
            var title = new Label { Text = _curso.nameCurso, TextColor = Color.FromHex("##ec672f"), FontSize = 20, Margin = new Thickness(10, 0, 10, 0) };
            stack.Children.Add(title);
            var type = new Label { Text = _curso.tipoCurso, TextColor = Color.Black, FontSize = 15, Margin = new Thickness(10, 0, 10, 0) };
            stack.Children.Add(type);
            var resp = new Label { Text = _curso.responsavelCurso, TextColor = Color.Black, FontAttributes = FontAttributes.Bold, FontSize = 15, Margin = new Thickness(10, 0, 10, 10) };
            stack.Children.Add(resp);
            var description = new Frame { Content = new Label { Text = _curso.descricaoCurso } };
            stack.Children.Add(description);
            var content = new ScrollView { Content = stack };

            //print
            this.Content = content;
        }
    }
}