namespace finalClient
{
    partial class GameChooser
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
            this.grpPlay = new System.Windows.Forms.GroupBox();
            this.grpWait = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // grpPlay
            // 
            this.grpPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpPlay.ForeColor = System.Drawing.Color.Green;
            this.grpPlay.Location = new System.Drawing.Point(12, 12);
            this.grpPlay.Name = "grpPlay";
            this.grpPlay.Size = new System.Drawing.Size(233, 143);
            this.grpPlay.TabIndex = 0;
            this.grpPlay.TabStop = false;
            this.grpPlay.Text = "Ready To Play";
            // 
            // grpWait
            // 
            this.grpWait.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpWait.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.grpWait.Location = new System.Drawing.Point(289, 12);
            this.grpWait.Name = "grpWait";
            this.grpWait.Size = new System.Drawing.Size(233, 143);
            this.grpWait.TabIndex = 1;
            this.grpWait.TabStop = false;
            this.grpWait.Text = "Waiting for player";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(311, 177);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(129, 23);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(116, 177);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(129, 23);
            this.btnPlay.TabIndex = 4;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // GameChooser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 212);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.grpWait);
            this.Controls.Add(this.grpPlay);
            this.Name = "GameChooser";
            this.Text = "GameChooser";
            this.Load += new System.EventHandler(this.GameChooser_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpPlay;
        private System.Windows.Forms.GroupBox grpWait;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnPlay;
    }
}