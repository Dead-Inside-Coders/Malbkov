﻿namespace lab4
{
    partial class InterpolationSearchForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxArr = new System.Windows.Forms.TextBox();
            this.buttonFind = new System.Windows.Forms.Button();
            this.textBoxPosition = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxElement = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(221, 62);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 23);
            this.button1.TabIndex = 49;
            this.button1.Text = "Сгенерировать ";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(48, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 48;
            this.label1.Text = "Массив :";
            // 
            // textBoxArr
            // 
            this.textBoxArr.Location = new System.Drawing.Point(52, 104);
            this.textBoxArr.Multiline = true;
            this.textBoxArr.Name = "textBoxArr";
            this.textBoxArr.Size = new System.Drawing.Size(289, 27);
            this.textBoxArr.TabIndex = 47;
            // 
            // buttonFind
            // 
            this.buttonFind.Location = new System.Drawing.Point(131, 224);
            this.buttonFind.Name = "buttonFind";
            this.buttonFind.Size = new System.Drawing.Size(123, 39);
            this.buttonFind.TabIndex = 46;
            this.buttonFind.Text = "Найти ";
            this.buttonFind.UseVisualStyleBackColor = true;
            // 
            // textBoxPosition
            // 
            this.textBoxPosition.Location = new System.Drawing.Point(193, 300);
            this.textBoxPosition.Name = "textBoxPosition";
            this.textBoxPosition.Size = new System.Drawing.Size(100, 20);
            this.textBoxPosition.TabIndex = 45;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(99, 300);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 20);
            this.label4.TabIndex = 44;
            this.label4.Text = "Позиция:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(48, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 20);
            this.label3.TabIndex = 43;
            this.label3.Text = "Поиск элемента :";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox1.Location = new System.Drawing.Point(421, 65);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(332, 275);
            this.richTextBox1.TabIndex = 42;
            this.richTextBox1.Text = " ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(416, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(271, 25);
            this.label2.TabIndex = 41;
            this.label2.Text = "Интерполяционный поиск";
            // 
            // textBoxElement
            // 
            this.textBoxElement.Location = new System.Drawing.Point(208, 173);
            this.textBoxElement.Name = "textBoxElement";
            this.textBoxElement.Size = new System.Drawing.Size(58, 20);
            this.textBoxElement.TabIndex = 40;
            // 
            // InterpolationSearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 360);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxArr);
            this.Controls.Add(this.buttonFind);
            this.Controls.Add(this.textBoxPosition);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxElement);
            this.Name = "InterpolationSearchForm";
            this.Text = "LinearFormWithSentitel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxArr;
        private System.Windows.Forms.Button buttonFind;
        private System.Windows.Forms.TextBox textBoxPosition;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxElement;
    }
}