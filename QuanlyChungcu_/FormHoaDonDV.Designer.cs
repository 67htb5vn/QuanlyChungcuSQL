namespace QuanlyChungcu
{
    partial class FormHoaDonDV
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
            buttonKhoiTao = new Button();
            buttonXoa = new Button();
            buttonSua = new Button();
            buttonThem = new Button();
            buttonTimKiem = new Button();
            groupBoxHoaDonTPhong2 = new GroupBox();
            datagridViewHoaDonDV = new DataGridView();
            groupBoxHoaDonDV1 = new GroupBox();
            comboBoxTrangThaiTT = new ComboBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBoxHopDong = new TextBox();
            textBoxNgayTT = new TextBox();
            textBoxThangSD = new TextBox();
            textBoxHoaDon = new TextBox();
            groupBoxHoaDonTPhong2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)datagridViewHoaDonDV).BeginInit();
            groupBoxHoaDonDV1.SuspendLayout();
            SuspendLayout();
            // 
            // buttonKhoiTao
            // 
            buttonKhoiTao.Location = new Point(536, 230);
            buttonKhoiTao.Name = "buttonKhoiTao";
            buttonKhoiTao.Size = new Size(94, 29);
            buttonKhoiTao.TabIndex = 20;
            buttonKhoiTao.Text = "Khởi tạo";
            buttonKhoiTao.UseVisualStyleBackColor = true;
            buttonKhoiTao.Click += buttonKhoiTao_Click;
            // 
            // buttonXoa
            // 
            buttonXoa.Location = new Point(404, 230);
            buttonXoa.Name = "buttonXoa";
            buttonXoa.Size = new Size(94, 29);
            buttonXoa.TabIndex = 19;
            buttonXoa.Text = "Xóa";
            buttonXoa.UseVisualStyleBackColor = true;
            buttonXoa.Click += buttonXoa_Click;
            // 
            // buttonSua
            // 
            buttonSua.Location = new Point(239, 230);
            buttonSua.Name = "buttonSua";
            buttonSua.Size = new Size(94, 29);
            buttonSua.TabIndex = 18;
            buttonSua.Text = "Sửa";
            buttonSua.UseVisualStyleBackColor = true;
            buttonSua.Click += buttonSua_Click;
            // 
            // buttonThem
            // 
            buttonThem.Location = new Point(63, 230);
            buttonThem.Name = "buttonThem";
            buttonThem.Size = new Size(94, 29);
            buttonThem.TabIndex = 17;
            buttonThem.Text = "Thêm";
            buttonThem.UseVisualStyleBackColor = true;
            buttonThem.Click += buttonThem_Click;
            // 
            // buttonTimKiem
            // 
            buttonTimKiem.Location = new Point(479, 128);
            buttonTimKiem.Name = "buttonTimKiem";
            buttonTimKiem.Size = new Size(94, 29);
            buttonTimKiem.TabIndex = 16;
            buttonTimKiem.Text = "Tìm kiếm";
            buttonTimKiem.UseVisualStyleBackColor = true;
            buttonTimKiem.Click += buttonTimKiem_Click;
            // 
            // groupBoxHoaDonTPhong2
            // 
            groupBoxHoaDonTPhong2.Controls.Add(datagridViewHoaDonDV);
            groupBoxHoaDonTPhong2.Location = new Point(-2, 283);
            groupBoxHoaDonTPhong2.Name = "groupBoxHoaDonTPhong2";
            groupBoxHoaDonTPhong2.Size = new Size(727, 231);
            groupBoxHoaDonTPhong2.TabIndex = 15;
            groupBoxHoaDonTPhong2.TabStop = false;
            groupBoxHoaDonTPhong2.Text = "groupBoxHoaDonTPhong2";
            // 
            // datagridViewHoaDonDV
            // 
            datagridViewHoaDonDV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            datagridViewHoaDonDV.Location = new Point(50, 59);
            datagridViewHoaDonDV.Name = "datagridViewHoaDonDV";
            datagridViewHoaDonDV.RowHeadersWidth = 51;
            datagridViewHoaDonDV.Size = new Size(582, 151);
            datagridViewHoaDonDV.TabIndex = 0;
            datagridViewHoaDonDV.CellContentClick += datagridViewHoaDonDV_CellContentClick;
            datagridViewHoaDonDV.CellFormatting += datagridViewHoaDonDV_CellFormatting;
            // 
            // groupBoxHoaDonDV1
            // 
            groupBoxHoaDonDV1.Controls.Add(comboBoxTrangThaiTT);
            groupBoxHoaDonDV1.Controls.Add(label5);
            groupBoxHoaDonDV1.Controls.Add(label4);
            groupBoxHoaDonDV1.Controls.Add(label3);
            groupBoxHoaDonDV1.Controls.Add(label2);
            groupBoxHoaDonDV1.Controls.Add(label1);
            groupBoxHoaDonDV1.Controls.Add(textBoxHopDong);
            groupBoxHoaDonDV1.Controls.Add(textBoxNgayTT);
            groupBoxHoaDonDV1.Controls.Add(buttonTimKiem);
            groupBoxHoaDonDV1.Controls.Add(textBoxThangSD);
            groupBoxHoaDonDV1.Controls.Add(textBoxHoaDon);
            groupBoxHoaDonDV1.Location = new Point(-2, 27);
            groupBoxHoaDonDV1.Name = "groupBoxHoaDonDV1";
            groupBoxHoaDonDV1.Size = new Size(727, 179);
            groupBoxHoaDonDV1.TabIndex = 14;
            groupBoxHoaDonDV1.TabStop = false;
            groupBoxHoaDonDV1.Text = "groupBoxHoaDonDV1";
            // 
            // comboBoxTrangThaiTT
            // 
            comboBoxTrangThaiTT.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxTrangThaiTT.FormattingEnabled = true;
            comboBoxTrangThaiTT.Items.AddRange(new object[] { "Đã thanh toán", "Chưa thanh toán" });
            comboBoxTrangThaiTT.Location = new Point(192, 87);
            comboBoxTrangThaiTT.Name = "comboBoxTrangThaiTT";
            comboBoxTrangThaiTT.Size = new Size(91, 28);
            comboBoxTrangThaiTT.TabIndex = 22;
            comboBoxTrangThaiTT.TextChanged += comboBoxTrangThaiTT_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(22, 128);
            label5.Name = "label5";
            label5.Size = new Size(99, 20);
            label5.TabIndex = 21;
            label5.Text = "Mã hợp đồng";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(332, 87);
            label4.Name = "label4";
            label4.Size = new Size(119, 20);
            label4.TabIndex = 20;
            label4.Text = "Ngày thanh toán";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 87);
            label3.Name = "label3";
            label3.Size = new Size(150, 20);
            label3.TabIndex = 19;
            label3.Text = "Trạng thái thanh toán";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(344, 37);
            label2.Name = "label2";
            label2.Size = new Size(107, 20);
            label2.TabIndex = 18;
            label2.Text = "Tháng sử dụng";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 41);
            label1.Name = "label1";
            label1.Size = new Size(89, 20);
            label1.TabIndex = 17;
            label1.Text = "Mã hóa đơn";
            // 
            // textBoxHopDong
            // 
            textBoxHopDong.Location = new Point(194, 128);
            textBoxHopDong.Name = "textBoxHopDong";
            textBoxHopDong.Size = new Size(89, 27);
            textBoxHopDong.TabIndex = 3;
            // 
            // textBoxNgayTT
            // 
            textBoxNgayTT.Location = new Point(479, 87);
            textBoxNgayTT.Name = "textBoxNgayTT";
            textBoxNgayTT.Size = new Size(94, 27);
            textBoxNgayTT.TabIndex = 2;
            // 
            // textBoxThangSD
            // 
            textBoxThangSD.Location = new Point(479, 34);
            textBoxThangSD.Name = "textBoxThangSD";
            textBoxThangSD.Size = new Size(89, 27);
            textBoxThangSD.TabIndex = 1;
            // 
            // textBoxHoaDon
            // 
            textBoxHoaDon.Location = new Point(189, 37);
            textBoxHoaDon.Name = "textBoxHoaDon";
            textBoxHoaDon.Size = new Size(94, 27);
            textBoxHoaDon.TabIndex = 0;
            // 
            // FormHoaDonDV
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(726, 520);
            Controls.Add(buttonKhoiTao);
            Controls.Add(buttonXoa);
            Controls.Add(buttonSua);
            Controls.Add(buttonThem);
            Controls.Add(groupBoxHoaDonTPhong2);
            Controls.Add(groupBoxHoaDonDV1);
            Name = "FormHoaDonDV";
            Text = "FormHoaDonDV";
            Load += FormHoaDonDV_Load;
            groupBoxHoaDonTPhong2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)datagridViewHoaDonDV).EndInit();
            groupBoxHoaDonDV1.ResumeLayout(false);
            groupBoxHoaDonDV1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonKhoiTao;
        private Button buttonXoa;
        private Button buttonSua;
        private Button buttonThem;
        private Button buttonTimKiem;
        private GroupBox groupBoxHoaDonTPhong2;
        private DataGridView datagridViewHoaDonDV;
        private GroupBox groupBoxHoaDonDV1;
        private TextBox textBoxNgayTT;
        private TextBox textBoxThangSD;
        private TextBox textBoxHoaDon;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBoxHopDong;
        private ComboBox comboBoxTrangThaiTT;
    }
}