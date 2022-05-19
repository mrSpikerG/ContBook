
using Contact_book.View;

namespace Contact_book
{
    partial class GeneralContactControlls
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.searchLineTB = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.AutoScrollMargin = new System.Drawing.Size(50, 50);
            this.panel1.Location = new System.Drawing.Point(19, 72);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(437, 500);
            this.panel1.TabIndex = 0;
            // 
            // searchLineTB
            // 
            this.searchLineTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchLineTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchLineTB.Location = new System.Drawing.Point(19, 28);
            this.searchLineTB.Name = "searchLineTB";
            this.searchLineTB.Size = new System.Drawing.Size(350, 21);
            this.searchLineTB.TabIndex = 1;
            this.searchLineTB.Text = "Поиск...";
            this.searchLineTB.TextChanged += new System.EventHandler(this.searchLineTB_TextChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(375, 28);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(81, 38);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "Точный\n поиск";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // GeneralContactControlls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.searchLineTB);
            this.Controls.Add(this.panel1);
            this.Name = "GeneralContactControlls";
            this.Size = new System.Drawing.Size(482, 599);
            this.Load += new System.EventHandler(this.AllContactControlls_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox searchLineTB;
        private System.Windows.Forms.CheckBox checkBox1;
        public ContactFormView contactFormView;
        public ChangeContactForm changeContactForm;
        public FileController fileController=new FileController();



    }
}
