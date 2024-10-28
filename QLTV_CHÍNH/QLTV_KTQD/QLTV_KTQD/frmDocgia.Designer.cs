
namespace HellloWorld
{
    partial class frmDocgia
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
            this.components = new System.ComponentModel.Container();
            this.cbxchucvu = new System.Windows.Forms.ComboBox();
            this.txtsdt2 = new System.Windows.Forms.TextBox();
            this.txtMalop = new System.Windows.Forms.TextBox();
            this.txtmadg2 = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.lbkvien = new System.Windows.Forms.Label();
            this.lbnum = new System.Windows.Forms.Label();
            this.lbType = new System.Windows.Forms.Label();
            this.lbclass = new System.Windows.Forms.Label();
            this.lbname = new System.Windows.Forms.Label();
            this.grdDocgia = new System.Windows.Forms.DataGridView();
            this.ma_doc_gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ten_doc_gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ma_lop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chuc_vu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.docgiaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLTV_PTUDDataSet = new QLTV_KTQD.QLTV_PTUDDataSet();
            this.lbmadg = new System.Windows.Forms.Label();
            this.grdLSmuon = new System.Windows.Forms.DataGridView();
            this.txtmadg1 = new System.Windows.Forms.TextBox();
            this.gbxTTdg = new System.Windows.Forms.GroupBox();
            this.txtkhoa = new System.Windows.Forms.TextBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.gbxTimdg = new System.Windows.Forms.GroupBox();
            this.cbxtraDG = new System.Windows.Forms.ComboBox();
            this.gbxLSmuon = new System.Windows.Forms.GroupBox();
            this.plDocgia = new System.Windows.Forms.Panel();
            this.grbEdit = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnFix = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.doc_giaTableAdapter = new QLTV_KTQD.QLTV_PTUDDataSetTableAdapters.doc_giaTableAdapter();
            this.panel13 = new System.Windows.Forms.Panel();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrv = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.fKphieumuomado6BAEFA67BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.phieu_muonTableAdapter = new QLTV_KTQD.QLTV_PTUDDataSetTableAdapters.phieu_muonTableAdapter();
            this.ma_phieu_muon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ma_kieu_muon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngay_muon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngay_hen_tra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngay_thuc_tra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ma_thu_thu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdDocgia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.docgiaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLTV_PTUDDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdLSmuon)).BeginInit();
            this.gbxTTdg.SuspendLayout();
            this.gbxTimdg.SuspendLayout();
            this.gbxLSmuon.SuspendLayout();
            this.plDocgia.SuspendLayout();
            this.grbEdit.SuspendLayout();
            this.panel13.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fKphieumuomado6BAEFA67BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxchucvu
            // 
            this.cbxchucvu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxchucvu.FormattingEnabled = true;
            this.cbxchucvu.Items.AddRange(new object[] {
            "GV",
            "SV"});
            this.cbxchucvu.Location = new System.Drawing.Point(107, 143);
            this.cbxchucvu.Margin = new System.Windows.Forms.Padding(2);
            this.cbxchucvu.Name = "cbxchucvu";
            this.cbxchucvu.Size = new System.Drawing.Size(170, 27);
            this.cbxchucvu.TabIndex = 6;
            this.cbxchucvu.SelectedIndexChanged += new System.EventHandler(this.cbxchucvu_SelectedIndexChanged);
            // 
            // txtsdt2
            // 
            this.txtsdt2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtsdt2.Location = new System.Drawing.Point(107, 266);
            this.txtsdt2.Margin = new System.Windows.Forms.Padding(2);
            this.txtsdt2.Multiline = true;
            this.txtsdt2.Name = "txtsdt2";
            this.txtsdt2.Size = new System.Drawing.Size(170, 22);
            this.txtsdt2.TabIndex = 2;
            this.txtsdt2.TextChanged += new System.EventHandler(this.txtsdt2_TextChanged);
            // 
            // txtMalop
            // 
            this.txtMalop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMalop.Location = new System.Drawing.Point(107, 183);
            this.txtMalop.Margin = new System.Windows.Forms.Padding(2);
            this.txtMalop.Multiline = true;
            this.txtMalop.Name = "txtMalop";
            this.txtMalop.Size = new System.Drawing.Size(170, 22);
            this.txtMalop.TabIndex = 2;
            this.txtMalop.TextChanged += new System.EventHandler(this.txtMalop_TextChanged);
            // 
            // txtmadg2
            // 
            this.txtmadg2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtmadg2.Location = new System.Drawing.Point(107, 55);
            this.txtmadg2.Margin = new System.Windows.Forms.Padding(2);
            this.txtmadg2.Multiline = true;
            this.txtmadg2.Name = "txtmadg2";
            this.txtmadg2.Size = new System.Drawing.Size(170, 22);
            this.txtmadg2.TabIndex = 2;
            this.txtmadg2.TextChanged += new System.EventHandler(this.txtmadg2_TextChanged);
            // 
            // txtname
            // 
            this.txtname.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtname.Location = new System.Drawing.Point(107, 97);
            this.txtname.Margin = new System.Windows.Forms.Padding(2);
            this.txtname.Multiline = true;
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(170, 22);
            this.txtname.TabIndex = 2;
            this.txtname.TextChanged += new System.EventHandler(this.txtname_TextChanged);
            // 
            // lbkvien
            // 
            this.lbkvien.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbkvien.AutoSize = true;
            this.lbkvien.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbkvien.Location = new System.Drawing.Point(7, 229);
            this.lbkvien.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbkvien.Name = "lbkvien";
            this.lbkvien.Size = new System.Drawing.Size(92, 19);
            this.lbkvien.TabIndex = 1;
            this.lbkvien.Text = "Mã khoa viện";
            this.lbkvien.Click += new System.EventHandler(this.lbkvien_Click);
            // 
            // lbnum
            // 
            this.lbnum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbnum.AutoSize = true;
            this.lbnum.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbnum.Location = new System.Drawing.Point(7, 271);
            this.lbnum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbnum.Name = "lbnum";
            this.lbnum.Size = new System.Drawing.Size(88, 19);
            this.lbnum.TabIndex = 1;
            this.lbnum.Text = "Số điện thoại";
            this.lbnum.Click += new System.EventHandler(this.lbnum_Click);
            // 
            // lbType
            // 
            this.lbType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbType.AutoSize = true;
            this.lbType.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbType.Location = new System.Drawing.Point(6, 145);
            this.lbType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbType.Name = "lbType";
            this.lbType.Size = new System.Drawing.Size(84, 19);
            this.lbType.TabIndex = 1;
            this.lbType.Text = "Loại độc giả";
            this.lbType.Click += new System.EventHandler(this.lbType_Click);
            // 
            // lbclass
            // 
            this.lbclass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbclass.AutoSize = true;
            this.lbclass.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbclass.Location = new System.Drawing.Point(7, 188);
            this.lbclass.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbclass.Name = "lbclass";
            this.lbclass.Size = new System.Drawing.Size(53, 19);
            this.lbclass.TabIndex = 1;
            this.lbclass.Text = "Mã lớp";
            this.lbclass.Click += new System.EventHandler(this.lbclass_Click);
            // 
            // lbname
            // 
            this.lbname.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbname.AutoSize = true;
            this.lbname.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbname.Location = new System.Drawing.Point(7, 102);
            this.lbname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbname.Name = "lbname";
            this.lbname.Size = new System.Drawing.Size(58, 19);
            this.lbname.TabIndex = 1;
            this.lbname.Text = "Họ tên*";
            this.lbname.Click += new System.EventHandler(this.lbname_Click);
            // 
            // grdDocgia
            // 
            this.grdDocgia.AutoGenerateColumns = false;
            this.grdDocgia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDocgia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ma_doc_gia,
            this.ten_doc_gia,
            this.ma_lop,
            this.sdt,
            this.chuc_vu});
            this.grdDocgia.DataSource = this.docgiaBindingSource;
            this.grdDocgia.Location = new System.Drawing.Point(2, 2);
            this.grdDocgia.Margin = new System.Windows.Forms.Padding(2);
            this.grdDocgia.Name = "grdDocgia";
            this.grdDocgia.RowHeadersWidth = 62;
            this.grdDocgia.RowTemplate.Height = 28;
            this.grdDocgia.Size = new System.Drawing.Size(534, 149);
            this.grdDocgia.TabIndex = 24;
            this.grdDocgia.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdDataDocgia_CellContentClick);
            // 
            // ma_doc_gia
            // 
            this.ma_doc_gia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ma_doc_gia.DataPropertyName = "ma_doc_gia";
            this.ma_doc_gia.HeaderText = "Mã độc giả";
            this.ma_doc_gia.Name = "ma_doc_gia";
            this.ma_doc_gia.Width = 103;
            // 
            // ten_doc_gia
            // 
            this.ten_doc_gia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ten_doc_gia.DataPropertyName = "ten_doc_gia";
            this.ten_doc_gia.HeaderText = "Tên độc giả";
            this.ten_doc_gia.Name = "ten_doc_gia";
            this.ten_doc_gia.Width = 105;
            // 
            // ma_lop
            // 
            this.ma_lop.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ma_lop.DataPropertyName = "ma_lop";
            this.ma_lop.HeaderText = "Mã lớp";
            this.ma_lop.Name = "ma_lop";
            this.ma_lop.Width = 78;
            // 
            // sdt
            // 
            this.sdt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.sdt.DataPropertyName = "sdt";
            this.sdt.HeaderText = "SĐT";
            this.sdt.Name = "sdt";
            this.sdt.Width = 63;
            // 
            // chuc_vu
            // 
            this.chuc_vu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.chuc_vu.DataPropertyName = "chuc_vu";
            this.chuc_vu.HeaderText = "Chức vụ";
            this.chuc_vu.Name = "chuc_vu";
            this.chuc_vu.Width = 86;
            // 
            // docgiaBindingSource
            // 
            this.docgiaBindingSource.DataMember = "doc_gia";
            this.docgiaBindingSource.DataSource = this.qLTV_PTUDDataSet;
            // 
            // qLTV_PTUDDataSet
            // 
            this.qLTV_PTUDDataSet.DataSetName = "QLTV_PTUDDataSet";
            this.qLTV_PTUDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lbmadg
            // 
            this.lbmadg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbmadg.AutoSize = true;
            this.lbmadg.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbmadg.Location = new System.Drawing.Point(5, 59);
            this.lbmadg.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbmadg.Name = "lbmadg";
            this.lbmadg.Size = new System.Drawing.Size(86, 19);
            this.lbmadg.TabIndex = 1;
            this.lbmadg.Text = "Mã độc giả*";
            this.lbmadg.Click += new System.EventHandler(this.lbmadg_Click);
            // 
            // grdLSmuon
            // 
            this.grdLSmuon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.grdLSmuon.AutoGenerateColumns = false;
            this.grdLSmuon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdLSmuon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ma_phieu_muon,
            this.ma_kieu_muon,
            this.ngay_muon,
            this.ngay_hen_tra,
            this.ngay_thuc_tra,
            this.ma_thu_thu});
            this.grdLSmuon.DataSource = this.fKphieumuomado6BAEFA67BindingSource;
            this.grdLSmuon.Location = new System.Drawing.Point(0, 23);
            this.grdLSmuon.Margin = new System.Windows.Forms.Padding(2);
            this.grdLSmuon.Name = "grdLSmuon";
            this.grdLSmuon.RowHeadersWidth = 62;
            this.grdLSmuon.RowTemplate.Height = 28;
            this.grdLSmuon.Size = new System.Drawing.Size(538, 143);
            this.grdLSmuon.TabIndex = 23;
            this.grdLSmuon.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // txtmadg1
            // 
            this.txtmadg1.Location = new System.Drawing.Point(170, 29);
            this.txtmadg1.Margin = new System.Windows.Forms.Padding(2);
            this.txtmadg1.Multiline = true;
            this.txtmadg1.Name = "txtmadg1";
            this.txtmadg1.Size = new System.Drawing.Size(204, 27);
            this.txtmadg1.TabIndex = 22;
            this.txtmadg1.TextChanged += new System.EventHandler(this.txtmadg1_TextChanged);
            // 
            // gbxTTdg
            // 
            this.gbxTTdg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxTTdg.BackColor = System.Drawing.Color.Lavender;
            this.gbxTTdg.Controls.Add(this.cbxchucvu);
            this.gbxTTdg.Controls.Add(this.txtsdt2);
            this.gbxTTdg.Controls.Add(this.txtkhoa);
            this.gbxTTdg.Controls.Add(this.txtMalop);
            this.gbxTTdg.Controls.Add(this.txtmadg2);
            this.gbxTTdg.Controls.Add(this.txtname);
            this.gbxTTdg.Controls.Add(this.lbkvien);
            this.gbxTTdg.Controls.Add(this.lbnum);
            this.gbxTTdg.Controls.Add(this.lbmadg);
            this.gbxTTdg.Controls.Add(this.lbType);
            this.gbxTTdg.Controls.Add(this.lbclass);
            this.gbxTTdg.Controls.Add(this.lbname);
            this.gbxTTdg.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxTTdg.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gbxTTdg.Location = new System.Drawing.Point(558, 86);
            this.gbxTTdg.Margin = new System.Windows.Forms.Padding(2);
            this.gbxTTdg.Name = "gbxTTdg";
            this.gbxTTdg.Padding = new System.Windows.Forms.Padding(2);
            this.gbxTTdg.Size = new System.Drawing.Size(295, 323);
            this.gbxTTdg.TabIndex = 20;
            this.gbxTTdg.TabStop = false;
            this.gbxTTdg.Tag = "";
            this.gbxTTdg.Text = "*Thông tin độc giả";
            this.gbxTTdg.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtkhoa
            // 
            this.txtkhoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtkhoa.Location = new System.Drawing.Point(107, 224);
            this.txtkhoa.Margin = new System.Windows.Forms.Padding(2);
            this.txtkhoa.Multiline = true;
            this.txtkhoa.Name = "txtkhoa";
            this.txtkhoa.Size = new System.Drawing.Size(170, 22);
            this.txtkhoa.TabIndex = 2;
            this.txtkhoa.TextChanged += new System.EventHandler(this.txtkhoa_TextChanged);
            // 
            // btnFind
            // 
            this.btnFind.AutoSize = true;
            this.btnFind.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnFind.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.btnFind.FlatAppearance.BorderSize = 0;
            this.btnFind.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnFind.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnFind.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFind.Location = new System.Drawing.Point(393, 29);
            this.btnFind.Margin = new System.Windows.Forms.Padding(2);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(67, 29);
            this.btnFind.TabIndex = 25;
            this.btnFind.Text = "Tìm";
            this.btnFind.UseVisualStyleBackColor = false;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // gbxTimdg
            // 
            this.gbxTimdg.BackColor = System.Drawing.Color.Lavender;
            this.gbxTimdg.Controls.Add(this.cbxtraDG);
            this.gbxTimdg.Controls.Add(this.btnFind);
            this.gbxTimdg.Controls.Add(this.txtmadg1);
            this.gbxTimdg.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxTimdg.Location = new System.Drawing.Point(11, 11);
            this.gbxTimdg.Margin = new System.Windows.Forms.Padding(2);
            this.gbxTimdg.Name = "gbxTimdg";
            this.gbxTimdg.Padding = new System.Windows.Forms.Padding(2);
            this.gbxTimdg.Size = new System.Drawing.Size(538, 66);
            this.gbxTimdg.TabIndex = 30;
            this.gbxTimdg.TabStop = false;
            this.gbxTimdg.Text = "* Tìm kiếm độc giả";
            this.gbxTimdg.Enter += new System.EventHandler(this.gbxTimdg_Enter);
            // 
            // cbxtraDG
            // 
            this.cbxtraDG.FormattingEnabled = true;
            this.cbxtraDG.Items.AddRange(new object[] {
            "Mã độc giả",
            "Tên độc giả",
            "Số điện thoại",
            "Mã lớp"});
            this.cbxtraDG.Location = new System.Drawing.Point(19, 29);
            this.cbxtraDG.Margin = new System.Windows.Forms.Padding(2);
            this.cbxtraDG.Name = "cbxtraDG";
            this.cbxtraDG.Size = new System.Drawing.Size(134, 27);
            this.cbxtraDG.TabIndex = 26;
            this.cbxtraDG.Text = "Từ khóa";
            this.cbxtraDG.SelectedIndexChanged += new System.EventHandler(this.cbxtraDG_SelectedIndexChanged);
            // 
            // gbxLSmuon
            // 
            this.gbxLSmuon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.gbxLSmuon.Controls.Add(this.grdLSmuon);
            this.gbxLSmuon.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxLSmuon.Location = new System.Drawing.Point(11, 320);
            this.gbxLSmuon.Margin = new System.Windows.Forms.Padding(2);
            this.gbxLSmuon.Name = "gbxLSmuon";
            this.gbxLSmuon.Padding = new System.Windows.Forms.Padding(2);
            this.gbxLSmuon.Size = new System.Drawing.Size(538, 170);
            this.gbxLSmuon.TabIndex = 32;
            this.gbxLSmuon.TabStop = false;
            this.gbxLSmuon.Text = "Lịch sử mượn";
            // 
            // plDocgia
            // 
            this.plDocgia.Controls.Add(this.grdDocgia);
            this.plDocgia.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plDocgia.Location = new System.Drawing.Point(11, 85);
            this.plDocgia.Name = "plDocgia";
            this.plDocgia.Size = new System.Drawing.Size(538, 153);
            this.plDocgia.TabIndex = 34;
            // 
            // grbEdit
            // 
            this.grbEdit.Controls.Add(this.btnDelete);
            this.grbEdit.Controls.Add(this.btnFix);
            this.grbEdit.Controls.Add(this.btnInsert);
            this.grbEdit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbEdit.Location = new System.Drawing.Point(560, 11);
            this.grbEdit.Name = "grbEdit";
            this.grbEdit.Size = new System.Drawing.Size(293, 66);
            this.grbEdit.TabIndex = 35;
            this.grbEdit.TabStop = false;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.Menu;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDelete.Location = new System.Drawing.Point(220, 17);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(67, 32);
            this.btnDelete.TabIndex = 31;
            this.btnDelete.Text = "Xoá";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnFix
            // 
            this.btnFix.BackColor = System.Drawing.SystemColors.Menu;
            this.btnFix.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFix.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFix.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnFix.Location = new System.Drawing.Point(126, 17);
            this.btnFix.Name = "btnFix";
            this.btnFix.Size = new System.Drawing.Size(67, 32);
            this.btnFix.TabIndex = 30;
            this.btnFix.Text = "Sửa";
            this.btnFix.UseVisualStyleBackColor = false;
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.SystemColors.Menu;
            this.btnInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsert.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnInsert.Location = new System.Drawing.Point(18, 17);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(67, 32);
            this.btnInsert.TabIndex = 29;
            this.btnInsert.Text = "Thêm";
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click_1);
            // 
            // doc_giaTableAdapter
            // 
            this.doc_giaTableAdapter.ClearBeforeFill = true;
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.Lavender;
            this.panel13.Controls.Add(this.btnLast);
            this.panel13.Controls.Add(this.btnNext);
            this.panel13.Controls.Add(this.btnPrv);
            this.panel13.Controls.Add(this.btnFirst);
            this.panel13.Controls.Add(this.label13);
            this.panel13.Location = new System.Drawing.Point(11, 256);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(538, 59);
            this.panel13.TabIndex = 36;
            this.panel13.Paint += new System.Windows.Forms.PaintEventHandler(this.panel13_Paint);
            // 
            // btnLast
            // 
            this.btnLast.BackColor = System.Drawing.Color.SteelBlue;
            this.btnLast.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.btnLast.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLast.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnLast.Location = new System.Drawing.Point(415, 13);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(104, 32);
            this.btnLast.TabIndex = 20;
            this.btnLast.Text = "Về cuối";
            this.btnLast.UseVisualStyleBackColor = false;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.SteelBlue;
            this.btnNext.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.btnNext.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNext.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnNext.Location = new System.Drawing.Point(283, 13);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(104, 32);
            this.btnNext.TabIndex = 19;
            this.btnNext.Text = "Về sau";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrv
            // 
            this.btnPrv.BackColor = System.Drawing.Color.SteelBlue;
            this.btnPrv.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.btnPrv.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPrv.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnPrv.Location = new System.Drawing.Point(151, 13);
            this.btnPrv.Name = "btnPrv";
            this.btnPrv.Size = new System.Drawing.Size(104, 32);
            this.btnPrv.TabIndex = 18;
            this.btnPrv.Text = "Về trước";
            this.btnPrv.UseVisualStyleBackColor = false;
            this.btnPrv.Click += new System.EventHandler(this.btnPrv_Click);
            // 
            // btnFirst
            // 
            this.btnFirst.BackColor = System.Drawing.Color.SteelBlue;
            this.btnFirst.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.btnFirst.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnFirst.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnFirst.Location = new System.Drawing.Point(19, 13);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(104, 32);
            this.btnFirst.TabIndex = 17;
            this.btnFirst.Text = "Về đầu";
            this.btnFirst.UseVisualStyleBackColor = false;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(291, 7);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(0, 19);
            this.label13.TabIndex = 5;
            // 
            // fKphieumuomado6BAEFA67BindingSource
            // 
            this.fKphieumuomado6BAEFA67BindingSource.DataMember = "FK__phieu_muo__ma_do__6BAEFA67";
            this.fKphieumuomado6BAEFA67BindingSource.DataSource = this.docgiaBindingSource;
            // 
            // phieu_muonTableAdapter
            // 
            this.phieu_muonTableAdapter.ClearBeforeFill = true;
            // 
            // ma_phieu_muon
            // 
            this.ma_phieu_muon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ma_phieu_muon.DataPropertyName = "ma_phieu_muon";
            this.ma_phieu_muon.HeaderText = "Mã PM";
            this.ma_phieu_muon.Name = "ma_phieu_muon";
            this.ma_phieu_muon.Width = 82;
            // 
            // ma_kieu_muon
            // 
            this.ma_kieu_muon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ma_kieu_muon.DataPropertyName = "ma_kieu_muon";
            this.ma_kieu_muon.HeaderText = "Mã kiểu mượn";
            this.ma_kieu_muon.Name = "ma_kieu_muon";
            this.ma_kieu_muon.Width = 123;
            // 
            // ngay_muon
            // 
            this.ngay_muon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ngay_muon.DataPropertyName = "ngay_muon";
            this.ngay_muon.HeaderText = "Ngày mượn";
            this.ngay_muon.Name = "ngay_muon";
            this.ngay_muon.Width = 106;
            // 
            // ngay_hen_tra
            // 
            this.ngay_hen_tra.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ngay_hen_tra.DataPropertyName = "ngay_hen_tra";
            this.ngay_hen_tra.HeaderText = "Ngày hẹn trả";
            this.ngay_hen_tra.Name = "ngay_hen_tra";
            this.ngay_hen_tra.ReadOnly = true;
            this.ngay_hen_tra.Width = 112;
            // 
            // ngay_thuc_tra
            // 
            this.ngay_thuc_tra.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ngay_thuc_tra.DataPropertyName = "ngay_thuc_tra";
            this.ngay_thuc_tra.HeaderText = "Ngày thực trả";
            this.ngay_thuc_tra.Name = "ngay_thuc_tra";
            this.ngay_thuc_tra.Width = 118;
            // 
            // ma_thu_thu
            // 
            this.ma_thu_thu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ma_thu_thu.DataPropertyName = "ma_thu_thu";
            this.ma_thu_thu.HeaderText = "Mã thủ thư";
            this.ma_thu_thu.Name = "ma_thu_thu";
            this.ma_thu_thu.Width = 101;
            // 
            // frmDocgia
            // 
            this.AcceptButton = this.btnFind;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(855, 501);
            this.Controls.Add(this.panel13);
            this.Controls.Add(this.grbEdit);
            this.Controls.Add(this.plDocgia);
            this.Controls.Add(this.gbxTTdg);
            this.Controls.Add(this.gbxTimdg);
            this.Controls.Add(this.gbxLSmuon);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmDocgia";
            this.Text = "frmDocgia.cs";
            this.Load += new System.EventHandler(this.frmDocgia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdDocgia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.docgiaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLTV_PTUDDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdLSmuon)).EndInit();
            this.gbxTTdg.ResumeLayout(false);
            this.gbxTTdg.PerformLayout();
            this.gbxTimdg.ResumeLayout(false);
            this.gbxTimdg.PerformLayout();
            this.gbxLSmuon.ResumeLayout(false);
            this.plDocgia.ResumeLayout(false);
            this.grbEdit.ResumeLayout(false);
            this.panel13.ResumeLayout(false);
            this.panel13.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fKphieumuomado6BAEFA67BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox cbxchucvu;
        private System.Windows.Forms.TextBox txtsdt2;
        private System.Windows.Forms.TextBox txtMalop;
        private System.Windows.Forms.TextBox txtmadg2;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label lbkvien;
        private System.Windows.Forms.Label lbnum;
        private System.Windows.Forms.Label lbType;
        private System.Windows.Forms.Label lbclass;
        private System.Windows.Forms.Label lbname;
        private System.Windows.Forms.DataGridView grdDocgia;
        private System.Windows.Forms.Label lbmadg;
        private System.Windows.Forms.DataGridView grdLSmuon;
        private System.Windows.Forms.TextBox txtmadg1;
        private System.Windows.Forms.GroupBox gbxTTdg;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.GroupBox gbxTimdg;
        private System.Windows.Forms.GroupBox gbxLSmuon;
        private System.Windows.Forms.ComboBox cbxtraDG;
        private System.Windows.Forms.Panel plDocgia;
        private System.Windows.Forms.GroupBox grbEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnFix;
        private System.Windows.Forms.Button btnInsert;
        private QLTV_KTQD.QLTV_PTUDDataSet qLTV_PTUDDataSet;
        private System.Windows.Forms.BindingSource docgiaBindingSource;
        private QLTV_KTQD.QLTV_PTUDDataSetTableAdapters.doc_giaTableAdapter doc_giaTableAdapter;
        private System.Windows.Forms.TextBox txtkhoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn ma_doc_gia;
        private System.Windows.Forms.DataGridViewTextBoxColumn ten_doc_gia;
        private System.Windows.Forms.DataGridViewTextBoxColumn ma_lop;
        private System.Windows.Forms.DataGridViewTextBoxColumn sdt;
        private System.Windows.Forms.DataGridViewTextBoxColumn chuc_vu;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrv;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.BindingSource fKphieumuomado6BAEFA67BindingSource;
        private QLTV_KTQD.QLTV_PTUDDataSetTableAdapters.phieu_muonTableAdapter phieu_muonTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ma_phieu_muon;
        private System.Windows.Forms.DataGridViewTextBoxColumn ma_kieu_muon;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngay_muon;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngay_hen_tra;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngay_thuc_tra;
        private System.Windows.Forms.DataGridViewTextBoxColumn ma_thu_thu;
    }
}