namespace RecursionMethods
{
    partial class FibonacciForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxRec_Number = new System.Windows.Forms.TextBox();
            this.textBoxRec_Result = new System.Windows.Forms.TextBox();
            this.textBoxLoop_Result = new System.Windows.Forms.TextBox();
            this.textBoxLoop_Number = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonRec = new System.Windows.Forms.Button();
            this.buttonLoop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(139, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Рекурсивный алгоритм";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(139, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Нерекурсивный алгоритм";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(106, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "-ое число Фибоначи:";
            // 
            // textBoxRec_Number
            // 
            this.textBoxRec_Number.Location = new System.Drawing.Point(74, 86);
            this.textBoxRec_Number.Name = "textBoxRec_Number";
            this.textBoxRec_Number.Size = new System.Drawing.Size(26, 20);
            this.textBoxRec_Number.TabIndex = 3;
            // 
            // textBoxRec_Result
            // 
            this.textBoxRec_Result.Location = new System.Drawing.Point(259, 88);
            this.textBoxRec_Result.Name = "textBoxRec_Result";
            this.textBoxRec_Result.Size = new System.Drawing.Size(212, 20);
            this.textBoxRec_Result.TabIndex = 4;
            // 
            // textBoxLoop_Result
            // 
            this.textBoxLoop_Result.Location = new System.Drawing.Point(259, 259);
            this.textBoxLoop_Result.Name = "textBoxLoop_Result";
            this.textBoxLoop_Result.Size = new System.Drawing.Size(212, 20);
            this.textBoxLoop_Result.TabIndex = 7;
            // 
            // textBoxLoop_Number
            // 
            this.textBoxLoop_Number.Location = new System.Drawing.Point(74, 259);
            this.textBoxLoop_Number.Name = "textBoxLoop_Number";
            this.textBoxLoop_Number.Size = new System.Drawing.Size(26, 20);
            this.textBoxLoop_Number.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(106, 262);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "-ое число Фибоначи:";
            // 
            // buttonRec
            // 
            this.buttonRec.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonRec.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonRec.Location = new System.Drawing.Point(188, 136);
            this.buttonRec.Name = "buttonRec";
            this.buttonRec.Size = new System.Drawing.Size(101, 44);
            this.buttonRec.TabIndex = 8;
            this.buttonRec.Text = "Вычислить ";
            this.buttonRec.UseVisualStyleBackColor = false;
            this.buttonRec.Click += new System.EventHandler(this.buttonRec_Click);
            // 
            // buttonLoop
            // 
            this.buttonLoop.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonLoop.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonLoop.Location = new System.Drawing.Point(188, 312);
            this.buttonLoop.Name = "buttonLoop";
            this.buttonLoop.Size = new System.Drawing.Size(101, 44);
            this.buttonLoop.TabIndex = 9;
            this.buttonLoop.Text = "Вычислить ";
            this.buttonLoop.UseVisualStyleBackColor = false;
            this.buttonLoop.Click += new System.EventHandler(this.buttonLoop_Click);
            // 
            // FibonacciForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 383);
            this.Controls.Add(this.buttonLoop);
            this.Controls.Add(this.buttonRec);
            this.Controls.Add(this.textBoxLoop_Result);
            this.Controls.Add(this.textBoxLoop_Number);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxRec_Result);
            this.Controls.Add(this.textBoxRec_Number);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FibonacciForm";
            this.Text = "FibonacciForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxRec_Number;
        private System.Windows.Forms.TextBox textBoxRec_Result;
        private System.Windows.Forms.TextBox textBoxLoop_Result;
        private System.Windows.Forms.TextBox textBoxLoop_Number;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonRec;
        private System.Windows.Forms.Button buttonLoop;
    }
}