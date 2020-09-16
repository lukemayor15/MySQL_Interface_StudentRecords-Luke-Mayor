namespace MySQL_Interface_StudentRecords
{
    partial class NextOfKinForm
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
            this.user_id_lbl = new System.Windows.Forms.Label();
            this.k_fname_lbl = new System.Windows.Forms.Label();
            this.k_phone_no_lbl = new System.Windows.Forms.Label();
            this.k_fname_txt = new System.Windows.Forms.TextBox();
            this.k_phone_no_txt = new System.Windows.Forms.TextBox();
            this.u_id_cmb = new System.Windows.Forms.ComboBox();
            this.submit_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // user_id_lbl
            // 
            this.user_id_lbl.AutoSize = true;
            this.user_id_lbl.Location = new System.Drawing.Point(35, 26);
            this.user_id_lbl.Name = "user_id_lbl";
            this.user_id_lbl.Size = new System.Drawing.Size(55, 17);
            this.user_id_lbl.TabIndex = 1;
            this.user_id_lbl.Text = "User ID";
            // 
            // k_fname_lbl
            // 
            this.k_fname_lbl.AutoSize = true;
            this.k_fname_lbl.Location = new System.Drawing.Point(35, 56);
            this.k_fname_lbl.Name = "k_fname_lbl";
            this.k_fname_lbl.Size = new System.Drawing.Size(76, 17);
            this.k_fname_lbl.TabIndex = 2;
            this.k_fname_lbl.Text = "First Name";
            // 
            // k_phone_no_lbl
            // 
            this.k_phone_no_lbl.AutoSize = true;
            this.k_phone_no_lbl.Location = new System.Drawing.Point(35, 86);
            this.k_phone_no_lbl.Name = "k_phone_no_lbl";
            this.k_phone_no_lbl.Size = new System.Drawing.Size(71, 17);
            this.k_phone_no_lbl.TabIndex = 3;
            this.k_phone_no_lbl.Text = "Phone No";
            // 
            // k_fname_txt
            // 
            this.k_fname_txt.Location = new System.Drawing.Point(140, 56);
            this.k_fname_txt.Name = "k_fname_txt";
            this.k_fname_txt.Size = new System.Drawing.Size(200, 22);
            this.k_fname_txt.TabIndex = 5;
            // 
            // k_phone_no_txt
            // 
            this.k_phone_no_txt.Location = new System.Drawing.Point(140, 86);
            this.k_phone_no_txt.Name = "k_phone_no_txt";
            this.k_phone_no_txt.Size = new System.Drawing.Size(200, 22);
            this.k_phone_no_txt.TabIndex = 6;
            // 
            // u_id_cmb
            // 
            this.u_id_cmb.FormattingEnabled = true;
            this.u_id_cmb.Location = new System.Drawing.Point(140, 26);
            this.u_id_cmb.Name = "u_id_cmb";
            this.u_id_cmb.Size = new System.Drawing.Size(200, 24);
            this.u_id_cmb.TabIndex = 7;
            // 
            // submit_btn
            // 
            this.submit_btn.Location = new System.Drawing.Point(140, 136);
            this.submit_btn.Name = "submit_btn";
            this.submit_btn.Size = new System.Drawing.Size(150, 25);
            this.submit_btn.TabIndex = 8;
            this.submit_btn.Text = "Insert/Update";
            this.submit_btn.UseVisualStyleBackColor = true;
            this.submit_btn.Click += new System.EventHandler(this.submit_btn_Click);
            // 
            // NextOfKinForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 313);
            this.Controls.Add(this.submit_btn);
            this.Controls.Add(this.u_id_cmb);
            this.Controls.Add(this.k_phone_no_txt);
            this.Controls.Add(this.k_fname_txt);
            this.Controls.Add(this.k_phone_no_lbl);
            this.Controls.Add(this.k_fname_lbl);
            this.Controls.Add(this.user_id_lbl);
            this.Name = "NextOfKinForm";
            this.Text = "NextOfKinForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.NextOfKinForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label user_id_lbl;
        private System.Windows.Forms.Label k_fname_lbl;
        private System.Windows.Forms.Label k_phone_no_lbl;
        private System.Windows.Forms.TextBox k_fname_txt;
        private System.Windows.Forms.TextBox k_phone_no_txt;
        private System.Windows.Forms.ComboBox u_id_cmb;
        private System.Windows.Forms.Button submit_btn;
    }
}