using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PlacaMae.Paginas.Carousel
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Pagina2 : ContentPage
    {
        public Pagina2()
        {
            InitializeComponent();
            
             
        }



        private async void ClicarBotao(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new Processador());

        }

        private async void ClicarRAM(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new MemoriaRAM());
        }

        private async void ClicarIO(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new EntradasIO());
        }

        private async void ClicarBateria(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new Bateria());
        }

        private async void ClicarSLOTS(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new ExpansãoSLOTS());
        }
    }
    

}