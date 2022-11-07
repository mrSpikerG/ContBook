
namespace Contact_book.View
{
    partial class ChangeContactForm
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SurnameTB = new System.Windows.Forms.TextBox();
            this.NameTB = new System.Windows.Forms.TextBox();
            this.phoneNumberTB = new System.Windows.Forms.TextBox();
            this.adressTB = new System.Windows.Forms.TextBox();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(98, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(133, 118);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // SurnameTB
            // 
            this.SurnameTB.Location = new System.Drawing.Point(52, 215);
            this.SurnameTB.Name = "SurnameTB";
            this.SurnameTB.Size = new System.Drawing.Size(213, 22);
            this.SurnameTB.TabIndex = 4;
            // 
            // NameTB
            // 
            this.NameTB.Location = new System.Drawing.Point(52, 162);
            this.NameTB.Name = "NameTB";
            this.NameTB.Size = new System.Drawing.Size(213, 22);
            this.NameTB.TabIndex = 5;
            // 
            // phoneNumberTB
            // 
            this.phoneNumberTB.Location = new System.Drawing.Point(52, 301);
            this.phoneNumberTB.Name = "phoneNumberTB";
            this.phoneNumberTB.Size = new System.Drawing.Size(213, 22);
            this.phoneNumberTB.TabIndex = 7;
            // 
            // adressTB
            // 
            this.adressTB.Location = new System.Drawing.Point(52, 365);
            this.adressTB.Multiline = true;
            this.adressTB.Name = "adressTB";
            this.adressTB.Size = new System.Drawing.Size(213, 63);
            this.adressTB.TabIndex = 8;
            // 
            // cancelBtn
            // 
            this.cancelBtn.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cancelBtn.Location = new System.Drawing.Point(12, 12);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 34);
            this.cancelBtn.TabIndex = 9;
            this.cancelBtn.Text = "Отмена";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveBtn.Location = new System.Drawing.Point(250, 12);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 34);
            this.saveBtn.TabIndex = 10;
            this.saveBtn.Text = "Готово";
            this.saveBtn.UseVisualStyleBackColor = true;
            // 
            // ChangeContactForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(337, 506);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.adressTB);
            this.Controls.Add(this.phoneNumberTB);
            this.Controls.Add(this.NameTB);
            this.Controls.Add(this.SurnameTB);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ChangeContactForm";
            this.Text = "ChangeContactForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.TextBox SurnameTB;
        public System.Windows.Forms.TextBox NameTB;
        public System.Windows.Forms.TextBox phoneNumberTB;
        public System.Windows.Forms.TextBox adressTB;
        private System.Windows.Forms.Button cancelBtn;
        public System.Windows.Forms.Button saveBtn;
    }
}