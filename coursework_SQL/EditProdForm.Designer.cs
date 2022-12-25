namespace coursework_SQL
{
    partial class EditProdForm
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
            this.addBtn = new System.Windows.Forms.Button();
            this.txtBoxDescr = new System.Windows.Forms.TextBox();
            this.txtBoxName = new System.Windows.Forms.TextBox();
            this.numUpDownPrice = new System.Windows.Forms.NumericUpDown();
            this.cbId_cat = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numUpDownEdit = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.loadBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownEdit)).BeginInit();
            this.SuspendLayout();
            // 
            // addBtn
            // 
            this.addBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addBtn.ForeColor = System.Drawing.Color.Black;
            this.addBtn.Location = new System.Drawing.Point(169, 496);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(174, 49);
            this.addBtn.TabIndex = 25;
            this.addBtn.Text = "Изменить";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // txtBoxDescr
            // 
            this.txtBoxDescr.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBoxDescr.Location = new System.Drawing.Point(42, 440);
            this.txtBoxDescr.Name = "txtBoxDescr";
            this.txtBoxDescr.Size = new System.Drawing.Size(403, 38);
            this.txtBoxDescr.TabIndex = 24;
            // 
            // txtBoxName
            // 
            this.txtBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBoxName.Location = new System.Drawing.Point(42, 346);
            this.txtBoxName.Name = "txtBoxName";
            this.txtBoxName.Size = new System.Drawing.Size(403, 38);
            this.txtBoxName.TabIndex = 23;
            // 
            // numUpDownPrice
            // 
            this.numUpDownPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numUpDownPrice.Location = new System.Drawing.Point(332, 252);
            this.numUpDownPrice.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numUpDownPrice.Minimum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.numUpDownPrice.Name = "numUpDownPrice";
            this.numUpDownPrice.Size = new System.Drawing.Size(113, 38);
            this.numUpDownPrice.TabIndex = 22;
            this.numUpDownPrice.Value = new decimal(new int[] {
            99,
            0,
            0,
            0});
            // 
            // cbId_cat
            // 
            this.cbId_cat.DropDownWidth = 300;
            this.cbId_cat.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbId_cat.FormattingEnabled = true;
            this.cbId_cat.Items.AddRange(new object[] {
            "Бытовая техника",
            "Смартфоны",
            "Мультимедиа",
            "ПК",
            "Ноутбуки",
            "Периферия"});
            this.cbId_cat.Location = new System.Drawing.Point(42, 251);
            this.cbId_cat.Name = "cbId_cat";
            this.cbId_cat.Size = new System.Drawing.Size(258, 39);
            this.cbId_cat.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(37, 408);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 29);
            this.label5.TabIndex = 20;
            this.label5.Text = "Описание";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(37, 314);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 29);
            this.label4.TabIndex = 19;
            this.label4.Text = "Название";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(351, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 29);
            this.label3.TabIndex = 18;
            this.label3.Text = "Цена";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(92, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 29);
            this.label2.TabIndex = 17;
            this.label2.Text = "Категория";
            // 
            // numUpDownEdit
            // 
            this.numUpDownEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numUpDownEdit.Location = new System.Drawing.Point(42, 128);
            this.numUpDownEdit.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numUpDownEdit.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUpDownEdit.Name = "numUpDownEdit";
            this.numUpDownEdit.Size = new System.Drawing.Size(98, 38);
            this.numUpDownEdit.TabIndex = 26;
            this.numUpDownEdit.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(37, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 29);
            this.label1.TabIndex = 27;
            this.label1.Text = "id товара";
            // 
            // loadBtn
            // 
            this.loadBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loadBtn.ForeColor = System.Drawing.Color.Black;
            this.loadBtn.Location = new System.Drawing.Point(160, 121);
            this.loadBtn.Name = "loadBtn";
            this.loadBtn.Size = new System.Drawing.Size(285, 49);
            this.loadBtn.TabIndex = 28;
            this.loadBtn.Text = "Подгрузить данные";
            this.loadBtn.UseVisualStyleBackColor = true;
            this.loadBtn.Click += new System.EventHandler(this.loadBtn_Click);
            // 
            // EditProdForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(482, 569);
            this.Controls.Add(this.loadBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numUpDownEdit);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.txtBoxDescr);
            this.Controls.Add(this.txtBoxName);
            this.Controls.Add(this.numUpDownPrice);
            this.Controls.Add(this.cbId_cat);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.Orange;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "EditProdForm";
            this.Text = "Редактирование";
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownEdit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.TextBox txtBoxDescr;
        private System.Windows.Forms.TextBox txtBoxName;
        private System.Windows.Forms.NumericUpDown numUpDownPrice;
        private System.Windows.Forms.ComboBox cbId_cat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numUpDownEdit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button loadBtn;
    }
}