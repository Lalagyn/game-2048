namespace _2048_game
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.label1 = new System.Windows.Forms.Label();
            this.New_Game_Button = new System.Windows.Forms.Button();
            this.About_button = new System.Windows.Forms.Button();
            this.Exit_button = new System.Windows.Forms.Button();
            this.explanation_button = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(307, 217);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Меню";
            // 
            // New_Game_Button
            // 
            this.New_Game_Button.BackColor = System.Drawing.Color.Gold;
            this.New_Game_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.New_Game_Button.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.New_Game_Button.Location = new System.Drawing.Point(276, 300);
            this.New_Game_Button.Name = "New_Game_Button";
            this.New_Game_Button.Size = new System.Drawing.Size(200, 75);
            this.New_Game_Button.TabIndex = 1;
            this.New_Game_Button.Text = "Почати гру";
            this.New_Game_Button.UseVisualStyleBackColor = false;
            this.New_Game_Button.Click += new System.EventHandler(this.New_Game_Button_Click);
            // 
            // About_button
            // 
            this.About_button.BackColor = System.Drawing.Color.Gold;
            this.About_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.About_button.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.About_button.Location = new System.Drawing.Point(276, 404);
            this.About_button.Name = "About_button";
            this.About_button.Size = new System.Drawing.Size(200, 75);
            this.About_button.TabIndex = 3;
            this.About_button.Text = "Про гру";
            this.About_button.UseVisualStyleBackColor = false;
            this.About_button.Click += new System.EventHandler(this.About_button_Click);
            // 
            // Exit_button
            // 
            this.Exit_button.BackColor = System.Drawing.Color.Gold;
            this.Exit_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Exit_button.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Exit_button.Location = new System.Drawing.Point(276, 610);
            this.Exit_button.Name = "Exit_button";
            this.Exit_button.Size = new System.Drawing.Size(200, 75);
            this.Exit_button.TabIndex = 4;
            this.Exit_button.Text = "Вихід";
            this.Exit_button.UseVisualStyleBackColor = false;
            this.Exit_button.Click += new System.EventHandler(this.Exit_button_Click);
            // 
            // explanation_button
            // 
            this.explanation_button.BackColor = System.Drawing.Color.Gold;
            this.explanation_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.explanation_button.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.explanation_button.Location = new System.Drawing.Point(276, 510);
            this.explanation_button.Name = "explanation_button";
            this.explanation_button.Size = new System.Drawing.Size(200, 75);
            this.explanation_button.TabIndex = 5;
            this.explanation_button.Text = "Пояснення гри";
            this.explanation_button.UseVisualStyleBackColor = false;
            this.explanation_button.Click += new System.EventHandler(this.explanation_button_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(288, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(165, 157);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(737, 848);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.explanation_button);
            this.Controls.Add(this.Exit_button);
            this.Controls.Add(this.About_button);
            this.Controls.Add(this.New_Game_Button);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(755, 895);
            this.MinimumSize = new System.Drawing.Size(755, 895);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "2048";
     
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button New_Game_Button;
        private System.Windows.Forms.Button About_button;
        private System.Windows.Forms.Button Exit_button;
        private System.Windows.Forms.Button explanation_button;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}