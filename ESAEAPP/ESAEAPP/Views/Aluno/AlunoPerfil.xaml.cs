using ESAEAPP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ESAEAPP.Views.Aluno
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AlunoPerfil : ContentPage
    {
        public AlunoPerfil()
        {
            InitializeComponent();
        }

        private void BtnLogout_Clicked(object sender, EventArgs e)
        {
            GlobalVariables.AlunoIsLoged = false;
            Navigation.PushAsync(new AlunoLogin());
        }
    }
}