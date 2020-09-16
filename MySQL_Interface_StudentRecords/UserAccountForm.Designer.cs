namespace MySQL_Interface_StudentRecords
{
    partial class UserAccountForm
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
            this.u_uname_lbl = new System.Windows.Forms.Label();
            this.u_password_lbl = new System.Windows.Forms.Label();
            this.u_accesslevel_lbl = new System.Windows.Forms.Label();
            this.u_uname_txt = new System.Windows.Forms.TextBox();
            this.u_password_txt = new System.Windows.Forms.TextBox();
            this.u_accesslevel_txt = new System.Windows.Forms.TextBox();
            this.submit_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // u_uname_lbl
            // 
            this.u_uname_lbl.AutoSize = true;
            this.u_uname_lbl.Location = new System.Drawing.Point(35, 30);
            this.u_uname_lbl.Name = "u_uname_lbl";
            this.u_uname_lbl.Size = new System.Drawing.Size(79, 17);
            this.u_uname_lbl.TabIndex = 0;
            this.u_uname_lbl.Text = "User Name";
            // 
            // u_password_lbl
            // 
            this.u_password_lbl.AutoSize = true;
            this.u_password_lbl.Location = new System.Drawing.Point(35, 60);
            this.u_password_lbl.Name = "u_password_lbl";
            this.u_password_lbl.Size = new System.Drawing.Size(103, 17);
            this.u_password_lbl.TabIndex = 1;
            this.u_password_lbl.Text = "User Password";
            // 
            // u_accesslevel_lbl
            // 
            this.u_accesslevel_lbl.AutoSize = true;
            this.u_accesslevel_lbl.Location = new System.Drawing.Point(35, 90);
            this.u_accesslevel_lbl.Name = "u_accesslevel_lbl";
            this.u_accesslevel_lbl.Size = new System.Drawing.Size(86, 17);
            this.u_accesslevel_lbl.TabIndex = 2;
            this.u_accesslevel_lbl.Text = "Access level";
            // 
            // u_uname_txt
            // 
            this.u_uname_txt.Location = new System.Drawing.Point(140, 30);
            this.u_uname_txt.Name = "u_uname_txt";
            this.u_uname_txt.Size = new System.Drawing.Size(200, 22);
            this.u_uname_txt.TabIndex = 3;
            // 
            // u_password_txt
            // 
            this.u_password_txt.Location = new System.Drawing.Point(140, 60);
            this.u_password_txt.Name = "u_password_txt";
            this.u_password_txt.Size = new System.Drawing.Size(200, 22);
            this.u_password_txt.TabIndex = 4;
            // 
            // u_accesslevel_txt
            // 
            this.u_accesslevel_txt.Location = new System.Drawing.Point(140, 90);
            this.u_accesslevel_txt.Name = "u_accesslevel_txt";
            this.u_accesslevel_txt.Size = new System.Drawing.Size(200, 22);
            this.u_accesslevel_txt.TabIndex = 5;
            // 
            // submit_btn
            // 
            this.submit_btn.Location = new System.Drawing.Point(140, 285);
            this.submit_btn.Name = "submit_btn";
            this.submit_btn.Size = new System.Drawing.Size(150, 25);
            this.submit_btn.TabIndex = 7;
            this.submit_btn.Text = "Insert/Update";
            this.submit_btn.UseVisualStyleBackColor = true;
            this.submit_btn.Click += new System.EventHandler(this.submit_btn_Click);
            // 
            // UserAccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 313);
            this.Controls.Add(this.submit_btn);
            this.Controls.Add(this.u_accesslevel_txt);
            this.Controls.Add(this.u_password_txt);
            this.Controls.Add(this.u_uname_txt);
            this.Controls.Add(this.u_accesslevel_lbl);
            this.Controls.Add(this.u_password_lbl);
            this.Controls.Add(this.u_uname_lbl);
            this.Name = "UserAccountForm";
            this.Text = "User Account";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UserAccountForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label u_uname_lbl;
        private System.Windows.Forms.Label u_password_lbl;
        private System.Windows.Forms.Label u_accesslevel_lbl;
        private System.Windows.Forms.TextBox u_uname_txt;
        private System.Windows.Forms.TextBox u_password_txt;
        private System.Windows.Forms.TextBox u_accesslevel_txt;
        private System.Windows.Forms.Button submit_btn;
    }
}