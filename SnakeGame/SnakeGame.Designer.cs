
namespace SnakeGame
{
    partial class SnakeGame
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.picBxGameZone = new System.Windows.Forms.PictureBox();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.lblS = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.BtnHelp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picBxGameZone)).BeginInit();
            this.SuspendLayout();
            // 
            // picBxGameZone
            // 
            this.picBxGameZone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBxGameZone.Location = new System.Drawing.Point(71, 74);
            this.picBxGameZone.Name = "picBxGameZone";
            this.picBxGameZone.Size = new System.Drawing.Size(500, 500);
            this.picBxGameZone.TabIndex = 0;
            this.picBxGameZone.TabStop = false;
            this.picBxGameZone.Paint += new System.Windows.Forms.PaintEventHandler(this.picbx_Paint);
            // 
            // gameTimer
            // 
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // lblS
            // 
            this.lblS.AutoSize = true;
            this.lblS.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblS.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblS.Location = new System.Drawing.Point(13, 23);
            this.lblS.Name = "lblS";
            this.lblS.Size = new System.Drawing.Size(82, 35);
            this.lblS.TabIndex = 1;
            this.lblS.Text = "Score:";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblScore.Location = new System.Drawing.Point(92, 23);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(0, 35);
            this.lblScore.TabIndex = 2;
            // 
            // BtnHelp
            // 
            this.BtnHelp.Location = new System.Drawing.Point(504, 13);
            this.BtnHelp.Name = "BtnHelp";
            this.BtnHelp.Size = new System.Drawing.Size(115, 45);
            this.BtnHelp.TabIndex = 3;
            this.BtnHelp.Text = "Help";
            this.BtnHelp.UseVisualStyleBackColor = true;
            this.BtnHelp.Click += new System.EventHandler(this.BtnHelp_Click);
            // 
            // SnakeGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 586);
            this.Controls.Add(this.BtnHelp);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblS);
            this.Controls.Add(this.picBxGameZone);
            this.KeyPreview = true;
            this.Name = "SnakeGame";
            this.Text = "Snake ";
            this.Load += new System.EventHandler(this.Form1_Load);
            
            ((System.ComponentModel.ISupportInitialize)(this.picBxGameZone)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBxGameZone;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label lblS;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Button BtnHelp;
    }
}

