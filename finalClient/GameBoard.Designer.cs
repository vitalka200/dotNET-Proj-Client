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
            this.btnHistory = new System.Windows.Forms.Button();
            this.btnComputer = new System.Windows.Forms.Button();
            this.btnFriend = new System.Windows.Forms.Button();
            this.btnPasue = new System.Windows.Forms.Button();
            this.btnUndo = new System.Windows.Forms.Button();
            this.bthPlay = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.endGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lastMoveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadHistoryGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataBaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.lblUserName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblUserName.Location = new System.Drawing.Point(79, 20);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(167, 33);
            this.lblUserName.TabIndex = 0;
            this.lblUserName.Text = "User name";
            // 
            // blackScore
            // 
            this.blackScore.BackColor = System.Drawing.Color.Transparent;
            this.blackScore.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.blackScore.Controls.Add(this.btnHistory);
            this.blackScore.Controls.Add(this.btnComputer);
            this.blackScore.Controls.Add(this.btnFriend);
            this.blackScore.Controls.Add(this.btnPasue);
            this.blackScore.Controls.Add(this.btnUndo);
            this.blackScore.Controls.Add(this.bthPlay);
            this.blackScore.Controls.Add(this.lblUserName);
            this.blackScore.Location = new System.Drawing.Point(456, 258);
            this.blackScore.Name = "blackScore";
            this.blackScore.Size = new System.Drawing.Size(312, 292);
            this.blackScore.TabIndex = 2;
            // 
            // btnHistory
            // 
            this.btnHistory.BackColor = System.Drawing.Color.Yellow;
            this.btnHistory.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHistory.Location = new System.Drawing.Point(30, 181);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(247, 35);
            this.btnHistory.TabIndex = 7;
            this.btnHistory.Text = "Games History";
            this.btnHistory.UseVisualStyleBackColor = false;
            this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click);
            // 
            // btnComputer
            // 
            this.btnComputer.BackColor = System.Drawing.Color.Yellow;
            this.btnComputer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnComputer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComputer.Location = new System.Drawing.Point(33, 127);
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
            this.btnFriend.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFriend.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFriend.Location = new System.Drawing.Point(33, 77);
            this.btnFriend.Name = "btnFriend";
            this.btnFriend.Size = new System.Drawing.Size(244, 35);
            this.btnFriend.TabIndex = 5;
            this.btnFriend.Text = "Start Vs. Friend";
            this.btnFriend.UseVisualStyleBackColor = false;
            this.btnFriend.Click += new System.EventHandler(this.btnFriend_Click);
            // 
            // btnPasue
            // 
            this.btnPasue.BackColor = System.Drawing.Color.Transparent;
            this.btnPasue.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnPasue.FlatAppearance.BorderSize = 0;
            this.btnPasue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPasue.ForeColor = System.Drawing.Color.Transparent;
            this.btnPasue.Location = new System.Drawing.Point(256, 239);
            this.btnPasue.Name = "btnPasue";
            this.btnPasue.Size = new System.Drawing.Size(35, 35);
            this.btnPasue.TabIndex = 4;
            this.btnPasue.UseVisualStyleBackColor = false;
            this.btnPasue.Click += new System.EventHandler(this.btnPasue_Click);
            // 
            // btnUndo
            // 
            this.btnUndo.BackColor = System.Drawing.Color.Transparent;
            this.btnUndo.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnUndo.FlatAppearance.BorderSize = 0;
            this.btnUndo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUndo.ForeColor = System.Drawing.Color.Transparent;
            this.btnUndo.Location = new System.Drawing.Point(135, 239);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(35, 35);
            this.btnUndo.TabIndex = 2;
            this.btnUndo.UseVisualStyleBackColor = false;
            this.btnUndo.Click += new System.EventHandler(this.btnUndo_Click);
            // 
            // bthPlay
            // 
            this.bthPlay.BackColor = System.Drawing.Color.Transparent;
            this.bthPlay.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.bthPlay.FlatAppearance.BorderSize = 0;
            this.bthPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bthPlay.ForeColor = System.Drawing.Color.Transparent;
            this.bthPlay.Location = new System.Drawing.Point(30, 239);
            this.bthPlay.Name = "bthPlay";
            this.bthPlay.Size = new System.Drawing.Size(35, 35);
            this.bthPlay.TabIndex = 1;
            this.bthPlay.UseVisualStyleBackColor = false;
            this.bthPlay.Click += new System.EventHandler(this.bthPlay_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(781, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.endGameToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.newGameToolStripMenuItem.Text = "New Game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
            // 
            // endGameToolStripMenuItem
            // 
            this.endGameToolStripMenuItem.Name = "endGameToolStripMenuItem";
            this.endGameToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.endGameToolStripMenuItem.Text = "End Game";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lastMoveToolStripMenuItem,
            this.loadHistoryGameToolStripMenuItem,
            this.dataBaseToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // lastMoveToolStripMenuItem
            // 
            this.lastMoveToolStripMenuItem.Name = "lastMoveToolStripMenuItem";
            this.lastMoveToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.lastMoveToolStripMenuItem.Text = "Last Move";
            // 
            // loadHistoryGameToolStripMenuItem
            // 
            this.loadHistoryGameToolStripMenuItem.Name = "loadHistoryGameToolStripMenuItem";
            this.loadHistoryGameToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.loadHistoryGameToolStripMenuItem.Text = "Load History Game";
            // 
            // dataBaseToolStripMenuItem
            // 
            this.dataBaseToolStripMenuItem.Name = "dataBaseToolStripMenuItem";
            this.dataBaseToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.dataBaseToolStripMenuItem.Text = "DataBase";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
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
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem endGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lastMoveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadHistoryGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataBaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Panel pnlWhiteLose;
        private System.Windows.Forms.Panel pnlBlackLose;
        private System.Windows.Forms.Panel pnlWhite;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlBlack;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblWhiteScore;
        private System.Windows.Forms.Label lblBlackScore;
        private System.Windows.Forms.Button bthPlay;
        private System.Windows.Forms.Button btnPasue;
        private System.Windows.Forms.Button btnUndo;
        private System.Windows.Forms.Button btnFriend;
        private System.Windows.Forms.Button btnHistory;
        private System.Windows.Forms.Button btnComputer;
        private System.Windows.Forms.PictureBox pictureBoxTurn;
    }
}