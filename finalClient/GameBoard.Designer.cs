namespace finalClient
{
    partial class GameBoard
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
            this.boardPanel = new System.Windows.Forms.Panel();
            this.gameDataView = new System.Windows.Forms.DataGridView();
            this.infoPanel = new System.Windows.Forms.Panel();
            this.pictureBoxTurn = new System.Windows.Forms.PictureBox();
            this.pnlWhiteLose = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.lblWhiteScore = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlWhite = new System.Windows.Forms.Panel();
            this.lblTurn = new System.Windows.Forms.Label();
            this.pnlBlackLose = new System.Windows.Forms.Panel();
            this.lblBlackScore = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlBlack = new System.Windows.Forms.Panel();
            this.lblUserName = new System.Windows.Forms.Label();
            this.blackScore = new System.Windows.Forms.Panel();
            this.lblRivalColor = new System.Windows.Forms.Label();
            this.lblRivalName = new System.Windows.Forms.Label();
            this.lblUserColor = new System.Windows.Forms.Label();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnHistory = new System.Windows.Forms.Button();
            this.btnComputer = new System.Windows.Forms.Button();
            this.btnFriend = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.boardPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gameDataView)).BeginInit();
            this.infoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTurn)).BeginInit();
            this.pnlWhiteLose.SuspendLayout();
            this.pnlBlackLose.SuspendLayout();
            this.blackScore.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // boardPanel
            // 
            this.boardPanel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.boardPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.boardPanel.Controls.Add(this.gameDataView);
            this.boardPanel.Location = new System.Drawing.Point(13, 46);
            this.boardPanel.Name = "boardPanel";
            this.boardPanel.Size = new System.Drawing.Size(414, 504);
            this.boardPanel.TabIndex = 0;
            // 
            // gameDataView
            // 
            this.gameDataView.AllowUserToAddRows = false;
            this.gameDataView.AllowUserToDeleteRows = false;
            this.gameDataView.AllowUserToResizeColumns = false;
            this.gameDataView.AllowUserToResizeRows = false;
            this.gameDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gameDataView.ColumnHeadersVisible = false;
            this.gameDataView.Location = new System.Drawing.Point(4, 4);
            this.gameDataView.Name = "gameDataView";
            this.gameDataView.ReadOnly = true;
            this.gameDataView.RowHeadersVisible = false;
            this.gameDataView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gameDataView.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.gameDataView.Size = new System.Drawing.Size(403, 493);
            this.gameDataView.TabIndex = 0;
            this.gameDataView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gameDataView_CellClick);
            // 
            // infoPanel
            // 
            this.infoPanel.BackColor = System.Drawing.Color.Transparent;
            this.infoPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.infoPanel.Controls.Add(this.pictureBoxTurn);
            this.infoPanel.Controls.Add(this.pnlWhiteLose);
            this.infoPanel.Controls.Add(this.lblTurn);
            this.infoPanel.Controls.Add(this.pnlBlackLose);
            this.infoPanel.Location = new System.Drawing.Point(456, 46);
            this.infoPanel.Name = "infoPanel";
            this.infoPanel.Size = new System.Drawing.Size(313, 206);
            this.infoPanel.TabIndex = 1;
            // 
            // pictureBoxTurn
            // 
            this.pictureBoxTurn.Location = new System.Drawing.Point(166, 4);
            this.pictureBoxTurn.Name = "pictureBoxTurn";
            this.pictureBoxTurn.Size = new System.Drawing.Size(131, 106);
            this.pictureBoxTurn.TabIndex = 4;
            this.pictureBoxTurn.TabStop = false;
            // 
            // pnlWhiteLose
            // 
            this.pnlWhiteLose.Controls.Add(this.label3);
            this.pnlWhiteLose.Controls.Add(this.lblWhiteScore);
            this.pnlWhiteLose.Controls.Add(this.label1);
            this.pnlWhiteLose.Controls.Add(this.pnlWhite);
            this.pnlWhiteLose.Location = new System.Drawing.Point(166, 129);
            this.pnlWhiteLose.Name = "pnlWhiteLose";
            this.pnlWhiteLose.Size = new System.Drawing.Size(140, 70);
            this.pnlWhiteLose.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Yellow;
            this.label3.Location = new System.Drawing.Point(-151, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 33);
            this.label3.TabIndex = 3;
            this.label3.Text = "0";
            // 
            // lblWhiteScore
            // 
            this.lblWhiteScore.AutoSize = true;
            this.lblWhiteScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWhiteScore.ForeColor = System.Drawing.Color.Yellow;
            this.lblWhiteScore.Location = new System.Drawing.Point(6, 24);
            this.lblWhiteScore.Name = "lblWhiteScore";
            this.lblWhiteScore.Size = new System.Drawing.Size(32, 33);
            this.lblWhiteScore.TabIndex = 2;
            this.lblWhiteScore.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(31, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "X";
            // 
            // pnlWhite
            // 
            this.pnlWhite.Location = new System.Drawing.Point(61, 4);
            this.pnlWhite.Name = "pnlWhite";
            this.pnlWhite.Size = new System.Drawing.Size(71, 63);
            this.pnlWhite.TabIndex = 0;
            // 
            // lblTurn
            // 
            this.lblTurn.AutoSize = true;
            this.lblTurn.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTurn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTurn.Location = new System.Drawing.Point(3, 4);
            this.lblTurn.Name = "lblTurn";
            this.lblTurn.Size = new System.Drawing.Size(152, 33);
            this.lblTurn.TabIndex = 0;
            this.lblTurn.Text = "Next Turn";
            // 
            // pnlBlackLose
            // 
            this.pnlBlackLose.Controls.Add(this.lblBlackScore);
            this.pnlBlackLose.Controls.Add(this.label2);
            this.pnlBlackLose.Controls.Add(this.pnlBlack);
            this.pnlBlackLose.Location = new System.Drawing.Point(3, 129);
            this.pnlBlackLose.Name = "pnlBlackLose";
            this.pnlBlackLose.Size = new System.Drawing.Size(140, 70);
            this.pnlBlackLose.TabIndex = 2;
            // 
            // lblBlackScore
            // 
            this.lblBlackScore.AutoSize = true;
            this.lblBlackScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBlackScore.ForeColor = System.Drawing.Color.Yellow;
            this.lblBlackScore.Location = new System.Drawing.Point(12, 24);
            this.lblBlackScore.Name = "lblBlackScore";
            this.lblBlackScore.Size = new System.Drawing.Size(32, 33);
            this.lblBlackScore.TabIndex = 4;
            this.lblBlackScore.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(40, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 33);
            this.label2.TabIndex = 2;
            this.label2.Text = "X";
            // 
            // pnlBlack
            // 
            this.pnlBlack.Location = new System.Drawing.Point(64, 4);
            this.pnlBlack.Name = "pnlBlack";
            this.pnlBlack.Size = new System.Drawing.Size(71, 63);
            this.pnlBlack.TabIndex = 1;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.ForeColor = System.Drawing.Color.Yellow;
            this.lblUserName.Location = new System.Drawing.Point(-3, 14);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(167, 33);
            this.lblUserName.TabIndex = 0;
            this.lblUserName.Text = "User name";
            // 
            // blackScore
            // 
            this.blackScore.BackColor = System.Drawing.Color.Transparent;
            this.blackScore.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.blackScore.Controls.Add(this.lblRivalColor);
            this.blackScore.Controls.Add(this.lblRivalName);
            this.blackScore.Controls.Add(this.lblUserColor);
            this.blackScore.Controls.Add(this.btnPause);
            this.blackScore.Controls.Add(this.btnHistory);
            this.blackScore.Controls.Add(this.btnComputer);
            this.blackScore.Controls.Add(this.btnFriend);
            this.blackScore.Controls.Add(this.lblUserName);
            this.blackScore.Location = new System.Drawing.Point(456, 258);
            this.blackScore.Name = "blackScore";
            this.blackScore.Size = new System.Drawing.Size(312, 292);
            this.blackScore.TabIndex = 2;
            // 
            // lblRivalColor
            // 
            this.lblRivalColor.AutoSize = true;
            this.lblRivalColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRivalColor.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblRivalColor.Location = new System.Drawing.Point(175, 62);
            this.lblRivalColor.Name = "lblRivalColor";
            this.lblRivalColor.Size = new System.Drawing.Size(130, 33);
            this.lblRivalColor.TabIndex = 11;
            this.lblRivalColor.Text = "as white";
            this.lblRivalColor.Visible = false;
            // 
            // lblRivalName
            // 
            this.lblRivalName.AutoSize = true;
            this.lblRivalName.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRivalName.ForeColor = System.Drawing.Color.Yellow;
            this.lblRivalName.Location = new System.Drawing.Point(-2, 62);
            this.lblRivalName.Name = "lblRivalName";
            this.lblRivalName.Size = new System.Drawing.Size(172, 33);
            this.lblRivalName.TabIndex = 10;
            this.lblRivalName.Text = "Rival name";
            this.lblRivalName.Visible = false;
            // 
            // lblUserColor
            // 
            this.lblUserColor.AutoSize = true;
            this.lblUserColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserColor.ForeColor = System.Drawing.Color.Black;
            this.lblUserColor.Location = new System.Drawing.Point(175, 14);
            this.lblUserColor.Name = "lblUserColor";
            this.lblUserColor.Size = new System.Drawing.Size(131, 33);
            this.lblUserColor.TabIndex = 9;
            this.lblUserColor.Text = "as black";
            this.lblUserColor.Visible = false;
            // 
            // btnPause
            // 
            this.btnPause.BackColor = System.Drawing.Color.Yellow;
            this.btnPause.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPause.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPause.Location = new System.Drawing.Point(160, 235);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(139, 35);
            this.btnPause.TabIndex = 8;
            this.btnPause.Text = "Pause";
            this.btnPause.UseVisualStyleBackColor = false;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnHistory
            // 
            this.btnHistory.BackColor = System.Drawing.Color.Yellow;
            this.btnHistory.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHistory.Location = new System.Drawing.Point(10, 235);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(139, 35);
            this.btnHistory.TabIndex = 7;
            this.btnHistory.Text = "History";
            this.btnHistory.UseVisualStyleBackColor = false;
            this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click);
            // 
            // btnComputer
            // 
            this.btnComputer.BackColor = System.Drawing.Color.Yellow;
            this.btnComputer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnComputer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComputer.Location = new System.Drawing.Point(33, 169);
            this.btnComputer.Name = "btnComputer";
            this.btnComputer.Size = new System.Drawing.Size(244, 35);
            this.btnComputer.TabIndex = 6;
            this.btnComputer.Text = "Start Vs. Computer";
            this.btnComputer.UseVisualStyleBackColor = false;
            this.btnComputer.Click += new System.EventHandler(this.btnComputer_Click);
            // 
            // btnFriend
            // 
            this.btnFriend.BackColor = System.Drawing.Color.Yellow;
            this.btnFriend.Enabled = false;
            this.btnFriend.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFriend.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFriend.Location = new System.Drawing.Point(33, 110);
            this.btnFriend.Name = "btnFriend";
            this.btnFriend.Size = new System.Drawing.Size(244, 35);
            this.btnFriend.TabIndex = 5;
            this.btnFriend.Text = "Start Vs. Friend";
            this.btnFriend.UseVisualStyleBackColor = false;
            this.btnFriend.Click += new System.EventHandler(this.btnFriend_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(781, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // GameBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(781, 578);
            this.Controls.Add(this.blackScore);
            this.Controls.Add(this.infoPanel);
            this.Controls.Add(this.boardPanel);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "GameBoard";
            this.Text = "GameBoard";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GameBoard_FormClosed);
            this.Load += new System.EventHandler(this.GameBoard_Load);
            this.boardPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gameDataView)).EndInit();
            this.infoPanel.ResumeLayout(false);
            this.infoPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTurn)).EndInit();
            this.pnlWhiteLose.ResumeLayout(false);
            this.pnlWhiteLose.PerformLayout();
            this.pnlBlackLose.ResumeLayout(false);
            this.pnlBlackLose.PerformLayout();
            this.blackScore.ResumeLayout(false);
            this.blackScore.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel boardPanel;
        private System.Windows.Forms.Panel infoPanel;
        private System.Windows.Forms.Panel blackScore;
        private System.Windows.Forms.DataGridView gameDataView;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label lblTurn;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Panel pnlWhiteLose;
        private System.Windows.Forms.Panel pnlBlackLose;
        private System.Windows.Forms.Panel pnlWhite;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlBlack;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblWhiteScore;
        private System.Windows.Forms.Label lblBlackScore;
        private System.Windows.Forms.Button btnFriend;
        private System.Windows.Forms.Button btnHistory;
        private System.Windows.Forms.Button btnComputer;
        private System.Windows.Forms.PictureBox pictureBoxTurn;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Label lblRivalColor;
        private System.Windows.Forms.Label lblRivalName;
        private System.Windows.Forms.Label lblUserColor;
    }
}