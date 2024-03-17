namespace WinFormsApp3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            button3 = new Button();
            textBox6 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1, -4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(290, 173);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.DimGray;
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.ForeColor = Color.White;
            textBox3.Location = new Point(1, 376);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(290, 20);
            textBox3.TabIndex = 6;
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.DimGray;
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.ForeColor = Color.White;
            textBox4.Location = new Point(1, 320);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(290, 20);
            textBox4.TabIndex = 8;
            // 
            // textBox5
            // 
            textBox5.BackColor = Color.DimGray;
            textBox5.BorderStyle = BorderStyle.None;
            textBox5.ForeColor = Color.White;
            textBox5.Location = new Point(1, 261);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(290, 20);
            textBox5.TabIndex = 9;
            // 
            // button3
            // 
            button3.BackColor = Color.DimGray;
            button3.FlatStyle = FlatStyle.Popup;
            button3.ForeColor = Color.White;
            button3.Location = new Point(106, 402);
            button3.Name = "button3";
            button3.Size = new Size(86, 28);
            button3.TabIndex = 10;
            button3.Text = "send";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // textBox6
            // 
            textBox6.BackColor = Color.DimGray;
            textBox6.BorderStyle = BorderStyle.None;
            textBox6.ForeColor = Color.White;
            textBox6.Location = new Point(1, 206);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(290, 20);
            textBox6.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(106, 183);
            label1.Name = "label1";
            label1.Size = new Size(70, 20);
            label1.TabIndex = 12;
            label1.Text = "webhook";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(72, 238);
            label2.Name = "label2";
            label2.Size = new Size(140, 20);
            label2.TabIndex = 13;
            label2.Text = "Username webhook";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(90, 297);
            label3.Name = "label3";
            label3.Size = new Size(102, 20);
            label3.TabIndex = 14;
            label3.Text = "message send";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.White;
            label4.Location = new Point(120, 353);
            label4.Name = "label4";
            label4.Size = new Size(56, 20);
            label4.TabIndex = 15;
            label4.Text = "url img";
            // 
            // button1
            // 
            button1.BackColor = Color.DimGray;
            button1.FlatStyle = FlatStyle.Popup;
            button1.ForeColor = Color.White;
            button1.Location = new Point(106, 436);
            button1.Name = "button1";
            button1.Size = new Size(86, 29);
            button1.TabIndex = 16;
            button1.Text = "delete";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(294, 469);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox6);
            Controls.Add(button3);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "Form1";
            Text = "#mh";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox1;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private Button button3;
        private TextBox textBox6;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button1;
    }
}