using Module4TP1.services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace Module4TP1
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        private ITwitterService twitterService;
        public MainPage()
        {
            InitializeComponent();
            this.twitterService = new TwitterService();
        }

        private async void btnConnexion_Clicked(object sender, EventArgs e)
        {
            Console.WriteLine("btn clicked");

            String id = this.id.Text;
            String mdp = this.mdp.Text;
            bool infos = this.infos.IsToggled;

            String error ="";

            if (Connectivity.NetworkAccess != NetworkAccess.Internet)
            {
                error += "Pas d'accè internet";
            }
            if (id ==null ||id.Length <3)
            {
                error += "Le login doit contenir plus de 3 caractères\n";
            }
            if (mdp == null || mdp.Length<6)
            {
                error += "Le mot de passe doit contenir plus de 6 caractères";
            }

            this.error.Text = error;
            if (error != "")
            {
                this.error.IsVisible = true;
            }
            else
            {
                this.error.IsVisible = false;
                if (this.twitterService.authenticate(id, mdp))
                {
                    await Navigation.PushAsync(new TweetList());
                    /*this.listTweet.IsVisible = true;
                    this.formConexion.IsVisible = false;*/
                }
            }
        }
    }
}
