namespace lab4
{
    partial class Main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.BinarySearch = new System.Windows.Forms.Button();
            this.BinarySearch_Rec = new System.Windows.Forms.Button();
            this.LinearSearch = new System.Windows.Forms.Button();
            this.InterpolationSearch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(301, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Алгоритмы поиска";
            // 
            // BinarySearch
            // 
            this.BinarySearch.Location = new System.Drawing.Point(42, 104);
            this.BinarySearch.Name = "BinarySearch";
            this.BinarySearch.Size = new System.Drawing.Size(141, 88);
            this.BinarySearch.TabIndex = 1;
            this.BinarySearch.Text = "Бинарный поиск";
            this.BinarySearch.UseVisualStyleBackColor = true;
            this.BinarySearch.Click += new System.EventHandler(this.BinarySearch_Click);
            // 
            // BinarySearch_Rec
            // 
            this.BinarySearch_Rec.Location = new System.Drawing.Point(235, 104);
            this.BinarySearch_Rec.Name = "BinarySearch_Rec";
            this.BinarySearch_Rec.Size = new System.Drawing.Size(141, 88);
            this.BinarySearch_Rec.TabIndex = 2;
            this.BinarySearch_Rec.Text = "Бинарный поиск(Рекурсивный)";
            this.BinarySearch_Rec.UseVisualStyleBackColor = true;
            this.BinarySearch_Rec.Click += new System.EventHandler(this.BinarySearch_Rec_Click);
            // 
            // LinearSearch
            // 
            this.LinearSearch.Location = new System.Drawing.Point(429, 104);
            this.LinearSearch.Name = "LinearSearch";
            this.LinearSearch.Size = new System.Drawing.Size(141, 88);
            this.LinearSearch.TabIndex = 3;
            this.LinearSearch.Text = "Линейный поиск";
            this.LinearSearch.UseVisualStyleBackColor = true;
            this.LinearSearch.Click += new System.EventHandler(this.LinearSearch_Click);
            // 
            // InterpolationSearch
            // 
            this.InterpolationSearch.Location = new System.Drawing.Point(628, 104);
            this.InterpolationSearch.Name = "InterpolationSearch";
            this.InterpolationSearch.Size = new System.Drawing.Size(141, 88);
            this.InterpolationSearch.TabIndex = 5;
            this.InterpolationSearch.Text = "Интерполяционный поиск";
            this.InterpolationSearch.UseVisualStyleBackColor = true;
            this.InterpolationSearch.Click += new System.EventHandler(this.InterpolationSearch_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(800, 325);
            this.Controls.Add(this.InterpolationSearch);
            this.Controls.Add(this.LinearSearch);
            this.Controls.Add(this.BinarySearch_Rec);
            this.Controls.Add(this.BinarySearch);
            this.Controls.Add(this.label1);
            this.Name = "Main";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BinarySearch;
        private System.Windows.Forms.Button BinarySearch_Rec;
        private System.Windows.Forms.Button LinearSearch;
        private System.Windows.Forms.Button InterpolationSearch;
    }
}

