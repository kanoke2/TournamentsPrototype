namespace TrackerUi
{
    partial class TournamentDashboardForm
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
            this.createTeamLabel = new System.Windows.Forms.Label();
            this.loadExistingTournmanetDropBox = new System.Windows.Forms.ComboBox();
            this.loadExistingTournamentLabel = new System.Windows.Forms.Label();
            this.loadTournamentbutton = new System.Windows.Forms.Button();
            this.createTournamentButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // createTeamLabel
            // 
            this.createTeamLabel.AutoSize = true;
            this.createTeamLabel.Font = new System.Drawing.Font("Segoe UI Light", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createTeamLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.createTeamLabel.Location = new System.Drawing.Point(178, 28);
            this.createTeamLabel.Margin = new System.Windows.Forms.Padding(11, 0, 11, 0);
            this.createTeamLabel.Name = "createTeamLabel";
            this.createTeamLabel.Size = new System.Drawing.Size(350, 47);
            this.createTeamLabel.TabIndex = 13;
            this.createTeamLabel.Text = "Tournment Dashboard";
            this.createTeamLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // loadExistingTournmanetDropBox
            // 
            this.loadExistingTournmanetDropBox.FormattingEnabled = true;
            this.loadExistingTournmanetDropBox.Location = new System.Drawing.Point(165, 158);
            this.loadExistingTournmanetDropBox.Name = "loadExistingTournmanetDropBox";
            this.loadExistingTournmanetDropBox.Size = new System.Drawing.Size(377, 38);
            this.loadExistingTournmanetDropBox.TabIndex = 20;
            // 
            // loadExistingTournamentLabel
            // 
            this.loadExistingTournamentLabel.AutoSize = true;
            this.loadExistingTournamentLabel.Font = new System.Drawing.Font("Segoe UI Light", 20F);
            this.loadExistingTournamentLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.loadExistingTournamentLabel.Location = new System.Drawing.Point(202, 118);
            this.loadExistingTournamentLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.loadExistingTournamentLabel.Name = "loadExistingTournamentLabel";
            this.loadExistingTournamentLabel.Size = new System.Drawing.Size(303, 37);
            this.loadExistingTournamentLabel.TabIndex = 19;
            this.loadExistingTournamentLabel.Text = "Load Existing Tournament";
            // 
            // loadTournamentbutton
            // 
            this.loadTournamentbutton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.loadTournamentbutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.loadTournamentbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.loadTournamentbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loadTournamentbutton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.loadTournamentbutton.Location = new System.Drawing.Point(239, 216);
            this.loadTournamentbutton.Name = "loadTournamentbutton";
            this.loadTournamentbutton.Size = new System.Drawing.Size(228, 58);
            this.loadTournamentbutton.TabIndex = 21;
            this.loadTournamentbutton.Text = "Load Tournament";
            this.loadTournamentbutton.UseVisualStyleBackColor = true;
            // 
            // createTournamentButton
            // 
            this.createTournamentButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.createTournamentButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.createTournamentButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.createTournamentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createTournamentButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.createTournamentButton.Location = new System.Drawing.Point(213, 280);
            this.createTournamentButton.Name = "createTournamentButton";
            this.createTournamentButton.Size = new System.Drawing.Size(281, 77);
            this.createTournamentButton.TabIndex = 25;
            this.createTournamentButton.Text = "Create Tournament";
            this.createTournamentButton.UseVisualStyleBackColor = true;
            // 
            // TournamentDashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(706, 448);
            this.Controls.Add(this.createTournamentButton);
            this.Controls.Add(this.loadTournamentbutton);
            this.Controls.Add(this.loadExistingTournmanetDropBox);
            this.Controls.Add(this.loadExistingTournamentLabel);
            this.Controls.Add(this.createTeamLabel);
            this.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "TournamentDashboardForm";
            this.Text = "Tournament Dashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label createTeamLabel;
        private System.Windows.Forms.ComboBox loadExistingTournmanetDropBox;
        private System.Windows.Forms.Label loadExistingTournamentLabel;
        private System.Windows.Forms.Button loadTournamentbutton;
        private System.Windows.Forms.Button createTournamentButton;
    }
}