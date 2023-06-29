namespace Game
{
    partial class Form1
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
            this.openGLControl1 = new SharpGL.OpenGLControl();
            this.lives = new System.Windows.Forms.Label();
            this.score = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.level = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.openGLControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // openGLControl1
            // 
            this.openGLControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.openGLControl1.DrawFPS = false;
            this.openGLControl1.FrameRate = 35;
            this.openGLControl1.Location = new System.Drawing.Point(0, 0);
            this.openGLControl1.Name = "openGLControl1";
            this.openGLControl1.OpenGLVersion = SharpGL.Version.OpenGLVersion.OpenGL2_1;
            this.openGLControl1.RenderContextType = SharpGL.RenderContextType.DIBSection;
            this.openGLControl1.RenderTrigger = SharpGL.RenderTrigger.TimerBased;
            this.openGLControl1.Size = new System.Drawing.Size(800, 450);
            this.openGLControl1.TabIndex = 0;
            this.openGLControl1.OpenGLDraw += new SharpGL.RenderEventHandler(this.openGLControl1_OpenGLDraw);
            this.openGLControl1.Load += new System.EventHandler(this.openGLControl1_Load);
            this.openGLControl1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.openGLControl1_KeyDown);
            this.openGLControl1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.openGLControl1_MouseClick);
            // 
            // lives
            // 
            this.lives.AutoSize = true;
            this.lives.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lives.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lives.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lives.Location = new System.Drawing.Point(12, 19);
            this.lives.Name = "lives";
            this.lives.Size = new System.Drawing.Size(42, 19);
            this.lives.TabIndex = 1;
            this.lives.Text = "Lives";
            this.lives.Click += new System.EventHandler(this.openGLControl1_Load);
            // 
            // score
            // 
            this.score.AutoSize = true;
            this.score.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.score.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.score.Location = new System.Drawing.Point(78, 19);
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(47, 19);
            this.score.TabIndex = 2;
            this.score.Text = "Score";
            this.score.Click += new System.EventHandler(this.openGLControl1_Load);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Red;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(629, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "D";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Lime;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(666, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 31);
            this.label2.TabIndex = 4;
            this.label2.Text = "K";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Blue;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(629, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 31);
            this.label3.TabIndex = 5;
            this.label3.Text = "M";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Yellow;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(666, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 31);
            this.label4.TabIndex = 6;
            this.label4.Text = "C";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Cyan;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(703, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 31);
            this.label5.TabIndex = 7;
            this.label5.Text = "S";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Fuchsia;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(703, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 31);
            this.label6.TabIndex = 8;
            this.label6.Text = "L";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // level
            // 
            this.level.AutoSize = true;
            this.level.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.level.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.level.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.level.Location = new System.Drawing.Point(156, 19);
            this.level.Name = "level";
            this.level.Size = new System.Drawing.Size(44, 19);
            this.level.TabIndex = 9;
            this.level.Text = "Level";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.level);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.score);
            this.Controls.Add(this.lives);
            this.Controls.Add(this.openGLControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.openGLControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SharpGL.OpenGLControl openGLControl1;
        private System.Windows.Forms.Label lives;
        private System.Windows.Forms.Label score;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label level;
    }
}

