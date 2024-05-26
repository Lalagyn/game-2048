namespace _2048_game
{
    partial class Field_Form
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Field_Form));
            this.Label_field = new System.Windows.Forms.Label();
            this.Small_RadioButton = new System.Windows.Forms.RadioButton();
            this.Classic_RadioButton = new System.Windows.Forms.RadioButton();
            this.Big_RadioButton = new System.Windows.Forms.RadioButton();
            this.Start_game_button = new System.Windows.Forms.Button();
            this.Home_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Label_field
            // 
            this.Label_field.AutoSize = true;
            this.Label_field.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label_field.Location = new System.Drawing.Point(251, 36);
            this.Label_field.Name = "Label_field";
            this.Label_field.Size = new System.Drawing.Size(240, 46);
            this.Label_field.TabIndex = 0;
            this.Label_field.Text = "Вибір поля";
            // 
            // Small_RadioButton
            // 
            this.Small_RadioButton.AutoSize = true;
            this.Small_RadioButton.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Small_RadioButton.Location = new System.Drawing.Point(287, 190);
            this.Small_RadioButton.Name = "Small_RadioButton";
            this.Small_RadioButton.Size = new System.Drawing.Size(157, 30);
            this.Small_RadioButton.TabIndex = 1;
            this.Small_RadioButton.Text = "Малий(3x3)";
            this.Small_RadioButton.UseVisualStyleBackColor = true;
            // 
            // Classic_RadioButton
            // 
            this.Classic_RadioButton.AutoSize = true;
            this.Classic_RadioButton.Checked = true;
            this.Classic_RadioButton.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Classic_RadioButton.Location = new System.Drawing.Point(259, 288);
            this.Classic_RadioButton.Name = "Classic_RadioButton";
            this.Classic_RadioButton.Size = new System.Drawing.Size(200, 30);
            this.Classic_RadioButton.TabIndex = 2;
            this.Classic_RadioButton.TabStop = true;
            this.Classic_RadioButton.Text = "Класичний(4x4)";
            this.Classic_RadioButton.UseVisualStyleBackColor = true;
            // 
            // Big_RadioButton
            // 
            this.Big_RadioButton.AutoSize = true;
            this.Big_RadioButton.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Big_RadioButton.Location = new System.Drawing.Point(274, 396);
            this.Big_RadioButton.Name = "Big_RadioButton";
            this.Big_RadioButton.Size = new System.Drawing.Size(175, 30);
            this.Big_RadioButton.TabIndex = 3;
            this.Big_RadioButton.Text = "Великий(5x5)";
            this.Big_RadioButton.UseVisualStyleBackColor = true;
            // 
            // Start_game_button
            // 
            this.Start_game_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Start_game_button.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Start_game_button.Location = new System.Drawing.Point(286, 513);
            this.Start_game_button.Name = "Start_game_button";
            this.Start_game_button.Size = new System.Drawing.Size(158, 51);
            this.Start_game_button.TabIndex = 4;
            this.Start_game_button.Text = "Почати гру";
            this.Start_game_button.UseVisualStyleBackColor = true;
            this.Start_game_button.Click += new System.EventHandler(this.Start_game_button_Click);
            // 
            // Home_Button
            // 
            this.Home_Button.BackColor = System.Drawing.Color.Gold;
            this.Home_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Home_Button.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Home_Button.Image = ((System.Drawing.Image)(resources.GetObject("Home_Button.Image")));
            this.Home_Button.Location = new System.Drawing.Point(655, 12);
            this.Home_Button.Name = "Home_Button";
            this.Home_Button.Size = new System.Drawing.Size(70, 70);
            this.Home_Button.TabIndex = 20;
            this.Home_Button.UseVisualStyleBackColor = false;
            this.Home_Button.Click += new System.EventHandler(this.Home_Button_Click);
            // 
            // Field_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(737, 848);
            this.Controls.Add(this.Home_Button);
            this.Controls.Add(this.Start_game_button);
            this.Controls.Add(this.Big_RadioButton);
            this.Controls.Add(this.Classic_RadioButton);
            this.Controls.Add(this.Small_RadioButton);
            this.Controls.Add(this.Label_field);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(755, 895);
            this.MinimumSize = new System.Drawing.Size(755, 895);
            this.Name = "Field_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "2048";
          
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label_field;
        private System.Windows.Forms.RadioButton Small_RadioButton;
        private System.Windows.Forms.RadioButton Classic_RadioButton;
        private System.Windows.Forms.RadioButton Big_RadioButton;
        private System.Windows.Forms.Button Start_game_button;
        private System.Windows.Forms.Button Home_Button;
    }
}

