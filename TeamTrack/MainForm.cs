using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeamTrack
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        //Status Colors and the current status of each team
        Color[] statusColors = { Color.White, Color.Yellow, Color.Red, Color.Green };
        string[] statusText = { "No Inspect", "Hardware Ok", "Inspect Fail", "Ready!" };
        int[] currentStatus = { 0, 0, 0, 0, 0, 0, 0, 0};
        
        //Test data
        static string[] teams = { "Team 1", "Team 2", "Team 3", "Team 4", "Team 5", "Team 6", "Team 7", "Team 1337" };
        static string[] times = { "3:00", "3:00", "4:00", "4:00", "3:00", "3:00", "4:00", "4:00" };
        static int[] arenas = { 1, 1, 2, 2, 3, 3, 4, 4};
        static int teamCount = 8;

        

        //Add test data
        private void MainForm_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < teamCount; ++i)
            {
                int rowID = DivisionGridView1.Rows.Add();
                DataGridViewRow row = DivisionGridView1.Rows[rowID];

                row.Cells[0].Value = teams[i];
                row.Cells[1].Value = statusText[0];
                row.Cells[1].Style.BackColor = Color.White;
                row.Cells[2].Value = times[i];
                row.Cells[3].Value = arenas[i];
            }
            //Clear the selection because it is a pain in the ass
            DivisionGridView1.ClearSelection();
        }

        //Exit menu option
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Load from .CSV
        private void fromCSVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int teamCount = 0;
            List<Team> teams = LoadFile.fromCSV(ref teamCount);
            //Clear out the rows from the grid view
            DivisionGridView1.Rows.Clear();

            foreach (Team team in teams)
            {
                int rowID = DivisionGridView1.Rows.Add();
                DataGridViewRow row = DivisionGridView1.Rows[rowID];

                row.Cells[0].Value = team.TeamName;
                row.Cells[1].Value = statusText[0];
                row.Cells[1].Style.BackColor = Color.White;
                row.Cells[2].Value = team.Time;
                row.Cells[3].Value = team.Station;
                //Clear the selection because it is a pain in the ass
                DivisionGridView1.ClearSelection();
            }

        }

        //Change the color of the cell clicked. 
        private void DivisionGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //Only change the color of the cell if it is in the status column and if the header isn't clicked.
            if (e.ColumnIndex == 1 && e.RowIndex != -1)
            {
                //Update the currentStatus array add if left click, subtract if right clicked.
                if (e.Button == MouseButtons.Left)
                    currentStatus[e.RowIndex] = (currentStatus[e.RowIndex] + 1) % 4;
                else
                {
                    if (currentStatus[e.RowIndex] - 1 < 0)
                        currentStatus[e.RowIndex] = 3;
                    else
                        currentStatus[e.RowIndex]--;
                }

                //Change the color of the selected row
                DivisionGridView1.Rows[e.RowIndex].Cells[1].Style.BackColor =
                    statusColors[currentStatus[e.RowIndex]];
                //Update the status text in the selected row
                DivisionGridView1.Rows[e.RowIndex].Cells[1].Value = statusText[currentStatus[e.RowIndex]];

                //Clear the selection because it is a pain in the ass
                DivisionGridView1.ClearSelection();
            }
        }
    }
}
