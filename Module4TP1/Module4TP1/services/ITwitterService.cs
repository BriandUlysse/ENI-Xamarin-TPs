using Module4TP1.models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Module4TP1.services
{
    public interface ITwitterService
    {
        bool authenticate(String user, String mdp);

        List<Tweet> getTweets(String cara); 
    }
}
