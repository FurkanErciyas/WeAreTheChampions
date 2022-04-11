namespace WeAreTheChampions
{
    partial class AddMatchForm
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
            this.dtpMatchTime = new System.Windows.Forms.DateTimePicker();
            this.cboHomeTeam = new System.Windows.Forms.ComboBox();
            this.cboAwayTeam = new System.Windows.Forms.ComboBox();
            this.cboAwayScore = new System.Windows.Forms.ComboBox();
            this.cboHomeScore = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dtpMatchTime
            // 
            this.dtpMatchTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpMatchTime.Location = new System.Drawing.Point(868, 552);
            this.dtpMatchTime.Name = "dtpMatchTime";
            this.dtpMatchTime.Size = new System.Drawing.Size(288, 29);
            this.dtpMatchTime.TabIndex = 2;
            // 
            // cboHomeTeam
            // 
            this.cboHomeTeam.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboHomeTeam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboHomeTeam.FormattingEnabled = true;
            this.cboHomeTeam.Location = new System.Drawing.Point(202, 330);
            this.cboHomeTeam.Name = "cboHomeTeam";
            this.cboHomeTeam.Size = new System.Drawing.Size(246, 32);
            this.cboHomeTeam.TabIndex = 4;
            // 
            // cboAwayTeam
            // 
            this.cboAwayTeam.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboAwayTeam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAwayTeam.FormattingEnabled = true;
            this.cboAwayTeam.Location = new System.Drawing.Point(736, 330);
            this.cboAwayTeam.Name = "cboAwayTeam";
            this.cboAwayTeam.Size = new System.Drawing.Size(246, 32);
            this.cboAwayTeam.TabIndex = 5;
            // 
            // cboAwayScore
            // 
            this.cboAwayScore.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboAwayScore.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAwayScore.FormattingEnabled = true;
            this.cboAwayScore.Location = new System.Drawing.Point(648, 330);
            this.cboAwayScore.Name = "cboAwayScore";
            this.cboAwayScore.Size = new System.Drawing.Size(82, 32);
            this.cboAwayScore.TabIndex = 8;
            // 
            // cboHomeScore
            // 
            this.cboHomeScore.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboHomeScore.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboHomeScore.FormattingEnabled = true;
            this.cboHomeScore.Location = new System.Drawing.Point(454, 330);
            this.cboHomeScore.Name = "cboHomeScore";
            this.cboHomeScore.Size = new System.Drawing.Size(82, 32);
            this.cboHomeScore.TabIndex = 9;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAdd.Location = new System.Drawing.Point(525, 397);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(130, 32);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // AddMatchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WeAreTheChampions.Properties.Resources.AddMatchForm_Stadium;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1168, 593);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cboHomeScore);
            this.Controls.Add(this.cboAwayScore);
            this.Controls.Add(this.cboAwayTeam);
            this.Controls.Add(this.cboHomeTeam);
            this.Controls.Add(this.dtpMatchTime);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "AddMatchForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Match";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dtpMatchTime;
        private System.Windows.Forms.ComboBox cboHomeTeam;
        private System.Windows.Forms.ComboBox cboAwayTeam;
        private System.Windows.Forms.ComboBox cboAwayScore;
        private System.Windows.Forms.ComboBox cboHomeScore;
        private System.Windows.Forms.Button btnAdd;
    }
}