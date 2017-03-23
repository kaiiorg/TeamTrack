using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;

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
            teamCount = 0;
            

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = ".CSV Files (*.csv) | *.csv";

            if(ofd.ShowDialog() == DialogResult.OK)
            {
                StreamReader file = new StreamReader(ofd.OpenFile());
                List<string> lines = new List<string>();
                
                
                //Read each line and add to the lines list
                while(!file.EndOfStream)
                    lines.Add(file.ReadLine());

                //Split each line, put values in Team object, put Team object in list
                foreach (string line in lines)
                {
                    string[] s = line.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                    //Skip any lines that only have two items in it. They aren't needed at this time
                    if (s.Length == 2)
                        continue;
                    //Skip the "Team Name,Team Number,Time,Station,Dvision Name" header
                    if (s.Length == 5 && s[0] == "Team Name")
                        continue;
                    //Sanity check; each of the last lines should have 3 elements
                    if (s.Length == 5)
                    {
                        Team tempTeam = new Team();
                        tempTeam.Divison = s[4];
                        tempTeam.TeamName = s[0];
                        tempTeam.TeamNumber = s[1];
                        tempTeam.Time = s[2];
                        tempTeam.Station = s[3];
                        teams.Add(tempTeam);
                        teamCount++;
                    }
                }
                file.Close();
            }
            else
            {
                throw new Exception("No file selected.");
            }

            return teams;
        }


    }

    
    class Team
    {
        //Name of the team
        public string TeamName { set; get; }
        //Team number
        public string TeamNumber { set; get; }
        //Name of the team's division
        public string Divison { set; get; }
        //Time of team's inspection time
        public string Time { get; set; }
        //Name of team's inspection station
        public string Station { get; set; }

        public Team() { clear(); }

        /// <summary>
        /// Clears all stored values
        /// </summary>
        public void clear()
        {
            TeamName = "";
            Divison = "";
            Time = "";
            Station = "";
        }
    }
}
