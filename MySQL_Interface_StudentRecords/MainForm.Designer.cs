namespace MySQL_Interface_StudentRecords
{
    partial class MainForm
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
            this.enrolmentf_tab = new System.Windows.Forms.TabPage();
            this.enrolmentf_s_cmb = new System.Windows.Forms.ComboBox();
            this.enrolmentf_s_lbl = new System.Windows.Forms.Label();
            this.enrolmentfilter_dg = new System.Windows.Forms.DataGridView();
            this.enrolmentf_clm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enrolmentf_course_clm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enrolmentf_student_clm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.test_btn = new System.Windows.Forms.Button();
            this.main_tbc = new System.Windows.Forms.TabControl();
            this.student_tab = new System.Windows.Forms.TabPage();
            this.search_s_sname_txt = new System.Windows.Forms.TextBox();
            this.search_s_sname_lbl = new System.Windows.Forms.Label();
            this.update_su_btn = new System.Windows.Forms.Button();
            this.delete_su_btn = new System.Windows.Forms.Button();
            this.insert_su_btn = new System.Windows.Forms.Button();
            this.select_su_btn = new System.Windows.Forms.Button();
            this.student_dg = new System.Windows.Forms.DataGridView();
            this.student_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.user_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.s_fname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.s_sname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.s_mname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.s_dob = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.s_phone_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.s_email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.s_id_image = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.user_account = new System.Windows.Forms.TabPage();
            this.search_user_uname_txt = new System.Windows.Forms.TextBox();
            this.search_user__uname_lbl = new System.Windows.Forms.Label();
            this.update_user_account = new System.Windows.Forms.Button();
            this.delete_user_btn = new System.Windows.Forms.Button();
            this.insert_user_btn = new System.Windows.Forms.Button();
            this.select_user_btn = new System.Windows.Forms.Button();
            this.user_account_dg = new System.Windows.Forms.DataGridView();
            this.staff_tab = new System.Windows.Forms.TabPage();
            this.search_staff_sname_txt = new System.Windows.Forms.TextBox();
            this.search_staff_sname_lbl = new System.Windows.Forms.Label();
            this.update_staff_btn = new System.Windows.Forms.Button();
            this.delete_staff_btn = new System.Windows.Forms.Button();
            this.staff_insert_btn = new System.Windows.Forms.Button();
            this.select_staff_btn = new System.Windows.Forms.Button();
            this.staff_dg = new System.Windows.Forms.DataGridView();
            this.staff_id_clm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.st_user_id_clm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.st_fname_clm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.st_sname_clm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.st_mname_lbl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.st_dob_clm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.st_phone_no_clm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.st_email_clm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.st_id_image = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.next_of_kin_tab = new System.Windows.Forms.TabPage();
            this.search_next_of_kin_kin_id_txt = new System.Windows.Forms.TextBox();
            this.search_next_of_kin_kin_id_lbl = new System.Windows.Forms.Label();
            this.update_next_of_kin_btn = new System.Windows.Forms.Button();
            this.delete_next_of_kin_btn = new System.Windows.Forms.Button();
            this.insert_next_of_kin_btn = new System.Windows.Forms.Button();
            this.select_nect_of_kin_btn = new System.Windows.Forms.Button();
            this.next_of_kin_dg = new System.Windows.Forms.DataGridView();
            this.kin_id_clm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.k_user_id_clm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.k_fname_clm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.k_phone_no_clm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address_tab = new System.Windows.Forms.TabPage();
            this.search_address_town_txt = new System.Windows.Forms.TextBox();
            this.search_address_town_lbl = new System.Windows.Forms.Label();
            this.update_address_btn = new System.Windows.Forms.Button();
            this.delete_address_btn = new System.Windows.Forms.Button();
            this.insert_address_btn = new System.Windows.Forms.Button();
            this.select_address_btn = new System.Windows.Forms.Button();
            this.address_dg = new System.Windows.Forms.DataGridView();
            this.address_id_clm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.a_user_id_clm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.a_postcode_clm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.a_address_line1_clm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.a_address_line2_clm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.a_town_clm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.a_county_clm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.a_current_address_clm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dep_tab = new System.Windows.Forms.TabPage();
            this.search_dep_leader_txt = new System.Windows.Forms.TextBox();
            this.search_dep_leader_lbl = new System.Windows.Forms.Label();
            this.update_dep_btn = new System.Windows.Forms.Button();
            this.delete_dep_btn = new System.Windows.Forms.Button();
            this.insert_dep_btn = new System.Windows.Forms.Button();
            this.select_dep_btn = new System.Windows.Forms.Button();
            this.dep_dg = new System.Windows.Forms.DataGridView();
            this.dep_id_clm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dep_name_clm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dep_email_clm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dep_phone_no_clm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dep_leader_clm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jobrole_tab = new System.Windows.Forms.TabPage();
            this.search_job_title_txt = new System.Windows.Forms.TextBox();
            this.search_job_title_lbl = new System.Windows.Forms.Label();
            this.update_j_role_btn = new System.Windows.Forms.Button();
            this.delete_j_role_btn = new System.Windows.Forms.Button();
            this.insert_j_role_btn = new System.Windows.Forms.Button();
            this.select_j_role_btn = new System.Windows.Forms.Button();
            this.J_role_dg = new System.Windows.Forms.DataGridView();
            this.role_id_clm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.j_staff_id_clm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.j_dep_id_clm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.j_title_clm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.learning_aim_tab = new System.Windows.Forms.TabPage();
            this.search_learning_aim_title_txt = new System.Windows.Forms.TextBox();
            this.search_learning_aim_title_lbl = new System.Windows.Forms.Label();
            this.update_learning_aim_btn = new System.Windows.Forms.Button();
            this.delete_learning_aim_btn = new System.Windows.Forms.Button();
            this.insert_learning_aim_btn = new System.Windows.Forms.Button();
            this.select_learning_aim_btn = new System.Windows.Forms.Button();
            this.learning_aim_dg = new System.Windows.Forms.DataGridView();
            this.aim_id_clm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.l_dep_id_clm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.l_learning_aim_title_clm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.l_learning_aim_des_clm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.course_tab = new System.Windows.Forms.TabPage();
            this.search_course_cname_txt = new System.Windows.Forms.TextBox();
            this.search_course_cname_lbl = new System.Windows.Forms.Label();
            this.update_course_btn = new System.Windows.Forms.Button();
            this.Delete_course_btn = new System.Windows.Forms.Button();
            this.insert_course_btn = new System.Windows.Forms.Button();
            this.select_course_btn = new System.Windows.Forms.Button();
            this.course_dg = new System.Windows.Forms.DataGridView();
            this.course_id_clm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_aim_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_cname_clm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_level_clm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_start_d_clm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_end_d_clm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enrolment_tab = new System.Windows.Forms.TabPage();
            this.search_enrolment_data_txt = new System.Windows.Forms.TextBox();
            this.search_enrolment_data_lbl = new System.Windows.Forms.Label();
            this.update_enrolment_btn = new System.Windows.Forms.Button();
            this.delete_enrolment_btn = new System.Windows.Forms.Button();
            this.insert_enrolment_btn = new System.Windows.Forms.Button();
            this.select_enrolment_btn = new System.Windows.Forms.Button();
            this.enrolment_dg = new System.Windows.Forms.DataGridView();
            this.enrolment_id_clm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.en_course_id_clm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.en_student_id_clm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.en_date_clm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jobrolef_tab = new System.Windows.Forms.TabPage();
            this.jobrolef_staff_cmb = new System.Windows.Forms.ComboBox();
            this.jobrolef_staff_lbl = new System.Windows.Forms.Label();
            this.jobrolef_dg = new System.Windows.Forms.DataGridView();
            this.jobrolef_id_clm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ep_clm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jobrolef_stname_clm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.user_id_clm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.u_uname_clm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.u_password_clm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.u_access_level_clm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enrolmentf_tab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.enrolmentfilter_dg)).BeginInit();
            this.main_tbc.SuspendLayout();
            this.student_tab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.student_dg)).BeginInit();
            this.user_account.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.user_account_dg)).BeginInit();
            this.staff_tab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.staff_dg)).BeginInit();
            this.next_of_kin_tab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.next_of_kin_dg)).BeginInit();
            this.address_tab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.address_dg)).BeginInit();
            this.dep_tab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dep_dg)).BeginInit();
            this.jobrole_tab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.J_role_dg)).BeginInit();
            this.learning_aim_tab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.learning_aim_dg)).BeginInit();
            this.course_tab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.course_dg)).BeginInit();
            this.enrolment_tab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.enrolment_dg)).BeginInit();
            this.jobrolef_tab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.jobrolef_dg)).BeginInit();
            this.SuspendLayout();
            // 
            // enrolmentf_tab
            // 
            this.enrolmentf_tab.Controls.Add(this.enrolmentf_s_cmb);
            this.enrolmentf_tab.Controls.Add(this.enrolmentf_s_lbl);
            this.enrolmentf_tab.Controls.Add(this.enrolmentfilter_dg);
            this.enrolmentf_tab.Location = new System.Drawing.Point(4, 25);
            this.enrolmentf_tab.Name = "enrolmentf_tab";
            this.enrolmentf_tab.Padding = new System.Windows.Forms.Padding(3);
            this.enrolmentf_tab.Size = new System.Drawing.Size(1102, 551);
            this.enrolmentf_tab.TabIndex = 10;
            this.enrolmentf_tab.Text = "Enrolment Filters";
            this.enrolmentf_tab.UseVisualStyleBackColor = true;
            this.enrolmentf_tab.Enter += new System.EventHandler(this.enrolmentf_tab_Enter);
            // 
            // enrolmentf_s_cmb
            // 
            this.enrolmentf_s_cmb.FormattingEnabled = true;
            this.enrolmentf_s_cmb.Location = new System.Drawing.Point(160, 60);
            this.enrolmentf_s_cmb.Name = "enrolmentf_s_cmb";
            this.enrolmentf_s_cmb.Size = new System.Drawing.Size(200, 24);
            this.enrolmentf_s_cmb.TabIndex = 2;
            this.enrolmentf_s_cmb.SelectedIndexChanged += new System.EventHandler(this.enrolmentf_s_cmb_SelectedIndexChanged);
            // 
            // enrolmentf_s_lbl
            // 
            this.enrolmentf_s_lbl.AutoSize = true;
            this.enrolmentf_s_lbl.Location = new System.Drawing.Point(20, 60);
            this.enrolmentf_s_lbl.Name = "enrolmentf_s_lbl";
            this.enrolmentf_s_lbl.Size = new System.Drawing.Size(111, 17);
            this.enrolmentf_s_lbl.TabIndex = 1;
            this.enrolmentf_s_lbl.Text = "Filter by Student";
            // 
            // enrolmentfilter_dg
            // 
            this.enrolmentfilter_dg.AllowUserToAddRows = false;
            this.enrolmentfilter_dg.AllowUserToDeleteRows = false;
            this.enrolmentfilter_dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.enrolmentfilter_dg.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.enrolmentf_clm,
            this.enrolmentf_course_clm,
            this.enrolmentf_student_clm});
            this.enrolmentfilter_dg.Location = new System.Drawing.Point(15, 100);
            this.enrolmentfilter_dg.Name = "enrolmentfilter_dg";
            this.enrolmentfilter_dg.ReadOnly = true;
            this.enrolmentfilter_dg.RowTemplate.Height = 24;
            this.enrolmentfilter_dg.Size = new System.Drawing.Size(1070, 440);
            this.enrolmentfilter_dg.TabIndex = 0;
            // 
            // enrolmentf_clm
            // 
            this.enrolmentf_clm.HeaderText = "Enrolment ID";
            this.enrolmentf_clm.Name = "enrolmentf_clm";
            this.enrolmentf_clm.ReadOnly = true;
            // 
            // enrolmentf_course_clm
            // 
            this.enrolmentf_course_clm.HeaderText = "Course Name";
            this.enrolmentf_course_clm.Name = "enrolmentf_course_clm";
            this.enrolmentf_course_clm.ReadOnly = true;
            // 
            // enrolmentf_student_clm
            // 
            this.enrolmentf_student_clm.HeaderText = "Student Name";
            this.enrolmentf_student_clm.Name = "enrolmentf_student_clm";
            this.enrolmentf_student_clm.ReadOnly = true;
            // 
            // test_btn
            // 
            this.test_btn.Location = new System.Drawing.Point(15, 600);
            this.test_btn.Name = "test_btn";
            this.test_btn.Size = new System.Drawing.Size(125, 25);
            this.test_btn.TabIndex = 0;
            this.test_btn.Text = "Test Connection";
            this.test_btn.UseVisualStyleBackColor = true;
            this.test_btn.Click += new System.EventHandler(this.test_btn_Click);
            // 
            // main_tbc
            // 
            this.main_tbc.Controls.Add(this.student_tab);
            this.main_tbc.Controls.Add(this.user_account);
            this.main_tbc.Controls.Add(this.staff_tab);
            this.main_tbc.Controls.Add(this.next_of_kin_tab);
            this.main_tbc.Controls.Add(this.address_tab);
            this.main_tbc.Controls.Add(this.dep_tab);
            this.main_tbc.Controls.Add(this.jobrole_tab);
            this.main_tbc.Controls.Add(this.learning_aim_tab);
            this.main_tbc.Controls.Add(this.course_tab);
            this.main_tbc.Controls.Add(this.enrolment_tab);
            this.main_tbc.Controls.Add(this.enrolmentf_tab);
            this.main_tbc.Controls.Add(this.jobrolef_tab);
            this.main_tbc.Location = new System.Drawing.Point(15, 15);
            this.main_tbc.Name = "main_tbc";
            this.main_tbc.SelectedIndex = 0;
            this.main_tbc.Size = new System.Drawing.Size(1110, 580);
            this.main_tbc.TabIndex = 1;
            // 
            // student_tab
            // 
            this.student_tab.Controls.Add(this.search_s_sname_txt);
            this.student_tab.Controls.Add(this.search_s_sname_lbl);
            this.student_tab.Controls.Add(this.update_su_btn);
            this.student_tab.Controls.Add(this.delete_su_btn);
            this.student_tab.Controls.Add(this.insert_su_btn);
            this.student_tab.Controls.Add(this.select_su_btn);
            this.student_tab.Controls.Add(this.student_dg);
            this.student_tab.Location = new System.Drawing.Point(4, 25);
            this.student_tab.Name = "student_tab";
            this.student_tab.Padding = new System.Windows.Forms.Padding(3);
            this.student_tab.Size = new System.Drawing.Size(1102, 551);
            this.student_tab.TabIndex = 0;
            this.student_tab.Text = "Students";
            this.student_tab.UseVisualStyleBackColor = true;
            // 
            // search_s_sname_txt
            // 
            this.search_s_sname_txt.Location = new System.Drawing.Point(821, 60);
            this.search_s_sname_txt.Name = "search_s_sname_txt";
            this.search_s_sname_txt.Size = new System.Drawing.Size(200, 22);
            this.search_s_sname_txt.TabIndex = 6;
            this.search_s_sname_txt.TextChanged += new System.EventHandler(this.search_s_sname_txt_TextChange);
            // 
            // search_s_sname_lbl
            // 
            this.search_s_sname_lbl.AutoSize = true;
            this.search_s_sname_lbl.Location = new System.Drawing.Point(651, 63);
            this.search_s_sname_lbl.Name = "search_s_sname_lbl";
            this.search_s_sname_lbl.Size = new System.Drawing.Size(134, 17);
            this.search_s_sname_lbl.TabIndex = 5;
            this.search_s_sname_lbl.Text = "Search on Surname";
            // 
            // update_su_btn
            // 
            this.update_su_btn.Location = new System.Drawing.Point(500, 60);
            this.update_su_btn.Name = "update_su_btn";
            this.update_su_btn.Size = new System.Drawing.Size(145, 25);
            this.update_su_btn.TabIndex = 4;
            this.update_su_btn.Text = "Update Customer";
            this.update_su_btn.UseVisualStyleBackColor = true;
            this.update_su_btn.Click += new System.EventHandler(this.update_su_btn_Click);
            // 
            // delete_su_btn
            // 
            this.delete_su_btn.Location = new System.Drawing.Point(340, 60);
            this.delete_su_btn.Name = "delete_su_btn";
            this.delete_su_btn.Size = new System.Drawing.Size(145, 25);
            this.delete_su_btn.TabIndex = 3;
            this.delete_su_btn.Text = "Delete Student";
            this.delete_su_btn.UseVisualStyleBackColor = true;
            this.delete_su_btn.Click += new System.EventHandler(this.delete_su_btn_Click);
            // 
            // insert_su_btn
            // 
            this.insert_su_btn.Location = new System.Drawing.Point(180, 60);
            this.insert_su_btn.Name = "insert_su_btn";
            this.insert_su_btn.Size = new System.Drawing.Size(145, 25);
            this.insert_su_btn.TabIndex = 2;
            this.insert_su_btn.Text = "Insert Student";
            this.insert_su_btn.UseVisualStyleBackColor = true;
            this.insert_su_btn.Click += new System.EventHandler(this.insert_su_btn_Click);
            // 
            // select_su_btn
            // 
            this.select_su_btn.Location = new System.Drawing.Point(20, 60);
            this.select_su_btn.Name = "select_su_btn";
            this.select_su_btn.Size = new System.Drawing.Size(145, 25);
            this.select_su_btn.TabIndex = 1;
            this.select_su_btn.Text = "Select Student";
            this.select_su_btn.UseVisualStyleBackColor = true;
            this.select_su_btn.Click += new System.EventHandler(this.select_su_btn_Click);
            // 
            // student_dg
            // 
            this.student_dg.AllowUserToAddRows = false;
            this.student_dg.AllowUserToDeleteRows = false;
            this.student_dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.student_dg.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.student_id,
            this.user_id,
            this.s_fname,
            this.s_sname,
            this.s_mname,
            this.s_dob,
            this.s_phone_no,
            this.s_email,
            this.s_id_image});
            this.student_dg.Location = new System.Drawing.Point(15, 100);
            this.student_dg.Name = "student_dg";
            this.student_dg.ReadOnly = true;
            this.student_dg.RowTemplate.Height = 24;
            this.student_dg.Size = new System.Drawing.Size(1070, 400);
            this.student_dg.TabIndex = 0;
            // 
            // student_id
            // 
            this.student_id.HeaderText = "Student ID";
            this.student_id.Name = "student_id";
            this.student_id.ReadOnly = true;
            // 
            // user_id
            // 
            this.user_id.HeaderText = "User ID";
            this.user_id.Name = "user_id";
            this.user_id.ReadOnly = true;
            // 
            // s_fname
            // 
            this.s_fname.HeaderText = "First Name";
            this.s_fname.Name = "s_fname";
            this.s_fname.ReadOnly = true;
            // 
            // s_sname
            // 
            this.s_sname.HeaderText = "Surname";
            this.s_sname.Name = "s_sname";
            this.s_sname.ReadOnly = true;
            // 
            // s_mname
            // 
            this.s_mname.HeaderText = "Middle Name";
            this.s_mname.Name = "s_mname";
            this.s_mname.ReadOnly = true;
            // 
            // s_dob
            // 
            this.s_dob.HeaderText = "Date of Birith";
            this.s_dob.Name = "s_dob";
            this.s_dob.ReadOnly = true;
            // 
            // s_phone_no
            // 
            this.s_phone_no.HeaderText = "Phone Number";
            this.s_phone_no.Name = "s_phone_no";
            this.s_phone_no.ReadOnly = true;
            // 
            // s_email
            // 
            this.s_email.HeaderText = "Email";
            this.s_email.Name = "s_email";
            this.s_email.ReadOnly = true;
            // 
            // s_id_image
            // 
            this.s_id_image.HeaderText = "Image ID";
            this.s_id_image.Name = "s_id_image";
            this.s_id_image.ReadOnly = true;
            // 
            // user_account
            // 
            this.user_account.Controls.Add(this.search_user_uname_txt);
            this.user_account.Controls.Add(this.search_user__uname_lbl);
            this.user_account.Controls.Add(this.update_user_account);
            this.user_account.Controls.Add(this.delete_user_btn);
            this.user_account.Controls.Add(this.insert_user_btn);
            this.user_account.Controls.Add(this.select_user_btn);
            this.user_account.Controls.Add(this.user_account_dg);
            this.user_account.Location = new System.Drawing.Point(4, 25);
            this.user_account.Name = "user_account";
            this.user_account.Padding = new System.Windows.Forms.Padding(3);
            this.user_account.Size = new System.Drawing.Size(1102, 551);
            this.user_account.TabIndex = 1;
            this.user_account.Text = "User Account";
            this.user_account.UseVisualStyleBackColor = true;
            // 
            // search_user_uname_txt
            // 
            this.search_user_uname_txt.Location = new System.Drawing.Point(199, 19);
            this.search_user_uname_txt.Name = "search_user_uname_txt";
            this.search_user_uname_txt.Size = new System.Drawing.Size(200, 22);
            this.search_user_uname_txt.TabIndex = 6;
            this.search_user_uname_txt.TextChanged += new System.EventHandler(this.search_user_uname_txt_TextChange);
            // 
            // search_user__uname_lbl
            // 
            this.search_user__uname_lbl.AutoSize = true;
            this.search_user__uname_lbl.Location = new System.Drawing.Point(12, 19);
            this.search_user__uname_lbl.Name = "search_user__uname_lbl";
            this.search_user__uname_lbl.Size = new System.Drawing.Size(148, 17);
            this.search_user__uname_lbl.TabIndex = 5;
            this.search_user__uname_lbl.Text = "Search on User Name";
            // 
            // update_user_account
            // 
            this.update_user_account.Location = new System.Drawing.Point(732, 61);
            this.update_user_account.Name = "update_user_account";
            this.update_user_account.Size = new System.Drawing.Size(220, 25);
            this.update_user_account.TabIndex = 4;
            this.update_user_account.Text = "Update User Account";
            this.update_user_account.UseVisualStyleBackColor = true;
            this.update_user_account.Click += new System.EventHandler(this.update_user_account_Click);
            // 
            // delete_user_btn
            // 
            this.delete_user_btn.Location = new System.Drawing.Point(496, 61);
            this.delete_user_btn.Name = "delete_user_btn";
            this.delete_user_btn.Size = new System.Drawing.Size(220, 25);
            this.delete_user_btn.TabIndex = 3;
            this.delete_user_btn.Text = "Delete User Account";
            this.delete_user_btn.UseVisualStyleBackColor = true;
            this.delete_user_btn.Click += new System.EventHandler(this.delete_user_btn_Click);
            // 
            // insert_user_btn
            // 
            this.insert_user_btn.Location = new System.Drawing.Point(254, 61);
            this.insert_user_btn.Name = "insert_user_btn";
            this.insert_user_btn.Size = new System.Drawing.Size(220, 25);
            this.insert_user_btn.TabIndex = 2;
            this.insert_user_btn.Text = "Insert User Account";
            this.insert_user_btn.UseVisualStyleBackColor = true;
            this.insert_user_btn.Click += new System.EventHandler(this.insert_user_btn_Click);
            // 
            // select_user_btn
            // 
            this.select_user_btn.Location = new System.Drawing.Point(15, 61);
            this.select_user_btn.Name = "select_user_btn";
            this.select_user_btn.Size = new System.Drawing.Size(220, 25);
            this.select_user_btn.TabIndex = 1;
            this.select_user_btn.Text = "Select User Accounts";
            this.select_user_btn.UseVisualStyleBackColor = true;
            this.select_user_btn.Click += new System.EventHandler(this.select_user_btn_Click);
            // 
            // user_account_dg
            // 
            this.user_account_dg.AllowUserToAddRows = false;
            this.user_account_dg.AllowUserToDeleteRows = false;
            this.user_account_dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.user_account_dg.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.user_id_clm,
            this.u_uname_clm,
            this.u_password_clm,
            this.u_access_level_clm});
            this.user_account_dg.Location = new System.Drawing.Point(15, 100);
            this.user_account_dg.Name = "user_account_dg";
            this.user_account_dg.ReadOnly = true;
            this.user_account_dg.RowTemplate.Height = 24;
            this.user_account_dg.Size = new System.Drawing.Size(1070, 440);
            this.user_account_dg.TabIndex = 0;
            // 
            // staff_tab
            // 
            this.staff_tab.Controls.Add(this.search_staff_sname_txt);
            this.staff_tab.Controls.Add(this.search_staff_sname_lbl);
            this.staff_tab.Controls.Add(this.update_staff_btn);
            this.staff_tab.Controls.Add(this.delete_staff_btn);
            this.staff_tab.Controls.Add(this.staff_insert_btn);
            this.staff_tab.Controls.Add(this.select_staff_btn);
            this.staff_tab.Controls.Add(this.staff_dg);
            this.staff_tab.Location = new System.Drawing.Point(4, 25);
            this.staff_tab.Name = "staff_tab";
            this.staff_tab.Padding = new System.Windows.Forms.Padding(3);
            this.staff_tab.Size = new System.Drawing.Size(1102, 551);
            this.staff_tab.TabIndex = 2;
            this.staff_tab.Text = "Staff ";
            this.staff_tab.UseVisualStyleBackColor = true;
            // 
            // search_staff_sname_txt
            // 
            this.search_staff_sname_txt.Location = new System.Drawing.Point(812, 65);
            this.search_staff_sname_txt.Name = "search_staff_sname_txt";
            this.search_staff_sname_txt.Size = new System.Drawing.Size(200, 22);
            this.search_staff_sname_txt.TabIndex = 6;
            this.search_staff_sname_txt.TextChanged += new System.EventHandler(this.search_staff_sname_text_TextChange);
            // 
            // search_staff_sname_lbl
            // 
            this.search_staff_sname_lbl.AutoSize = true;
            this.search_staff_sname_lbl.Location = new System.Drawing.Point(660, 65);
            this.search_staff_sname_lbl.Name = "search_staff_sname_lbl";
            this.search_staff_sname_lbl.Size = new System.Drawing.Size(134, 17);
            this.search_staff_sname_lbl.TabIndex = 5;
            this.search_staff_sname_lbl.Text = "Search on Surname";
            // 
            // update_staff_btn
            // 
            this.update_staff_btn.Location = new System.Drawing.Point(500, 60);
            this.update_staff_btn.Name = "update_staff_btn";
            this.update_staff_btn.Size = new System.Drawing.Size(145, 25);
            this.update_staff_btn.TabIndex = 4;
            this.update_staff_btn.Text = "Update Staff";
            this.update_staff_btn.UseVisualStyleBackColor = true;
            this.update_staff_btn.Click += new System.EventHandler(this.update_staff_btn_Click);
            // 
            // delete_staff_btn
            // 
            this.delete_staff_btn.Location = new System.Drawing.Point(340, 60);
            this.delete_staff_btn.Name = "delete_staff_btn";
            this.delete_staff_btn.Size = new System.Drawing.Size(145, 25);
            this.delete_staff_btn.TabIndex = 3;
            this.delete_staff_btn.Text = "Delete Staff";
            this.delete_staff_btn.UseVisualStyleBackColor = true;
            this.delete_staff_btn.Click += new System.EventHandler(this.delete_staff_btn_Click);
            // 
            // staff_insert_btn
            // 
            this.staff_insert_btn.Location = new System.Drawing.Point(180, 60);
            this.staff_insert_btn.Name = "staff_insert_btn";
            this.staff_insert_btn.Size = new System.Drawing.Size(145, 25);
            this.staff_insert_btn.TabIndex = 2;
            this.staff_insert_btn.Text = "Insert Staff";
            this.staff_insert_btn.UseVisualStyleBackColor = true;
            this.staff_insert_btn.Click += new System.EventHandler(this.staff_insert_btn_Click);
            // 
            // select_staff_btn
            // 
            this.select_staff_btn.Location = new System.Drawing.Point(20, 60);
            this.select_staff_btn.Name = "select_staff_btn";
            this.select_staff_btn.Size = new System.Drawing.Size(145, 25);
            this.select_staff_btn.TabIndex = 1;
            this.select_staff_btn.Text = "Select Staff";
            this.select_staff_btn.UseVisualStyleBackColor = true;
            this.select_staff_btn.Click += new System.EventHandler(this.select_staff_btn_Click);
            // 
            // staff_dg
            // 
            this.staff_dg.AllowUserToAddRows = false;
            this.staff_dg.AllowUserToDeleteRows = false;
            this.staff_dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.staff_dg.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.staff_id_clm,
            this.st_user_id_clm,
            this.st_fname_clm,
            this.st_sname_clm,
            this.st_mname_lbl,
            this.st_dob_clm,
            this.st_phone_no_clm,
            this.st_email_clm,
            this.st_id_image});
            this.staff_dg.Location = new System.Drawing.Point(15, 100);
            this.staff_dg.Name = "staff_dg";
            this.staff_dg.ReadOnly = true;
            this.staff_dg.RowTemplate.Height = 24;
            this.staff_dg.Size = new System.Drawing.Size(1070, 440);
            this.staff_dg.TabIndex = 0;
            // 
            // staff_id_clm
            // 
            this.staff_id_clm.HeaderText = "Staff ID";
            this.staff_id_clm.Name = "staff_id_clm";
            this.staff_id_clm.ReadOnly = true;
            // 
            // st_user_id_clm
            // 
            this.st_user_id_clm.HeaderText = "User ID";
            this.st_user_id_clm.Name = "st_user_id_clm";
            this.st_user_id_clm.ReadOnly = true;
            // 
            // st_fname_clm
            // 
            this.st_fname_clm.HeaderText = "First Name";
            this.st_fname_clm.Name = "st_fname_clm";
            this.st_fname_clm.ReadOnly = true;
            // 
            // st_sname_clm
            // 
            this.st_sname_clm.HeaderText = "Surname";
            this.st_sname_clm.Name = "st_sname_clm";
            this.st_sname_clm.ReadOnly = true;
            // 
            // st_mname_lbl
            // 
            this.st_mname_lbl.HeaderText = "Middle Name";
            this.st_mname_lbl.Name = "st_mname_lbl";
            this.st_mname_lbl.ReadOnly = true;
            // 
            // st_dob_clm
            // 
            this.st_dob_clm.HeaderText = "Data of Birith";
            this.st_dob_clm.Name = "st_dob_clm";
            this.st_dob_clm.ReadOnly = true;
            // 
            // st_phone_no_clm
            // 
            this.st_phone_no_clm.HeaderText = "Phone No";
            this.st_phone_no_clm.Name = "st_phone_no_clm";
            this.st_phone_no_clm.ReadOnly = true;
            // 
            // st_email_clm
            // 
            this.st_email_clm.HeaderText = "Email";
            this.st_email_clm.Name = "st_email_clm";
            this.st_email_clm.ReadOnly = true;
            // 
            // st_id_image
            // 
            this.st_id_image.HeaderText = "ID Image";
            this.st_id_image.Name = "st_id_image";
            this.st_id_image.ReadOnly = true;
            // 
            // next_of_kin_tab
            // 
            this.next_of_kin_tab.Controls.Add(this.search_next_of_kin_kin_id_txt);
            this.next_of_kin_tab.Controls.Add(this.search_next_of_kin_kin_id_lbl);
            this.next_of_kin_tab.Controls.Add(this.update_next_of_kin_btn);
            this.next_of_kin_tab.Controls.Add(this.delete_next_of_kin_btn);
            this.next_of_kin_tab.Controls.Add(this.insert_next_of_kin_btn);
            this.next_of_kin_tab.Controls.Add(this.select_nect_of_kin_btn);
            this.next_of_kin_tab.Controls.Add(this.next_of_kin_dg);
            this.next_of_kin_tab.Location = new System.Drawing.Point(4, 25);
            this.next_of_kin_tab.Name = "next_of_kin_tab";
            this.next_of_kin_tab.Padding = new System.Windows.Forms.Padding(3);
            this.next_of_kin_tab.Size = new System.Drawing.Size(1102, 551);
            this.next_of_kin_tab.TabIndex = 3;
            this.next_of_kin_tab.Text = "Next Of Kin";
            this.next_of_kin_tab.UseVisualStyleBackColor = true;
            // 
            // search_next_of_kin_kin_id_txt
            // 
            this.search_next_of_kin_kin_id_txt.Location = new System.Drawing.Point(775, 65);
            this.search_next_of_kin_kin_id_txt.Name = "search_next_of_kin_kin_id_txt";
            this.search_next_of_kin_kin_id_txt.Size = new System.Drawing.Size(200, 22);
            this.search_next_of_kin_kin_id_txt.TabIndex = 6;
            this.search_next_of_kin_kin_id_txt.TextChanged += new System.EventHandler(this.search_next_of_kin_kin_id_txt_TextChange);
            // 
            // search_next_of_kin_kin_id_lbl
            // 
            this.search_next_of_kin_kin_id_lbl.AutoSize = true;
            this.search_next_of_kin_kin_id_lbl.Location = new System.Drawing.Point(660, 65);
            this.search_next_of_kin_kin_id_lbl.Name = "search_next_of_kin_kin_id_lbl";
            this.search_next_of_kin_kin_id_lbl.Size = new System.Drawing.Size(94, 17);
            this.search_next_of_kin_kin_id_lbl.TabIndex = 5;
            this.search_next_of_kin_kin_id_lbl.Text = "Search Kin ID";
            // 
            // update_next_of_kin_btn
            // 
            this.update_next_of_kin_btn.Location = new System.Drawing.Point(500, 60);
            this.update_next_of_kin_btn.Name = "update_next_of_kin_btn";
            this.update_next_of_kin_btn.Size = new System.Drawing.Size(145, 25);
            this.update_next_of_kin_btn.TabIndex = 4;
            this.update_next_of_kin_btn.Text = "Update Next Of Kin";
            this.update_next_of_kin_btn.UseVisualStyleBackColor = true;
            this.update_next_of_kin_btn.Click += new System.EventHandler(this.update_next_of_kin_btn_Click);
            // 
            // delete_next_of_kin_btn
            // 
            this.delete_next_of_kin_btn.Location = new System.Drawing.Point(340, 60);
            this.delete_next_of_kin_btn.Name = "delete_next_of_kin_btn";
            this.delete_next_of_kin_btn.Size = new System.Drawing.Size(145, 25);
            this.delete_next_of_kin_btn.TabIndex = 3;
            this.delete_next_of_kin_btn.Text = "Delete Next Of Kin";
            this.delete_next_of_kin_btn.UseVisualStyleBackColor = true;
            this.delete_next_of_kin_btn.Click += new System.EventHandler(this.delete_next_of_kin_btn_Click);
            // 
            // insert_next_of_kin_btn
            // 
            this.insert_next_of_kin_btn.Location = new System.Drawing.Point(180, 60);
            this.insert_next_of_kin_btn.Name = "insert_next_of_kin_btn";
            this.insert_next_of_kin_btn.Size = new System.Drawing.Size(145, 25);
            this.insert_next_of_kin_btn.TabIndex = 2;
            this.insert_next_of_kin_btn.Text = "Insert Next Of Kin";
            this.insert_next_of_kin_btn.UseVisualStyleBackColor = true;
            this.insert_next_of_kin_btn.Click += new System.EventHandler(this.insert_next_of_kin_btn_Click);
            // 
            // select_nect_of_kin_btn
            // 
            this.select_nect_of_kin_btn.Location = new System.Drawing.Point(20, 60);
            this.select_nect_of_kin_btn.Name = "select_nect_of_kin_btn";
            this.select_nect_of_kin_btn.Size = new System.Drawing.Size(145, 25);
            this.select_nect_of_kin_btn.TabIndex = 1;
            this.select_nect_of_kin_btn.Text = "Select Next Of kin";
            this.select_nect_of_kin_btn.UseVisualStyleBackColor = true;
            this.select_nect_of_kin_btn.Click += new System.EventHandler(this.select_nect_of_kin_btn_Click);
            // 
            // next_of_kin_dg
            // 
            this.next_of_kin_dg.AllowUserToAddRows = false;
            this.next_of_kin_dg.AllowUserToDeleteRows = false;
            this.next_of_kin_dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.next_of_kin_dg.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kin_id_clm,
            this.k_user_id_clm,
            this.k_fname_clm,
            this.k_phone_no_clm});
            this.next_of_kin_dg.Location = new System.Drawing.Point(15, 100);
            this.next_of_kin_dg.Name = "next_of_kin_dg";
            this.next_of_kin_dg.ReadOnly = true;
            this.next_of_kin_dg.RowTemplate.Height = 24;
            this.next_of_kin_dg.Size = new System.Drawing.Size(1070, 440);
            this.next_of_kin_dg.TabIndex = 0;
            // 
            // kin_id_clm
            // 
            this.kin_id_clm.HeaderText = "Kin ID";
            this.kin_id_clm.Name = "kin_id_clm";
            this.kin_id_clm.ReadOnly = true;
            // 
            // k_user_id_clm
            // 
            this.k_user_id_clm.HeaderText = "User ID";
            this.k_user_id_clm.Name = "k_user_id_clm";
            this.k_user_id_clm.ReadOnly = true;
            // 
            // k_fname_clm
            // 
            this.k_fname_clm.HeaderText = "First Name";
            this.k_fname_clm.Name = "k_fname_clm";
            this.k_fname_clm.ReadOnly = true;
            // 
            // k_phone_no_clm
            // 
            this.k_phone_no_clm.HeaderText = "Phone No";
            this.k_phone_no_clm.Name = "k_phone_no_clm";
            this.k_phone_no_clm.ReadOnly = true;
            // 
            // address_tab
            // 
            this.address_tab.Controls.Add(this.search_address_town_txt);
            this.address_tab.Controls.Add(this.search_address_town_lbl);
            this.address_tab.Controls.Add(this.update_address_btn);
            this.address_tab.Controls.Add(this.delete_address_btn);
            this.address_tab.Controls.Add(this.insert_address_btn);
            this.address_tab.Controls.Add(this.select_address_btn);
            this.address_tab.Controls.Add(this.address_dg);
            this.address_tab.Location = new System.Drawing.Point(4, 25);
            this.address_tab.Name = "address_tab";
            this.address_tab.Padding = new System.Windows.Forms.Padding(3);
            this.address_tab.Size = new System.Drawing.Size(1102, 551);
            this.address_tab.TabIndex = 4;
            this.address_tab.Text = "Address ";
            this.address_tab.UseVisualStyleBackColor = true;
            // 
            // search_address_town_txt
            // 
            this.search_address_town_txt.Location = new System.Drawing.Point(775, 65);
            this.search_address_town_txt.Name = "search_address_town_txt";
            this.search_address_town_txt.Size = new System.Drawing.Size(200, 22);
            this.search_address_town_txt.TabIndex = 6;
            this.search_address_town_txt.TextChanged += new System.EventHandler(this.search_address_town_txt_TextChange);
            // 
            // search_address_town_lbl
            // 
            this.search_address_town_lbl.AutoSize = true;
            this.search_address_town_lbl.Location = new System.Drawing.Point(660, 65);
            this.search_address_town_lbl.Name = "search_address_town_lbl";
            this.search_address_town_lbl.Size = new System.Drawing.Size(110, 17);
            this.search_address_town_lbl.TabIndex = 5;
            this.search_address_town_lbl.Text = "Search by Town";
            // 
            // update_address_btn
            // 
            this.update_address_btn.Location = new System.Drawing.Point(500, 60);
            this.update_address_btn.Name = "update_address_btn";
            this.update_address_btn.Size = new System.Drawing.Size(145, 25);
            this.update_address_btn.TabIndex = 4;
            this.update_address_btn.Text = "Update Address";
            this.update_address_btn.UseVisualStyleBackColor = true;
            this.update_address_btn.Click += new System.EventHandler(this.update_address_btn_Click);
            // 
            // delete_address_btn
            // 
            this.delete_address_btn.Location = new System.Drawing.Point(340, 60);
            this.delete_address_btn.Name = "delete_address_btn";
            this.delete_address_btn.Size = new System.Drawing.Size(145, 25);
            this.delete_address_btn.TabIndex = 3;
            this.delete_address_btn.Text = "Delete Address";
            this.delete_address_btn.UseVisualStyleBackColor = true;
            this.delete_address_btn.Click += new System.EventHandler(this.delete_address_btn_Click);
            // 
            // insert_address_btn
            // 
            this.insert_address_btn.Location = new System.Drawing.Point(180, 60);
            this.insert_address_btn.Name = "insert_address_btn";
            this.insert_address_btn.Size = new System.Drawing.Size(145, 25);
            this.insert_address_btn.TabIndex = 2;
            this.insert_address_btn.Text = "Insert Address";
            this.insert_address_btn.UseVisualStyleBackColor = true;
            this.insert_address_btn.Click += new System.EventHandler(this.insert_address_btn_Click);
            // 
            // select_address_btn
            // 
            this.select_address_btn.Location = new System.Drawing.Point(20, 60);
            this.select_address_btn.Name = "select_address_btn";
            this.select_address_btn.Size = new System.Drawing.Size(145, 25);
            this.select_address_btn.TabIndex = 1;
            this.select_address_btn.Text = "Select Address";
            this.select_address_btn.UseVisualStyleBackColor = true;
            this.select_address_btn.Click += new System.EventHandler(this.select_address_btn_Click);
            // 
            // address_dg
            // 
            this.address_dg.AllowUserToAddRows = false;
            this.address_dg.AllowUserToDeleteRows = false;
            this.address_dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.address_dg.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.address_id_clm,
            this.a_user_id_clm,
            this.a_postcode_clm,
            this.a_address_line1_clm,
            this.a_address_line2_clm,
            this.a_town_clm,
            this.a_county_clm,
            this.a_current_address_clm});
            this.address_dg.Location = new System.Drawing.Point(15, 100);
            this.address_dg.Name = "address_dg";
            this.address_dg.ReadOnly = true;
            this.address_dg.RowTemplate.Height = 24;
            this.address_dg.Size = new System.Drawing.Size(1070, 440);
            this.address_dg.TabIndex = 0;
            // 
            // address_id_clm
            // 
            this.address_id_clm.HeaderText = "Address ID";
            this.address_id_clm.Name = "address_id_clm";
            this.address_id_clm.ReadOnly = true;
            // 
            // a_user_id_clm
            // 
            this.a_user_id_clm.HeaderText = "User ID";
            this.a_user_id_clm.Name = "a_user_id_clm";
            this.a_user_id_clm.ReadOnly = true;
            // 
            // a_postcode_clm
            // 
            this.a_postcode_clm.HeaderText = "Postcode";
            this.a_postcode_clm.Name = "a_postcode_clm";
            this.a_postcode_clm.ReadOnly = true;
            // 
            // a_address_line1_clm
            // 
            this.a_address_line1_clm.HeaderText = "Address Line 1";
            this.a_address_line1_clm.Name = "a_address_line1_clm";
            this.a_address_line1_clm.ReadOnly = true;
            // 
            // a_address_line2_clm
            // 
            this.a_address_line2_clm.HeaderText = "Address Line 2";
            this.a_address_line2_clm.Name = "a_address_line2_clm";
            this.a_address_line2_clm.ReadOnly = true;
            // 
            // a_town_clm
            // 
            this.a_town_clm.HeaderText = "Town";
            this.a_town_clm.Name = "a_town_clm";
            this.a_town_clm.ReadOnly = true;
            // 
            // a_county_clm
            // 
            this.a_county_clm.HeaderText = "County";
            this.a_county_clm.Name = "a_county_clm";
            this.a_county_clm.ReadOnly = true;
            // 
            // a_current_address_clm
            // 
            this.a_current_address_clm.HeaderText = "Current Address";
            this.a_current_address_clm.Name = "a_current_address_clm";
            this.a_current_address_clm.ReadOnly = true;
            // 
            // dep_tab
            // 
            this.dep_tab.Controls.Add(this.search_dep_leader_txt);
            this.dep_tab.Controls.Add(this.search_dep_leader_lbl);
            this.dep_tab.Controls.Add(this.update_dep_btn);
            this.dep_tab.Controls.Add(this.delete_dep_btn);
            this.dep_tab.Controls.Add(this.insert_dep_btn);
            this.dep_tab.Controls.Add(this.select_dep_btn);
            this.dep_tab.Controls.Add(this.dep_dg);
            this.dep_tab.Location = new System.Drawing.Point(4, 25);
            this.dep_tab.Name = "dep_tab";
            this.dep_tab.Padding = new System.Windows.Forms.Padding(3);
            this.dep_tab.Size = new System.Drawing.Size(1102, 551);
            this.dep_tab.TabIndex = 5;
            this.dep_tab.Text = "Department";
            this.dep_tab.UseVisualStyleBackColor = true;
            // 
            // search_dep_leader_txt
            // 
            this.search_dep_leader_txt.Location = new System.Drawing.Point(803, 65);
            this.search_dep_leader_txt.Name = "search_dep_leader_txt";
            this.search_dep_leader_txt.Size = new System.Drawing.Size(200, 22);
            this.search_dep_leader_txt.TabIndex = 6;
            this.search_dep_leader_txt.TextChanged += new System.EventHandler(this.search_dep_leader_txt_TextChange);
            // 
            // search_dep_leader_lbl
            // 
            this.search_dep_leader_lbl.AutoSize = true;
            this.search_dep_leader_lbl.Location = new System.Drawing.Point(660, 65);
            this.search_dep_leader_lbl.Name = "search_dep_leader_lbl";
            this.search_dep_leader_lbl.Size = new System.Drawing.Size(121, 17);
            this.search_dep_leader_lbl.TabIndex = 5;
            this.search_dep_leader_lbl.Text = "Search by Leader";
            // 
            // update_dep_btn
            // 
            this.update_dep_btn.Location = new System.Drawing.Point(500, 60);
            this.update_dep_btn.Name = "update_dep_btn";
            this.update_dep_btn.Size = new System.Drawing.Size(145, 25);
            this.update_dep_btn.TabIndex = 4;
            this.update_dep_btn.Text = "Update Department";
            this.update_dep_btn.UseVisualStyleBackColor = true;
            this.update_dep_btn.Click += new System.EventHandler(this.update_dep_btn_Click);
            // 
            // delete_dep_btn
            // 
            this.delete_dep_btn.Location = new System.Drawing.Point(340, 60);
            this.delete_dep_btn.Name = "delete_dep_btn";
            this.delete_dep_btn.Size = new System.Drawing.Size(145, 25);
            this.delete_dep_btn.TabIndex = 3;
            this.delete_dep_btn.Text = "Delete Department";
            this.delete_dep_btn.UseVisualStyleBackColor = true;
            this.delete_dep_btn.Click += new System.EventHandler(this.delete_dep_btn_Click);
            // 
            // insert_dep_btn
            // 
            this.insert_dep_btn.Location = new System.Drawing.Point(180, 60);
            this.insert_dep_btn.Name = "insert_dep_btn";
            this.insert_dep_btn.Size = new System.Drawing.Size(145, 25);
            this.insert_dep_btn.TabIndex = 2;
            this.insert_dep_btn.Text = "Insert Department";
            this.insert_dep_btn.UseVisualStyleBackColor = true;
            this.insert_dep_btn.Click += new System.EventHandler(this.insert_dep_btn_Click);
            // 
            // select_dep_btn
            // 
            this.select_dep_btn.Location = new System.Drawing.Point(20, 60);
            this.select_dep_btn.Name = "select_dep_btn";
            this.select_dep_btn.Size = new System.Drawing.Size(145, 25);
            this.select_dep_btn.TabIndex = 1;
            this.select_dep_btn.Text = "Select Department";
            this.select_dep_btn.UseVisualStyleBackColor = true;
            this.select_dep_btn.Click += new System.EventHandler(this.select_dep_btn_Click);
            // 
            // dep_dg
            // 
            this.dep_dg.AllowUserToAddRows = false;
            this.dep_dg.AllowUserToDeleteRows = false;
            this.dep_dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dep_dg.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dep_id_clm,
            this.dep_name_clm,
            this.dep_email_clm,
            this.dep_phone_no_clm,
            this.dep_leader_clm});
            this.dep_dg.Location = new System.Drawing.Point(15, 100);
            this.dep_dg.Name = "dep_dg";
            this.dep_dg.ReadOnly = true;
            this.dep_dg.RowTemplate.Height = 24;
            this.dep_dg.Size = new System.Drawing.Size(1070, 440);
            this.dep_dg.TabIndex = 0;
            // 
            // dep_id_clm
            // 
            this.dep_id_clm.HeaderText = "Department ID";
            this.dep_id_clm.Name = "dep_id_clm";
            this.dep_id_clm.ReadOnly = true;
            // 
            // dep_name_clm
            // 
            this.dep_name_clm.HeaderText = "Department Name";
            this.dep_name_clm.Name = "dep_name_clm";
            this.dep_name_clm.ReadOnly = true;
            // 
            // dep_email_clm
            // 
            this.dep_email_clm.HeaderText = "Email";
            this.dep_email_clm.Name = "dep_email_clm";
            this.dep_email_clm.ReadOnly = true;
            // 
            // dep_phone_no_clm
            // 
            this.dep_phone_no_clm.HeaderText = "Phone No";
            this.dep_phone_no_clm.Name = "dep_phone_no_clm";
            this.dep_phone_no_clm.ReadOnly = true;
            // 
            // dep_leader_clm
            // 
            this.dep_leader_clm.HeaderText = "Leader";
            this.dep_leader_clm.Name = "dep_leader_clm";
            this.dep_leader_clm.ReadOnly = true;
            // 
            // jobrole_tab
            // 
            this.jobrole_tab.Controls.Add(this.search_job_title_txt);
            this.jobrole_tab.Controls.Add(this.search_job_title_lbl);
            this.jobrole_tab.Controls.Add(this.update_j_role_btn);
            this.jobrole_tab.Controls.Add(this.delete_j_role_btn);
            this.jobrole_tab.Controls.Add(this.insert_j_role_btn);
            this.jobrole_tab.Controls.Add(this.select_j_role_btn);
            this.jobrole_tab.Controls.Add(this.J_role_dg);
            this.jobrole_tab.Location = new System.Drawing.Point(4, 25);
            this.jobrole_tab.Name = "jobrole_tab";
            this.jobrole_tab.Padding = new System.Windows.Forms.Padding(3);
            this.jobrole_tab.Size = new System.Drawing.Size(1102, 551);
            this.jobrole_tab.TabIndex = 6;
            this.jobrole_tab.Text = "Job Role";
            this.jobrole_tab.UseVisualStyleBackColor = true;
            // 
            // search_job_title_txt
            // 
            this.search_job_title_txt.Location = new System.Drawing.Point(796, 63);
            this.search_job_title_txt.Name = "search_job_title_txt";
            this.search_job_title_txt.Size = new System.Drawing.Size(200, 22);
            this.search_job_title_txt.TabIndex = 6;
            this.search_job_title_txt.TextChanged += new System.EventHandler(this.search_job_title_txt_TextChange);
            // 
            // search_job_title_lbl
            // 
            this.search_job_title_lbl.AutoSize = true;
            this.search_job_title_lbl.Location = new System.Drawing.Point(660, 65);
            this.search_job_title_lbl.Name = "search_job_title_lbl";
            this.search_job_title_lbl.Size = new System.Drawing.Size(130, 17);
            this.search_job_title_lbl.TabIndex = 5;
            this.search_job_title_lbl.Text = "Search by Job Title";
            // 
            // update_j_role_btn
            // 
            this.update_j_role_btn.Location = new System.Drawing.Point(500, 60);
            this.update_j_role_btn.Name = "update_j_role_btn";
            this.update_j_role_btn.Size = new System.Drawing.Size(145, 25);
            this.update_j_role_btn.TabIndex = 4;
            this.update_j_role_btn.Text = "Update Job Role";
            this.update_j_role_btn.UseVisualStyleBackColor = true;
            this.update_j_role_btn.Click += new System.EventHandler(this.update_j_role_btn_Click);
            // 
            // delete_j_role_btn
            // 
            this.delete_j_role_btn.Location = new System.Drawing.Point(340, 60);
            this.delete_j_role_btn.Name = "delete_j_role_btn";
            this.delete_j_role_btn.Size = new System.Drawing.Size(145, 25);
            this.delete_j_role_btn.TabIndex = 3;
            this.delete_j_role_btn.Text = "Delete Job Role";
            this.delete_j_role_btn.UseVisualStyleBackColor = true;
            this.delete_j_role_btn.Click += new System.EventHandler(this.delete_j_role_btn_Click);
            // 
            // insert_j_role_btn
            // 
            this.insert_j_role_btn.Location = new System.Drawing.Point(180, 60);
            this.insert_j_role_btn.Name = "insert_j_role_btn";
            this.insert_j_role_btn.Size = new System.Drawing.Size(145, 25);
            this.insert_j_role_btn.TabIndex = 2;
            this.insert_j_role_btn.Text = "Insert Job Role";
            this.insert_j_role_btn.UseVisualStyleBackColor = true;
            this.insert_j_role_btn.Click += new System.EventHandler(this.insert_j_role_btn_Click);
            // 
            // select_j_role_btn
            // 
            this.select_j_role_btn.Location = new System.Drawing.Point(20, 60);
            this.select_j_role_btn.Name = "select_j_role_btn";
            this.select_j_role_btn.Size = new System.Drawing.Size(145, 25);
            this.select_j_role_btn.TabIndex = 1;
            this.select_j_role_btn.Text = "Select Job Role";
            this.select_j_role_btn.UseVisualStyleBackColor = true;
            this.select_j_role_btn.Click += new System.EventHandler(this.select_j_role_btn_Click);
            // 
            // J_role_dg
            // 
            this.J_role_dg.AllowUserToAddRows = false;
            this.J_role_dg.AllowUserToDeleteRows = false;
            this.J_role_dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.J_role_dg.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.role_id_clm,
            this.j_staff_id_clm,
            this.j_dep_id_clm,
            this.j_title_clm});
            this.J_role_dg.Location = new System.Drawing.Point(15, 100);
            this.J_role_dg.Name = "J_role_dg";
            this.J_role_dg.ReadOnly = true;
            this.J_role_dg.RowTemplate.Height = 24;
            this.J_role_dg.Size = new System.Drawing.Size(1070, 440);
            this.J_role_dg.TabIndex = 0;
            // 
            // role_id_clm
            // 
            this.role_id_clm.HeaderText = "Role ID";
            this.role_id_clm.Name = "role_id_clm";
            this.role_id_clm.ReadOnly = true;
            // 
            // j_staff_id_clm
            // 
            this.j_staff_id_clm.HeaderText = "Staff ID";
            this.j_staff_id_clm.Name = "j_staff_id_clm";
            this.j_staff_id_clm.ReadOnly = true;
            // 
            // j_dep_id_clm
            // 
            this.j_dep_id_clm.HeaderText = "Department ID";
            this.j_dep_id_clm.Name = "j_dep_id_clm";
            this.j_dep_id_clm.ReadOnly = true;
            // 
            // j_title_clm
            // 
            this.j_title_clm.HeaderText = "Job Title";
            this.j_title_clm.Name = "j_title_clm";
            this.j_title_clm.ReadOnly = true;
            // 
            // learning_aim_tab
            // 
            this.learning_aim_tab.Controls.Add(this.search_learning_aim_title_txt);
            this.learning_aim_tab.Controls.Add(this.search_learning_aim_title_lbl);
            this.learning_aim_tab.Controls.Add(this.update_learning_aim_btn);
            this.learning_aim_tab.Controls.Add(this.delete_learning_aim_btn);
            this.learning_aim_tab.Controls.Add(this.insert_learning_aim_btn);
            this.learning_aim_tab.Controls.Add(this.select_learning_aim_btn);
            this.learning_aim_tab.Controls.Add(this.learning_aim_dg);
            this.learning_aim_tab.Location = new System.Drawing.Point(4, 25);
            this.learning_aim_tab.Name = "learning_aim_tab";
            this.learning_aim_tab.Padding = new System.Windows.Forms.Padding(3);
            this.learning_aim_tab.Size = new System.Drawing.Size(1102, 551);
            this.learning_aim_tab.TabIndex = 7;
            this.learning_aim_tab.Text = "Learning Aim";
            this.learning_aim_tab.UseVisualStyleBackColor = true;
            // 
            // search_learning_aim_title_txt
            // 
            this.search_learning_aim_title_txt.Location = new System.Drawing.Point(775, 65);
            this.search_learning_aim_title_txt.Name = "search_learning_aim_title_txt";
            this.search_learning_aim_title_txt.Size = new System.Drawing.Size(200, 22);
            this.search_learning_aim_title_txt.TabIndex = 6;
            this.search_learning_aim_title_txt.TextChanged += new System.EventHandler(this.search_learning_aim_title_txt_TextChange);
            // 
            // search_learning_aim_title_lbl
            // 
            this.search_learning_aim_title_lbl.AutoSize = true;
            this.search_learning_aim_title_lbl.Location = new System.Drawing.Point(660, 65);
            this.search_learning_aim_title_lbl.Name = "search_learning_aim_title_lbl";
            this.search_learning_aim_title_lbl.Size = new System.Drawing.Size(103, 17);
            this.search_learning_aim_title_lbl.TabIndex = 5;
            this.search_learning_aim_title_lbl.Text = "Search by Title";
            // 
            // update_learning_aim_btn
            // 
            this.update_learning_aim_btn.Location = new System.Drawing.Point(500, 60);
            this.update_learning_aim_btn.Name = "update_learning_aim_btn";
            this.update_learning_aim_btn.Size = new System.Drawing.Size(153, 25);
            this.update_learning_aim_btn.TabIndex = 4;
            this.update_learning_aim_btn.Text = "Update Learning Aim";
            this.update_learning_aim_btn.UseVisualStyleBackColor = true;
            this.update_learning_aim_btn.Click += new System.EventHandler(this.update_learning_aim_btn_Click);
            // 
            // delete_learning_aim_btn
            // 
            this.delete_learning_aim_btn.Location = new System.Drawing.Point(340, 60);
            this.delete_learning_aim_btn.Name = "delete_learning_aim_btn";
            this.delete_learning_aim_btn.Size = new System.Drawing.Size(145, 25);
            this.delete_learning_aim_btn.TabIndex = 3;
            this.delete_learning_aim_btn.Text = "Delete Learning Aim";
            this.delete_learning_aim_btn.UseVisualStyleBackColor = true;
            this.delete_learning_aim_btn.Click += new System.EventHandler(this.delete_learning_aim_btn_Click);
            // 
            // insert_learning_aim_btn
            // 
            this.insert_learning_aim_btn.Location = new System.Drawing.Point(180, 60);
            this.insert_learning_aim_btn.Name = "insert_learning_aim_btn";
            this.insert_learning_aim_btn.Size = new System.Drawing.Size(145, 25);
            this.insert_learning_aim_btn.TabIndex = 2;
            this.insert_learning_aim_btn.Text = "Insert Learning Aim";
            this.insert_learning_aim_btn.UseVisualStyleBackColor = true;
            this.insert_learning_aim_btn.Click += new System.EventHandler(this.insert_learning_aim_btn_Click);
            // 
            // select_learning_aim_btn
            // 
            this.select_learning_aim_btn.Location = new System.Drawing.Point(20, 60);
            this.select_learning_aim_btn.Name = "select_learning_aim_btn";
            this.select_learning_aim_btn.Size = new System.Drawing.Size(145, 25);
            this.select_learning_aim_btn.TabIndex = 1;
            this.select_learning_aim_btn.Text = "Select Learning Aim";
            this.select_learning_aim_btn.UseVisualStyleBackColor = true;
            this.select_learning_aim_btn.Click += new System.EventHandler(this.select_learning_aim_btn_Click);
            // 
            // learning_aim_dg
            // 
            this.learning_aim_dg.AllowUserToAddRows = false;
            this.learning_aim_dg.AllowUserToDeleteRows = false;
            this.learning_aim_dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.learning_aim_dg.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.aim_id_clm,
            this.l_dep_id_clm,
            this.l_learning_aim_title_clm,
            this.l_learning_aim_des_clm});
            this.learning_aim_dg.Location = new System.Drawing.Point(15, 100);
            this.learning_aim_dg.Name = "learning_aim_dg";
            this.learning_aim_dg.ReadOnly = true;
            this.learning_aim_dg.RowTemplate.Height = 24;
            this.learning_aim_dg.Size = new System.Drawing.Size(1070, 440);
            this.learning_aim_dg.TabIndex = 0;
            // 
            // aim_id_clm
            // 
            this.aim_id_clm.HeaderText = "Learning Aim ID";
            this.aim_id_clm.Name = "aim_id_clm";
            this.aim_id_clm.ReadOnly = true;
            // 
            // l_dep_id_clm
            // 
            this.l_dep_id_clm.HeaderText = "Department ID";
            this.l_dep_id_clm.Name = "l_dep_id_clm";
            this.l_dep_id_clm.ReadOnly = true;
            // 
            // l_learning_aim_title_clm
            // 
            this.l_learning_aim_title_clm.HeaderText = "Title";
            this.l_learning_aim_title_clm.Name = "l_learning_aim_title_clm";
            this.l_learning_aim_title_clm.ReadOnly = true;
            // 
            // l_learning_aim_des_clm
            // 
            this.l_learning_aim_des_clm.HeaderText = "Description";
            this.l_learning_aim_des_clm.Name = "l_learning_aim_des_clm";
            this.l_learning_aim_des_clm.ReadOnly = true;
            // 
            // course_tab
            // 
            this.course_tab.Controls.Add(this.search_course_cname_txt);
            this.course_tab.Controls.Add(this.search_course_cname_lbl);
            this.course_tab.Controls.Add(this.update_course_btn);
            this.course_tab.Controls.Add(this.Delete_course_btn);
            this.course_tab.Controls.Add(this.insert_course_btn);
            this.course_tab.Controls.Add(this.select_course_btn);
            this.course_tab.Controls.Add(this.course_dg);
            this.course_tab.Location = new System.Drawing.Point(4, 25);
            this.course_tab.Name = "course_tab";
            this.course_tab.Padding = new System.Windows.Forms.Padding(3);
            this.course_tab.Size = new System.Drawing.Size(1102, 551);
            this.course_tab.TabIndex = 8;
            this.course_tab.Text = "Course";
            this.course_tab.UseVisualStyleBackColor = true;
            // 
            // search_course_cname_txt
            // 
            this.search_course_cname_txt.Location = new System.Drawing.Point(779, 68);
            this.search_course_cname_txt.Name = "search_course_cname_txt";
            this.search_course_cname_txt.Size = new System.Drawing.Size(200, 22);
            this.search_course_cname_txt.TabIndex = 6;
            this.search_course_cname_txt.TextChanged += new System.EventHandler(this.search_course_cname_txt_TextChange);
            // 
            // search_course_cname_lbl
            // 
            this.search_course_cname_lbl.AutoSize = true;
            this.search_course_cname_lbl.Location = new System.Drawing.Point(660, 68);
            this.search_course_cname_lbl.Name = "search_course_cname_lbl";
            this.search_course_cname_lbl.Size = new System.Drawing.Size(113, 17);
            this.search_course_cname_lbl.TabIndex = 5;
            this.search_course_cname_lbl.Text = "Search by Name";
            // 
            // update_course_btn
            // 
            this.update_course_btn.Location = new System.Drawing.Point(500, 60);
            this.update_course_btn.Name = "update_course_btn";
            this.update_course_btn.Size = new System.Drawing.Size(145, 25);
            this.update_course_btn.TabIndex = 4;
            this.update_course_btn.Text = "Update Course";
            this.update_course_btn.UseVisualStyleBackColor = true;
            this.update_course_btn.Click += new System.EventHandler(this.update_course_btn_Click);
            // 
            // Delete_course_btn
            // 
            this.Delete_course_btn.Location = new System.Drawing.Point(340, 60);
            this.Delete_course_btn.Name = "Delete_course_btn";
            this.Delete_course_btn.Size = new System.Drawing.Size(145, 25);
            this.Delete_course_btn.TabIndex = 3;
            this.Delete_course_btn.Text = "Delete Course";
            this.Delete_course_btn.UseVisualStyleBackColor = true;
            this.Delete_course_btn.Click += new System.EventHandler(this.Delete_course_btn_Click);
            // 
            // insert_course_btn
            // 
            this.insert_course_btn.Location = new System.Drawing.Point(180, 60);
            this.insert_course_btn.Name = "insert_course_btn";
            this.insert_course_btn.Size = new System.Drawing.Size(145, 25);
            this.insert_course_btn.TabIndex = 2;
            this.insert_course_btn.Text = "Insert Course";
            this.insert_course_btn.UseVisualStyleBackColor = true;
            this.insert_course_btn.Click += new System.EventHandler(this.insert_course_btn_Click);
            // 
            // select_course_btn
            // 
            this.select_course_btn.Location = new System.Drawing.Point(20, 60);
            this.select_course_btn.Name = "select_course_btn";
            this.select_course_btn.Size = new System.Drawing.Size(145, 25);
            this.select_course_btn.TabIndex = 1;
            this.select_course_btn.Text = "Select Course";
            this.select_course_btn.UseVisualStyleBackColor = true;
            this.select_course_btn.Click += new System.EventHandler(this.select_course_btn_Click);
            // 
            // course_dg
            // 
            this.course_dg.AllowUserToAddRows = false;
            this.course_dg.AllowUserToDeleteRows = false;
            this.course_dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.course_dg.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.course_id_clm,
            this.c_aim_id,
            this.c_cname_clm,
            this.c_level_clm,
            this.c_start_d_clm,
            this.c_end_d_clm});
            this.course_dg.Location = new System.Drawing.Point(15, 100);
            this.course_dg.Name = "course_dg";
            this.course_dg.ReadOnly = true;
            this.course_dg.RowTemplate.Height = 24;
            this.course_dg.Size = new System.Drawing.Size(1070, 440);
            this.course_dg.TabIndex = 0;
            // 
            // course_id_clm
            // 
            this.course_id_clm.HeaderText = "Course ID";
            this.course_id_clm.Name = "course_id_clm";
            this.course_id_clm.ReadOnly = true;
            // 
            // c_aim_id
            // 
            this.c_aim_id.HeaderText = "Aim ID";
            this.c_aim_id.Name = "c_aim_id";
            this.c_aim_id.ReadOnly = true;
            // 
            // c_cname_clm
            // 
            this.c_cname_clm.HeaderText = "Name";
            this.c_cname_clm.Name = "c_cname_clm";
            this.c_cname_clm.ReadOnly = true;
            // 
            // c_level_clm
            // 
            this.c_level_clm.HeaderText = "Level";
            this.c_level_clm.Name = "c_level_clm";
            this.c_level_clm.ReadOnly = true;
            // 
            // c_start_d_clm
            // 
            this.c_start_d_clm.HeaderText = "Start Date";
            this.c_start_d_clm.Name = "c_start_d_clm";
            this.c_start_d_clm.ReadOnly = true;
            // 
            // c_end_d_clm
            // 
            this.c_end_d_clm.HeaderText = "End Date";
            this.c_end_d_clm.Name = "c_end_d_clm";
            this.c_end_d_clm.ReadOnly = true;
            // 
            // enrolment_tab
            // 
            this.enrolment_tab.Controls.Add(this.search_enrolment_data_txt);
            this.enrolment_tab.Controls.Add(this.search_enrolment_data_lbl);
            this.enrolment_tab.Controls.Add(this.update_enrolment_btn);
            this.enrolment_tab.Controls.Add(this.delete_enrolment_btn);
            this.enrolment_tab.Controls.Add(this.insert_enrolment_btn);
            this.enrolment_tab.Controls.Add(this.select_enrolment_btn);
            this.enrolment_tab.Controls.Add(this.enrolment_dg);
            this.enrolment_tab.Location = new System.Drawing.Point(4, 25);
            this.enrolment_tab.Name = "enrolment_tab";
            this.enrolment_tab.Padding = new System.Windows.Forms.Padding(3);
            this.enrolment_tab.Size = new System.Drawing.Size(1102, 551);
            this.enrolment_tab.TabIndex = 9;
            this.enrolment_tab.Text = "Enrolment";
            this.enrolment_tab.UseVisualStyleBackColor = true;
            // 
            // search_enrolment_data_txt
            // 
            this.search_enrolment_data_txt.Location = new System.Drawing.Point(792, 65);
            this.search_enrolment_data_txt.Name = "search_enrolment_data_txt";
            this.search_enrolment_data_txt.Size = new System.Drawing.Size(200, 22);
            this.search_enrolment_data_txt.TabIndex = 6;
            this.search_enrolment_data_txt.TextChanged += new System.EventHandler(this.search_enrolment_data_txt_TextChange);
            // 
            // search_enrolment_data_lbl
            // 
            this.search_enrolment_data_lbl.AutoSize = true;
            this.search_enrolment_data_lbl.Location = new System.Drawing.Point(669, 68);
            this.search_enrolment_data_lbl.Name = "search_enrolment_data_lbl";
            this.search_enrolment_data_lbl.Size = new System.Drawing.Size(106, 17);
            this.search_enrolment_data_lbl.TabIndex = 5;
            this.search_enrolment_data_lbl.Text = "Search by Date";
            // 
            // update_enrolment_btn
            // 
            this.update_enrolment_btn.Location = new System.Drawing.Point(500, 60);
            this.update_enrolment_btn.Name = "update_enrolment_btn";
            this.update_enrolment_btn.Size = new System.Drawing.Size(145, 25);
            this.update_enrolment_btn.TabIndex = 4;
            this.update_enrolment_btn.Text = "Update Enrolment";
            this.update_enrolment_btn.UseVisualStyleBackColor = true;
            this.update_enrolment_btn.Click += new System.EventHandler(this.update_enrolment_btn_Click);
            // 
            // delete_enrolment_btn
            // 
            this.delete_enrolment_btn.Location = new System.Drawing.Point(340, 60);
            this.delete_enrolment_btn.Name = "delete_enrolment_btn";
            this.delete_enrolment_btn.Size = new System.Drawing.Size(145, 25);
            this.delete_enrolment_btn.TabIndex = 3;
            this.delete_enrolment_btn.Text = "Delete Enrolment";
            this.delete_enrolment_btn.UseVisualStyleBackColor = true;
            this.delete_enrolment_btn.Click += new System.EventHandler(this.delete_enrolment_btn_Click);
            // 
            // insert_enrolment_btn
            // 
            this.insert_enrolment_btn.Location = new System.Drawing.Point(180, 60);
            this.insert_enrolment_btn.Name = "insert_enrolment_btn";
            this.insert_enrolment_btn.Size = new System.Drawing.Size(145, 25);
            this.insert_enrolment_btn.TabIndex = 2;
            this.insert_enrolment_btn.Text = "Insert Enrolment";
            this.insert_enrolment_btn.UseVisualStyleBackColor = true;
            this.insert_enrolment_btn.Click += new System.EventHandler(this.insert_enrolment_btn_Click);
            // 
            // select_enrolment_btn
            // 
            this.select_enrolment_btn.Location = new System.Drawing.Point(20, 60);
            this.select_enrolment_btn.Name = "select_enrolment_btn";
            this.select_enrolment_btn.Size = new System.Drawing.Size(145, 25);
            this.select_enrolment_btn.TabIndex = 1;
            this.select_enrolment_btn.Text = "Select Enrolment";
            this.select_enrolment_btn.UseVisualStyleBackColor = true;
            this.select_enrolment_btn.Click += new System.EventHandler(this.select_enrolment_btn_Click);
            // 
            // enrolment_dg
            // 
            this.enrolment_dg.AllowUserToAddRows = false;
            this.enrolment_dg.AllowUserToDeleteRows = false;
            this.enrolment_dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.enrolment_dg.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.enrolment_id_clm,
            this.en_course_id_clm,
            this.en_student_id_clm,
            this.en_date_clm});
            this.enrolment_dg.Location = new System.Drawing.Point(15, 100);
            this.enrolment_dg.Name = "enrolment_dg";
            this.enrolment_dg.ReadOnly = true;
            this.enrolment_dg.RowTemplate.Height = 24;
            this.enrolment_dg.Size = new System.Drawing.Size(1070, 440);
            this.enrolment_dg.TabIndex = 0;
            // 
            // enrolment_id_clm
            // 
            this.enrolment_id_clm.HeaderText = "Enrolment ID";
            this.enrolment_id_clm.Name = "enrolment_id_clm";
            this.enrolment_id_clm.ReadOnly = true;
            // 
            // en_course_id_clm
            // 
            this.en_course_id_clm.HeaderText = "Course ID";
            this.en_course_id_clm.Name = "en_course_id_clm";
            this.en_course_id_clm.ReadOnly = true;
            // 
            // en_student_id_clm
            // 
            this.en_student_id_clm.HeaderText = "Student ID";
            this.en_student_id_clm.Name = "en_student_id_clm";
            this.en_student_id_clm.ReadOnly = true;
            // 
            // en_date_clm
            // 
            this.en_date_clm.HeaderText = "Enrolment date";
            this.en_date_clm.Name = "en_date_clm";
            this.en_date_clm.ReadOnly = true;
            // 
            // jobrolef_tab
            // 
            this.jobrolef_tab.Controls.Add(this.jobrolef_staff_cmb);
            this.jobrolef_tab.Controls.Add(this.jobrolef_staff_lbl);
            this.jobrolef_tab.Controls.Add(this.jobrolef_dg);
            this.jobrolef_tab.Location = new System.Drawing.Point(4, 25);
            this.jobrolef_tab.Name = "jobrolef_tab";
            this.jobrolef_tab.Padding = new System.Windows.Forms.Padding(3);
            this.jobrolef_tab.Size = new System.Drawing.Size(1102, 551);
            this.jobrolef_tab.TabIndex = 11;
            this.jobrolef_tab.Text = "Job Role Filters";
            this.jobrolef_tab.UseVisualStyleBackColor = true;
            this.jobrolef_tab.Enter += new System.EventHandler(this.jobRolef_tab_Enter);
            // 
            // jobrolef_staff_cmb
            // 
            this.jobrolef_staff_cmb.FormattingEnabled = true;
            this.jobrolef_staff_cmb.Location = new System.Drawing.Point(160, 60);
            this.jobrolef_staff_cmb.Name = "jobrolef_staff_cmb";
            this.jobrolef_staff_cmb.Size = new System.Drawing.Size(200, 24);
            this.jobrolef_staff_cmb.TabIndex = 2;
            this.jobrolef_staff_cmb.SelectedIndexChanged += new System.EventHandler(this.jobRolef_staff_cmb_SelectedIndexChanged);
            // 
            // jobrolef_staff_lbl
            // 
            this.jobrolef_staff_lbl.AutoSize = true;
            this.jobrolef_staff_lbl.Location = new System.Drawing.Point(20, 60);
            this.jobrolef_staff_lbl.Name = "jobrolef_staff_lbl";
            this.jobrolef_staff_lbl.Size = new System.Drawing.Size(105, 17);
            this.jobrolef_staff_lbl.TabIndex = 1;
            this.jobrolef_staff_lbl.Text = "Search by Staff";
            // 
            // jobrolef_dg
            // 
            this.jobrolef_dg.AllowUserToAddRows = false;
            this.jobrolef_dg.AllowUserToDeleteRows = false;
            this.jobrolef_dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.jobrolef_dg.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.jobrolef_id_clm,
            this.ep_clm,
            this.jobrolef_stname_clm});
            this.jobrolef_dg.Location = new System.Drawing.Point(15, 100);
            this.jobrolef_dg.Name = "jobrolef_dg";
            this.jobrolef_dg.ReadOnly = true;
            this.jobrolef_dg.RowTemplate.Height = 24;
            this.jobrolef_dg.Size = new System.Drawing.Size(1070, 440);
            this.jobrolef_dg.TabIndex = 0;
            // 
            // jobrolef_id_clm
            // 
            this.jobrolef_id_clm.HeaderText = "Job Role ID";
            this.jobrolef_id_clm.Name = "jobrolef_id_clm";
            this.jobrolef_id_clm.ReadOnly = true;
            // 
            // ep_clm
            // 
            this.ep_clm.HeaderText = "Department";
            this.ep_clm.Name = "ep_clm";
            this.ep_clm.ReadOnly = true;
            // 
            // jobrolef_stname_clm
            // 
            this.jobrolef_stname_clm.HeaderText = "Staff Name";
            this.jobrolef_stname_clm.Name = "jobrolef_stname_clm";
            this.jobrolef_stname_clm.ReadOnly = true;
            // 
            // user_id_clm
            // 
            this.user_id_clm.HeaderText = "User ID";
            this.user_id_clm.Name = "user_id_clm";
            this.user_id_clm.ReadOnly = true;
            // 
            // u_uname_clm
            // 
            this.u_uname_clm.HeaderText = "User Name";
            this.u_uname_clm.Name = "u_uname_clm";
            this.u_uname_clm.ReadOnly = true;
            // 
            // u_password_clm
            // 
            this.u_password_clm.HeaderText = "Password";
            this.u_password_clm.Name = "u_password_clm";
            this.u_password_clm.ReadOnly = true;
            // 
            // u_access_level_clm
            // 
            this.u_access_level_clm.HeaderText = "Access Level";
            this.u_access_level_clm.Name = "u_access_level_clm";
            this.u_access_level_clm.ReadOnly = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1162, 633);
            this.Controls.Add(this.main_tbc);
            this.Controls.Add(this.test_btn);
            this.Name = "MainForm";
            this.Text = "Natural Selection";
            this.enrolmentf_tab.ResumeLayout(false);
            this.enrolmentf_tab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.enrolmentfilter_dg)).EndInit();
            this.main_tbc.ResumeLayout(false);
            this.student_tab.ResumeLayout(false);
            this.student_tab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.student_dg)).EndInit();
            this.user_account.ResumeLayout(false);
            this.user_account.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.user_account_dg)).EndInit();
            this.staff_tab.ResumeLayout(false);
            this.staff_tab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.staff_dg)).EndInit();
            this.next_of_kin_tab.ResumeLayout(false);
            this.next_of_kin_tab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.next_of_kin_dg)).EndInit();
            this.address_tab.ResumeLayout(false);
            this.address_tab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.address_dg)).EndInit();
            this.dep_tab.ResumeLayout(false);
            this.dep_tab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dep_dg)).EndInit();
            this.jobrole_tab.ResumeLayout(false);
            this.jobrole_tab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.J_role_dg)).EndInit();
            this.learning_aim_tab.ResumeLayout(false);
            this.learning_aim_tab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.learning_aim_dg)).EndInit();
            this.course_tab.ResumeLayout(false);
            this.course_tab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.course_dg)).EndInit();
            this.enrolment_tab.ResumeLayout(false);
            this.enrolment_tab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.enrolment_dg)).EndInit();
            this.jobrolef_tab.ResumeLayout(false);
            this.jobrolef_tab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.jobrolef_dg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button test_btn;
        private System.Windows.Forms.TabControl main_tbc;
        private System.Windows.Forms.TabPage student_tab;
        private System.Windows.Forms.Button select_su_btn;
        private System.Windows.Forms.DataGridView student_dg;
        private System.Windows.Forms.DataGridViewTextBoxColumn student_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn user_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn s_fname;
        private System.Windows.Forms.DataGridViewTextBoxColumn s_sname;
        private System.Windows.Forms.DataGridViewTextBoxColumn s_mname;
        private System.Windows.Forms.DataGridViewTextBoxColumn s_dob;
        private System.Windows.Forms.DataGridViewTextBoxColumn s_phone_no;
        private System.Windows.Forms.DataGridViewTextBoxColumn s_email;
        private System.Windows.Forms.DataGridViewTextBoxColumn s_id_image;
        private System.Windows.Forms.TabPage user_account;
        private System.Windows.Forms.Button insert_su_btn;
        private System.Windows.Forms.Button delete_su_btn;
        private System.Windows.Forms.Button update_su_btn;
        private System.Windows.Forms.DataGridView user_account_dg;
        private System.Windows.Forms.Button update_user_account;
        private System.Windows.Forms.Button delete_user_btn;
        private System.Windows.Forms.Button insert_user_btn;
        private System.Windows.Forms.Button select_user_btn;
        private System.Windows.Forms.TextBox search_s_sname_txt;
        private System.Windows.Forms.Label search_s_sname_lbl;
        private System.Windows.Forms.TabPage staff_tab;
        private System.Windows.Forms.Button update_staff_btn;
        private System.Windows.Forms.Button delete_staff_btn;
        private System.Windows.Forms.Button staff_insert_btn;
        private System.Windows.Forms.Button select_staff_btn;
        private System.Windows.Forms.DataGridView staff_dg;
        private System.Windows.Forms.DataGridViewTextBoxColumn staff_id_clm;
        private System.Windows.Forms.DataGridViewTextBoxColumn st_user_id_clm;
        private System.Windows.Forms.DataGridViewTextBoxColumn st_fname_clm;
        private System.Windows.Forms.DataGridViewTextBoxColumn st_sname_clm;
        private System.Windows.Forms.DataGridViewTextBoxColumn st_mname_lbl;
        private System.Windows.Forms.DataGridViewTextBoxColumn st_dob_clm;
        private System.Windows.Forms.DataGridViewTextBoxColumn st_phone_no_clm;
        private System.Windows.Forms.DataGridViewTextBoxColumn st_email_clm;
        private System.Windows.Forms.DataGridViewTextBoxColumn st_id_image;
        private System.Windows.Forms.TextBox search_staff_sname_txt;
        private System.Windows.Forms.Label search_staff_sname_lbl;
        private System.Windows.Forms.TextBox search_user_uname_txt;
        private System.Windows.Forms.Label search_user__uname_lbl;
        private System.Windows.Forms.TabPage next_of_kin_tab;
        private System.Windows.Forms.Button update_next_of_kin_btn;
        private System.Windows.Forms.Button delete_next_of_kin_btn;
        private System.Windows.Forms.Button insert_next_of_kin_btn;
        private System.Windows.Forms.Button select_nect_of_kin_btn;
        private System.Windows.Forms.DataGridView next_of_kin_dg;
        private System.Windows.Forms.DataGridViewTextBoxColumn kin_id_clm;
        private System.Windows.Forms.DataGridViewTextBoxColumn k_user_id_clm;
        private System.Windows.Forms.DataGridViewTextBoxColumn k_fname_clm;
        private System.Windows.Forms.DataGridViewTextBoxColumn k_phone_no_clm;
        private System.Windows.Forms.Label search_next_of_kin_kin_id_lbl;
        private System.Windows.Forms.TextBox search_next_of_kin_kin_id_txt;
        private System.Windows.Forms.TabPage address_tab;
        private System.Windows.Forms.Button update_address_btn;
        private System.Windows.Forms.Button delete_address_btn;
        private System.Windows.Forms.Button insert_address_btn;
        private System.Windows.Forms.Button select_address_btn;
        private System.Windows.Forms.DataGridView address_dg;
        private System.Windows.Forms.DataGridViewTextBoxColumn address_id_clm;
        private System.Windows.Forms.DataGridViewTextBoxColumn a_user_id_clm;
        private System.Windows.Forms.DataGridViewTextBoxColumn a_postcode_clm;
        private System.Windows.Forms.DataGridViewTextBoxColumn a_address_line1_clm;
        private System.Windows.Forms.DataGridViewTextBoxColumn a_address_line2_clm;
        private System.Windows.Forms.DataGridViewTextBoxColumn a_town_clm;
        private System.Windows.Forms.DataGridViewTextBoxColumn a_county_clm;
        private System.Windows.Forms.DataGridViewTextBoxColumn a_current_address_clm;
        private System.Windows.Forms.TextBox search_address_town_txt;
        private System.Windows.Forms.Label search_address_town_lbl;
        private System.Windows.Forms.TabPage dep_tab;
        private System.Windows.Forms.DataGridView dep_dg;
        private System.Windows.Forms.Button update_dep_btn;
        private System.Windows.Forms.Button delete_dep_btn;
        private System.Windows.Forms.Button insert_dep_btn;
        private System.Windows.Forms.Button select_dep_btn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dep_id_clm;
        private System.Windows.Forms.DataGridViewTextBoxColumn dep_name_clm;
        private System.Windows.Forms.DataGridViewTextBoxColumn dep_email_clm;
        private System.Windows.Forms.DataGridViewTextBoxColumn dep_phone_no_clm;
        private System.Windows.Forms.DataGridViewTextBoxColumn dep_leader_clm;
        private System.Windows.Forms.TextBox search_dep_leader_txt;
        private System.Windows.Forms.Label search_dep_leader_lbl;
        private System.Windows.Forms.TabPage jobrole_tab;
        private System.Windows.Forms.DataGridView J_role_dg;
        private System.Windows.Forms.DataGridViewTextBoxColumn role_id_clm;
        private System.Windows.Forms.DataGridViewTextBoxColumn j_staff_id_clm;
        private System.Windows.Forms.DataGridViewTextBoxColumn j_dep_id_clm;
        private System.Windows.Forms.DataGridViewTextBoxColumn j_title_clm;
        private System.Windows.Forms.Button update_j_role_btn;
        private System.Windows.Forms.Button delete_j_role_btn;
        private System.Windows.Forms.Button insert_j_role_btn;
        private System.Windows.Forms.Button select_j_role_btn;
        private System.Windows.Forms.TextBox search_job_title_txt;
        private System.Windows.Forms.Label search_job_title_lbl;
        private System.Windows.Forms.TabPage learning_aim_tab;
        private System.Windows.Forms.Button update_learning_aim_btn;
        private System.Windows.Forms.Button delete_learning_aim_btn;
        private System.Windows.Forms.Button insert_learning_aim_btn;
        private System.Windows.Forms.Button select_learning_aim_btn;
        private System.Windows.Forms.DataGridView learning_aim_dg;
        private System.Windows.Forms.DataGridViewTextBoxColumn aim_id_clm;
        private System.Windows.Forms.DataGridViewTextBoxColumn l_dep_id_clm;
        private System.Windows.Forms.DataGridViewTextBoxColumn l_learning_aim_title_clm;
        private System.Windows.Forms.DataGridViewTextBoxColumn l_learning_aim_des_clm;
        private System.Windows.Forms.TextBox search_learning_aim_title_txt;
        private System.Windows.Forms.Label search_learning_aim_title_lbl;
        private System.Windows.Forms.TabPage course_tab;
        private System.Windows.Forms.Button update_course_btn;
        private System.Windows.Forms.Button Delete_course_btn;
        private System.Windows.Forms.Button insert_course_btn;
        private System.Windows.Forms.Button select_course_btn;
        private System.Windows.Forms.DataGridView course_dg;
        private System.Windows.Forms.DataGridViewTextBoxColumn course_id_clm;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_aim_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_cname_clm;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_level_clm;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_start_d_clm;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_end_d_clm;
        private System.Windows.Forms.TextBox search_course_cname_txt;
        private System.Windows.Forms.Label search_course_cname_lbl;
        private System.Windows.Forms.TabPage enrolment_tab;
        private System.Windows.Forms.Button update_enrolment_btn;
        private System.Windows.Forms.Button delete_enrolment_btn;
        private System.Windows.Forms.Button insert_enrolment_btn;
        private System.Windows.Forms.Button select_enrolment_btn;
        private System.Windows.Forms.DataGridView enrolment_dg;
        private System.Windows.Forms.DataGridViewTextBoxColumn enrolment_id_clm;
        private System.Windows.Forms.DataGridViewTextBoxColumn en_course_id_clm;
        private System.Windows.Forms.DataGridViewTextBoxColumn en_student_id_clm;
        private System.Windows.Forms.DataGridViewTextBoxColumn en_date_clm;
        private System.Windows.Forms.TextBox search_enrolment_data_txt;
        private System.Windows.Forms.Label search_enrolment_data_lbl;
        private System.Windows.Forms.ComboBox enrolmentf_s_cmb;
        private System.Windows.Forms.Label enrolmentf_s_lbl;
        private System.Windows.Forms.DataGridView enrolmentfilter_dg;
        private System.Windows.Forms.DataGridViewTextBoxColumn enrolmentf_clm;
        private System.Windows.Forms.DataGridViewTextBoxColumn enrolmentf_course_clm;
        private System.Windows.Forms.DataGridViewTextBoxColumn enrolmentf_student_clm;
        private System.Windows.Forms.TabPage enrolmentf_tab;
        private System.Windows.Forms.TabPage jobrolef_tab;
        private System.Windows.Forms.ComboBox jobrolef_staff_cmb;
        private System.Windows.Forms.Label jobrolef_staff_lbl;
        private System.Windows.Forms.DataGridView jobrolef_dg;
        private System.Windows.Forms.DataGridViewTextBoxColumn jobrolef_id_clm;
        private System.Windows.Forms.DataGridViewTextBoxColumn ep_clm;
        private System.Windows.Forms.DataGridViewTextBoxColumn jobrolef_stname_clm;
        private System.Windows.Forms.DataGridViewTextBoxColumn user_id_clm;
        private System.Windows.Forms.DataGridViewTextBoxColumn u_uname_clm;
        private System.Windows.Forms.DataGridViewTextBoxColumn u_password_clm;
        private System.Windows.Forms.DataGridViewTextBoxColumn u_access_level_clm;
    }
}

