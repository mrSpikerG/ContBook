
namespace Contact_book.View
{
    partial class ContactFormView
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
            this.NameLB = new System.Windows.Forms.Label();
            this.SurnameLB = new System.Windows.Forms.Label();
            this.PhoneNumberLB = new System.Windows.Forms.Label();
            this.AdressLB = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.deleteBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // NameLB
            // 
            this.NameLB.AutoSize = true;
            this.NameLB.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.NameLB.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameLB.ForeColor = System.Drawing.SystemColors.ControlText;
            this.NameLB.Location = new System.Drawing.Point(122, 132);
            this.NameLB.Name = "NameLB";
            this.NameLB.Size = new System.Drawing.Size(68, 25);
            this.NameLB.TabIndex = 1;
            this.NameLB.Text = "label1";
            this.NameLB.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // SurnameLB
            // 
            this.SurnameLB.AutoSize = true;
            this.SurnameLB.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.SurnameLB.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SurnameLB.ForeColor = System.Drawing.SystemColors.ControlText;
            this.SurnameLB.Location = new System.Drawing.Point(97, 166);
            this.SurnameLB.Name = "SurnameLB";
            this.SurnameLB.Size = new System.Drawing.Size(68, 25);
            this.SurnameLB.TabIndex = 2;
            this.SurnameLB.Text = "label2";
            this.SurnameLB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PhoneNumberLB
            // 
            this.PhoneNumberLB.AutoSize = true;
            this.PhoneNumberLB.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.PhoneNumberLB.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PhoneNumberLB.ForeColor = System.Drawing.SystemColors.ControlText;
            this.PhoneNumberLB.Location = new System.Drawing.Point(74, 227);
            this.PhoneNumberLB.Name = "PhoneNumberLB";
            this.PhoneNumberLB.Size = new System.Drawing.Size(68, 25);
            this.PhoneNumberLB.TabIndex = 3;
            this.PhoneNumberLB.Text = "label3";
            this.PhoneNumberLB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.PhoneNumberLB.Click += new System.EventHandler(this.PhoneNumberLB_Click);
            // 
            // AdressLB
            // 
            this.AdressLB.AutoSize = true;
            this.AdressLB.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.AdressLB.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AdressLB.ForeColor = System.Drawing.SystemColors.ControlText;
            this.AdressLB.Location = new System.Drawing.Point(74, 289);
            this.AdressLB.Name = "AdressLB";
            this.AdressLB.Size = new System.Drawing.Size(68, 25);
            this.AdressLB.TabIndex = 4;
            this.AdressLB.Text = "label4";
            this.AdressLB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(3, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 29);
            this.button1.TabIndex = 5;
            this.button1.Text = "Вернуться";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(241, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 29);
            this.button2.TabIndex = 6;
            this.button2.Text = "Править";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(102, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(133, 118);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // deleteBtn
            // 
            this.deleteBtn.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteBtn.ForeColor = System.Drawing.Color.Red;
            this.deleteBtn.Location = new System.Drawing.Point(91, 388);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(144, 29);
            this.deleteBtn.TabIndex = 12;
            this.deleteBtn.Text = "Удалить контакт";
            this.deleteBtn.UseVisualStyleBackColor = true;
            // 
            // ContactFormView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(342, 454);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.AdressLB);
            this.Controls.Add(this.PhoneNumberLB);
            this.Controls.Add(this.SurnameLB);
            this.Controls.Add(this.NameLB);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ContactFormView";
            this.Text = "ContactFormView";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Label NameLB;
        public System.Windows.Forms.Label SurnameLB;
        public System.Windows.Forms.Label PhoneNumberLB;
        public System.Windows.Forms.Label AdressLB;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.Button button2;
        public System.Windows.Forms.Button deleteBtn;
    }
}