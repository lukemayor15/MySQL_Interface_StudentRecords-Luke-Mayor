namespace MySQL_Interface_StudentRecords
{
    partial class DepartmentForm
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
            this.dep_name_lbl = new System.Windows.Forms.Label();
            this.dep_phone_no_lbl = new System.Windows.Forms.Label();
            this.dep_email_lbl = new System.Windows.Forms.Label();
            this.dep_leader_lbl = new System.Windows.Forms.Label();
            this.dep_name_txt = new System.Windows.Forms.TextBox();
            this.dep_phone_no_txt = new System.Windows.Forms.TextBox();
            this.dep_email_txt = new System.Windows.Forms.TextBox();
            this.dep_leader_txt = new System.Windows.Forms.TextBox();
            this.submit_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dep_name_lbl
            // 
            this.dep_name_lbl.AutoSize = true;
            this.dep_name_lbl.Location = new System.Drawing.Point(12, 33);
            this.dep_name_lbl.Name = "dep_name_lbl";
            this.dep_name_lbl.Size = new System.Drawing.Size(123, 17);
            this.dep_name_lbl.TabIndex = 0;
            this.dep_name_lbl.Text = "Department Name";
            // 
            // dep_phone_no_lbl
            // 
            this.dep_phone_no_lbl.AutoSize = true;
            this.dep_phone_no_lbl.Location = new System.Drawing.Point(12, 90);
            this.dep_phone_no_lbl.Name = "dep_phone_no_lbl";
            this.dep_phone_no_lbl.Size = new System.Drawing.Size(71, 17);
            this.dep_phone_no_lbl.TabIndex = 1;
            this.dep_phone_no_lbl.Text = "Phone No";
            // 
            // dep_email_lbl
            // 
            this.dep_email_lbl.AutoSize = true;
            this.dep_email_lbl.Location = new System.Drawing.Point(12, 60);
            this.dep_email_lbl.Name = "dep_email_lbl";
            this.dep_email_lbl.Size = new System.Drawing.Size(42, 17);
            this.dep_email_lbl.TabIndex = 2;
            this.dep_email_lbl.Text = "Email";
            // 
            // dep_leader_lbl
            // 
            this.dep_leader_lbl.AutoSize = true;
            this.dep_leader_lbl.Location = new System.Drawing.Point(12, 118);
            this.dep_leader_lbl.Name = "dep_leader_lbl";
            this.dep_leader_lbl.Size = new System.Drawing.Size(53, 17);
            this.dep_leader_lbl.TabIndex = 3;
            this.dep_leader_lbl.Text = "Leader";
            // 
            // dep_name_txt
            // 
            this.dep_name_txt.Location = new System.Drawing.Point(141, 30);
            this.dep_name_txt.Name = "dep_name_txt";
            this.dep_name_txt.Size = new System.Drawing.Size(196, 22);
            this.dep_name_txt.TabIndex = 4;
            // 
            // dep_phone_no_txt
            // 
            this.dep_phone_no_txt.Location = new System.Drawing.Point(141, 90);
            this.dep_phone_no_txt.Name = "dep_phone_no_txt";
            this.dep_phone_no_txt.Size = new System.Drawing.Size(196, 22);
            this.dep_phone_no_txt.TabIndex = 5;
            // 
            // dep_email_txt
            // 
            this.dep_email_txt.Location = new System.Drawing.Point(141, 60);
            this.dep_email_txt.Name = "dep_email_txt";
            this.dep_email_txt.Size = new System.Drawing.Size(196, 22);
            this.dep_email_txt.TabIndex = 6;
            // 
            // dep_leader_txt
            // 
            this.dep_leader_txt.Location = new System.Drawing.Point(141, 118);
            this.dep_leader_txt.Name = "dep_leader_txt";
            this.dep_leader_txt.Size = new System.Drawing.Size(196, 22);
            this.dep_leader_txt.TabIndex = 7;
            // 
            // submit_btn
            // 
            this.submit_btn.Location = new System.Drawing.Point(141, 163);
            this.submit_btn.Name = "submit_btn";
            this.submit_btn.Size = new System.Drawing.Size(196, 23);
            this.submit_btn.TabIndex = 8;
            this.submit_btn.Text = "Insert/Update";
            this.submit_btn.UseVisualStyleBackColor = true;
            this.submit_btn.Click += new System.EventHandler(this.submit_btn_Click);
            // 
            // DepartmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 313);
            this.Controls.Add(this.submit_btn);
            this.Controls.Add(this.dep_leader_txt);
            this.Controls.Add(this.dep_email_txt);
            this.Controls.Add(this.dep_phone_no_txt);
            this.Controls.Add(this.dep_name_txt);
            this.Controls.Add(this.dep_leader_lbl);
            this.Controls.Add(this.dep_email_lbl);
            this.Controls.Add(this.dep_phone_no_lbl);
            this.Controls.Add(this.dep_name_lbl);
            this.Name = "DepartmentForm";
            this.Text = "DepartmentForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DepForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label dep_name_lbl;
        private System.Windows.Forms.Label dep_phone_no_lbl;
        private System.Windows.Forms.Label dep_email_lbl;
        private System.Windows.Forms.Label dep_leader_lbl;
        private System.Windows.Forms.TextBox dep_name_txt;
        private System.Windows.Forms.TextBox dep_phone_no_txt;
        private System.Windows.Forms.TextBox dep_email_txt;
        private System.Windows.Forms.TextBox dep_leader_txt;
        private System.Windows.Forms.Button submit_btn;
    }
}