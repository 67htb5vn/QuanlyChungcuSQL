using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace QuanlyChungcu
{
    partial class FormHoaDonTPhong
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
            tabControlHoaDonTPhong = new TabControl();
            tabPageThang = new TabPage();
            buttonKhoiTao = new Button();
            buttonXoa = new Button();
            buttonSua = new Button();
            buttonThem = new Button();
            groupBoxHoaDonTPhongThang2 = new GroupBox();
            datagridViewHoaDonTPThang = new DataGridView();
            groupBoxHoaDonTPhongThang1 = new GroupBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            buttonTimKiem = new Button();
            label1 = new Label();
            comboBoxTrangThaiTT = new ComboBox();
            textBoxHopDong = new TextBox();
            textBoxNgayTT = new TextBox();
            textBoxThoiGianSD = new TextBox();
            textBoxHoaDon = new TextBox();
            tabPageQuy = new TabPage();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            groupBoxHoaDonTPhongQuy2 = new GroupBox();
            dataGridViewHoaDonTPhongQuy = new DataGridView();
            groupBoxHoaDonTPhongQuy1 = new GroupBox();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            comboBoxTrangThaiTTQuy = new ComboBox();
            textBoxmaHopDongQuy = new TextBox();
            textBoxNgayTTQuy = new TextBox();
            textBoxThoiGianSDQuy = new TextBox();
            textBoxHoaDonQuy = new TextBox();
            tabControlHoaDonTPhong.SuspendLayout();
            tabPageThang.SuspendLayout();
            groupBoxHoaDonTPhongThang2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)datagridViewHoaDonTPThang).BeginInit();
            groupBoxHoaDonTPhongThang1.SuspendLayout();
            tabPageQuy.SuspendLayout();
            groupBoxHoaDonTPhongQuy2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewHoaDonTPhongQuy).BeginInit();
            groupBoxHoaDonTPhongQuy1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControlHoaDonTPhong
            // 
            tabControlHoaDonTPhong.Controls.Add(tabPageThang);
            tabControlHoaDonTPhong.Controls.Add(tabPageQuy);
            tabControlHoaDonTPhong.Location = new Point(3, 35);
            tabControlHoaDonTPhong.Name = "tabControlHoaDonTPhong";
            tabControlHoaDonTPhong.SelectedIndex = 0;
            tabControlHoaDonTPhong.Size = new Size(673, 521);
            tabControlHoaDonTPhong.TabIndex = 0;
            // 
            // tabPageThang
            // 
            tabPageThang.Controls.Add(buttonKhoiTao);
            tabPageThang.Controls.Add(buttonXoa);
            tabPageThang.Controls.Add(buttonSua);
            tabPageThang.Controls.Add(buttonThem);
            tabPageThang.Controls.Add(groupBoxHoaDonTPhongThang2);
            tabPageThang.Controls.Add(groupBoxHoaDonTPhongThang1);
            tabPageThang.Location = new Point(4, 29);
            tabPageThang.Name = "tabPageThang";
            tabPageThang.Padding = new Padding(3);
            tabPageThang.Size = new Size(665, 488);
            tabPageThang.TabIndex = 0;
            tabPageThang.Text = "Theo thang";
            tabPageThang.UseVisualStyleBackColor = true;
            // 
            // buttonKhoiTao
            // 
            buttonKhoiTao.Location = new Point(537, 201);
            buttonKhoiTao.Name = "buttonKhoiTao";
            buttonKhoiTao.Size = new Size(93, 29);
            buttonKhoiTao.TabIndex = 27;
            buttonKhoiTao.Text = "Khởi tạo";
            buttonKhoiTao.UseVisualStyleBackColor = true;
            buttonKhoiTao.Click += buttonKhoiTao_Click;
            // 
            // buttonXoa
            // 
            buttonXoa.Location = new Point(393, 201);
            buttonXoa.Name = "buttonXoa";
            buttonXoa.Size = new Size(81, 29);
            buttonXoa.TabIndex = 26;
            buttonXoa.Text = "Xóa";
            buttonXoa.UseVisualStyleBackColor = true;
            buttonXoa.Click += buttonXoa_Click;
            // 
            // buttonSua
            // 
            buttonSua.Location = new Point(231, 201);
            buttonSua.Name = "buttonSua";
            buttonSua.Size = new Size(94, 29);
            buttonSua.TabIndex = 25;
            buttonSua.Text = "Sửa";
            buttonSua.UseVisualStyleBackColor = true;
            buttonSua.Click += buttonSua_Click;
            // 
            // buttonThem
            // 
            buttonThem.Location = new Point(69, 201);
            buttonThem.Name = "buttonThem";
            buttonThem.Size = new Size(97, 29);
            buttonThem.TabIndex = 24;
            buttonThem.Text = "Thêm";
            buttonThem.UseVisualStyleBackColor = true;
            buttonThem.Click += buttonThem_Click;
            // 
            // groupBoxHoaDonTPhongThang2
            // 
            groupBoxHoaDonTPhongThang2.Controls.Add(datagridViewHoaDonTPThang);
            groupBoxHoaDonTPhongThang2.Location = new Point(-2, 250);
            groupBoxHoaDonTPhongThang2.Name = "groupBoxHoaDonTPhongThang2";
            groupBoxHoaDonTPhongThang2.Size = new Size(660, 211);
            groupBoxHoaDonTPhongThang2.TabIndex = 22;
            groupBoxHoaDonTPhongThang2.TabStop = false;
            groupBoxHoaDonTPhongThang2.Text = "groupBoxHoaDonTPhongThang2";
            // 
            // datagridViewHoaDonTPThang
            // 
            datagridViewHoaDonTPThang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            datagridViewHoaDonTPThang.Location = new Point(29, 45);
            datagridViewHoaDonTPThang.Name = "datagridViewHoaDonTPThang";
            datagridViewHoaDonTPThang.RowHeadersWidth = 51;
            datagridViewHoaDonTPThang.Size = new Size(582, 160);
            datagridViewHoaDonTPThang.TabIndex = 0;
            datagridViewHoaDonTPThang.CellContentClick += datagridViewHoaDonTPThang_CellContentClick;
            datagridViewHoaDonTPThang.CellFormatting += datagridViewHoaDonTPThang_CellFormatting;
            // 
            // groupBoxHoaDonTPhongThang1
            // 
            groupBoxHoaDonTPhongThang1.Controls.Add(label5);
            groupBoxHoaDonTPhongThang1.Controls.Add(label4);
            groupBoxHoaDonTPhongThang1.Controls.Add(label3);
            groupBoxHoaDonTPhongThang1.Controls.Add(label2);
            groupBoxHoaDonTPhongThang1.Controls.Add(buttonTimKiem);
            groupBoxHoaDonTPhongThang1.Controls.Add(label1);
            groupBoxHoaDonTPhongThang1.Controls.Add(comboBoxTrangThaiTT);
            groupBoxHoaDonTPhongThang1.Controls.Add(textBoxHopDong);
            groupBoxHoaDonTPhongThang1.Controls.Add(textBoxNgayTT);
            groupBoxHoaDonTPhongThang1.Controls.Add(textBoxThoiGianSD);
            groupBoxHoaDonTPhongThang1.Controls.Add(textBoxHoaDon);
            groupBoxHoaDonTPhongThang1.Location = new Point(-2, 22);
            groupBoxHoaDonTPhongThang1.Name = "groupBoxHoaDonTPhongThang1";
            groupBoxHoaDonTPhongThang1.Size = new Size(660, 173);
            groupBoxHoaDonTPhongThang1.TabIndex = 21;
            groupBoxHoaDonTPhongThang1.TabStop = false;
            groupBoxHoaDonTPhongThang1.Text = "groupBoxHoaDonTPhongThang1";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(57, 131);
            label5.Name = "label5";
            label5.Size = new Size(99, 20);
            label5.TabIndex = 9;
            label5.Text = "Mã hợp đồng";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(382, 85);
            label4.Name = "label4";
            label4.Size = new Size(64, 20);
            label4.TabIndex = 8;
            label4.Text = "Ngày TT";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(47, 82);
            label3.Name = "label3";
            label3.Size = new Size(95, 20);
            label3.TabIndex = 7;
            label3.Text = "Trạng thái TT";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(354, 42);
            label2.Name = "label2";
            label2.Size = new Size(95, 20);
            label2.TabIndex = 6;
            label2.Text = "Thời Gian SD";
            // 
            // buttonTimKiem
            // 
            buttonTimKiem.Location = new Point(470, 122);
            buttonTimKiem.Name = "buttonTimKiem";
            buttonTimKiem.Size = new Size(109, 29);
            buttonTimKiem.TabIndex = 23;
            buttonTimKiem.Text = "Tìm kiếm";
            buttonTimKiem.UseVisualStyleBackColor = true;
            buttonTimKiem.Click += buttonTimKiem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(47, 38);
            label1.Name = "label1";
            label1.Size = new Size(89, 20);
            label1.TabIndex = 5;
            label1.Text = "Mã hóa đơn";
            // 
            // comboBoxTrangThaiTT
            // 
            comboBoxTrangThaiTT.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxTrangThaiTT.FormattingEnabled = true;
            comboBoxTrangThaiTT.Items.AddRange(new object[] { "Đã thanh toán", "Chưa thanh toán" });
            comboBoxTrangThaiTT.Location = new Point(162, 78);
            comboBoxTrangThaiTT.Name = "comboBoxTrangThaiTT";
            comboBoxTrangThaiTT.Size = new Size(115, 28);
            comboBoxTrangThaiTT.TabIndex = 4;
            comboBoxTrangThaiTT.TextChanged += comboBoxTrangThaiTT_TextChanged;
            // 
            // textBoxHopDong
            // 
            textBoxHopDong.Location = new Point(162, 128);
            textBoxHopDong.Name = "textBoxHopDong";
            textBoxHopDong.Size = new Size(114, 27);
            textBoxHopDong.TabIndex = 3;
            // 
            // textBoxNgayTT
            // 
            textBoxNgayTT.Location = new Point(470, 79);
            textBoxNgayTT.Name = "textBoxNgayTT";
            textBoxNgayTT.Size = new Size(109, 27);
            textBoxNgayTT.TabIndex = 2;
            // 
            // textBoxThoiGianSD
            // 
            textBoxThoiGianSD.Location = new Point(470, 35);
            textBoxThoiGianSD.Name = "textBoxThoiGianSD";
            textBoxThoiGianSD.Size = new Size(109, 27);
            textBoxThoiGianSD.TabIndex = 1;
            // 
            // textBoxHoaDon
            // 
            textBoxHoaDon.Location = new Point(162, 35);
            textBoxHoaDon.Name = "textBoxHoaDon";
            textBoxHoaDon.Size = new Size(114, 27);
            textBoxHoaDon.TabIndex = 0;
            // 
            // tabPageQuy
            // 
            tabPageQuy.Controls.Add(button1);
            tabPageQuy.Controls.Add(button2);
            tabPageQuy.Controls.Add(button3);
            tabPageQuy.Controls.Add(button4);
            tabPageQuy.Controls.Add(button5);
            tabPageQuy.Controls.Add(groupBoxHoaDonTPhongQuy2);
            tabPageQuy.Controls.Add(groupBoxHoaDonTPhongQuy1);
            tabPageQuy.Location = new Point(4, 29);
            tabPageQuy.Name = "tabPageQuy";
            tabPageQuy.Padding = new Padding(3);
            tabPageQuy.Size = new Size(665, 488);
            tabPageQuy.TabIndex = 1;
            tabPageQuy.Text = "Theo quý";
            tabPageQuy.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(541, 204);
            button1.Name = "button1";
            button1.Size = new Size(93, 29);
            button1.TabIndex = 34;
            button1.Text = "Khởi tạo";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(438, 204);
            button2.Name = "button2";
            button2.Size = new Size(81, 29);
            button2.TabIndex = 33;
            button2.Text = "Xóa";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(306, 204);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 32;
            button3.Text = "Sửa";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(177, 204);
            button4.Name = "button4";
            button4.Size = new Size(97, 29);
            button4.TabIndex = 31;
            button4.Text = "Thêm";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(31, 204);
            button5.Name = "button5";
            button5.Size = new Size(109, 29);
            button5.TabIndex = 30;
            button5.Text = "Tìm kiếm";
            button5.UseVisualStyleBackColor = true;
            // 
            // groupBoxHoaDonTPhongQuy2
            // 
            groupBoxHoaDonTPhongQuy2.Controls.Add(dataGridViewHoaDonTPhongQuy);
            groupBoxHoaDonTPhongQuy2.Location = new Point(2, 253);
            groupBoxHoaDonTPhongQuy2.Name = "groupBoxHoaDonTPhongQuy2";
            groupBoxHoaDonTPhongQuy2.Size = new Size(660, 211);
            groupBoxHoaDonTPhongQuy2.TabIndex = 29;
            groupBoxHoaDonTPhongQuy2.TabStop = false;
            groupBoxHoaDonTPhongQuy2.Text = "groupBoxQuyHoaDonTPhongQuy2";
            // 
            // dataGridViewHoaDonTPhongQuy
            // 
            dataGridViewHoaDonTPhongQuy.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewHoaDonTPhongQuy.Location = new Point(29, 45);
            dataGridViewHoaDonTPhongQuy.Name = "dataGridViewHoaDonTPhongQuy";
            dataGridViewHoaDonTPhongQuy.RowHeadersWidth = 51;
            dataGridViewHoaDonTPhongQuy.Size = new Size(582, 160);
            dataGridViewHoaDonTPhongQuy.TabIndex = 0;
            // 
            // groupBoxHoaDonTPhongQuy1
            // 
            groupBoxHoaDonTPhongQuy1.Controls.Add(label10);
            groupBoxHoaDonTPhongQuy1.Controls.Add(label9);
            groupBoxHoaDonTPhongQuy1.Controls.Add(label8);
            groupBoxHoaDonTPhongQuy1.Controls.Add(label7);
            groupBoxHoaDonTPhongQuy1.Controls.Add(label6);
            groupBoxHoaDonTPhongQuy1.Controls.Add(comboBoxTrangThaiTTQuy);
            groupBoxHoaDonTPhongQuy1.Controls.Add(textBoxmaHopDongQuy);
            groupBoxHoaDonTPhongQuy1.Controls.Add(textBoxNgayTTQuy);
            groupBoxHoaDonTPhongQuy1.Controls.Add(textBoxThoiGianSDQuy);
            groupBoxHoaDonTPhongQuy1.Controls.Add(textBoxHoaDonQuy);
            groupBoxHoaDonTPhongQuy1.Location = new Point(2, 25);
            groupBoxHoaDonTPhongQuy1.Name = "groupBoxHoaDonTPhongQuy1";
            groupBoxHoaDonTPhongQuy1.Size = new Size(660, 164);
            groupBoxHoaDonTPhongQuy1.TabIndex = 28;
            groupBoxHoaDonTPhongQuy1.TabStop = false;
            groupBoxHoaDonTPhongQuy1.Text = "groupBoxHoaDonTPhongQuy1";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(27, 135);
            label10.Name = "label10";
            label10.Size = new Size(99, 20);
            label10.TabIndex = 11;
            label10.Text = "Mã hợp đồng";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(377, 89);
            label9.Name = "label9";
            label9.Size = new Size(64, 20);
            label9.TabIndex = 10;
            label9.Text = "Ngày TT";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(30, 85);
            label8.Name = "label8";
            label8.Size = new Size(95, 20);
            label8.TabIndex = 9;
            label8.Text = "Trạng thái TT";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(347, 40);
            label7.Name = "label7";
            label7.Size = new Size(94, 20);
            label7.TabIndex = 8;
            label7.Text = "Thời gian SD";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(30, 40);
            label6.Name = "label6";
            label6.Size = new Size(89, 20);
            label6.TabIndex = 7;
            label6.Text = "Mã hóa đơn";
            // 
            // comboBoxTrangThaiTTQuy
            // 
            comboBoxTrangThaiTTQuy.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxTrangThaiTTQuy.FormattingEnabled = true;
            comboBoxTrangThaiTTQuy.Items.AddRange(new object[] { "Đã thanh toán", "Chưa thanh toán" });
            comboBoxTrangThaiTTQuy.Location = new Point(131, 81);
            comboBoxTrangThaiTTQuy.Name = "comboBoxTrangThaiTTQuy";
            comboBoxTrangThaiTTQuy.Size = new Size(115, 28);
            comboBoxTrangThaiTTQuy.TabIndex = 4;
            // 
            // textBoxmaHopDongQuy
            // 
            textBoxmaHopDongQuy.Location = new Point(132, 128);
            textBoxmaHopDongQuy.Name = "textBoxmaHopDongQuy";
            textBoxmaHopDongQuy.Size = new Size(114, 27);
            textBoxmaHopDongQuy.TabIndex = 3;
            // 
            // textBoxNgayTTQuy
            // 
            textBoxNgayTTQuy.Location = new Point(453, 82);
            textBoxNgayTTQuy.Name = "textBoxNgayTTQuy";
            textBoxNgayTTQuy.Size = new Size(109, 27);
            textBoxNgayTTQuy.TabIndex = 2;
            // 
            // textBoxThoiGianSDQuy
            // 
            textBoxThoiGianSDQuy.Location = new Point(453, 37);
            textBoxThoiGianSDQuy.Name = "textBoxThoiGianSDQuy";
            textBoxThoiGianSDQuy.Size = new Size(109, 27);
            textBoxThoiGianSDQuy.TabIndex = 1;
            // 
            // textBoxHoaDonQuy
            // 
            textBoxHoaDonQuy.Location = new Point(131, 37);
            textBoxHoaDonQuy.Name = "textBoxHoaDonQuy";
            textBoxHoaDonQuy.Size = new Size(114, 27);
            textBoxHoaDonQuy.TabIndex = 0;
            // 
            // FormHoaDonTPhong
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(675, 557);
            Controls.Add(tabControlHoaDonTPhong);
            Name = "FormHoaDonTPhong";
            Text = "FormHoaDonTPhong";
            Load += FormHoaDonTPhong_Load;
            tabControlHoaDonTPhong.ResumeLayout(false);
            tabPageThang.ResumeLayout(false);
            groupBoxHoaDonTPhongThang2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)datagridViewHoaDonTPThang).EndInit();
            groupBoxHoaDonTPhongThang1.ResumeLayout(false);
            groupBoxHoaDonTPhongThang1.PerformLayout();
            tabPageQuy.ResumeLayout(false);
            groupBoxHoaDonTPhongQuy2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewHoaDonTPhongQuy).EndInit();
            groupBoxHoaDonTPhongQuy1.ResumeLayout(false);
            groupBoxHoaDonTPhongQuy1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControlHoaDonTPhong;
        private TabPage tabPageThang;
        private TabPage tabPageQuy;
        private Button buttonKhoiTao;
        private Button buttonXoa;
        private Button buttonSua;
        private Button buttonThem;
        private Button buttonTimKiem;
        private GroupBox groupBoxHoaDonTPhongThang2;
        private DataGridView datagridViewHoaDonTPThang;
        private GroupBox groupBoxHoaDonTPhongThang1;
        private TextBox textBoxNgayTT;
        private TextBox textBoxThoiGianSD;
        private TextBox textBoxHoaDon;
        private TextBox textBoxHopDong;
        private ComboBox comboBoxTrangThaiTT;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private GroupBox groupBoxHoaDonTPhongQuy2;
        private DataGridView dataGridViewHoaDonTPhongQuy;
        private GroupBox groupBoxHoaDonTPhongQuy1;
        private ComboBox comboBoxTrangThaiTTQuy;
        private TextBox textBoxmaHopDongQuy;
        private TextBox textBoxNgayTTQuy;
        private TextBox textBoxThoiGianSDQuy;
        private TextBox textBoxHoaDonQuy;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
    }
}