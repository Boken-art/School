namespace Shool2
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.homePage1 = new Shool2.HomePage();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.surename = new System.Windows.Forms.Label();
            this.textBoxSur = new System.Windows.Forms.TextBox();
            this.pass = new System.Windows.Forms.Label();
            this.name1 = new System.Windows.Forms.Label();
            this.textBoxPasword = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Shool2.Properties.Resources.Avatar;
            this.pictureBox1.Location = new System.Drawing.Point(36, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(72, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image) (resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(36, 138);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(72, 70);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Fuchsia;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(393, 559);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Indigo;
            this.panel2.Controls.Add(this.homePage1);
            this.panel2.Controls.Add(this.richTextBox1);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.dateTimePicker1);
            this.panel2.Controls.Add(this.surename);
            this.panel2.Controls.Add(this.textBoxSur);
            this.panel2.Controls.Add(this.pass);
            this.panel2.Controls.Add(this.name1);
            this.panel2.Controls.Add(this.textBoxPasword);
            this.panel2.Controls.Add(this.textBoxName);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(365, 535);
            this.panel2.TabIndex = 3;
            // 
            // homePage1
            // 
            this.homePage1.Location = new System.Drawing.Point(-12, -12);
            this.homePage1.Name = "homePage1";
            this.homePage1.Size = new System.Drawing.Size(395, 559);
            this.homePage1.TabIndex = 19;
            this.homePage1.Load += new System.EventHandler(this.homePage1_Load);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(57, 358);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(272, 20);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Fuchsia;
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(57, 483);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(272, 49);
            this.button1.TabIndex = 4;
            this.button1.Text = "Create User";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.sendText);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(141, 212);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(139, 20);
            this.dateTimePicker1.TabIndex = 18;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // surename
            // 
            this.surename.AutoSize = true;
            this.surename.BackColor = System.Drawing.Color.White;
            this.surename.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.surename.Location = new System.Drawing.Point(165, 86);
            this.surename.Name = "surename";
            this.surename.Size = new System.Drawing.Size(83, 13);
            this.surename.TabIndex = 17;
            this.surename.Text = "Enter Surename";
            // 
            // textBoxSur
            // 
            this.textBoxSur.Location = new System.Drawing.Point(141, 83);
            this.textBoxSur.Name = "textBoxSur";
            this.textBoxSur.Size = new System.Drawing.Size(139, 20);
            this.textBoxSur.TabIndex = 16;
            this.textBoxSur.Click += new System.EventHandler(this.textBoxSur_TextChanged);
            this.textBoxSur.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // pass
            // 
            this.pass.AutoSize = true;
            this.pass.BackColor = System.Drawing.Color.White;
            this.pass.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pass.Location = new System.Drawing.Point(165, 160);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(81, 13);
            this.pass.TabIndex = 9;
            this.pass.Text = "Enter Password";
            this.pass.Click += new System.EventHandler(this.label3_Click);
            // 
            // name1
            // 
            this.name1.AutoSize = true;
            this.name1.BackColor = System.Drawing.Color.White;
            this.name1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.name1.Location = new System.Drawing.Point(165, 36);
            this.name1.Name = "name1";
            this.name1.Size = new System.Drawing.Size(63, 13);
            this.name1.TabIndex = 7;
            this.name1.Text = "Enter Name";
            // 
            // textBoxPasword
            // 
            this.textBoxPasword.Location = new System.Drawing.Point(141, 157);
            this.textBoxPasword.Name = "textBoxPasword";
            this.textBoxPasword.Size = new System.Drawing.Size(139, 20);
            this.textBoxPasword.TabIndex = 3;
            this.textBoxPasword.Click += new System.EventHandler(this.textBoxPasword_TextChanged);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(141, 33);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(139, 20);
            this.textBoxName.TabIndex = 2;
            this.textBoxName.Click += new System.EventHandler(this.textBoxName_TextChanged);
            this.textBoxName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 559);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
        }

        private Shool2.HomePage homePage1;

        private System.Windows.Forms.DateTimePicker dateTimePicker1;

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBoxSur;
        private System.Windows.Forms.Label pass;
        private System.Windows.Forms.Label name1;
        private System.Windows.Forms.TextBox textBoxPasword;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label surename;
    }
}

