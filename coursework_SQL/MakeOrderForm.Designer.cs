namespace coursework_SQL
{
    partial class MakeOrderForm
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
            this.idCl = new System.Windows.Forms.NumericUpDown();
            this.addBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.idFil = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.idPr = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.ammountPr = new System.Windows.Forms.NumericUpDown();
            this.orderDate = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.dgwNewOrder = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.idCl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.idFil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.idPr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ammountPr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwNewOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Orange;
            this.label1.Location = new System.Drawing.Point(37, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 29);
            this.label1.TabIndex = 39;
            this.label1.Text = "id клиента";
            // 
            // idCl
            // 
            this.idCl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.idCl.Location = new System.Drawing.Point(42, 70);
            this.idCl.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.idCl.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.idCl.Name = "idCl";
            this.idCl.Size = new System.Drawing.Size(117, 38);
            this.idCl.TabIndex = 38;
            this.idCl.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // addBtn
            // 
            this.addBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addBtn.ForeColor = System.Drawing.Color.Black;
            this.addBtn.Location = new System.Drawing.Point(162, 235);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(174, 49);
            this.addBtn.TabIndex = 37;
            this.addBtn.Text = "Оформить";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Orange;
            this.label2.Location = new System.Drawing.Point(37, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 29);
            this.label2.TabIndex = 41;
            this.label2.Text = "id магазина";
            // 
            // idFil
            // 
            this.idFil.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.idFil.Location = new System.Drawing.Point(42, 162);
            this.idFil.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.idFil.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.idFil.Name = "idFil";
            this.idFil.Size = new System.Drawing.Size(100, 38);
            this.idFil.TabIndex = 40;
            this.idFil.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.Orange;
            this.label6.Location = new System.Drawing.Point(191, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 29);
            this.label6.TabIndex = 45;
            this.label6.Text = "id товара";
            // 
            // idPr
            // 
            this.idPr.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.idPr.Location = new System.Drawing.Point(196, 70);
            this.idPr.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.idPr.Name = "idPr";
            this.idPr.Size = new System.Drawing.Size(117, 38);
            this.idPr.TabIndex = 44;
            this.idPr.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Orange;
            this.label3.Location = new System.Drawing.Point(344, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 29);
            this.label3.TabIndex = 47;
            this.label3.Text = "кол-во";
            // 
            // ammountPr
            // 
            this.ammountPr.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ammountPr.Location = new System.Drawing.Point(349, 70);
            this.ammountPr.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.ammountPr.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ammountPr.Name = "ammountPr";
            this.ammountPr.Size = new System.Drawing.Size(96, 38);
            this.ammountPr.TabIndex = 46;
            this.ammountPr.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // orderDate
            // 
            this.orderDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.orderDate.CustomFormat = "dd.MM.yyyy H:m:s";
            this.orderDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.orderDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.orderDate.Location = new System.Drawing.Point(171, 162);
            this.orderDate.MaxDate = new System.DateTime(2022, 12, 31, 23, 59, 0, 0);
            this.orderDate.MinDate = new System.DateTime(2020, 1, 1, 0, 1, 0, 0);
            this.orderDate.Name = "orderDate";
            this.orderDate.Size = new System.Drawing.Size(274, 38);
            this.orderDate.TabIndex = 48;
            this.orderDate.Value = new System.DateTime(2022, 12, 26, 14, 23, 13, 0);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.Orange;
            this.label7.Location = new System.Drawing.Point(271, 130);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 29);
            this.label7.TabIndex = 49;
            this.label7.Text = "дата";
            // 
            // dgwNewOrder
            // 
            this.dgwNewOrder.AllowUserToAddRows = false;
            this.dgwNewOrder.AllowUserToDeleteRows = false;
            this.dgwNewOrder.BackgroundColor = System.Drawing.Color.Black;
            this.dgwNewOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwNewOrder.GridColor = System.Drawing.Color.Black;
            this.dgwNewOrder.Location = new System.Drawing.Point(28, 308);
            this.dgwNewOrder.Name = "dgwNewOrder";
            this.dgwNewOrder.ReadOnly = true;
            this.dgwNewOrder.RowHeadersWidth = 51;
            this.dgwNewOrder.RowTemplate.Height = 24;
            this.dgwNewOrder.Size = new System.Drawing.Size(427, 237);
            this.dgwNewOrder.TabIndex = 51;
            // 
            // MakeOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(482, 569);
            this.Controls.Add(this.dgwNewOrder);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.orderDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ammountPr);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.idPr);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.idFil);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.idCl);
            this.Controls.Add(this.addBtn);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MakeOrderForm";
            this.Text = "Оформление заказа";
            ((System.ComponentModel.ISupportInitialize)(this.idCl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.idFil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.idPr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ammountPr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwNewOrder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown idCl;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown idFil;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown idPr;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown ammountPr;
        private System.Windows.Forms.DateTimePicker orderDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgwNewOrder;
    }
}