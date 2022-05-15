namespace bai_cuoi_ky_winform
{
    partial class CalamViec
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtgv_working = new System.Windows.Forms.DataGridView();
            this.label11 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tblp_btn = new System.Windows.Forms.TableLayoutPanel();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnReload = new System.Windows.Forms.Button();
            this.panel_form = new System.Windows.Forms.Panel();
            this.txtThanhTien = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTongSoCa = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCLVSoTien = new System.Windows.Forms.TextBox();
            this.txtCLVID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtp_stopAt = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.dtp_startAt = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCLVTen = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpicker_createdDate = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_working)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.tblp_btn.SuspendLayout();
            this.panel_form.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgv_working
            // 
            this.dtgv_working.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Phetsarath OT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgv_working.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgv_working.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Phetsarath OT", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgv_working.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgv_working.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgv_working.Location = new System.Drawing.Point(16, 18);
            this.dtgv_working.Name = "dtgv_working";
            this.dtgv_working.ReadOnly = true;
            this.dtgv_working.RowHeadersWidth = 62;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgv_working.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgv_working.RowTemplate.Height = 24;
            this.dtgv_working.Size = new System.Drawing.Size(1083, 130);
            this.dtgv_working.TabIndex = 13;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(427, 23);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(312, 60);
            this.label11.TabIndex = 17;
            this.label11.Text = "Ca Làm Việc";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label11);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1182, 125);
            this.panel1.TabIndex = 18;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.BackgroundImage = global::bai_cuoi_ky_winform.Properties.Resources.cf;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel_form);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1182, 771);
            this.panel2.TabIndex = 17;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.tblp_btn);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 407);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1182, 125);
            this.panel4.TabIndex = 20;
            // 
            // tblp_btn
            // 
            this.tblp_btn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tblp_btn.ColumnCount = 7;
            this.tblp_btn.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28629F));
            this.tblp_btn.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28629F));
            this.tblp_btn.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28629F));
            this.tblp_btn.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28486F));
            this.tblp_btn.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28486F));
            this.tblp_btn.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tblp_btn.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tblp_btn.Controls.Add(this.btnEdit, 0, 0);
            this.tblp_btn.Controls.Add(this.btnDelete, 0, 0);
            this.tblp_btn.Controls.Add(this.btnCancel, 0, 0);
            this.tblp_btn.Controls.Add(this.btnAdd, 0, 0);
            this.tblp_btn.Controls.Add(this.btnExit, 2, 0);
            this.tblp_btn.Controls.Add(this.btnSave, 0, 0);
            this.tblp_btn.Controls.Add(this.btnReload, 1, 0);
            this.tblp_btn.Location = new System.Drawing.Point(137, 25);
            this.tblp_btn.Margin = new System.Windows.Forms.Padding(12, 3, 12, 3);
            this.tblp_btn.Name = "tblp_btn";
            this.tblp_btn.RowCount = 1;
            this.tblp_btn.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblp_btn.Size = new System.Drawing.Size(908, 75);
            this.tblp_btn.TabIndex = 14;
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEdit.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(390, 3);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(123, 69);
            this.btnEdit.TabIndex = 6;
            this.btnEdit.Text = "Chính sửa";
            this.btnEdit.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnDelete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDelete.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(519, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(123, 69);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCancel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(261, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(123, 69);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAdd.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(3, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(123, 69);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnExit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(777, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(128, 69);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSave.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(132, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(123, 69);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // btnReload
            // 
            this.btnReload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnReload.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnReload.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReload.Location = new System.Drawing.Point(648, 3);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(123, 69);
            this.btnReload.TabIndex = 0;
            this.btnReload.Text = "Tải lại";
            this.btnReload.UseVisualStyleBackColor = false;
            // 
            // panel_form
            // 
            this.panel_form.BackColor = System.Drawing.Color.Transparent;
            this.panel_form.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_form.Controls.Add(this.txtThanhTien);
            this.panel_form.Controls.Add(this.label6);
            this.panel_form.Controls.Add(this.txtTongSoCa);
            this.panel_form.Controls.Add(this.label3);
            this.panel_form.Controls.Add(this.txtCLVSoTien);
            this.panel_form.Controls.Add(this.txtCLVID);
            this.panel_form.Controls.Add(this.label5);
            this.panel_form.Controls.Add(this.dtp_stopAt);
            this.panel_form.Controls.Add(this.label7);
            this.panel_form.Controls.Add(this.dtp_startAt);
            this.panel_form.Controls.Add(this.label4);
            this.panel_form.Controls.Add(this.txtCLVTen);
            this.panel_form.Controls.Add(this.label1);
            this.panel_form.Controls.Add(this.dtpicker_createdDate);
            this.panel_form.Controls.Add(this.label9);
            this.panel_form.Controls.Add(this.label2);
            this.panel_form.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_form.ForeColor = System.Drawing.Color.White;
            this.panel_form.Location = new System.Drawing.Point(0, 125);
            this.panel_form.Name = "panel_form";
            this.panel_form.Size = new System.Drawing.Size(1182, 282);
            this.panel_form.TabIndex = 19;
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtThanhTien.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThanhTien.Location = new System.Drawing.Point(887, 184);
            this.txtThanhTien.Multiline = true;
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.Size = new System.Drawing.Size(241, 29);
            this.txtThanhTien.TabIndex = 57;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(683, 184);
            this.label6.Margin = new System.Windows.Forms.Padding(3, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 26);
            this.label6.TabIndex = 56;
            this.label6.Text = "Thành Tiền:";
            // 
            // txtTongSoCa
            // 
            this.txtTongSoCa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTongSoCa.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongSoCa.Location = new System.Drawing.Point(333, 189);
            this.txtTongSoCa.Multiline = true;
            this.txtTongSoCa.Name = "txtTongSoCa";
            this.txtTongSoCa.Size = new System.Drawing.Size(294, 29);
            this.txtTongSoCa.TabIndex = 55;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(129, 189);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 26);
            this.label3.TabIndex = 54;
            this.label3.Text = "Tổng Số Ca:";
            // 
            // txtCLVSoTien
            // 
            this.txtCLVSoTien.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCLVSoTien.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCLVSoTien.Location = new System.Drawing.Point(836, 72);
            this.txtCLVSoTien.Multiline = true;
            this.txtCLVSoTien.Name = "txtCLVSoTien";
            this.txtCLVSoTien.Size = new System.Drawing.Size(294, 29);
            this.txtCLVSoTien.TabIndex = 53;
            // 
            // txtCLVID
            // 
            this.txtCLVID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCLVID.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCLVID.Location = new System.Drawing.Point(333, 72);
            this.txtCLVID.Multiline = true;
            this.txtCLVID.Name = "txtCLVID";
            this.txtCLVID.Size = new System.Drawing.Size(294, 29);
            this.txtCLVID.TabIndex = 52;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(135, 69);
            this.label5.Margin = new System.Windows.Forms.Padding(3, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 26);
            this.label5.TabIndex = 51;
            this.label5.Text = "Nhân Viên ID:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // dtp_stopAt
            // 
            this.dtp_stopAt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtp_stopAt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_stopAt.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtp_stopAt.Location = new System.Drawing.Point(923, 128);
            this.dtp_stopAt.Name = "dtp_stopAt";
            this.dtp_stopAt.Size = new System.Drawing.Size(168, 30);
            this.dtp_stopAt.TabIndex = 50;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(682, 129);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(213, 26);
            this.label7.TabIndex = 49;
            this.label7.Text = "Thời Gian kết thúc:";
            // 
            // dtp_startAt
            // 
            this.dtp_startAt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtp_startAt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_startAt.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtp_startAt.Location = new System.Drawing.Point(366, 128);
            this.dtp_startAt.Name = "dtp_startAt";
            this.dtp_startAt.Size = new System.Drawing.Size(168, 30);
            this.dtp_startAt.TabIndex = 48;
            this.dtp_startAt.ValueChanged += new System.EventHandler(this.dtp_startAt_ValueChanged);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(129, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(216, 26);
            this.label4.TabIndex = 47;
            this.label4.Text = "Thời Gian Bắt đầu: ";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtCLVTen
            // 
            this.txtCLVTen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCLVTen.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCLVTen.Location = new System.Drawing.Point(333, 21);
            this.txtCLVTen.Multiline = true;
            this.txtCLVTen.Name = "txtCLVTen";
            this.txtCLVTen.Size = new System.Drawing.Size(294, 29);
            this.txtCLVTen.TabIndex = 44;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(132, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 26);
            this.label1.TabIndex = 43;
            this.label1.Text = "Tên Nhân Viên: ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dtpicker_createdDate
            // 
            this.dtpicker_createdDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpicker_createdDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpicker_createdDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpicker_createdDate.Location = new System.Drawing.Point(836, 22);
            this.dtpicker_createdDate.Name = "dtpicker_createdDate";
            this.dtpicker_createdDate.Size = new System.Drawing.Size(134, 30);
            this.dtpicker_createdDate.TabIndex = 41;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(689, 77);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(141, 26);
            this.label9.TabIndex = 40;
            this.label9.Text = "Số tiền / giờ:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(689, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 26);
            this.label2.TabIndex = 39;
            this.label2.Text = "Ngày làm:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.Controls.Add(this.dtgv_working);
            this.panel5.Location = new System.Drawing.Point(30, 569);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(16, 18, 16, 18);
            this.panel5.Size = new System.Drawing.Size(1115, 166);
            this.panel5.TabIndex = 16;
            // 
            // CalamViec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 771);
            this.Controls.Add(this.panel2);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "CalamViec";
            this.Text = "CalamViek";
            this.Load += new System.EventHandler(this.CalamViec_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_working)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.tblp_btn.ResumeLayout(false);
            this.panel_form.ResumeLayout(false);
            this.panel_form.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgv_working;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TableLayoutPanel tblp_btn;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Panel panel_form;
        private System.Windows.Forms.DateTimePicker dtp_stopAt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtp_startAt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCLVTen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpicker_createdDate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCLVID;
        private System.Windows.Forms.TextBox txtCLVSoTien;
        private System.Windows.Forms.TextBox txtThanhTien;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTongSoCa;
        private System.Windows.Forms.Label label3;
    }
}