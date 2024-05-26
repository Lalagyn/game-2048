namespace _2048_game
{
    partial class Field4x4_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Field4x4_Form));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.pressW = new System.Windows.Forms.Label();
            this.pressA = new System.Windows.Forms.Label();
            this.pressS = new System.Windows.Forms.Label();
            this.pressD = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Score_label1 = new System.Windows.Forms.Label();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.resetGameButton = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.PlayAgain = new System.Windows.Forms.Button();
            this.gameOverLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.backToMenuButton = new System.Windows.Forms.Button();
            this.Win_label = new System.Windows.Forms.Label();
            this.congratulations_label = new System.Windows.Forms.Label();
            this.gameOverPanel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.gameOverPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            
            // 
            // pressW
            // 
            this.pressW.AutoSize = true;
            this.pressW.BackColor = System.Drawing.Color.CornflowerBlue;
            this.pressW.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pressW.ForeColor = System.Drawing.SystemColors.Control;
            this.pressW.Location = new System.Drawing.Point(52, 0);
            this.pressW.Name = "pressW";
            this.pressW.Padding = new System.Windows.Forms.Padding(1, 5, 1, 5);
            this.pressW.Size = new System.Drawing.Size(46, 45);
            this.pressW.TabIndex = 0;
            this.pressW.Text = "W";
            // 
            // pressA
            // 
            this.pressA.AutoSize = true;
            this.pressA.BackColor = System.Drawing.Color.CornflowerBlue;
            this.pressA.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pressA.ForeColor = System.Drawing.SystemColors.Control;
            this.pressA.Location = new System.Drawing.Point(3, 53);
            this.pressA.Name = "pressA";
            this.pressA.Padding = new System.Windows.Forms.Padding(5, 5, 4, 5);
            this.pressA.Size = new System.Drawing.Size(45, 45);
            this.pressA.TabIndex = 1;
            this.pressA.Text = "A";
            // 
            // pressS
            // 
            this.pressS.AutoSize = true;
            this.pressS.BackColor = System.Drawing.Color.CornflowerBlue;
            this.pressS.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pressS.ForeColor = System.Drawing.SystemColors.Control;
            this.pressS.Location = new System.Drawing.Point(53, 105);
            this.pressS.Name = "pressS";
            this.pressS.Padding = new System.Windows.Forms.Padding(5);
            this.pressS.Size = new System.Drawing.Size(45, 45);
            this.pressS.TabIndex = 2;
            this.pressS.Text = "S";
            // 
            // pressD
            // 
            this.pressD.AutoSize = true;
            this.pressD.BackColor = System.Drawing.Color.CornflowerBlue;
            this.pressD.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pressD.ForeColor = System.Drawing.SystemColors.Control;
            this.pressD.Location = new System.Drawing.Point(102, 53);
            this.pressD.Name = "pressD";
            this.pressD.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pressD.Size = new System.Drawing.Size(45, 45);
            this.pressD.TabIndex = 3;
            this.pressD.Text = "D";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pressD);
            this.panel1.Controls.Add(this.pressS);
            this.panel1.Controls.Add(this.pressA);
            this.panel1.Controls.Add(this.pressW);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(150, 150);
            this.panel1.TabIndex = 22;
            // 
            // Score_label1
            // 
            this.Score_label1.AutoSize = true;
            this.Score_label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Score_label1.Location = new System.Drawing.Point(7, 100);
            this.Score_label1.Name = "Score_label1";
            this.Score_label1.Size = new System.Drawing.Size(133, 35);
            this.Score_label1.TabIndex = 23;
            this.Score_label1.Text = "Рахунок:";
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.BackColor = System.Drawing.Color.Gold;
            this.scoreLabel.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.scoreLabel.ForeColor = System.Drawing.Color.Black;
            this.scoreLabel.Location = new System.Drawing.Point(146, 100);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Padding = new System.Windows.Forms.Padding(35, 5, 35, 5);
            this.scoreLabel.Size = new System.Drawing.Size(95, 37);
            this.scoreLabel.TabIndex = 24;
            this.scoreLabel.Text = "0";
            // 
            // resetGameButton
            // 
            this.resetGameButton.BackColor = System.Drawing.Color.Gold;
            this.resetGameButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.resetGameButton.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.resetGameButton.ForeColor = System.Drawing.Color.White;
            this.resetGameButton.Image = ((System.Drawing.Image)(resources.GetObject("resetGameButton.Image")));
            this.resetGameButton.Location = new System.Drawing.Point(9, 6);
            this.resetGameButton.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.resetGameButton.Name = "resetGameButton";
            this.resetGameButton.Size = new System.Drawing.Size(67, 66);
            this.resetGameButton.TabIndex = 27;
            this.resetGameButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.resetGameButton.Click += new System.EventHandler(this.resetGameButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(311, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(63, 63);
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(311, 81);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(77, 60);
            this.pictureBox2.TabIndex = 29;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.resetGameButton);
            this.panel2.Controls.Add(this.scoreLabel);
            this.panel2.Controls.Add(this.Score_label1);
            this.panel2.Location = new System.Drawing.Point(326, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(399, 150);
            this.panel2.TabIndex = 28;
            // 
            // PlayAgain
            // 
            this.PlayAgain.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.PlayAgain.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PlayAgain.Location = new System.Drawing.Point(69, 371);
            this.PlayAgain.Margin = new System.Windows.Forms.Padding(4);
            this.PlayAgain.Name = "PlayAgain";
            this.PlayAgain.Size = new System.Drawing.Size(180, 65);
            this.PlayAgain.TabIndex = 9;
            this.PlayAgain.Text = "Почати знову";
            this.PlayAgain.UseVisualStyleBackColor = true;
            this.PlayAgain.Click += new System.EventHandler(this.PlayAgain_Click);
            // 
            // gameOverLabel
            // 
            this.gameOverLabel.AutoSize = true;
            this.gameOverLabel.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gameOverLabel.Location = new System.Drawing.Point(133, 83);
            this.gameOverLabel.Name = "gameOverLabel";
            this.gameOverLabel.Size = new System.Drawing.Size(305, 46);
            this.gameOverLabel.TabIndex = 11;
            this.gameOverLabel.Text = "ВИ ПРОГРАЛИ";
            this.gameOverLabel.Visible = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Black;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 185F));
            this.tableLayoutPanel1.Controls.Add(this.label19, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.label18, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.label17, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label16, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label15, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.label14, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.label13, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label12, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label11, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.label10, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label7, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label6, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label5, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label9, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel1.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(81, 245);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 129F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 129F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 129F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 129F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(572, 529);
            this.tableLayoutPanel1.TabIndex = 26;
            // 
            // label19
            // 
            this.label19.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label19.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label19.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label19.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label19.Location = new System.Drawing.Point(434, 399);
            this.label19.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(127, 117);
            this.label19.TabIndex = 19;
            this.label19.Text = " ";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label18
            // 
            this.label18.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label18.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label18.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label18.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label18.Location = new System.Drawing.Point(294, 399);
            this.label18.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(126, 117);
            this.label18.TabIndex = 18;
            this.label18.Text = " ";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label17
            // 
            this.label17.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label17.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label17.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label17.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label17.Location = new System.Drawing.Point(154, 399);
            this.label17.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(126, 117);
            this.label17.TabIndex = 17;
            this.label17.Text = " ";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label16
            // 
            this.label16.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label16.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label16.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label16.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label16.Location = new System.Drawing.Point(14, 399);
            this.label16.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(126, 117);
            this.label16.TabIndex = 16;
            this.label16.Text = " ";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label15.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label15.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label15.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label15.Location = new System.Drawing.Point(434, 270);
            this.label15.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(127, 117);
            this.label15.TabIndex = 15;
            this.label15.Text = " ";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label14.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label14.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label14.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label14.Location = new System.Drawing.Point(294, 270);
            this.label14.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(126, 117);
            this.label14.TabIndex = 14;
            this.label14.Text = " ";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label13.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label13.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label13.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label13.Location = new System.Drawing.Point(154, 270);
            this.label13.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(126, 117);
            this.label13.TabIndex = 13;
            this.label13.Text = " ";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label12.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label12.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label12.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label12.Location = new System.Drawing.Point(14, 270);
            this.label12.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(126, 117);
            this.label12.TabIndex = 12;
            this.label12.Text = " ";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label11.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label11.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label11.Location = new System.Drawing.Point(434, 141);
            this.label11.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(127, 117);
            this.label11.TabIndex = 11;
            this.label11.Text = " ";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label10.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label10.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label10.Location = new System.Drawing.Point(294, 141);
            this.label10.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(126, 117);
            this.label10.TabIndex = 10;
            this.label10.Text = " ";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label8.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label8.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label8.Location = new System.Drawing.Point(14, 141);
            this.label8.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 117);
            this.label8.TabIndex = 8;
            this.label8.Text = " ";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label7.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label7.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label7.Location = new System.Drawing.Point(434, 12);
            this.label7.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 117);
            this.label7.TabIndex = 7;
            this.label7.Text = " ";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label6.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label6.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label6.Location = new System.Drawing.Point(294, 12);
            this.label6.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 117);
            this.label6.TabIndex = 6;
            this.label6.Text = " ";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label5.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label5.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label5.Location = new System.Drawing.Point(154, 12);
            this.label5.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 117);
            this.label5.TabIndex = 9;
            this.label5.Text = " ";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label9.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label9.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label9.Location = new System.Drawing.Point(154, 141);
            this.label9.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(126, 117);
            this.label9.TabIndex = 5;
            this.label9.Text = " ";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label3.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label3.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label3.Location = new System.Drawing.Point(14, 12);
            this.label3.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 117);
            this.label3.TabIndex = 20;
            this.label3.Text = " ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // backToMenuButton
            // 
            this.backToMenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.backToMenuButton.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.backToMenuButton.Location = new System.Drawing.Point(291, 371);
            this.backToMenuButton.Margin = new System.Windows.Forms.Padding(4);
            this.backToMenuButton.Name = "backToMenuButton";
            this.backToMenuButton.Size = new System.Drawing.Size(180, 65);
            this.backToMenuButton.TabIndex = 12;
            this.backToMenuButton.Text = "Вихід в меню";
            this.backToMenuButton.UseVisualStyleBackColor = true;
            this.backToMenuButton.Click += new System.EventHandler(this.backToMenuButton_Click);
            // 
            // Win_label
            // 
            this.Win_label.AutoSize = true;
            this.Win_label.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Win_label.Location = new System.Drawing.Point(143, 89);
            this.Win_label.Name = "Win_label";
            this.Win_label.Size = new System.Drawing.Size(277, 46);
            this.Win_label.TabIndex = 13;
            this.Win_label.Text = "ВИ ВИГРАЛИ";
            this.Win_label.Visible = false;
            // 
            // congratulations_label
            // 
            this.congratulations_label.AutoSize = true;
            this.congratulations_label.BackColor = System.Drawing.Color.Orange;
            this.congratulations_label.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.congratulations_label.ForeColor = System.Drawing.Color.White;
            this.congratulations_label.Location = new System.Drawing.Point(200, 240);
            this.congratulations_label.Name = "congratulations_label";
            this.congratulations_label.Size = new System.Drawing.Size(151, 35);
            this.congratulations_label.TabIndex = 14;
            this.congratulations_label.Text = "Вітаємо!!!";
            this.congratulations_label.Visible = false;
            // 
            // gameOverPanel
            // 
            this.gameOverPanel.BackColor = System.Drawing.Color.Orange;
            this.gameOverPanel.Controls.Add(this.congratulations_label);
            this.gameOverPanel.Controls.Add(this.Win_label);
            this.gameOverPanel.Controls.Add(this.backToMenuButton);
            this.gameOverPanel.Controls.Add(this.gameOverLabel);
            this.gameOverPanel.Controls.Add(this.PlayAgain);
            this.gameOverPanel.Location = new System.Drawing.Point(81, 245);
            this.gameOverPanel.Name = "gameOverPanel";
            this.gameOverPanel.Size = new System.Drawing.Size(572, 529);
            this.gameOverPanel.TabIndex = 29;
            this.gameOverPanel.Visible = false;
           
            // 
            // Field4x4_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(737, 848);
            this.Controls.Add(this.gameOverPanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(755, 895);
            this.MinimumSize = new System.Drawing.Size(755, 895);
            this.Name = "Field4x4_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "2048";
            
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyPress);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.gameOverPanel.ResumeLayout(false);
            this.gameOverPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label pressW;
        private System.Windows.Forms.Label pressA;
        private System.Windows.Forms.Label pressS;
        private System.Windows.Forms.Label pressD;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Score_label1;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Label resetGameButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button PlayAgain;
        private System.Windows.Forms.Label gameOverLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button backToMenuButton;
        private System.Windows.Forms.Label Win_label;
        private System.Windows.Forms.Label congratulations_label;
        private System.Windows.Forms.Panel gameOverPanel;
    }
}