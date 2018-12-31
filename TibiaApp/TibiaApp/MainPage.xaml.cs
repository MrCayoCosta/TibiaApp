using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TibiaApp.Model;
using TibiaApp.Service;
using Xamarin.Forms;

namespace TibiaApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            btnPesquisar.Clicked += BuscarChar;
        }

        private void BuscarChar(object sender, EventArgs e)
        {
            string name = entryName.Text;

            try
            {
                Example chr = TibiaService.buscaChar(name);
                
                if(chr != null)
                {
                    valorLvl.Text = chr.characters.data.level;
                    valorVocation.Text = chr.characters.data.vocation;
                    valorSex.Text = chr.characters.data.sex;
                    valorWorld.Text = chr.characters.data.world;
                    valorResidence.Text = chr.characters.data.residence;
                    valorAchievement.Text = chr.characters.data.achievement_points;
                    valorLogin.Text = chr.characters.data.last_login[0].date.ToString();
                }
                else
                {
                    DisplayAlert("Erro", "O char chamado" + chr.characters.data.name + "não foi encontrado.", "OK");
                }
            }
            catch(Exception ex)
            {
                DisplayAlert("Eita...", "Aconteceu alguma coisa errada", "Beleza");
            }
        }
    }
}
