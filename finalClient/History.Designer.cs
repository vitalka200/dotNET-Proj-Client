namespace finalClient
{
    partial class History
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
            this.historyGridView = new System.Windows.Forms.DataGridView();
            this.btnMoves = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.pictureBoxHistory = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.historyGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // historyGridView
            // 
            this.historyGridView.AllowUserToAddRows = false;
            this.historyGridView.AllowUserToDeleteRows = false;
            this.historyGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.historyGridView.Location = new System.Drawing.Point(192, 22);
            this.historyGridView.Name = "historyGridView";
            this.historyGridView.ReadOnly = true;
            this.historyGridView.Size = new System.Drawing.Size(435, 187);
            this.historyGridView.TabIndex = 0;
            // 
            // btnMoves
            // 
            this.btnMoves.Location = new System.Drawing.Point(241, 231);
            this.btnMoves.Name = "btnMoves";
            this.btnMoves.Size = new System.Drawing.Size(121, 23);
            this.btnMoves.TabIndex = 2;
            this.btnMoves.Text = "Show Me The Moves";
            this.btnMoves.UseVisualStyleBackColor = true;
            this.btnMoves.Click += new System.EventHandler(this.btnMoves_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(466, 231);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pictureBoxHistory
            // 
            this.pictureBoxHistory.Location = new System.Drawing.Point(13, 22);
            this.pictureBoxHistory.Name = "pictureBoxHistory";
            this.pictureBoxHistory.Size = new System.Drawing.Size(173, 245);
            this.pictureBoxHistory.TabIndex = 1;
            this.pictureBoxHistory.TabStop = false;
            // 
            // History
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 279);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnMoves);
            this.Controls.Add(this.pictureBoxHistory);
            this.Controls.Add(this.historyGridView);
            this.Name = "History";
            this.Text = "History";
            this.Load += new System.EventHandler(this.History_Load);
            ((System.ComponentModel.ISupportInitialize)(this.historyGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHistory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView historyGridView;
        private System.Windows.Forms.PictureBox pictureBoxHistory;
        private System.Windows.Forms.Button btnMoves;
        private System.Windows.Forms.Button btnExit;
    }
}