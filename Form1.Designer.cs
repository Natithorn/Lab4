namespace LAB4
{
    partial class Form1
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
            this.textName1 = new System.Windows.Forms.TextBox();
            this.textBirth2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Addbutton1 = new System.Windows.Forms.Button();
            this.AllnametextBox1 = new System.Windows.Forms.TextBox();
            this.AllnumtextBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textGPA1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textGPAavgBox1 = new System.Windows.Forms.TextBox();
            this.textGPAminBox2 = new System.Windows.Forms.TextBox();
            this.textGPAMaxBox3 = new System.Windows.Forms.TextBox();
            this.textShownameMaxBox4 = new System.Windows.Forms.TextBox();
            this.textShownameMinBox5 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textName1
            // 
            this.textName1.Location = new System.Drawing.Point(40, 54);
            this.textName1.Name = "textName1";
            this.textName1.Size = new System.Drawing.Size(150, 31);
            this.textName1.TabIndex = 0;
            this.textName1.TextChanged += new System.EventHandler(this.textName1_TextChanged);
            // 
            // textBirth2
            // 
            this.textBirth2.Location = new System.Drawing.Point(40, 130);
            this.textBirth2.Name = "textBirth2";
            this.textBirth2.Size = new System.Drawing.Size(150, 31);
            this.textBirth2.TabIndex = 1;
            this.textBirth2.TextChanged += new System.EventHandler(this.textBirth2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "ชื่อ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "ปีเกิด";
            // 
            // Addbutton1
            // 
            this.Addbutton1.Location = new System.Drawing.Point(78, 254);
            this.Addbutton1.Name = "Addbutton1";
            this.Addbutton1.Size = new System.Drawing.Size(112, 78);
            this.Addbutton1.TabIndex = 6;
            this.Addbutton1.Text = "Add";
            this.Addbutton1.UseVisualStyleBackColor = true;
            this.Addbutton1.Click += new System.EventHandler(this.Addbutton1_Click);
            // 
            // AllnametextBox1
            // 
            this.AllnametextBox1.Location = new System.Drawing.Point(295, 251);
            this.AllnametextBox1.Multiline = true;
            this.AllnametextBox1.Name = "AllnametextBox1";
            this.AllnametextBox1.Size = new System.Drawing.Size(182, 184);
            this.AllnametextBox1.TabIndex = 7;
            // 
            // AllnumtextBox2
            // 
            this.AllnumtextBox2.Location = new System.Drawing.Point(295, 199);
            this.AllnumtextBox2.Name = "AllnumtextBox2";
            this.AllnumtextBox2.Size = new System.Drawing.Size(182, 31);
            this.AllnumtextBox2.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(231, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "รายชื่อ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(201, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "อายุทั้งหมด";
            // 
            // textGPA1
            // 
            this.textGPA1.Location = new System.Drawing.Point(40, 199);
            this.textGPA1.Name = "textGPA1";
            this.textGPA1.Size = new System.Drawing.Size(150, 31);
            this.textGPA1.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "GPA";
            // 
            // textGPAavgBox1
            // 
            this.textGPAavgBox1.Location = new System.Drawing.Point(364, 143);
            this.textGPAavgBox1.Name = "textGPAavgBox1";
            this.textGPAavgBox1.Size = new System.Drawing.Size(182, 31);
            this.textGPAavgBox1.TabIndex = 13;
            // 
            // textGPAminBox2
            // 
            this.textGPAminBox2.Location = new System.Drawing.Point(363, 92);
            this.textGPAminBox2.Name = "textGPAminBox2";
            this.textGPAminBox2.Size = new System.Drawing.Size(183, 31);
            this.textGPAminBox2.TabIndex = 14;
            // 
            // textGPAMaxBox3
            // 
            this.textGPAMaxBox3.Location = new System.Drawing.Point(363, 42);
            this.textGPAMaxBox3.Name = "textGPAMaxBox3";
            this.textGPAMaxBox3.Size = new System.Drawing.Size(183, 31);
            this.textGPAMaxBox3.TabIndex = 15;
            // 
            // textShownameMaxBox4
            // 
            this.textShownameMaxBox4.Location = new System.Drawing.Point(617, 42);
            this.textShownameMaxBox4.Name = "textShownameMaxBox4";
            this.textShownameMaxBox4.Size = new System.Drawing.Size(150, 31);
            this.textShownameMaxBox4.TabIndex = 16;
            // 
            // textShownameMinBox5
            // 
            this.textShownameMinBox5.Location = new System.Drawing.Point(617, 96);
            this.textShownameMinBox5.Name = "textShownameMinBox5";
            this.textShownameMinBox5.Size = new System.Drawing.Size(150, 31);
            this.textShownameMinBox5.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(567, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 25);
            this.label6.TabIndex = 18;
            this.label6.Text = "ชื่อ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(567, 95);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 25);
            this.label7.TabIndex = 19;
            this.label7.Text = "ชื่อ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(267, 45);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 25);
            this.label8.TabIndex = 20;
            this.label8.Text = "GPAMax";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(267, 95);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 25);
            this.label9.TabIndex = 21;
            this.label9.Text = "GPAMin";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(268, 146);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 25);
            this.label10.TabIndex = 22;
            this.label10.Text = "GPAavg";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textShownameMinBox5);
            this.Controls.Add(this.textShownameMaxBox4);
            this.Controls.Add(this.textGPAMaxBox3);
            this.Controls.Add(this.textGPAminBox2);
            this.Controls.Add(this.textGPAavgBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textGPA1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.AllnumtextBox2);
            this.Controls.Add(this.AllnametextBox1);
            this.Controls.Add(this.Addbutton1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBirth2);
            this.Controls.Add(this.textName1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textName1;
        private TextBox textBirth2;
        private Label label1;
        private Label label2;
        private Button Addbutton1;
        private TextBox AllnametextBox1;
        private TextBox AllnumtextBox2;
        private Label label4;
        private Label label5;
        private TextBox textGPA1;
        private Label label3;
        private TextBox textGPAavgBox1;
        private TextBox textGPAminBox2;
        private TextBox textGPAMaxBox3;
        private TextBox textShownameMaxBox4;
        private TextBox textShownameMinBox5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
    }
}