namespace RecursionMethods
{
    partial class QSortForm
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.QuickSort = new System.Windows.Forms.GroupBox();
            this.buttonQuick = new System.Windows.Forms.Button();
            this.textBoxQuick_Sort = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxQuick_NotSort = new System.Windows.Forms.TextBox();
            this.QuickSort.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox1.Location = new System.Drawing.Point(240, 306);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(307, 101);
            this.richTextBox1.TabIndex = 6;
            this.richTextBox1.Text = "Быстрая сортировка, сортировка Хоара  — широко известный алгоритм сортировки, раз" +
    "работанный английским информатиком Чарльзом Хоаром во время его работы в МГУ в 1" +
    "960 году.";
            // 
            // QuickSort
            // 
            this.QuickSort.Controls.Add(this.buttonQuick);
            this.QuickSort.Controls.Add(this.textBoxQuick_Sort);
            this.QuickSort.Controls.Add(this.label1);
            this.QuickSort.Controls.Add(this.textBoxQuick_NotSort);
            this.QuickSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.QuickSort.Location = new System.Drawing.Point(254, 42);
            this.QuickSort.Name = "QuickSort";
            this.QuickSort.Size = new System.Drawing.Size(278, 248);
            this.QuickSort.TabIndex = 5;
            this.QuickSort.TabStop = false;
            this.QuickSort.Text = "Быстрая сортировка";
            // 
            // buttonQuick
            // 
            this.buttonQuick.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonQuick.Location = new System.Drawing.Point(61, 151);
            this.buttonQuick.Name = "buttonQuick";
            this.buttonQuick.Size = new System.Drawing.Size(146, 31);
            this.buttonQuick.TabIndex = 3;
            this.buttonQuick.Text = "Сортировать";
            this.buttonQuick.UseVisualStyleBackColor = false;
            this.buttonQuick.Click += new System.EventHandler(this.buttonQuick_Click);
            // 
            // textBoxQuick_Sort
            // 
            this.textBoxQuick_Sort.Location = new System.Drawing.Point(22, 206);
            this.textBoxQuick_Sort.Name = "textBoxQuick_Sort";
            this.textBoxQuick_Sort.ReadOnly = true;
            this.textBoxQuick_Sort.Size = new System.Drawing.Size(229, 26);
            this.textBoxQuick_Sort.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(19, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Массив из чисел(через пробел)";
            // 
            // textBoxQuick_NotSort
            // 
            this.textBoxQuick_NotSort.Location = new System.Drawing.Point(22, 81);
            this.textBoxQuick_NotSort.Name = "textBoxQuick_NotSort";
            this.textBoxQuick_NotSort.Size = new System.Drawing.Size(229, 26);
            this.textBoxQuick_NotSort.TabIndex = 0;
            // 
            // QSortForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 419);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.QuickSort);
            this.Name = "QSortForm";
            this.Text = "QSortForm";
            this.QuickSort.ResumeLayout(false);
            this.QuickSort.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.GroupBox QuickSort;
        private System.Windows.Forms.Button buttonQuick;
        private System.Windows.Forms.TextBox textBoxQuick_Sort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxQuick_NotSort;
    }
}