using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamTrack
{
    /// <summary>
    /// Class to load data from various file types
    /// </summary>
    static class LoadFile
    {
        //Load data from a Comma Seperated Value (CSV) file
        static public List<Team> fromCSV(ref int teamCount)
        {
            List<Team> teams = new List<Team>();
            //Make sure teamcount is 0.
            teamCount = 0;


            return teams;
        }


    }

    
    class Team
    {
        //Name of the team
        private string teamName;
        public string TeamName { set; get; }
        //Name of the team's division
        private string divison;
        public string Divison { set; get; }
        //Time of team's first match
        private string time;
        public string Time { get; set; }
        //Arena number of team's first match
        private string arena;
        public string Arena { get; set; }
    }
}
