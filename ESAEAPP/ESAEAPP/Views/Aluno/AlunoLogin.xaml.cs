using ESAEAPP.API;
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
    public partial class AlunoLogin : ContentPage
    {
        public AlunoLogin()
        {
            InitializeComponent();
        }

        private void BtnLog_Clicked(object sender, EventArgs e)
        {
            GlobalVariables.AlunoIsLoged = true;
            Navigation.PushAsync(new AlunoPerfil());
        }
    }
}