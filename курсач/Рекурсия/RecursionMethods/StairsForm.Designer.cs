namespace RecursionMethods
{
    partial class StairsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StairsForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_CountStairs = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_CountWays = new System.Windows.Forms.TextBox();
            this.buttonStairs = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxMaxJump = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(313, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Задача о зайце и ступенях";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(47, 255);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Количество ступеней(N)";
            // 
            // textBox_CountStairs
            // 
            this.textBox_CountStairs.Location = new System.Drawing.Point(234, 251);
            this.textBox_CountStairs.Name = "textBox_CountStairs";
            this.textBox_CountStairs.Size = new System.Drawing.Size(100, 20);
            this.textBox_CountStairs.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(391, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(423, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Число способов забраться на данное кол-во ступеней";
            // 
            // textBox_CountWays
            // 
            this.textBox_CountWays.Location = new System.Drawing.Point(518, 190);
            this.textBox_CountWays.Name = "textBox_CountWays";
            this.textBox_CountWays.ReadOnly = true;
            this.textBox_CountWays.Size = new System.Drawing.Size(196, 20);
            this.textBox_CountWays.TabIndex = 4;
            // 
            // buttonStairs
            // 
            this.buttonStairs.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonStairs.Location = new System.Drawing.Point(165, 328);
            this.buttonStairs.Name = "buttonStairs";
            this.buttonStairs.Size = new System.Drawing.Size(75, 23);
            this.buttonStairs.TabIndex = 5;
            this.buttonStairs.Text = "Решить";
            this.buttonStairs.UseVisualStyleBackColor = false;
            this.buttonStairs.Click += new System.EventHandler(this.buttonStairs_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox1.Location = new System.Drawing.Point(50, 73);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(304, 165);
            this.richTextBox1.TabIndex = 6;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(47, 294);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Максимальный прыжок(K)";
            // 
            // textBoxMaxJump
            // 
            this.textBoxMaxJump.Location = new System.Drawing.Point(234, 290);
            this.textBoxMaxJump.Name = "textBoxMaxJump";
            this.textBoxMaxJump.Size = new System.Drawing.Size(100, 20);
            this.textBoxMaxJump.TabIndex = 8;
            // 
            // StairsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 363);
            this.Controls.Add(this.textBoxMaxJump);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.buttonStairs);
            this.Controls.Add(this.textBox_CountWays);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_CountStairs);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "StairsForm";
            this.Text = "StairsForm";
           // this.Load += new System.EventHandler(this.StairsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
             
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_CountStairs;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_CountWays;
        private System.Windows.Forms.Button buttonStairs;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxMaxJump;
    }
}