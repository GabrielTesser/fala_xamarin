using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace App1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void btn_fala_Clicked(object sender, EventArgs e)
        {
            var locales = await TextToSpeech.GetLocalesAsync();

            var locale = locales.FirstOrDefault(loc => string.Equals(loc.Country, "Brasil"));

            var settings = new SpeechOptions()
            {
                Locale = locale,
                Volume = .50f,
                Pitch = 1.6f
            };


            await TextToSpeech.SpeakAsync(txt_fala.Text, settings);
        }

        private async void btn_cachorro_Clicked(object sender, EventArgs e)
        {
            var locales = await TextToSpeech.GetLocalesAsync();

            var locale = locales.FirstOrDefault(loc => string.Equals(loc.Country, "Brasil"));

            var settings = new SpeechOptions()
            {
                Locale = locale,
                Volume = .50f,
                Pitch = 1.6f
            };


            await TextToSpeech.SpeakAsync("cachorro", settings);
        }

        private async void btn_cavalo_Clicked(object sender, EventArgs e)
        {
            var locales = await TextToSpeech.GetLocalesAsync();

            var locale = locales.FirstOrDefault(loc => string.Equals(loc.Country, "Brasil"));

            var settings = new SpeechOptions()
            {
                Locale = locale,
                Volume = .50f,
                Pitch = 1.6f
            };

            await TextToSpeech.SpeakAsync("cavalo", settings);
        }
    }
}
