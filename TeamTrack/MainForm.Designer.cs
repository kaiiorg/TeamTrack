namespace TeamTrack
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DivisionGridView1 = new System.Windows.Forms.DataGridView();
            this.divisionLabel1 = new System.Windows.Forms.Label();
            this.Team = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Arena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DivisionGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // DivisionGridView1
            // 
            this.DivisionGridView1.AllowUserToAddRows = false;
            this.DivisionGridView1.AllowUserToDeleteRows = false;
            this.DivisionGridView1.AllowUserToResizeColumns = false;
            this.DivisionGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            this.DivisionGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DivisionGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.DivisionGridView1.BackgroundColor = System.Drawing.Color.White;
            this.DivisionGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DivisionGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DivisionGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DivisionGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Team,
            this.Status,
            this.Time,
            this.Arena});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DivisionGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.DivisionGridView1.Location = new System.Drawing.Point(12, 51);
            this.DivisionGridView1.Name = "DivisionGridView1";
            this.DivisionGridView1.ReadOnly = true;
            this.DivisionGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DivisionGridView1.RowHeadersVisible = false;
            this.DivisionGridView1.RowTemplate.Height = 42;
            this.DivisionGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.DivisionGridView1.ShowCellErrors = false;
            this.DivisionGridView1.ShowEditingIcon = false;
            this.DivisionGridView1.Size = new System.Drawing.Size(678, 456);
            this.DivisionGridView1.TabIndex = 0;
            this.DivisionGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DivisionGridView1_CellClick);
            // 
            // divisionLabel1
            // 
            this.divisionLabel1.AutoSize = true;
            this.divisionLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divisionLabel1.Location = new System.Drawing.Point(5, 9);
            this.divisionLabel1.Name = "divisionLabel1";
            this.divisionLabel1.Size = new System.Drawing.Size(279, 39);
            this.divisionLabel1.TabIndex = 1;
            this.divisionLabel1.Text = "DIVISON NAME";
            // 
            // Team
            // 
            this.Team.HeaderText = "Team";
            this.Team.Name = "Team";
            this.Team.ReadOnly = true;
            this.Team.Width = 250;
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Width = 200;
            // 
            // Time
            // 
            this.Time.HeaderText = "Time";
            this.Time.Name = "Time";
            this.Time.ReadOnly = true;
            // 
            // Arena
            // 
            this.Arena.HeaderText = "Arena";
            this.Arena.Name = "Arena";
            this.Arena.ReadOnly = true;
            this.Arena.Width = 125;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(931, 519);
            this.Controls.Add(this.divisionLabel1);
            this.Controls.Add(this.DivisionGridView1);
            this.Name = "MainForm";
            this.Text = "Team Track";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DivisionGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DivisionGridView1;
        private System.Windows.Forms.Label divisionLabel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Team;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn Arena;
    }
}

