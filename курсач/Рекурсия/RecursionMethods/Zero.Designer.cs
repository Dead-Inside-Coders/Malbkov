namespace RecursionMethods
{
    partial class Zero
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonTask1 = new System.Windows.Forms.Button();
            this.textBoxR1 = new System.Windows.Forms.TextBox();
            this.textBoxK1 = new System.Windows.Forms.TextBox();
            this.textBoxN1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonTask3 = new System.Windows.Forms.Button();
            this.textBoxR3 = new System.Windows.Forms.TextBox();
            this.textBoxK3 = new System.Windows.Forms.TextBox();
            this.textBoxN3 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonTask1);
            this.groupBox1.Controls.Add(this.textBoxR1);
            this.groupBox1.Controls.Add(this.textBoxK1);
            this.groupBox1.Controls.Add(this.textBoxN1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(48, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(314, 251);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Нахождение числа n-разрядных чисел в системе с основанием k не содержащих двух ну" +
    "лей подряд";
            // 
            // buttonTask1
            // 
            this.buttonTask1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonTask1.Location = new System.Drawing.Point(181, 78);
            this.buttonTask1.Name = "buttonTask1";
            this.buttonTask1.Size = new System.Drawing.Size(75, 23);
            this.buttonTask1.TabIndex = 8;
            this.buttonTask1.Text = "Найти ";
            this.buttonTask1.UseVisualStyleBackColor = false;
            this.buttonTask1.Click += new System.EventHandler(this.buttonTask1_Click);
            // 
            // textBoxR1
            // 
            this.textBoxR1.Location = new System.Drawing.Point(116, 162);
            this.textBoxR1.Name = "textBoxR1";
            this.textBoxR1.ReadOnly = true;
            this.textBoxR1.Size = new System.Drawing.Size(162, 20);
            this.textBoxR1.TabIndex = 1;
            // 
            // textBoxK1
            // 
            this.textBoxK1.Location = new System.Drawing.Point(59, 108);
            this.textBoxK1.Name = "textBoxK1";
            this.textBoxK1.Size = new System.Drawing.Size(75, 20);
            this.textBoxK1.TabIndex = 1;
            // 
            // textBoxN1
            // 
            this.textBoxN1.Location = new System.Drawing.Point(59, 63);
            this.textBoxN1.Name = "textBoxN1";
            this.textBoxN1.Size = new System.Drawing.Size(75, 20);
            this.textBoxN1.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Искомое число:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "k=";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "n=";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.buttonTask3);
            this.groupBox3.Controls.Add(this.textBoxR3);
            this.groupBox3.Controls.Add(this.textBoxK3);
            this.groupBox3.Controls.Add(this.textBoxN3);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Location = new System.Drawing.Point(426, 45);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(339, 251);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Нахождение числа n-разрядных чисел в системе с основанием k, не содержащих двух н" +
    "улей подряд и заканчивающихся цифрой, отличной от нуля";
            // 
            // buttonTask3
            // 
            this.buttonTask3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonTask3.Location = new System.Drawing.Point(198, 73);
            this.buttonTask3.Name = "buttonTask3";
            this.buttonTask3.Size = new System.Drawing.Size(75, 23);
            this.buttonTask3.TabIndex = 14;
            this.buttonTask3.Text = "Найти ";
            this.buttonTask3.UseVisualStyleBackColor = false;
            this.buttonTask3.Click += new System.EventHandler(this.buttonTask3_Click);
            // 
            // textBoxR3
            // 
            this.textBoxR3.Location = new System.Drawing.Point(122, 172);
            this.textBoxR3.Name = "textBoxR3";
            this.textBoxR3.ReadOnly = true;
            this.textBoxR3.Size = new System.Drawing.Size(197, 20);
            this.textBoxR3.TabIndex = 8;
            // 
            // textBoxK3
            // 
            this.textBoxK3.Location = new System.Drawing.Point(65, 118);
            this.textBoxK3.Name = "textBoxK3";
            this.textBoxK3.Size = new System.Drawing.Size(75, 20);
            this.textBoxK3.TabIndex = 9;
            // 
            // textBoxN3
            // 
            this.textBoxN3.Location = new System.Drawing.Point(65, 73);
            this.textBoxN3.Name = "textBoxN3";
            this.textBoxN3.Size = new System.Drawing.Size(75, 20);
            this.textBoxN3.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 175);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Искомое число:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(28, 121);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(19, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "k=";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(28, 73);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(19, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "n=";
            // 
            // Zero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 319);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "Zero";
            this.Text = "Zero";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxR1;
        private System.Windows.Forms.TextBox textBoxK1;
        private System.Windows.Forms.TextBox textBoxN1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBoxR3;
        private System.Windows.Forms.TextBox textBoxK3;
        private System.Windows.Forms.TextBox textBoxN3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.Button buttonTask1;
        public System.Windows.Forms.Button buttonTask3;
    }
}