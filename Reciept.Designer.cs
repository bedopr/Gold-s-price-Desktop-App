namespace RECIEPT
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label label2;
            this.button1 = new System.Windows.Forms.Button();
            this.box = new System.Windows.Forms.TextBox();
            this.boxnumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.weight = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.k21 = new System.Windows.Forms.Label();
            this.k18 = new System.Windows.Forms.Label();
            this.goldprice = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.Location = new System.Drawing.Point(1271, 93);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(49, 29);
            label2.TabIndex = 6;
            label2.Text = "الرقم";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Lime;
            this.button1.Font = new System.Drawing.Font("Gotham", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(23, 638);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(401, 54);
            this.button1.TabIndex = 0;
            this.button1.Text = "PRINT";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // box
            // 
            this.box.Location = new System.Drawing.Point(1051, 59);
            this.box.Name = "box";
            this.box.Size = new System.Drawing.Size(202, 20);
            this.box.TabIndex = 2;
            this.box.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // boxnumber
            // 
            this.boxnumber.Location = new System.Drawing.Point(1052, 102);
            this.boxnumber.Name = "boxnumber";
            this.boxnumber.Size = new System.Drawing.Size(202, 20);
            this.boxnumber.TabIndex = 4;
            this.boxnumber.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1270, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "الاسم";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.ItemHeight = 24;
            this.comboBox1.Items.AddRange(new object[] {
            "غويشه عيار 21",
            "خاتم عيار 21",
            "حلق عيار 21",
            "دبله عيار 21",
            "سلسله عيار 21",
            "انسيال عيار 21",
            "توينز عيار 21",
            "اسوره عيار 21",
            "كوليه عيار 21",
            "دلاية عيار 21",
            "خاتم عيار 18",
            "حلق عيار 18",
            "دبله عيار 18",
            "سلسله عيار 18",
            "انسيال عيار 18",
            "توينز عيار 18",
            "اسوره عيار 18",
            "كوليه عيار 18",
            "دلاية عيار 18",
            "عملة عيار 21",
            "سبيكة عيار 24"});
            this.comboBox1.Location = new System.Drawing.Point(1068, 239);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(202, 32);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1276, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 29);
            this.label3.TabIndex = 8;
            this.label3.Text = "بيان";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1003, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 29);
            this.label4.TabIndex = 9;
            this.label4.Text = "الوزن";
            // 
            // weight
            // 
            this.weight.Location = new System.Drawing.Point(900, 247);
            this.weight.Name = "weight";
            this.weight.Size = new System.Drawing.Size(100, 20);
            this.weight.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(823, 238);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 29);
            this.label5.TabIndex = 11;
            this.label5.Text = "السعر";
            // 
            // price
            // 
            this.price.Location = new System.Drawing.Point(711, 247);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(100, 20);
            this.price.TabIndex = 12;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(917, 340);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(403, 303);
            this.listBox1.TabIndex = 15;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(596, 189);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 38);
            this.button2.TabIndex = 16;
            this.button2.Text = "اضافه";
            this.button2.UseMnemonic = false;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(595, 235);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(92, 37);
            this.button3.TabIndex = 17;
            this.button3.Text = "ازاله";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(581, 285);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(123, 50);
            this.button4.TabIndex = 18;
            this.button4.Text = "ازالة الكل";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1284, 665);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "DATE";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.k21);
            this.panel1.Controls.Add(this.k18);
            this.panel1.Location = new System.Drawing.Point(-3, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(203, 86);
            this.panel1.TabIndex = 20;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(96, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(4, 88);
            this.panel3.TabIndex = 25;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(3, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(199, 4);
            this.panel2.TabIndex = 24;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(116, 52);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 24);
            this.label8.TabIndex = 25;
            this.label8.Text = "عيار 18";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(116, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 24);
            this.label7.TabIndex = 24;
            this.label7.Text = "عيار 21";
            // 
            // k21
            // 
            this.k21.AutoSize = true;
            this.k21.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.k21.Location = new System.Drawing.Point(22, 9);
            this.k21.Name = "k21";
            this.k21.Size = new System.Drawing.Size(16, 24);
            this.k21.TabIndex = 22;
            this.k21.Text = "-";
            this.k21.Click += new System.EventHandler(this.k21_Click);
            // 
            // k18
            // 
            this.k18.AutoSize = true;
            this.k18.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.k18.Location = new System.Drawing.Point(22, 52);
            this.k18.Name = "k18";
            this.k18.Size = new System.Drawing.Size(16, 24);
            this.k18.TabIndex = 21;
            this.k18.Text = "-";
            // 
            // goldprice
            // 
            this.goldprice.Location = new System.Drawing.Point(270, 23);
            this.goldprice.Name = "goldprice";
            this.goldprice.Size = new System.Drawing.Size(100, 20);
            this.goldprice.TabIndex = 21;
            this.goldprice.TextChanged += new System.EventHandler(this.textBox1_TextChanged_2);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(376, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "سعر الذهب 21";
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(218, 19);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(46, 27);
            this.button5.TabIndex = 23;
            this.button5.Text = "ok";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1348, 707);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.goldprice);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.price);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.weight);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.boxnumber);
            this.Controls.Add(this.box);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox box;
        private System.Windows.Forms.TextBox boxnumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox weight;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox price;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label k21;
        private System.Windows.Forms.Label k18;
        private System.Windows.Forms.TextBox goldprice;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
    }
}

