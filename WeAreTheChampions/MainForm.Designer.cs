namespace WeAreTheChampions
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
            this.components = new System.ComponentModel.Container();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tpPlayers = new System.Windows.Forms.TabPage();
            this.lblNewPlayer = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboTeams = new System.Windows.Forms.ComboBox();
            this.dgvPlayers = new System.Windows.Forms.DataGridView();
            this.tpTeams = new System.Windows.Forms.TabPage();
            this.lblNewTeam = new System.Windows.Forms.LinkLabel();
            this.dgvTeams = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.cms = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.tpPlayers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlayers)).BeginInit();
            this.tpTeams.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeams)).BeginInit();
            this.tabControl.SuspendLayout();
            this.cms.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 33);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(481, 474);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Matches";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tpPlayers
            // 
            this.tpPlayers.Controls.Add(this.lblNewPlayer);
            this.tpPlayers.Controls.Add(this.label2);
            this.tpPlayers.Controls.Add(this.label1);
            this.tpPlayers.Controls.Add(this.cboTeams);
            this.tpPlayers.Controls.Add(this.dgvPlayers);
            this.tpPlayers.Location = new System.Drawing.Point(4, 33);
            this.tpPlayers.Margin = new System.Windows.Forms.Padding(6);
            this.tpPlayers.Name = "tpPlayers";
            this.tpPlayers.Padding = new System.Windows.Forms.Padding(6);
            this.tpPlayers.Size = new System.Drawing.Size(481, 474);
            this.tpPlayers.TabIndex = 1;
            this.tpPlayers.Text = "Players";
            this.tpPlayers.UseVisualStyleBackColor = true;
            // 
            // lblNewPlayer
            // 
            this.lblNewPlayer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNewPlayer.AutoSize = true;
            this.lblNewPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblNewPlayer.Location = new System.Drawing.Point(379, 52);
            this.lblNewPlayer.Name = "lblNewPlayer";
            this.lblNewPlayer.Size = new System.Drawing.Size(92, 20);
            this.lblNewPlayer.TabIndex = 17;
            this.lblNewPlayer.TabStop = true;
            this.lblNewPlayer.Text = "+NewPlayer";
            this.lblNewPlayer.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblNewPlayer_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 24);
            this.label2.TabIndex = 15;
            this.label2.Text = "Players";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(9, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 24);
            this.label1.TabIndex = 14;
            this.label1.Text = "Teams: ";
            // 
            // cboTeams
            // 
            this.cboTeams.DisplayMember = "TeamName";
            this.cboTeams.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTeams.FormattingEnabled = true;
            this.cboTeams.Location = new System.Drawing.Point(93, 12);
            this.cboTeams.Name = "cboTeams";
            this.cboTeams.Size = new System.Drawing.Size(378, 32);
            this.cboTeams.TabIndex = 13;
            this.cboTeams.SelectedIndexChanged += new System.EventHandler(this.cboTeams_SelectedIndexChanged);
            // 
            // dgvPlayers
            // 
            this.dgvPlayers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPlayers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPlayers.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvPlayers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlayers.Location = new System.Drawing.Point(13, 75);
            this.dgvPlayers.MultiSelect = false;
            this.dgvPlayers.Name = "dgvPlayers";
            this.dgvPlayers.ReadOnly = true;
            this.dgvPlayers.RowHeadersVisible = false;
            this.dgvPlayers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPlayers.Size = new System.Drawing.Size(458, 391);
            this.dgvPlayers.TabIndex = 12;
            this.dgvPlayers.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dgvPlayers_MouseDown);
            // 
            // tpTeams
            // 
            this.tpTeams.Controls.Add(this.lblNewTeam);
            this.tpTeams.Controls.Add(this.dgvTeams);
            this.tpTeams.Controls.Add(this.label3);
            this.tpTeams.Location = new System.Drawing.Point(4, 33);
            this.tpTeams.Margin = new System.Windows.Forms.Padding(6);
            this.tpTeams.Name = "tpTeams";
            this.tpTeams.Padding = new System.Windows.Forms.Padding(6);
            this.tpTeams.Size = new System.Drawing.Size(481, 474);
            this.tpTeams.TabIndex = 0;
            this.tpTeams.Text = "Teams";
            this.tpTeams.UseVisualStyleBackColor = true;
            // 
            // lblNewTeam
            // 
            this.lblNewTeam.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNewTeam.AutoSize = true;
            this.lblNewTeam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblNewTeam.Location = new System.Drawing.Point(381, 20);
            this.lblNewTeam.Name = "lblNewTeam";
            this.lblNewTeam.Size = new System.Drawing.Size(89, 20);
            this.lblNewTeam.TabIndex = 18;
            this.lblNewTeam.TabStop = true;
            this.lblNewTeam.Text = "+NewTeam";
            this.lblNewTeam.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblNewTeam_LinkClicked);
            // 
            // dgvTeams
            // 
            this.dgvTeams.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTeams.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTeams.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvTeams.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTeams.Location = new System.Drawing.Point(12, 44);
            this.dgvTeams.MultiSelect = false;
            this.dgvTeams.Name = "dgvTeams";
            this.dgvTeams.ReadOnly = true;
            this.dgvTeams.RowHeadersVisible = false;
            this.dgvTeams.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTeams.Size = new System.Drawing.Size(458, 421);
            this.dgvTeams.TabIndex = 1;
            this.dgvTeams.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dgvTeams_MouseDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "Teams";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tpTeams);
            this.tabControl.Controls.Add(this.tpPlayers);
            this.tabControl.Controls.Add(this.tabPage3);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Margin = new System.Windows.Forms.Padding(6);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(489, 511);
            this.tabControl.TabIndex = 0;
            // 
            // cms
            // 
            this.cms.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiEdit,
            this.tsmiDelete});
            this.cms.Name = "cms";
            this.cms.Size = new System.Drawing.Size(116, 52);
            // 
            // tsmiEdit
            // 
            this.tsmiEdit.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tsmiEdit.Name = "tsmiEdit";
            this.tsmiEdit.Size = new System.Drawing.Size(115, 24);
            this.tsmiEdit.Text = "Edit";
            // 
            // tsmiDelete
            // 
            this.tsmiDelete.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tsmiDelete.Name = "tsmiDelete";
            this.tsmiDelete.Size = new System.Drawing.Size(115, 24);
            this.tsmiDelete.Text = "Delete";
            this.tsmiDelete.Click += new System.EventHandler(this.tsmiDelete_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 511);
            this.Controls.Add(this.tabControl);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "We Are The Champions V1.0";
            this.tpPlayers.ResumeLayout(false);
            this.tpPlayers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlayers)).EndInit();
            this.tpTeams.ResumeLayout(false);
            this.tpTeams.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeams)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.cms.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tpPlayers;
        private System.Windows.Forms.LinkLabel lblNewPlayer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboTeams;
        private System.Windows.Forms.DataGridView dgvPlayers;
        private System.Windows.Forms.TabPage tpTeams;
        private System.Windows.Forms.LinkLabel lblNewTeam;
        private System.Windows.Forms.DataGridView dgvTeams;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.ContextMenuStrip cms;
        private System.Windows.Forms.ToolStripMenuItem tsmiEdit;
        private System.Windows.Forms.ToolStripMenuItem tsmiDelete;
    }
}