using Module4TP1.models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Module4TP1.services
{
    public class TwitterService : ITwitterService
    {
        public bool authenticate(string user, string mdp)
        {
            if (user == "user" && mdp == "motdepasse")
            {
                return true;
            }
            return false;
        }

        public List<Tweet> getTweets(string cara)
        {
            return new List<Tweet>
            {
                new Tweet{ date="hier",id="0", texte="tarabistouile blablablabla", userId="idUser1",userName="userName1", userPseudo="userPseudo1"},
                new Tweet{ date="ya pas longtemp",id="1", texte="tarabistouile blablablabla", userId="idUser2",userName="userName2", userPseudo="userPseudo2"},
                new Tweet{ date="aujourd'hui",id="2", texte="tarabistouile blablablabla", userId="idUser3",userName="userName3", userPseudo="userPseudo3"},
                new Tweet{ date="l'autre jour",id="3", texte="tarabistouile blablablabla", userId="idUser4",userName="userName4", userPseudo="userPseudo4"}
            };
        }
    }
}
