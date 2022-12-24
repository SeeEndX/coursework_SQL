namespace coursework_SQL
{
    partial class DelProdForm
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
            this.delBtn = new System.Windows.Forms.Button();
            this.numUpDownDel = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownDel)).BeginInit();
            this.SuspendLayout();
            // 
            // delBtn
            // 
            this.delBtn.BackColor = System.Drawing.Color.IndianRed;
            this.delBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.delBtn.ForeColor = System.Drawing.Color.Black;
            this.delBtn.Location = new System.Drawing.Point(42, 123);
            this.delBtn.Name = "delBtn";
            this.delBtn.Size = new System.Drawing.Size(202, 61);
            this.delBtn.TabIndex = 0;
            this.delBtn.Text = "Удалить";
            this.delBtn.UseVisualStyleBackColor = false;
            this.delBtn.Click += new System.EventHandler(this.delBtn_Click);
            // 
            // numUpDownDel
            // 
            this.numUpDownDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numUpDownDel.Location = new System.Drawing.Point(178, 68);
            this.numUpDownDel.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numUpDownDel.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUpDownDel.Name = "numUpDownDel";
            this.numUpDownDel.Size = new System.Drawing.Size(66, 38);
            this.numUpDownDel.TabIndex = 1;
            this.numUpDownDel.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(36, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "id товара";
            // 
            // DelProdForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(283, 229);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numUpDownDel);
            this.Controls.Add(this.delBtn);
            this.ForeColor = System.Drawing.Color.Orange;
            this.Name = "DelProdForm";
            this.Text = "DelProdForm";
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownDel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button delBtn;
        private System.Windows.Forms.NumericUpDown numUpDownDel;
        private System.Windows.Forms.Label label1;
    }
}