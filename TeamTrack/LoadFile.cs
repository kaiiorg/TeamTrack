using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            string divison = "";
            

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = ".CSV Files (*.csv) | *.csv";

            if(ofd.ShowDialog() == DialogResult.OK)
            {
                StreamReader file = new StreamReader(ofd.OpenFile());
                List<string> lines = new List<string>();
                Team tempTeam = new Team();
                
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
                    //Skip over the Divison Name: header
                    if (s.Length == 1 && s[0] == "Division Name:")
                        continue;
                    //If the divsion name hasn't been read yet, it should be read now assuming the last two if statements worked.
                    if (s.Length == 1 && divison == "")
                        divison = s[0];
                    //Skip the "Team Name Time Arena" header
                    if (s.Length == 3 && s[0] == "Team Name")
                        continue;
                    //Sanity check; each of the last lines should have 3 elements
                    if (s.Length == 3)
                    {
                        tempTeam.Divison = divison;
                        tempTeam.TeamName = s[0];
                        tempTeam.Time = s[1];
                        tempTeam.Arena = s[2];
                        teams.Add(tempTeam);
                        tempTeam.clear();
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
        private string teamName = "";
        public string TeamName { set; get; }
        //Name of the team's division
        private string divison = "";
        public string Divison { set; get; }
        //Time of team's first match
        private string time = "";
        public string Time { get; set; }
        //Arena number of team's first match
        private string arena = "";
        public string Arena { get; set; }

        public Team() { clear(); }

        /// <summary>
        /// Clears all stored values
        /// </summary>
        public void clear()
        {
            TeamName = "";
            Divison = "";
            Time = "";
            Arena = "";
        }
    }
}
