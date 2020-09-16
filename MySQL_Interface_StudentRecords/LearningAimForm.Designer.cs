namespace MySQL_Interface_StudentRecords
{
    partial class LearningAimForm
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
            this.dep_id_lbl = new System.Windows.Forms.Label();
            this.l_learning_aim_title_lbl = new System.Windows.Forms.Label();
            this.l_learning_aim_des_lbl = new System.Windows.Forms.Label();
            this.dep_id_cmb = new System.Windows.Forms.ComboBox();
            this.l_learning_aim_titile_txt = new System.Windows.Forms.TextBox();
            this.l_learning_aim_des_txt = new System.Windows.Forms.TextBox();
            this.submit_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dep_id_lbl
            // 
            this.dep_id_lbl.AutoSize = true;
            this.dep_id_lbl.Location = new System.Drawing.Point(35, 30);
            this.dep_id_lbl.Name = "dep_id_lbl";
            this.dep_id_lbl.Size = new System.Drawing.Size(99, 17);
            this.dep_id_lbl.TabIndex = 0;
            this.dep_id_lbl.Text = "Department ID";
            // 
            // l_learning_aim_title_lbl
            // 
            this.l_learning_aim_title_lbl.AutoSize = true;
            this.l_learning_aim_title_lbl.Location = new System.Drawing.Point(35, 60);
            this.l_learning_aim_title_lbl.Name = "l_learning_aim_title_lbl";
            this.l_learning_aim_title_lbl.Size = new System.Drawing.Size(35, 17);
            this.l_learning_aim_title_lbl.TabIndex = 1;
            this.l_learning_aim_title_lbl.Text = "Title";
            // 
            // l_learning_aim_des_lbl
            // 
            this.l_learning_aim_des_lbl.AutoSize = true;
            this.l_learning_aim_des_lbl.Location = new System.Drawing.Point(35, 90);
            this.l_learning_aim_des_lbl.Name = "l_learning_aim_des_lbl";
            this.l_learning_aim_des_lbl.Size = new System.Drawing.Size(76, 17);
            this.l_learning_aim_des_lbl.TabIndex = 2;
            this.l_learning_aim_des_lbl.Text = "Descrption";
            // 
            // dep_id_cmb
            // 
            this.dep_id_cmb.FormattingEnabled = true;
            this.dep_id_cmb.Location = new System.Drawing.Point(140, 30);
            this.dep_id_cmb.Name = "dep_id_cmb";
            this.dep_id_cmb.Size = new System.Drawing.Size(200, 24);
            this.dep_id_cmb.TabIndex = 3;
            // 
            // l_learning_aim_titile_txt
            // 
            this.l_learning_aim_titile_txt.Location = new System.Drawing.Point(140, 60);
            this.l_learning_aim_titile_txt.Name = "l_learning_aim_titile_txt";
            this.l_learning_aim_titile_txt.Size = new System.Drawing.Size(200, 22);
            this.l_learning_aim_titile_txt.TabIndex = 4;
            // 
            // l_learning_aim_des_txt
            // 
            this.l_learning_aim_des_txt.Location = new System.Drawing.Point(140, 90);
            this.l_learning_aim_des_txt.Multiline = true;
            this.l_learning_aim_des_txt.Name = "l_learning_aim_des_txt";
            this.l_learning_aim_des_txt.Size = new System.Drawing.Size(200, 180);
            this.l_learning_aim_des_txt.TabIndex = 5;
            // 
            // submit_btn
            // 
            this.submit_btn.Location = new System.Drawing.Point(140, 285);
            this.submit_btn.Name = "submit_btn";
            this.submit_btn.Size = new System.Drawing.Size(150, 25);
            this.submit_btn.TabIndex = 6;
            this.submit_btn.Text = "Insert/Update";
            this.submit_btn.UseVisualStyleBackColor = true;
            this.submit_btn.Click += new System.EventHandler(this.submit_btn_Click);
            // 
            // LearningAimForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 313);
            this.Controls.Add(this.submit_btn);
            this.Controls.Add(this.l_learning_aim_des_txt);
            this.Controls.Add(this.l_learning_aim_titile_txt);
            this.Controls.Add(this.dep_id_cmb);
            this.Controls.Add(this.l_learning_aim_des_lbl);
            this.Controls.Add(this.l_learning_aim_title_lbl);
            this.Controls.Add(this.dep_id_lbl);
            this.Name = "LearningAimForm";
            this.Text = "Learning Aim Form";
            this.ResumeLayout(false);
            this.PerformLayout();

            this.FormClosed += new System.Windows.Forms.
                FormClosedEventHandler(this.LearningAimForm_FormClosed);

        }

        #endregion

        private System.Windows.Forms.Label dep_id_lbl;
        private System.Windows.Forms.Label l_learning_aim_title_lbl;
        private System.Windows.Forms.Label l_learning_aim_des_lbl;
        private System.Windows.Forms.ComboBox dep_id_cmb;
        private System.Windows.Forms.TextBox l_learning_aim_titile_txt;
        private System.Windows.Forms.TextBox l_learning_aim_des_txt;
        private System.Windows.Forms.Button submit_btn;
    }
}