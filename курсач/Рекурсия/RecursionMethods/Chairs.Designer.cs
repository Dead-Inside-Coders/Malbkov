namespace RecursionMethods
{
    partial class Chairs
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
            this.textBoxChairs_Guests = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxChairs_Ways = new System.Windows.Forms.TextBox();
            this.buttonChairs = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(276, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Задача о гостях и стульях";
            // 
            // textBoxChairs_Guests
            // 
            this.textBoxChairs_Guests.Location = new System.Drawing.Point(214, 202);
            this.textBoxChairs_Guests.Name = "textBoxChairs_Guests";
            this.textBoxChairs_Guests.Size = new System.Drawing.Size(85, 20);
            this.textBoxChairs_Guests.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(48, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Количество гостей";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(449, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(206, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Число способов рассадки";
           // this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // textBoxChairs_Ways
            // 
            this.textBoxChairs_Ways.Location = new System.Drawing.Point(441, 207);
            this.textBoxChairs_Ways.Name = "textBoxChairs_Ways";
            this.textBoxChairs_Ways.ReadOnly = true;
            this.textBoxChairs_Ways.Size = new System.Drawing.Size(234, 20);
            this.textBoxChairs_Ways.TabIndex = 4;
            // 
            // buttonChairs
            // 
            this.buttonChairs.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonChairs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonChairs.Location = new System.Drawing.Point(113, 250);
            this.buttonChairs.Name = "buttonChairs";
            this.buttonChairs.Size = new System.Drawing.Size(112, 47);
            this.buttonChairs.TabIndex = 6;
            this.buttonChairs.Text = "Решить";
            this.buttonChairs.UseVisualStyleBackColor = false;
            this.buttonChairs.Click += new System.EventHandler(this.buttonChairs_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox1.Location = new System.Drawing.Point(52, 83);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(247, 96);
            this.richTextBox1.TabIndex = 7;
            this.richTextBox1.Text = "Найти число способов, при которых каждый гость сидит не на своем месте ";
            // 
            // Chairs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 359);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.textBoxChairs_Ways);
            this.Controls.Add(this.textBoxChairs_Guests);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonChairs);
            this.Controls.Add(this.label1);
            this.Name = "Chairs";
            this.Text = "Chairs";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxChairs_Guests;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxChairs_Ways;
        private System.Windows.Forms.Button buttonChairs;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}