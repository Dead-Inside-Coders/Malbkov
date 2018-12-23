namespace RecursionMethods
{
    partial class MergeSortForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MergeSortForm));
            this.QuickSort = new System.Windows.Forms.GroupBox();
            this.buttonMerge = new System.Windows.Forms.Button();
            this.textBoxMerge_Sort = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxMerge_NotSort = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.QuickSort.SuspendLayout();
            this.SuspendLayout();
            // 
            // QuickSort
            // 
            this.QuickSort.Controls.Add(this.buttonMerge);
            this.QuickSort.Controls.Add(this.textBoxMerge_Sort);
            this.QuickSort.Controls.Add(this.label1);
            this.QuickSort.Controls.Add(this.textBoxMerge_NotSort);
            this.QuickSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.QuickSort.Location = new System.Drawing.Point(57, 52);
            this.QuickSort.Name = "QuickSort";
            this.QuickSort.Size = new System.Drawing.Size(278, 248);
            this.QuickSort.TabIndex = 6;
            this.QuickSort.TabStop = false;
            this.QuickSort.Text = "Cортировка слиянием";
            // 
            // buttonMerge
            // 
            this.buttonMerge.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonMerge.Location = new System.Drawing.Point(61, 151);
            this.buttonMerge.Name = "buttonMerge";
            this.buttonMerge.Size = new System.Drawing.Size(146, 31);
            this.buttonMerge.TabIndex = 3;
            this.buttonMerge.Text = "Сортировать";
            this.buttonMerge.UseVisualStyleBackColor = false;
            this.buttonMerge.Click += new System.EventHandler(this.buttonMerge_Click);
            // 
            // textBoxMerge_Sort
            // 
            this.textBoxMerge_Sort.Location = new System.Drawing.Point(22, 206);
            this.textBoxMerge_Sort.Name = "textBoxMerge_Sort";
            this.textBoxMerge_Sort.ReadOnly = true;
            this.textBoxMerge_Sort.Size = new System.Drawing.Size(229, 26);
            this.textBoxMerge_Sort.TabIndex = 2;
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
            // textBoxMerge_NotSort
            // 
            this.textBoxMerge_NotSort.Location = new System.Drawing.Point(22, 81);
            this.textBoxMerge_NotSort.Name = "textBoxMerge_NotSort";
            this.textBoxMerge_NotSort.Size = new System.Drawing.Size(229, 26);
            this.textBoxMerge_NotSort.TabIndex = 0;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox1.Location = new System.Drawing.Point(407, 52);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(307, 113);
            this.richTextBox1.TabIndex = 7;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // MergeSortForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 341);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.QuickSort);
            this.Name = "MergeSortForm";
            this.Text = "MergeSortForm";
            this.QuickSort.ResumeLayout(false);
            this.QuickSort.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox QuickSort;
        private System.Windows.Forms.Button buttonMerge;
        private System.Windows.Forms.TextBox textBoxMerge_Sort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxMerge_NotSort;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}