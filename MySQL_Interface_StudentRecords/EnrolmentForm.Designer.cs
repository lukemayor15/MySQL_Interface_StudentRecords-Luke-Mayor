namespace MySQL_Interface_StudentRecords
{
    partial class EnrolmentForm
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
            this.course_id_lbl = new System.Windows.Forms.Label();
            this.student_id_lbl = new System.Windows.Forms.Label();
            this.en_data_lbl = new System.Windows.Forms.Label();
            this.c_id_cmb = new System.Windows.Forms.ComboBox();
            this.s_id_cmb = new System.Windows.Forms.ComboBox();
            this.en_date_txt = new System.Windows.Forms.TextBox();
            this.submit_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // course_id_lbl
            // 
            this.course_id_lbl.AutoSize = true;
            this.course_id_lbl.Location = new System.Drawing.Point(35, 30);
            this.course_id_lbl.Name = "course_id_lbl";
            this.course_id_lbl.Size = new System.Drawing.Size(70, 17);
            this.course_id_lbl.TabIndex = 0;
            this.course_id_lbl.Text = "Course ID";
            // 
            // student_id_lbl
            // 
            this.student_id_lbl.AutoSize = true;
            this.student_id_lbl.Location = new System.Drawing.Point(35, 60);
            this.student_id_lbl.Name = "student_id_lbl";
            this.student_id_lbl.Size = new System.Drawing.Size(74, 17);
            this.student_id_lbl.TabIndex = 1;
            this.student_id_lbl.Text = "Student ID";
            // 
            // en_data_lbl
            // 
            this.en_data_lbl.AutoSize = true;
            this.en_data_lbl.Location = new System.Drawing.Point(35, 90);
            this.en_data_lbl.Name = "en_data_lbl";
            this.en_data_lbl.Size = new System.Drawing.Size(106, 17);
            this.en_data_lbl.TabIndex = 2;
            this.en_data_lbl.Text = "Enrolment Date";
            // 
            // c_id_cmb
            // 
            this.c_id_cmb.FormattingEnabled = true;
            this.c_id_cmb.Location = new System.Drawing.Point(140, 30);
            this.c_id_cmb.Name = "c_id_cmb";
            this.c_id_cmb.Size = new System.Drawing.Size(200, 24);
            this.c_id_cmb.TabIndex = 3;
            // 
            // s_id_cmb
            // 
            this.s_id_cmb.FormattingEnabled = true;
            this.s_id_cmb.Location = new System.Drawing.Point(140, 60);
            this.s_id_cmb.Name = "s_id_cmb";
            this.s_id_cmb.Size = new System.Drawing.Size(200, 24);
            this.s_id_cmb.TabIndex = 4;
            // 
            // en_date_txt
            // 
            this.en_date_txt.Location = new System.Drawing.Point(140, 91);
            this.en_date_txt.Name = "en_date_txt";
            this.en_date_txt.Size = new System.Drawing.Size(200, 22);
            this.en_date_txt.TabIndex = 5;
            // 
            // submit_btn
            // 
            this.submit_btn.Location = new System.Drawing.Point(140, 120);
            this.submit_btn.Name = "submit_btn";
            this.submit_btn.Size = new System.Drawing.Size(200, 23);
            this.submit_btn.TabIndex = 6;
            this.submit_btn.Text = "Insert/Update";
            this.submit_btn.UseVisualStyleBackColor = true;
            this.submit_btn.Click += new System.EventHandler(this.submit_btn_Click);
            // 
            // EnrolmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 313);
            this.Controls.Add(this.submit_btn);
            this.Controls.Add(this.en_date_txt);
            this.Controls.Add(this.s_id_cmb);
            this.Controls.Add(this.c_id_cmb);
            this.Controls.Add(this.en_data_lbl);
            this.Controls.Add(this.student_id_lbl);
            this.Controls.Add(this.course_id_lbl);
            this.Name = "EnrolmentForm";
            this.Text = "Enrolment Form";
            this.ResumeLayout(false);
            this.PerformLayout();

            this.FormClosed += new System.Windows.Forms.
                FormClosedEventHandler(this.EnrolmentForm_FormClosed);

        }

        #endregion

        private System.Windows.Forms.Label course_id_lbl;
        private System.Windows.Forms.Label student_id_lbl;
        private System.Windows.Forms.Label en_data_lbl;
        private System.Windows.Forms.ComboBox c_id_cmb;
        private System.Windows.Forms.ComboBox s_id_cmb;
        private System.Windows.Forms.TextBox en_date_txt;
        private System.Windows.Forms.Button submit_btn;
    }
}