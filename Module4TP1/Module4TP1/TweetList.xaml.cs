using Module4TP1.services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Module4TP1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TweetList : ContentPage
    {
        public TweetList()
        {
            InitializeComponent();
            //Initialisation
            this.listTweet.ItemsSource = new TwitterService().getTweets("");
        }
    }
}