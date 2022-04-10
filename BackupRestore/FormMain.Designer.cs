
namespace BackupRestore
{
    partial class FormMain
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_Time = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.flp_ListDb = new System.Windows.Forms.FlowLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.pnl_WorkControl = new System.Windows.Forms.Panel();
            this.lsv_BackupVersions = new System.Windows.Forms.ListView();
            this.colPosition = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDescription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colUserName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dtp_TimeRestore = new System.Windows.Forms.DateTimePicker();
            this.dtp_DateRestore = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.chk_DelAllBeforeBackup = new System.Windows.Forms.CheckBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_DbName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_BackupCount = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_Backup = new System.Windows.Forms.Button();
            this.btn_Restore = new System.Windows.Forms.Button();
            this.btn_RestoreByTime = new System.Windows.Forms.Button();
            this.btn_CreateDevice = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.pnl_WorkControl.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 0.8412198F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(7);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 94.6768F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.323194F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1347, 801);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbl_Time);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(5, 763);
            this.panel1.Margin = new System.Windows.Forms.Padding(5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1337, 33);
            this.panel1.TabIndex = 1;
            // 
            // lbl_Time
            // 
            this.lbl_Time.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Time.AutoSize = true;
            this.lbl_Time.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Time.ForeColor = System.Drawing.Color.Teal;
            this.lbl_Time.Location = new System.Drawing.Point(1193, 8);
            this.lbl_Time.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_Time.Name = "lbl_Time";
            this.lbl_Time.Size = new System.Drawing.Size(106, 21);
            this.lbl_Time.TabIndex = 0;
            this.lbl_Time.Text = "HH:MM:SS";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tableLayoutPanel2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(5, 5);
            this.panel2.Margin = new System.Windows.Forms.Padding(5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1337, 748);
            this.panel2.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.03704F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.flowLayoutPanel1, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(5);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.027924F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 91.97208F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1337, 748);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.18743F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 83.81257F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.panel3, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(5, 65);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(5);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.09416F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1327, 678);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.flp_ListDb, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.panel4, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(5, 5);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(5);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.095238F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 93.90476F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(204, 668);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // flp_ListDb
            // 
            this.flp_ListDb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flp_ListDb.Location = new System.Drawing.Point(5, 45);
            this.flp_ListDb.Margin = new System.Windows.Forms.Padding(5);
            this.flp_ListDb.Name = "flp_ListDb";
            this.flp_ListDb.Size = new System.Drawing.Size(194, 618);
            this.flp_ListDb.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.button6);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Location = new System.Drawing.Point(5, 5);
            this.panel4.Margin = new System.Windows.Forms.Padding(5);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(194, 30);
            this.panel4.TabIndex = 1;
            // 
            // button6
            // 
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Image = global::BackupRestore.Properties.Resources.icons8_database_view_16;
            this.button6.Location = new System.Drawing.Point(7, 0);
            this.button6.Margin = new System.Windows.Forms.Padding(5);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(43, 38);
            this.button6.TabIndex = 1;
            this.button6.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cơ sở dữ liệu";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tableLayoutPanel5);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(219, 5);
            this.panel3.Margin = new System.Windows.Forms.Padding(5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1103, 668);
            this.panel3.TabIndex = 1;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.pnl_WorkControl, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.flowLayoutPanel2, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(5);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.407767F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 93.59223F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(1103, 668);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // pnl_WorkControl
            // 
            this.pnl_WorkControl.Controls.Add(this.lsv_BackupVersions);
            this.pnl_WorkControl.Controls.Add(this.dtp_TimeRestore);
            this.pnl_WorkControl.Controls.Add(this.dtp_DateRestore);
            this.pnl_WorkControl.Controls.Add(this.label5);
            this.pnl_WorkControl.Controls.Add(this.chk_DelAllBeforeBackup);
            this.pnl_WorkControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_WorkControl.Location = new System.Drawing.Point(5, 47);
            this.pnl_WorkControl.Margin = new System.Windows.Forms.Padding(5);
            this.pnl_WorkControl.Name = "pnl_WorkControl";
            this.pnl_WorkControl.Size = new System.Drawing.Size(1093, 616);
            this.pnl_WorkControl.TabIndex = 0;
            // 
            // lsv_BackupVersions
            // 
            this.lsv_BackupVersions.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colPosition,
            this.colDescription,
            this.colDate,
            this.colUserName});
            this.lsv_BackupVersions.Dock = System.Windows.Forms.DockStyle.Top;
            this.lsv_BackupVersions.FullRowSelect = true;
            this.lsv_BackupVersions.GridLines = true;
            this.lsv_BackupVersions.HideSelection = false;
            this.lsv_BackupVersions.Location = new System.Drawing.Point(0, 0);
            this.lsv_BackupVersions.Name = "lsv_BackupVersions";
            this.lsv_BackupVersions.Size = new System.Drawing.Size(1093, 349);
            this.lsv_BackupVersions.TabIndex = 5;
            this.lsv_BackupVersions.UseCompatibleStateImageBehavior = false;
            this.lsv_BackupVersions.View = System.Windows.Forms.View.Details;
            this.lsv_BackupVersions.SelectedIndexChanged += new System.EventHandler(this.lsv_BackupVersions_SelectedIndexChanged);
            // 
            // colPosition
            // 
            this.colPosition.Tag = "";
            this.colPosition.Text = "Position";
            this.colPosition.Width = 100;
            // 
            // colDescription
            // 
            this.colDescription.Text = "Description";
            this.colDescription.Width = 300;
            // 
            // colDate
            // 
            this.colDate.Text = "Date";
            this.colDate.Width = 300;
            // 
            // colUserName
            // 
            this.colUserName.Text = "UserName";
            this.colUserName.Width = 200;
            // 
            // dtp_TimeRestore
            // 
            this.dtp_TimeRestore.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_TimeRestore.Location = new System.Drawing.Point(705, 480);
            this.dtp_TimeRestore.Margin = new System.Windows.Forms.Padding(5);
            this.dtp_TimeRestore.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.dtp_TimeRestore.Name = "dtp_TimeRestore";
            this.dtp_TimeRestore.Size = new System.Drawing.Size(172, 33);
            this.dtp_TimeRestore.TabIndex = 4;
            // 
            // dtp_DateRestore
            // 
            this.dtp_DateRestore.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_DateRestore.Location = new System.Drawing.Point(509, 480);
            this.dtp_DateRestore.Margin = new System.Windows.Forms.Padding(5);
            this.dtp_DateRestore.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.dtp_DateRestore.Name = "dtp_DateRestore";
            this.dtp_DateRestore.Size = new System.Drawing.Size(172, 33);
            this.dtp_DateRestore.TabIndex = 3;
            this.dtp_DateRestore.Value = new System.DateTime(2022, 3, 20, 12, 51, 18, 140);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(158, 485);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(271, 25);
            this.label5.TabIndex = 2;
            this.label5.Text = "Ngày giờ muốn phục hồi đến ";
            // 
            // chk_DelAllBeforeBackup
            // 
            this.chk_DelAllBeforeBackup.AutoSize = true;
            this.chk_DelAllBeforeBackup.Location = new System.Drawing.Point(273, 378);
            this.chk_DelAllBeforeBackup.Margin = new System.Windows.Forms.Padding(5);
            this.chk_DelAllBeforeBackup.Name = "chk_DelAllBeforeBackup";
            this.chk_DelAllBeforeBackup.Size = new System.Drawing.Size(494, 29);
            this.chk_DelAllBeforeBackup.TabIndex = 1;
            this.chk_DelAllBeforeBackup.Text = "Xóa tất cả các bản backup trước đó  rồi mới backup";
            this.chk_DelAllBeforeBackup.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.label2);
            this.flowLayoutPanel2.Controls.Add(this.lbl_DbName);
            this.flowLayoutPanel2.Controls.Add(this.label3);
            this.flowLayoutPanel2.Controls.Add(this.label4);
            this.flowLayoutPanel2.Controls.Add(this.lbl_BackupCount);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(5, 5);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(5);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(1093, 32);
            this.flowLayoutPanel2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Database: ";
            // 
            // lbl_DbName
            // 
            this.lbl_DbName.AutoSize = true;
            this.lbl_DbName.Location = new System.Drawing.Point(121, 0);
            this.lbl_DbName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_DbName.Name = "lbl_DbName";
            this.lbl_DbName.Size = new System.Drawing.Size(91, 25);
            this.lbl_DbName.TabIndex = 1;
            this.lbl_DbName.Text = "db_name";
            this.lbl_DbName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(222, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "                          ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(400, 0);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Số bản sao lưu: ";
            // 
            // lbl_BackupCount
            // 
            this.lbl_BackupCount.AutoSize = true;
            this.lbl_BackupCount.Location = new System.Drawing.Point(565, 0);
            this.lbl_BackupCount.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_BackupCount.Name = "lbl_BackupCount";
            this.lbl_BackupCount.Size = new System.Drawing.Size(162, 25);
            this.lbl_BackupCount.TabIndex = 4;
            this.lbl_BackupCount.Text = "db_backupCount";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btn_Backup);
            this.flowLayoutPanel1.Controls.Add(this.btn_Restore);
            this.flowLayoutPanel1.Controls.Add(this.btn_RestoreByTime);
            this.flowLayoutPanel1.Controls.Add(this.btn_CreateDevice);
            this.flowLayoutPanel1.Controls.Add(this.btn_Exit);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(5, 5);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(5);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1327, 50);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // btn_Backup
            // 
            this.btn_Backup.FlatAppearance.BorderSize = 0;
            this.btn_Backup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Backup.Image = global::BackupRestore.Properties.Resources.icons8_data_backup_32;
            this.btn_Backup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Backup.Location = new System.Drawing.Point(5, 5);
            this.btn_Backup.Margin = new System.Windows.Forms.Padding(5, 5, 10, 5);
            this.btn_Backup.Name = "btn_Backup";
            this.btn_Backup.Size = new System.Drawing.Size(159, 45);
            this.btn_Backup.TabIndex = 0;
            this.btn_Backup.Text = "Sao Lưu";
            this.btn_Backup.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Backup.UseVisualStyleBackColor = true;
            this.btn_Backup.Click += new System.EventHandler(this.btn_Backup_Click);
            // 
            // btn_Restore
            // 
            this.btn_Restore.FlatAppearance.BorderSize = 0;
            this.btn_Restore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Restore.Image = global::BackupRestore.Properties.Resources.icons8_database_restore_32;
            this.btn_Restore.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Restore.Location = new System.Drawing.Point(179, 5);
            this.btn_Restore.Margin = new System.Windows.Forms.Padding(5, 5, 10, 5);
            this.btn_Restore.Name = "btn_Restore";
            this.btn_Restore.Size = new System.Drawing.Size(170, 45);
            this.btn_Restore.TabIndex = 1;
            this.btn_Restore.Text = "Phục Hồi";
            this.btn_Restore.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Restore.UseVisualStyleBackColor = true;
            this.btn_Restore.Click += new System.EventHandler(this.btn_Restore_Click);
            // 
            // btn_RestoreByTime
            // 
            this.btn_RestoreByTime.FlatAppearance.BorderSize = 0;
            this.btn_RestoreByTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_RestoreByTime.Image = global::BackupRestore.Properties.Resources.icons8_alarm_clock_32;
            this.btn_RestoreByTime.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_RestoreByTime.Location = new System.Drawing.Point(364, 5);
            this.btn_RestoreByTime.Margin = new System.Windows.Forms.Padding(5, 5, 10, 5);
            this.btn_RestoreByTime.Name = "btn_RestoreByTime";
            this.btn_RestoreByTime.Size = new System.Drawing.Size(214, 45);
            this.btn_RestoreByTime.TabIndex = 2;
            this.btn_RestoreByTime.Text = "Phục hồi theo TG";
            this.btn_RestoreByTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_RestoreByTime.UseVisualStyleBackColor = true;
            // 
            // btn_CreateDevice
            // 
            this.btn_CreateDevice.FlatAppearance.BorderSize = 0;
            this.btn_CreateDevice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CreateDevice.Image = global::BackupRestore.Properties.Resources.icons8_save_close_32;
            this.btn_CreateDevice.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_CreateDevice.Location = new System.Drawing.Point(593, 5);
            this.btn_CreateDevice.Margin = new System.Windows.Forms.Padding(5, 5, 10, 5);
            this.btn_CreateDevice.Name = "btn_CreateDevice";
            this.btn_CreateDevice.Size = new System.Drawing.Size(169, 45);
            this.btn_CreateDevice.TabIndex = 3;
            this.btn_CreateDevice.Text = "Tạo Device";
            this.btn_CreateDevice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_CreateDevice.UseVisualStyleBackColor = true;
            this.btn_CreateDevice.Click += new System.EventHandler(this.btn_CreateDevice_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.FlatAppearance.BorderSize = 0;
            this.btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Exit.Image = global::BackupRestore.Properties.Resources.icons8_close_window_32;
            this.btn_Exit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Exit.Location = new System.Drawing.Point(777, 5);
            this.btn_Exit.Margin = new System.Windows.Forms.Padding(5);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(130, 45);
            this.btn_Exit.TabIndex = 4;
            this.btn_Exit.Text = "Thoát";
            this.btn_Exit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1347, 801);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.pnl_WorkControl.ResumeLayout(false);
            this.pnl_WorkControl.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_Time;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.FlowLayoutPanel flp_ListDb;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Panel pnl_WorkControl;
        private System.Windows.Forms.DateTimePicker dtp_TimeRestore;
        private System.Windows.Forms.DateTimePicker dtp_DateRestore;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chk_DelAllBeforeBackup;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_DbName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_BackupCount;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btn_Backup;
        private System.Windows.Forms.Button btn_Restore;
        private System.Windows.Forms.Button btn_RestoreByTime;
        private System.Windows.Forms.Button btn_CreateDevice;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.ListView lsv_BackupVersions;
        private System.Windows.Forms.ColumnHeader colPosition;
        private System.Windows.Forms.ColumnHeader colDescription;
        private System.Windows.Forms.ColumnHeader colDate;
        private System.Windows.Forms.ColumnHeader colUserName;
    }
}