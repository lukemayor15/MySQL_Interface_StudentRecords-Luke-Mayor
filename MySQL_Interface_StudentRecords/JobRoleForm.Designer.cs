namespace MySQL_Interface_StudentRecords
{
    partial class JobRoleForm
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
            this.staff_id_lbl = new System.Windows.Forms.Label();
            this.dep_id_lbl = new System.Windows.Forms.Label();
            this.j_title_lbl = new System.Windows.Forms.Label();
            this.staff_id_cmb = new System.Windows.Forms.ComboBox();
            this.dep_id_cmb = new System.Windows.Forms.ComboBox();
            this.j_title_txt = new System.Windows.Forms.TextBox();
            this.submit_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // staff_id_lbl
            // 
            this.staff_id_lbl.AutoSize = true;
            this.staff_id_lbl.Location = new System.Drawing.Point(35, 30);
            this.staff_id_lbl.Name = "staff_id_lbl";
            this.staff_id_lbl.Size = new System.Drawing.Size(54, 17);
            this.staff_id_lbl.TabIndex = 0;
            this.staff_id_lbl.Text = "Staff ID";
            // 
            // dep_id_lbl
            // 
            this.dep_id_lbl.AutoSize = true;
            this.dep_id_lbl.Location = new System.Drawing.Point(35, 60);
            this.dep_id_lbl.Name = "dep_id_lbl";
            this.dep_id_lbl.Size = new System.Drawing.Size(99, 17);
            this.dep_id_lbl.TabIndex = 1;
            this.dep_id_lbl.Text = "Department ID";
            // 
            // j_title_lbl
            // 
            this.j_title_lbl.AutoSize = true;
            this.j_title_lbl.Location = new System.Drawing.Point(35, 90);
            this.j_title_lbl.Name = "j_title_lbl";
            this.j_title_lbl.Size = new System.Drawing.Size(62, 17);
            this.j_title_lbl.TabIndex = 2;
            this.j_title_lbl.Text = "Job Title";
            // 
            // staff_id_cmb
            // 
            this.staff_id_cmb.FormattingEnabled = true;
            this.staff_id_cmb.Location = new System.Drawing.Point(140, 30);
            this.staff_id_cmb.Name = "staff_id_cmb";
            this.staff_id_cmb.Size = new System.Drawing.Size(186, 24);
            this.staff_id_cmb.TabIndex = 3;
            // 
            // dep_id_cmb
            // 
            this.dep_id_cmb.FormattingEnabled = true;
            this.dep_id_cmb.Location = new System.Drawing.Point(140, 60);
            this.dep_id_cmb.Name = "dep_id_cmb";
            this.dep_id_cmb.Size = new System.Drawing.Size(186, 24);
            this.dep_id_cmb.TabIndex = 4;
            // 
            // j_title_txt
            // 
            this.j_title_txt.Location = new System.Drawing.Point(140, 90);
            this.j_title_txt.Name = "j_title_txt";
            this.j_title_txt.Size = new System.Drawing.Size(186, 22);
            this.j_title_txt.TabIndex = 5;
            // 
            // submit_btn
            // 
            this.submit_btn.Location = new System.Drawing.Point(140, 119);
            this.submit_btn.Name = "submit_btn";
            this.submit_btn.Size = new System.Drawing.Size(186, 23);
            this.submit_btn.TabIndex = 6;
            this.submit_btn.Text = "Insert/Update";
            this.submit_btn.UseVisualStyleBackColor = true;
            this.submit_btn.Click += new System.EventHandler(this.submit_btn_Click);
            // 
            // JobRoleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 313);
            this.Controls.Add(this.submit_btn);
            this.Controls.Add(this.j_title_txt);
            this.Controls.Add(this.dep_id_cmb);
            this.Controls.Add(this.staff_id_cmb);
            this.Controls.Add(this.j_title_lbl);
            this.Controls.Add(this.dep_id_lbl);
            this.Controls.Add(this.staff_id_lbl);
            this.Name = "JobRoleForm";
            this.Text = "Job Role Form";
            this.ResumeLayout(false);
            this.PerformLayout();

            this.FormClosed += new System.Windows.Forms.
                FormClosedEventHandler(this.JobRoleForm_FormClosed);

        }

        #endregion

        private System.Windows.Forms.Label staff_id_lbl;
        private System.Windows.Forms.Label dep_id_lbl;
        private System.Windows.Forms.Label j_title_lbl;
        private System.Windows.Forms.ComboBox staff_id_cmb;
        private System.Windows.Forms.ComboBox dep_id_cmb;
        private System.Windows.Forms.TextBox j_title_txt;
        private System.Windows.Forms.Button submit_btn;
    }
}