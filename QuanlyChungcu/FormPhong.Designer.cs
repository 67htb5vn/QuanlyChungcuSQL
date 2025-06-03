namespace QuanlyChungcu
{
    partial class FormPhong
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
            buttonXoa = new Button();
            buttonSua = new Button();
            buttonThem = new Button();
            buttonTimKiem = new Button();
            groupBoxPhong2 = new GroupBox();
            datagridViewPhong = new DataGridView();
            groupBoxPhong1 = new GroupBox();
            buttonKhoiTao = new Button();
            groupBoxPhong2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)datagridViewPhong).BeginInit();
            SuspendLayout();
            // 
            // buttonXoa
            // 
            buttonXoa.Location = new Point(416, 236);
            buttonXoa.Name = "buttonXoa";
            buttonXoa.Size = new Size(94, 29);
            buttonXoa.TabIndex = 11;
            buttonXoa.Text = "Xóa";
            buttonXoa.UseVisualStyleBackColor = true;
            // 
            // buttonSua
            // 
            buttonSua.Location = new Point(296, 236);
            buttonSua.Name = "buttonSua";
            buttonSua.Size = new Size(94, 29);
            buttonSua.TabIndex = 10;
            buttonSua.Text = "Sửa";
            buttonSua.UseVisualStyleBackColor = true;
            // 
            // buttonThem
            // 
            buttonThem.Location = new Point(164, 236);
            buttonThem.Name = "buttonThem";
            buttonThem.Size = new Size(94, 29);
            buttonThem.TabIndex = 9;
            buttonThem.Text = "Thêm";
            buttonThem.UseVisualStyleBackColor = true;
            // 
            // buttonTimKiem
            // 
            buttonTimKiem.Location = new Point(35, 236);
            buttonTimKiem.Name = "buttonTimKiem";
            buttonTimKiem.Size = new Size(94, 29);
            buttonTimKiem.TabIndex = 8;
            buttonTimKiem.Text = "Tìm kiếm";
            buttonTimKiem.UseVisualStyleBackColor = true;
            // 
            // groupBoxPhong2
            // 
            groupBoxPhong2.Controls.Add(datagridViewPhong);
            groupBoxPhong2.Location = new Point(0, 317);
            groupBoxPhong2.Name = "groupBoxPhong2";
            groupBoxPhong2.Size = new Size(652, 199);
            groupBoxPhong2.TabIndex = 7;
            groupBoxPhong2.TabStop = false;
            groupBoxPhong2.Text = "groupBoxPhong2";
            // 
            // datagridViewPhong
            // 
            datagridViewPhong.AllowUserToAddRows = false;
            datagridViewPhong.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            datagridViewPhong.Location = new Point(50, 52);
            datagridViewPhong.Name = "datagridViewPhong";
            datagridViewPhong.RowHeadersWidth = 51;
            datagridViewPhong.Size = new Size(562, 110);
            datagridViewPhong.TabIndex = 0;
            // 
            // groupBoxPhong1
            // 
            groupBoxPhong1.Location = new Point(0, 57);
            groupBoxPhong1.Name = "groupBoxPhong1";
            groupBoxPhong1.Size = new Size(652, 133);
            groupBoxPhong1.TabIndex = 6;
            groupBoxPhong1.TabStop = false;
            groupBoxPhong1.Text = "groupBoxPhong1";
            // 
            // buttonKhoiTao
            // 
            buttonKhoiTao.Location = new Point(536, 236);
            buttonKhoiTao.Name = "buttonKhoiTao";
            buttonKhoiTao.Size = new Size(94, 29);
            buttonKhoiTao.TabIndex = 12;
            buttonKhoiTao.Text = "Khởi tạo";
            buttonKhoiTao.UseVisualStyleBackColor = true;
            // 
            // FormPhong
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(653, 528);
            Controls.Add(buttonKhoiTao);
            Controls.Add(buttonXoa);
            Controls.Add(buttonSua);
            Controls.Add(buttonThem);
            Controls.Add(buttonTimKiem);
            Controls.Add(groupBoxPhong2);
            Controls.Add(groupBoxPhong1);
            Name = "FormPhong";
            Text = "FormPhong";
            Load += FormPhong_Load;
            groupBoxPhong2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)datagridViewPhong).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonXoa;
        private Button buttonSua;
        private Button buttonThem;
        private Button buttonTimKiem;
        private GroupBox groupBoxPhong2;
        private DataGridView datagridViewPhong;
        private GroupBox groupBoxPhong1;
        private Button buttonKhoiTao;
    }
}