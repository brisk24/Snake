namespace Snake_videosharp.info_
{
    partial class FormMenu
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
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.labelStart = new System.Windows.Forms.Label();
            this.labelSettings = new System.Windows.Forms.Label();
            this.labelExit = new System.Windows.Forms.Label();
            this.labelСopyright = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox.Image = global::Snake_videosharp.info_.Properties.Resources.fon;
            this.pictureBox.Location = new System.Drawing.Point(0, 0);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(800, 450);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // labelStart
            // 
            this.labelStart.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelStart.Location = new System.Drawing.Point(296, 167);
            this.labelStart.Name = "labelStart";
            this.labelStart.Size = new System.Drawing.Size(164, 41);
            this.labelStart.TabIndex = 1;
            this.labelStart.Text = "Новая игра";
            this.labelStart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelStart.Click += new System.EventHandler(this.labelStart_Click);
            this.labelStart.MouseLeave += new System.EventHandler(this.labelStart_MouseLeave);
            this.labelStart.MouseHover += new System.EventHandler(this.labelStart_MouseHover);
            // 
            // labelSettings
            // 
            this.labelSettings.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSettings.Location = new System.Drawing.Point(296, 228);
            this.labelSettings.Name = "labelSettings";
            this.labelSettings.Size = new System.Drawing.Size(164, 35);
            this.labelSettings.TabIndex = 2;
            this.labelSettings.Text = "Настройки";
            this.labelSettings.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelSettings.MouseLeave += new System.EventHandler(this.labelStart_MouseLeave);
            this.labelSettings.MouseHover += new System.EventHandler(this.labelStart_MouseHover);
            // 
            // labelExit
            // 
            this.labelExit.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelExit.Location = new System.Drawing.Point(296, 287);
            this.labelExit.Name = "labelExit";
            this.labelExit.Size = new System.Drawing.Size(164, 35);
            this.labelExit.TabIndex = 3;
            this.labelExit.Text = "Выход";
            this.labelExit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelExit.Click += new System.EventHandler(this.labelExit_Click);
            this.labelExit.MouseLeave += new System.EventHandler(this.labelStart_MouseLeave);
            this.labelExit.MouseHover += new System.EventHandler(this.labelStart_MouseHover);
            // 
            // labelСopyright
            // 
            this.labelСopyright.AutoSize = true;
            this.labelСopyright.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelСopyright.ForeColor = System.Drawing.Color.Silver;
            this.labelСopyright.Location = new System.Drawing.Point(733, 428);
            this.labelСopyright.Name = "labelСopyright";
            this.labelСopyright.Size = new System.Drawing.Size(55, 13);
            this.labelСopyright.TabIndex = 4;
            this.labelСopyright.Text = "brisk24.ru";
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelСopyright);
            this.Controls.Add(this.labelExit);
            this.Controls.Add(this.labelSettings);
            this.Controls.Add(this.labelStart);
            this.Controls.Add(this.pictureBox);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMenu";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Змейка";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label labelStart;
        private System.Windows.Forms.Label labelSettings;
        private System.Windows.Forms.Label labelExit;
        private System.Windows.Forms.Label labelСopyright;
    }
}