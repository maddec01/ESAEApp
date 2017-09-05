using ESAEAPP.Controller;
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
        AvisoApiController avisosAluno;

        public AlunoPerfil()
        {
            InitializeComponent();

            avisosAluno = new AvisoApiController();

            //seleciona apenas avisos relacionados com o aluno (por id)
            var avisosAlunoTemp = new List<Aviso>();

            foreach (Aviso _aviso in avisosAluno.ListaAvisos)
            {
               if (_aviso.cursoIdAviso == "2")
                {
                    avisosAlunoTemp.Add(_aviso);
                }
            }

            avisosAlunoListView.ItemsSource = avisosAlunoTemp;

            avisosAlunoListView.ItemTapped += async (sender, e) => {
                var item = e.Item as Aviso;

                await Navigation.PushAsync(new Avisos.AvisoPage(item));

                avisosAlunoListView.SelectedItem = null;
            };
        }

        private void BtnLogout_Clicked(object sender, EventArgs e)
        {
            GlobalVariables.AlunoIsLoged = false;
            Navigation.PushAsync(new AlunoLogin());
        }
    }
}