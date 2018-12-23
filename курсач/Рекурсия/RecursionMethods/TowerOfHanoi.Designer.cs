namespace RecursionMethods
{
    partial class TowerOfHanoi
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
            this.textBoxCountDisk = new System.Windows.Forms.TextBox();
            this.buttonHanoi = new System.Windows.Forms.Button();
            this.listBoxHanoi = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(61, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Задача о Ханойской башне";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(112, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Количество дисков";
            // 
            // textBoxCountDisk
            // 
            this.textBoxCountDisk.Location = new System.Drawing.Point(129, 115);
            this.textBoxCountDisk.Name = "textBoxCountDisk";
            this.textBoxCountDisk.Size = new System.Drawing.Size(100, 20);
            this.textBoxCountDisk.TabIndex = 2;
            // 
            // buttonHanoi
            // 
            this.buttonHanoi.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonHanoi.Location = new System.Drawing.Point(142, 158);
            this.buttonHanoi.Name = "buttonHanoi";
            this.buttonHanoi.Size = new System.Drawing.Size(75, 23);
            this.buttonHanoi.TabIndex = 3;
            this.buttonHanoi.Text = "Решить ";
            this.buttonHanoi.UseVisualStyleBackColor = false;
            this.buttonHanoi.Click += new System.EventHandler(this.buttonHanoi_Click);
            // 
            // listBoxHanoi
            // 
            this.listBoxHanoi.FormattingEnabled = true;
            this.listBoxHanoi.Location = new System.Drawing.Point(36, 221);
            this.listBoxHanoi.Name = "listBoxHanoi";
            this.listBoxHanoi.Size = new System.Drawing.Size(295, 95);
            this.listBoxHanoi.TabIndex = 4;
            // 
            // TowerOfHanoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 328);
            this.Controls.Add(this.listBoxHanoi);
            this.Controls.Add(this.buttonHanoi);
            this.Controls.Add(this.textBoxCountDisk);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TowerOfHanoi";
            this.Text = "TowerOfHanoi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxCountDisk;
        private System.Windows.Forms.Button buttonHanoi;
        private System.Windows.Forms.ListBox listBoxHanoi;
    }
}