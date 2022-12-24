namespace coursework_SQL
{
    partial class SignUpForm
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
            this.label21 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtBoxRegPassword = new System.Windows.Forms.TextBox();
            this.txtBoxRegUsername = new System.Windows.Forms.TextBox();
            this.regBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxRegNumber = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label21.Location = new System.Drawing.Point(40, 185);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(86, 25);
            this.label21.TabIndex = 9;
            this.label21.Text = "Пароль:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(40, 118);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 25);
            this.label11.TabIndex = 8;
            this.label11.Text = "Логин:";
            // 
            // txtBoxRegPassword
            // 
            this.txtBoxRegPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBoxRegPassword.Location = new System.Drawing.Point(132, 185);
            this.txtBoxRegPassword.Name = "txtBoxRegPassword";
            this.txtBoxRegPassword.Size = new System.Drawing.Size(186, 28);
            this.txtBoxRegPassword.TabIndex = 7;
            // 
            // txtBoxRegUsername
            // 
            this.txtBoxRegUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBoxRegUsername.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtBoxRegUsername.Location = new System.Drawing.Point(132, 115);
            this.txtBoxRegUsername.Name = "txtBoxRegUsername";
            this.txtBoxRegUsername.Size = new System.Drawing.Size(186, 30);
            this.txtBoxRegUsername.TabIndex = 6;
            // 
            // regBtn
            // 
            this.regBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.regBtn.Location = new System.Drawing.Point(45, 243);
            this.regBtn.Name = "regBtn";
            this.regBtn.Size = new System.Drawing.Size(273, 56);
            this.regBtn.TabIndex = 5;
            this.regBtn.Text = "Создать аккаунт";
            this.regBtn.UseVisualStyleBackColor = true;
            this.regBtn.Click += new System.EventHandler(this.regBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(40, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Номер:";
            // 
            // txtBoxRegNumber
            // 
            this.txtBoxRegNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBoxRegNumber.Location = new System.Drawing.Point(132, 48);
            this.txtBoxRegNumber.Mask = "0-(999)-000-00-00";
            this.txtBoxRegNumber.Name = "txtBoxRegNumber";
            this.txtBoxRegNumber.Size = new System.Drawing.Size(186, 30);
            this.txtBoxRegNumber.TabIndex = 12;
            // 
            // SignUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 373);
            this.Controls.Add(this.txtBoxRegNumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtBoxRegPassword);
            this.Controls.Add(this.txtBoxRegUsername);
            this.Controls.Add(this.regBtn);
            this.Name = "SignUpForm";
            this.Text = "Регистрация";
            this.Load += new System.EventHandler(this.SignUpForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtBoxRegPassword;
        private System.Windows.Forms.TextBox txtBoxRegUsername;
        private System.Windows.Forms.Button regBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txtBoxRegNumber;
    }
}