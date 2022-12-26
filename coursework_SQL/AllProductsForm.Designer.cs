namespace coursework_SQL
{
    partial class AllProductsForm
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
            this.dataGridViewProd = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProd)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Orange;
            this.label1.Location = new System.Drawing.Point(17, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Товары";
            // 
            // dataGridViewProd
            // 
            this.dataGridViewProd.AllowUserToAddRows = false;
            this.dataGridViewProd.AllowUserToDeleteRows = false;
            this.dataGridViewProd.BackgroundColor = System.Drawing.Color.Black;
            this.dataGridViewProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProd.GridColor = System.Drawing.Color.Black;
            this.dataGridViewProd.Location = new System.Drawing.Point(21, 40);
            this.dataGridViewProd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewProd.Name = "dataGridViewProd";
            this.dataGridViewProd.ReadOnly = true;
            this.dataGridViewProd.RowHeadersWidth = 51;
            this.dataGridViewProd.RowTemplate.Height = 24;
            this.dataGridViewProd.Size = new System.Drawing.Size(700, 251);
            this.dataGridViewProd.TabIndex = 1;
            // 
            // AllProductsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(742, 330);
            this.Controls.Add(this.dataGridViewProd);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(825, 600);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(760, 377);
            this.Name = "AllProductsForm";
            this.Text = "Товары";
            this.Load += new System.EventHandler(this.AllProductsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewProd;
    }
}