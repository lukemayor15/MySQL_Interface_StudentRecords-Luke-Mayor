namespace MySQL_Interface_StudentRecords
{
    partial class CourseForm
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
            this.c_cname_lbl = new System.Windows.Forms.Label();
            this.aim_id_lbl = new System.Windows.Forms.Label();
            this.c_start_d_lbl = new System.Windows.Forms.Label();
            this.c_end_d_lbl = new System.Windows.Forms.Label();
            this.c_level = new System.Windows.Forms.Label();
            this.aim_id_cmb = new System.Windows.Forms.ComboBox();
            this.c_level_txt = new System.Windows.Forms.TextBox();
            this.c_start_d_txt = new System.Windows.Forms.TextBox();
            this.c_end_d_txt = new System.Windows.Forms.TextBox();
            this.submit_btn = new System.Windows.Forms.Button();
            this.c_cname_txt = new System.Windows.Forms.TextBox();
            this.c_date_format_lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // c_cname_lbl
            // 
            this.c_cname_lbl.AutoSize = true;
            this.c_cname_lbl.Location = new System.Drawing.Point(35, 60);
            this.c_cname_lbl.Name = "c_cname_lbl";
            this.c_cname_lbl.Size = new System.Drawing.Size(45, 17);
            this.c_cname_lbl.TabIndex = 0;
            this.c_cname_lbl.Text = "Name";
            // 
            // aim_id_lbl
            // 
            this.aim_id_lbl.AutoSize = true;
            this.aim_id_lbl.Location = new System.Drawing.Point(35, 30);
            this.aim_id_lbl.Name = "aim_id_lbl";
            this.aim_id_lbl.Size = new System.Drawing.Size(48, 17);
            this.aim_id_lbl.TabIndex = 1;
            this.aim_id_lbl.Text = "Aim ID";
            // 
            // c_start_d_lbl
            // 
            this.c_start_d_lbl.AutoSize = true;
            this.c_start_d_lbl.Location = new System.Drawing.Point(35, 120);
            this.c_start_d_lbl.Name = "c_start_d_lbl";
            this.c_start_d_lbl.Size = new System.Drawing.Size(72, 17);
            this.c_start_d_lbl.TabIndex = 2;
            this.c_start_d_lbl.Text = "Start Data";
            this.c_start_d_lbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // c_end_d_lbl
            // 
            this.c_end_d_lbl.AutoSize = true;
            this.c_end_d_lbl.Location = new System.Drawing.Point(35, 150);
            this.c_end_d_lbl.Name = "c_end_d_lbl";
            this.c_end_d_lbl.Size = new System.Drawing.Size(67, 17);
            this.c_end_d_lbl.TabIndex = 3;
            this.c_end_d_lbl.Text = "End Data";
            // 
            // c_level
            // 
            this.c_level.AutoSize = true;
            this.c_level.Location = new System.Drawing.Point(35, 91);
            this.c_level.Name = "c_level";
            this.c_level.Size = new System.Drawing.Size(42, 17);
            this.c_level.TabIndex = 4;
            this.c_level.Text = "Level";
            // 
            // aim_id_cmb
            // 
            this.aim_id_cmb.FormattingEnabled = true;
            this.aim_id_cmb.Location = new System.Drawing.Point(140, 30);
            this.aim_id_cmb.Name = "aim_id_cmb";
            this.aim_id_cmb.Size = new System.Drawing.Size(200, 24);
            this.aim_id_cmb.TabIndex = 5;
            // 
            // c_level_txt
            // 
            this.c_level_txt.Location = new System.Drawing.Point(140, 91);
            this.c_level_txt.Name = "c_level_txt";
            this.c_level_txt.Size = new System.Drawing.Size(200, 22);
            this.c_level_txt.TabIndex = 7;
            // 
            // c_start_d_txt
            // 
            this.c_start_d_txt.Location = new System.Drawing.Point(140, 120);
            this.c_start_d_txt.Name = "c_start_d_txt";
            this.c_start_d_txt.Size = new System.Drawing.Size(200, 22);
            this.c_start_d_txt.TabIndex = 8;
            // 
            // c_end_d_txt
            // 
            this.c_end_d_txt.Location = new System.Drawing.Point(140, 150);
            this.c_end_d_txt.Name = "c_end_d_txt";
            this.c_end_d_txt.Size = new System.Drawing.Size(200, 22);
            this.c_end_d_txt.TabIndex = 9;
            // 
            // submit_btn
            // 
            this.submit_btn.Location = new System.Drawing.Point(140, 199);
            this.submit_btn.Name = "submit_btn";
            this.submit_btn.Size = new System.Drawing.Size(200, 23);
            this.submit_btn.TabIndex = 10;
            this.submit_btn.Text = "Insert/Update";
            this.submit_btn.UseVisualStyleBackColor = true;
            this.submit_btn.Click += new System.EventHandler(this.submit_btn_Click);
            // 
            // c_cname_txt
            // 
            this.c_cname_txt.Location = new System.Drawing.Point(140, 60);
            this.c_cname_txt.Name = "c_cname_txt";
            this.c_cname_txt.Size = new System.Drawing.Size(200, 22);
            this.c_cname_txt.TabIndex = 11;
            // 
            // c_date_format_lbl
            // 
            this.c_date_format_lbl.AutoSize = true;
            this.c_date_format_lbl.Location = new System.Drawing.Point(140, 179);
            this.c_date_format_lbl.Name = "c_date_format_lbl";
            this.c_date_format_lbl.Size = new System.Drawing.Size(132, 17);
            this.c_date_format_lbl.TabIndex = 12;
            this.c_date_format_lbl.Text = "Format yyyy-mm-dd";
            // 
            // CourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 313);
            this.Controls.Add(this.c_date_format_lbl);
            this.Controls.Add(this.c_cname_txt);
            this.Controls.Add(this.submit_btn);
            this.Controls.Add(this.c_end_d_txt);
            this.Controls.Add(this.c_start_d_txt);
            this.Controls.Add(this.c_level_txt);
            this.Controls.Add(this.aim_id_cmb);
            this.Controls.Add(this.c_level);
            this.Controls.Add(this.c_end_d_lbl);
            this.Controls.Add(this.c_start_d_lbl);
            this.Controls.Add(this.aim_id_lbl);
            this.Controls.Add(this.c_cname_lbl);
            this.Name = "CourseForm";
            this.Text = "Course Form";
            this.ResumeLayout(false);
            this.PerformLayout();

            this.FormClosed += new System.Windows.Forms.
                FormClosedEventHandler(this.CourseForm_FormColsed);

        }

        #endregion

        private System.Windows.Forms.Label c_cname_lbl;
        private System.Windows.Forms.Label aim_id_lbl;
        private System.Windows.Forms.Label c_start_d_lbl;
        private System.Windows.Forms.Label c_end_d_lbl;
        private System.Windows.Forms.Label c_level;
        private System.Windows.Forms.ComboBox aim_id_cmb;
        private System.Windows.Forms.TextBox c_level_txt;
        private System.Windows.Forms.TextBox c_start_d_txt;
        private System.Windows.Forms.TextBox c_end_d_txt;
        private System.Windows.Forms.Button submit_btn;
        private System.Windows.Forms.TextBox c_cname_txt;
        private System.Windows.Forms.Label c_date_format_lbl;
    }
}