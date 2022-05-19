
using Contact_book.View;

namespace Contact_book
{
    partial class ContactControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.NameLB = new System.Windows.Forms.Label();
            this.PhoneNumberLB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NameLB
            // 
            this.NameLB.AutoSize = true;
            this.NameLB.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.NameLB.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameLB.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.NameLB.Location = new System.Drawing.Point(49, 10);
            this.NameLB.Name = "NameLB";
            this.NameLB.Size = new System.Drawing.Size(59, 22);
            this.NameLB.TabIndex = 0;
            this.NameLB.Text = "label1";
            // 
            // PhoneNumberLB
            // 
            this.PhoneNumberLB.AutoSize = true;
            this.PhoneNumberLB.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.PhoneNumberLB.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PhoneNumberLB.Location = new System.Drawing.Point(204, 10);
            this.PhoneNumberLB.Name = "PhoneNumberLB";
            this.PhoneNumberLB.Size = new System.Drawing.Size(59, 22);
            this.PhoneNumberLB.TabIndex = 1;
            this.PhoneNumberLB.Text = "label2";
            // 
            // ContactControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Controls.Add(this.PhoneNumberLB);
            this.Controls.Add(this.NameLB);
            this.Name = "ContactControl";
            this.Size = new System.Drawing.Size(412, 40);
            this.Click += new System.EventHandler(this.ContactControl_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NameLB;
        private System.Windows.Forms.Label PhoneNumberLB;
        private ContactFormView contactform = new ContactFormView();
        public ChangeContactForm changeContactForm = new ChangeContactForm();
    }
}
