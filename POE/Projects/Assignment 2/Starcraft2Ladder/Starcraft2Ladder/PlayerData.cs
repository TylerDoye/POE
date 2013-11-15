using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Starcraft2Ladder
{
    class PlayerData
    {
        // creating all the variables that will bew used in the tables
        string league = string.Empty;
        string firstName = string.Empty;
        string surname = string.Empty;
        string alias = string.Empty;
        Int32 wins=0;
        Int32 losses=0;
        Int32 apm=0;
        Int32 leagueStanding=0;

        public string League
        {
            get { return league; }
        }

        public string FirstName
        {
            get { return firstName; }
        }


        public string Surname
        {
            get { return surname; }
        }
   

        public string Alias
        {
            get { return alias; }
        }

        
        public int Wins
        {
            get { return wins; }
        }
        

        public int Losses
        {
            get { return losses; }
        }
     

        public int Apm
        {
            get { return apm; }
        }
     

        public int LeagueStanding
        {
            get { return leagueStanding; }
          
        }

        //constructer so that object of the playerdata can be made

        public PlayerData(string aLeague, string aFirstName, string aSurname, string aAlias,
            Int32 aWins, Int32 aLosses, Int32 aApm, Int32 aLeagueStanding)
        {

           league = aLeague;
           firstName =aFirstName;
           surname = aSurname;
           alias = aAlias;
           wins = aWins;
           losses = aLosses;
           apm = aApm;
           leagueStanding = aLeagueStanding;
        }
    }
}
