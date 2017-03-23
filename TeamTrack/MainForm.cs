using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace TeamTrack
{
    public partial class MainForm : Form
    {
        //Status Colors and the current status of each team
        Color[] statusColors = { Color.White, Color.Yellow, Color.Red, Color.Green };
        string[] statusText = { "No Inspect", "Hardware Ok", "Inspect Fail", "Ready!" };
        int statusTotal = 4;

        #region Form Methods and Events
        public MainForm()
        {
            InitializeComponent();
        }

        //Add test data
        private void MainForm_Load(object sender, EventArgs e)
        {
            /*
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
            */
            //Clear the selection because it is a pain in the ass
            DivisionGridView1.ClearSelection();
        }

        //Exit menu option
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion

        #region File Loading
        //Load from .CSV
        private void fromCSVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int teamCount = 0;
            List<Team> teams = LoadFile.fromCSV(ref teamCount);
            //Clear out the rows from the grid views
            DivisionGridView1.Rows.Clear();
            DivisionGridView2.Rows.Clear();
            string firstDiv = "";

            foreach (Team team in teams)
            {
                //Set the first divison.
                if (firstDiv == "")
                    firstDiv = team.Divison;

                int rowID;
                DataGridViewRow row;

                //If the current team is in the first division, add a row to the first division datagridview
                //Else, add a row to the second division datagridview
                if (firstDiv == team.Divison)
                {
                    rowID = DivisionGridView1.Rows.Add();
                    row = DivisionGridView1.Rows[rowID];
                    divisionLabel1.Text = team.Divison;
                }
                else
                {
                    rowID = DivisionGridView2.Rows.Add();
                    row = DivisionGridView2.Rows[rowID];
                    divisionLabel2.Text = team.Divison;
                }

                row.Cells[0].Value = team.TeamName;
                //team.TeamNumber;
                row.Cells[1].Value = statusText[0];
                row.Cells[1].Style.BackColor = Color.White;
                row.Cells[2].Value = team.Time;
                row.Cells[3].Value = team.Station;

            }

            //Hide DivisionGridView2 if there are no rows; only one division is shown
            //Make sure it is shown otherwise
            DivisionGridView2.Visible = !(DivisionGridView2.Rows.Count == 0);
            divisionLabel2.Visible = !(DivisionGridView2.Rows.Count == 0);


            //Clear the selection because it is a pain in the ass
            DivisionGridView1.ClearSelection();
            DivisionGridView2.ClearSelection();
        }
        #endregion

        #region DvisionGridView 1 Events
        //Change the color of the cell clicked. 
        private void DivisionGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //Only change the color of the cell if it is in the status column and if the header isn't clicked.
            if (e.ColumnIndex == 1 && e.RowIndex != -1)
            {

                //Change the color to the next color if the left mouse button is clicked
                if (e.Button == MouseButtons.Left)
                {
                    //White -> Yellow
                    //Yellow -> Red
                    //Red -> Green
                    //Green -> White
                    for (int i = 0; i < statusTotal; ++i)
                    {
                        if (DivisionGridView1.Rows[e.RowIndex].Cells[1].Style.BackColor == statusColors[i])
                        {
                            DivisionGridView1.Rows[e.RowIndex].Cells[1].Style.BackColor = statusColors[(i + 1) % statusTotal];
                            DivisionGridView1.Rows[e.RowIndex].Cells[1].Value = statusText[(i + 1) % statusTotal];
                            break;
                        }
                    }
                }
                //Change the color to the last color if the right mouse button is clicked
                else
                {
                    //White -> Green
                    if (DivisionGridView1.Rows[e.RowIndex].Cells[1].Style.BackColor == statusColors[0])
                    {
                        DivisionGridView1.Rows[e.RowIndex].Cells[1].Style.BackColor = statusColors[statusTotal - 1];
                        DivisionGridView1.Rows[e.RowIndex].Cells[1].Value = statusText[statusTotal - 1];
                        //Clear the selection because it is a pain in the ass
                        DivisionGridView1.ClearSelection();
                        return;
                    }

                    //Green -> Red
                    //Red -> Yellow
                    //Yellow -> White
                    for (int i = 1; i < statusTotal; ++i)
                    {
                        if (DivisionGridView1.Rows[e.RowIndex].Cells[1].Style.BackColor == statusColors[i])
                        {
                            DivisionGridView1.Rows[e.RowIndex].Cells[1].Style.BackColor = statusColors[i - 1];
                            DivisionGridView1.Rows[e.RowIndex].Cells[1].Value = statusText[i - 1];
                            break;
                        }
                    }

                }

                //Clear the selection because it is a pain in the ass
                DivisionGridView1.ClearSelection();
            }
        }
        #endregion

        #region DvisionGridView 2 Events    
        private void DivisionGridView2_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //Only change the color of the cell if it is in the status column and if the header isn't clicked.
            if (e.ColumnIndex == 1 && e.RowIndex != -1)
            {

                //Change the color to the next color if the left mouse button is clicked
                if (e.Button == MouseButtons.Left)
                {
                    //White -> Yellow
                    //Yellow -> Red
                    //Red -> Green
                    //Green -> White
                    for (int i = 0; i < statusTotal; ++i)
                    {
                        if (DivisionGridView2.Rows[e.RowIndex].Cells[1].Style.BackColor == statusColors[i])
                        {
                            DivisionGridView2.Rows[e.RowIndex].Cells[1].Style.BackColor = statusColors[(i + 1) % statusTotal];
                            DivisionGridView2.Rows[e.RowIndex].Cells[1].Value = statusText[(i + 1) % statusTotal];
                            break;
                        }
                    }
                }
                //Change the color to the last color if the right mouse button is clicked
                else
                {
                    //White -> Green
                    if (DivisionGridView2.Rows[e.RowIndex].Cells[1].Style.BackColor == statusColors[0])
                    {
                        DivisionGridView2.Rows[e.RowIndex].Cells[1].Style.BackColor = statusColors[statusTotal -1];
                        DivisionGridView2.Rows[e.RowIndex].Cells[1].Value = statusText[statusTotal - 1];
                        //Clear the selection because it is a pain in the ass
                        DivisionGridView2.ClearSelection();
                        return;
                    }

                    //Green -> Red
                    //Red -> Yellow
                    //Yellow -> White
                    for (int i = 1; i < statusTotal; ++i)
                    {
                        if (DivisionGridView2.Rows[e.RowIndex].Cells[1].Style.BackColor == statusColors[i])
                        {
                            DivisionGridView2.Rows[e.RowIndex].Cells[1].Style.BackColor = statusColors[i - 1];
                            DivisionGridView2.Rows[e.RowIndex].Cells[1].Value = statusText[i - 1];
                            break;
                        }
                    }

                }

                //Clear the selection because it is a pain in the ass
                DivisionGridView2.ClearSelection();
            }
        }
        #endregion



    }
}
