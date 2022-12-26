namespace coursework_SQL
{
    partial class AdminForm
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
            this.searchBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.searchDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.editBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rbDate = new System.Windows.Forms.RadioButton();
            this.rbId = new System.Windows.Forms.RadioButton();
            this.numUpDownId = new System.Windows.Forms.NumericUpDown();
            this.prodLookBtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.makeOrderBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownId)).BeginInit();
            this.SuspendLayout();
            // 
            // searchBtn
            // 
            this.searchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchBtn.ForeColor = System.Drawing.Color.Black;
            this.searchBtn.Location = new System.Drawing.Point(256, 202);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(108, 47);
            this.searchBtn.TabIndex = 1;
            this.searchBtn.Text = "Найти";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.BackColor = System.Drawing.Color.IndianRed;
            this.deleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteBtn.ForeColor = System.Drawing.Color.Black;
            this.deleteBtn.Location = new System.Drawing.Point(448, 326);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(177, 47);
            this.deleteBtn.TabIndex = 2;
            this.deleteBtn.Text = "Удалить";
            this.deleteBtn.UseVisualStyleBackColor = false;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // searchDate
            // 
            this.searchDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.searchDate.Location = new System.Drawing.Point(168, 134);
            this.searchDate.MaxDate = new System.DateTime(2022, 12, 31, 0, 0, 0, 0);
            this.searchDate.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.searchDate.Name = "searchDate";
            this.searchDate.Size = new System.Drawing.Size(196, 38);
            this.searchDate.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 38);
            this.label1.TabIndex = 5;
            this.label1.Text = "Поиск заказов";
            // 
            // editBtn
            // 
            this.editBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.editBtn.ForeColor = System.Drawing.Color.Black;
            this.editBtn.Location = new System.Drawing.Point(448, 242);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(177, 47);
            this.editBtn.TabIndex = 6;
            this.editBtn.Text = "Изменить";
            this.editBtn.UseVisualStyleBackColor = true;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.BackColor = System.Drawing.Color.LightGreen;
            this.addBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addBtn.ForeColor = System.Drawing.Color.Black;
            this.addBtn.Location = new System.Drawing.Point(448, 155);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(177, 47);
            this.addBtn.TabIndex = 7;
            this.addBtn.Text = "Создать";
            this.addBtn.UseVisualStyleBackColor = false;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(441, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 38);
            this.label2.TabIndex = 8;
            this.label2.Text = "Товары";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(33, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "id клиента";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(33, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "Дата";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Location = new System.Drawing.Point(382, -6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(10, 458);
            this.label5.TabIndex = 11;
            // 
            // rbDate
            // 
            this.rbDate.AutoSize = true;
            this.rbDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbDate.Location = new System.Drawing.Point(168, 209);
            this.rbDate.Name = "rbDate";
            this.rbDate.Size = new System.Drawing.Size(82, 29);
            this.rbDate.TabIndex = 15;
            this.rbDate.Text = "Дата";
            this.rbDate.UseVisualStyleBackColor = true;
            // 
            // rbId
            // 
            this.rbId.AutoSize = true;
            this.rbId.Checked = true;
            this.rbId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbId.Location = new System.Drawing.Point(38, 209);
            this.rbId.Name = "rbId";
            this.rbId.Size = new System.Drawing.Size(130, 29);
            this.rbId.TabIndex = 16;
            this.rbId.TabStop = true;
            this.rbId.Text = "id клиента";
            this.rbId.UseVisualStyleBackColor = true;
            // 
            // numUpDownId
            // 
            this.numUpDownId.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numUpDownId.Location = new System.Drawing.Point(168, 71);
            this.numUpDownId.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numUpDownId.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUpDownId.Name = "numUpDownId";
            this.numUpDownId.Size = new System.Drawing.Size(196, 38);
            this.numUpDownId.TabIndex = 17;
            this.numUpDownId.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // prodLookBtn
            // 
            this.prodLookBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.prodLookBtn.ForeColor = System.Drawing.Color.Black;
            this.prodLookBtn.Location = new System.Drawing.Point(448, 71);
            this.prodLookBtn.Name = "prodLookBtn";
            this.prodLookBtn.Size = new System.Drawing.Size(177, 47);
            this.prodLookBtn.TabIndex = 18;
            this.prodLookBtn.Text = "Все товары";
            this.prodLookBtn.UseVisualStyleBackColor = true;
            this.prodLookBtn.Click += new System.EventHandler(this.prodLookBtn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Black;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(12, 281);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(352, 38);
            this.label7.TabIndex = 20;
            this.label7.Text = "Оформление заказа";
            // 
            // makeOrderBtn
            // 
            this.makeOrderBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.makeOrderBtn.ForeColor = System.Drawing.Color.Black;
            this.makeOrderBtn.Location = new System.Drawing.Point(120, 336);
            this.makeOrderBtn.Name = "makeOrderBtn";
            this.makeOrderBtn.Size = new System.Drawing.Size(244, 47);
            this.makeOrderBtn.TabIndex = 21;
            this.makeOrderBtn.Text = "Оформить заказ";
            this.makeOrderBtn.UseVisualStyleBackColor = true;
            this.makeOrderBtn.Click += new System.EventHandler(this.makeOrderBtn_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(662, 399);
            this.Controls.Add(this.makeOrderBtn);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.prodLookBtn);
            this.Controls.Add(this.numUpDownId);
            this.Controls.Add(this.rbId);
            this.Controls.Add(this.rbDate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchDate);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.searchBtn);
            this.ForeColor = System.Drawing.Color.Orange;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AdminForm";
            this.Text = "Администрирование";
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownId)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.DateTimePicker searchDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rbDate;
        private System.Windows.Forms.RadioButton rbId;
        private System.Windows.Forms.NumericUpDown numUpDownId;
        private System.Windows.Forms.Button prodLookBtn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button makeOrderBtn;
    }
}