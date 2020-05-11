using System.Collections.Generic;

namespace StalinGames.DAL.Models
{
    public static class ListItems
    {
        public static List<PlayerItem> Items { get; set; }

        //todo bespreken met steven
        //nieuwe kolom: accountcreateddate?

        //probeer te zien hoe ge ipv roles gwn u titles of backgrounds add en koopt
        //hoe ik het denk is: maak tabel aan waar ge een id hebt, user id en een profilepath/background.(zoals roles). via een repository kunt ge die dan toevoegen aan een user en ophalen
        //ipv uit te logge, bij een gefaalde login me die cookies, redirect to login
    }
}