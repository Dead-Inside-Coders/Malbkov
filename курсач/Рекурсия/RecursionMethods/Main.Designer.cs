namespace RecursionMethods
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
            this.labelTitle = new System.Windows.Forms.Label();
            this.buttonHanoi = new System.Windows.Forms.Button();
            this.buttonQuickSort = new System.Windows.Forms.Button();
            this.buttonMergeSort = new System.Windows.Forms.Button();
            this.buttonStairs = new System.Windows.Forms.Button();
            this.buttonChairs = new System.Windows.Forms.Button();
            this.buttonFibonachi = new System.Windows.Forms.Button();
            this.buttonHappyTicket = new System.Windows.Forms.Button();
            this.buttonZero = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTitle.Location = new System.Drawing.Point(276, 39);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(245, 25);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Рекурсивные методы";
            this.labelTitle.Click += new System.EventHandler(this.labelTitle_Click);
            // 
            // buttonHanoi
            // 
            this.buttonHanoi.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonHanoi.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonHanoi.Location = new System.Drawing.Point(99, 102);
            this.buttonHanoi.Name = "buttonHanoi";
            this.buttonHanoi.Size = new System.Drawing.Size(158, 60);
            this.buttonHanoi.TabIndex = 1;
            this.buttonHanoi.Text = "Задача о ханойской башне";
            this.buttonHanoi.UseVisualStyleBackColor = false;
            this.buttonHanoi.Click += new System.EventHandler(this.buttonHanoi_Click);
            // 
            // buttonQuickSort
            // 
            this.buttonQuickSort.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonQuickSort.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonQuickSort.Location = new System.Drawing.Point(324, 102);
            this.buttonQuickSort.Name = "buttonQuickSort";
            this.buttonQuickSort.Size = new System.Drawing.Size(158, 60);
            this.buttonQuickSort.TabIndex = 2;
            this.buttonQuickSort.Text = "Быстрая сортировка";
            this.buttonQuickSort.UseVisualStyleBackColor = false;
            this.buttonQuickSort.Click += new System.EventHandler(this.buttonQuickSort_Click);
            // 
            // buttonMergeSort
            // 
            this.buttonMergeSort.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonMergeSort.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonMergeSort.Location = new System.Drawing.Point(555, 102);
            this.buttonMergeSort.Name = "buttonMergeSort";
            this.buttonMergeSort.Size = new System.Drawing.Size(158, 60);
            this.buttonMergeSort.TabIndex = 3;
            this.buttonMergeSort.Text = "Сортировка слиянием";
            this.buttonMergeSort.UseVisualStyleBackColor = false;
            this.buttonMergeSort.Click += new System.EventHandler(this.buttonMergeSort_Click);
            // 
            // buttonStairs
            // 
            this.buttonStairs.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonStairs.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonStairs.Location = new System.Drawing.Point(555, 211);
            this.buttonStairs.Name = "buttonStairs";
            this.buttonStairs.Size = new System.Drawing.Size(158, 60);
            this.buttonStairs.TabIndex = 6;
            this.buttonStairs.Text = "Задача о ступеньках";
            this.buttonStairs.UseVisualStyleBackColor = false;
            this.buttonStairs.Click += new System.EventHandler(this.buttonStairs_Click);
            // 
            // buttonChairs
            // 
            this.buttonChairs.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonChairs.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonChairs.Location = new System.Drawing.Point(324, 211);
            this.buttonChairs.Name = "buttonChairs";
            this.buttonChairs.Size = new System.Drawing.Size(158, 60);
            this.buttonChairs.TabIndex = 5;
            this.buttonChairs.Text = "Задача о стульях";
            this.buttonChairs.UseVisualStyleBackColor = false;
            this.buttonChairs.Click += new System.EventHandler(this.buttonChairs_Click);
            // 
            // buttonFibonachi
            // 
            this.buttonFibonachi.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonFibonachi.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonFibonachi.Location = new System.Drawing.Point(99, 211);
            this.buttonFibonachi.Name = "buttonFibonachi";
            this.buttonFibonachi.Size = new System.Drawing.Size(158, 60);
            this.buttonFibonachi.TabIndex = 4;
            this.buttonFibonachi.Text = "Числа Фиббоначчи";
            this.buttonFibonachi.UseVisualStyleBackColor = false;
            this.buttonFibonachi.Click += new System.EventHandler(this.buttonFibonachi_Click);
            // 
            // buttonHappyTicket
            // 
            this.buttonHappyTicket.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonHappyTicket.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonHappyTicket.Location = new System.Drawing.Point(162, 302);
            this.buttonHappyTicket.Name = "buttonHappyTicket";
            this.buttonHappyTicket.Size = new System.Drawing.Size(158, 60);
            this.buttonHappyTicket.TabIndex = 7;
            this.buttonHappyTicket.Text = "Счастливый билет";
            this.buttonHappyTicket.UseVisualStyleBackColor = false;
            this.buttonHappyTicket.Click += new System.EventHandler(this.buttonHappyTicket_Click);
            // 
            // buttonZero
            // 
            this.buttonZero.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonZero.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonZero.Location = new System.Drawing.Point(476, 302);
            this.buttonZero.Name = "buttonZero";
            this.buttonZero.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonZero.Size = new System.Drawing.Size(158, 60);
            this.buttonZero.TabIndex = 8;
            this.buttonZero.Text = "Числа и нули";
            this.buttonZero.UseVisualStyleBackColor = false;
            this.buttonZero.Click += new System.EventHandler(this.buttonZero_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 374);
            this.Controls.Add(this.buttonZero);
            this.Controls.Add(this.buttonHappyTicket);
            this.Controls.Add(this.buttonStairs);
            this.Controls.Add(this.buttonChairs);
            this.Controls.Add(this.buttonFibonachi);
            this.Controls.Add(this.buttonMergeSort);
            this.Controls.Add(this.buttonQuickSort);
            this.Controls.Add(this.buttonHanoi);
            this.Controls.Add(this.labelTitle);
            this.Name = "Main";
            this.Text = "Рекурсия";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Button buttonHanoi;
        private System.Windows.Forms.Button buttonQuickSort;
        private System.Windows.Forms.Button buttonMergeSort;
        private System.Windows.Forms.Button buttonStairs;
        private System.Windows.Forms.Button buttonChairs;
        private System.Windows.Forms.Button buttonFibonachi;
        private System.Windows.Forms.Button buttonHappyTicket;
        private System.Windows.Forms.Button buttonZero;
    }
}

