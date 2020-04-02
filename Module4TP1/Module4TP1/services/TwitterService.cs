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
                new Tweet{ date="hier",id="0", texte="Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.", userId="idUser1",userName="userName1", userPseudo="userPseudo1"},
                new Tweet{ date="ya pas longtemp",id="1", texte="Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat", userId="idUser2",userName="userName2", userPseudo="userPseudo2"},
                new Tweet{ date="aujourd'hui",id="2", texte="Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur.", userId="idUser3",userName="userName3", userPseudo="userPseudo3"},
                new Tweet{ date="l'autre jour",id="3", texte="Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", userId="idUser4",userName="userName4", userPseudo="userPseudo4"}
            };
        }
    }
}
