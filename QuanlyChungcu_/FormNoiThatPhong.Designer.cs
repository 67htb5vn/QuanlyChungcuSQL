using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace QuanlyChungcu
{
    partial class FormNoiThatPhong
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
            groupBoxNoiThatPhong2 = new GroupBox();
            datagridViewNoiThatPhong = new DataGridView();
            groupBoxNoiThatPhong1 = new GroupBox();
            textBox6 = new TextBox();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            groupBoxNoiThatPhong2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)datagridViewNoiThatPhong).BeginInit();
            groupBoxNoiThatPhong1.SuspendLayout();
            SuspendLayout();
            // 
            // buttonKhoiTao
            // 
            buttonKhoiTao.Location = new Point(543, 197);
            buttonKhoiTao.Name = "buttonKhoiTao";
            buttonKhoiTao.Size = new Size(94, 29);
            buttonKhoiTao.TabIndex = 13;
            buttonKhoiTao.Text = "Khởi tạo";
            buttonKhoiTao.UseVisualStyleBackColor = true;
            // 
            // buttonXoa
            // 
            buttonXoa.Location = new Point(407, 197);
            buttonXoa.Name = "buttonXoa";
            buttonXoa.Size = new Size(94, 29);
            buttonXoa.TabIndex = 12;
            buttonXoa.Text = "Xóa";
            buttonXoa.UseVisualStyleBackColor = true;
            // 
            // buttonSua
            // 
            buttonSua.Location = new Point(291, 197);
            buttonSua.Name = "buttonSua";
            buttonSua.Size = new Size(94, 29);
            buttonSua.TabIndex = 11;
            buttonSua.Text = "Sửa";
            buttonSua.UseVisualStyleBackColor = true;
            // 
            // buttonThem
            // 
            buttonThem.Location = new Point(177, 197);
            buttonThem.Name = "buttonThem";
            buttonThem.Size = new Size(94, 29);
            buttonThem.TabIndex = 10;
            buttonThem.Text = "Thêm";
            buttonThem.UseVisualStyleBackColor = true;
            // 
            // buttonTimKiem
            // 
            buttonTimKiem.Location = new Point(51, 197);
            buttonTimKiem.Name = "buttonTimKiem";
            buttonTimKiem.Size = new Size(94, 29);
            buttonTimKiem.TabIndex = 9;
            buttonTimKiem.Text = "Tìm kiếm";
            buttonTimKiem.UseVisualStyleBackColor = true;
            // 
            // groupBoxNoiThatPhong2
            // 
            groupBoxNoiThatPhong2.Controls.Add(datagridViewNoiThatPhong);
            groupBoxNoiThatPhong2.Location = new Point(1, 262);
            groupBoxNoiThatPhong2.Name = "groupBoxNoiThatPhong2";
            groupBoxNoiThatPhong2.Size = new Size(689, 199);
            groupBoxNoiThatPhong2.TabIndex = 8;
            groupBoxNoiThatPhong2.TabStop = false;
            groupBoxNoiThatPhong2.Text = "groupBoxNoiThatPhong2";
            // 
            // datagridViewNoiThatPhong
            // 
            datagridViewNoiThatPhong.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            datagridViewNoiThatPhong.Location = new Point(29, 52);
            datagridViewNoiThatPhong.Name = "datagridViewNoiThatPhong";
            datagridViewNoiThatPhong.RowHeadersWidth = 51;
            datagridViewNoiThatPhong.Size = new Size(586, 113);
            datagridViewNoiThatPhong.TabIndex = 0;
            // 
            // groupBoxNoiThatPhong1
            // 
            groupBoxNoiThatPhong1.Controls.Add(textBox6);
            groupBoxNoiThatPhong1.Controls.Add(textBox5);
            groupBoxNoiThatPhong1.Controls.Add(textBox4);
            groupBoxNoiThatPhong1.Controls.Add(textBox3);
            groupBoxNoiThatPhong1.Controls.Add(textBox2);
            groupBoxNoiThatPhong1.Controls.Add(textBox1);
            groupBoxNoiThatPhong1.Location = new Point(1, 27);
            groupBoxNoiThatPhong1.Name = "groupBoxNoiThatPhong1";
            groupBoxNoiThatPhong1.Size = new Size(689, 133);
            groupBoxNoiThatPhong1.TabIndex = 7;
            groupBoxNoiThatPhong1.TabStop = false;
            groupBoxNoiThatPhong1.Text = "groupBoxNoiThatPhong1";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(595, 47);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(37, 27);
            textBox6.TabIndex = 5;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(467, 26);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(94, 27);
            textBox5.TabIndex = 4;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(406, 47);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(37, 27);
            textBox4.TabIndex = 3;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(290, 47);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(37, 27);
            textBox3.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(135, 37);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(37, 27);
            textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(50, 26);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(44, 27);
            textBox1.TabIndex = 0;
            // 
            // FormNoiThatPhong
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(691, 535);
            Controls.Add(buttonKhoiTao);
            Controls.Add(buttonXoa);
            Controls.Add(buttonSua);
            Controls.Add(buttonThem);
            Controls.Add(buttonTimKiem);
            Controls.Add(groupBoxNoiThatPhong2);
            Controls.Add(groupBoxNoiThatPhong1);
            Name = "FormNoiThatPhong";
            Text = "FormNoiThatPhong";
            Load += FormNoiThatPhong_Load;
            groupBoxNoiThatPhong2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)datagridViewNoiThatPhong).EndInit();
            groupBoxNoiThatPhong1.ResumeLayout(false);
            groupBoxNoiThatPhong1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonKhoiTao;
        private Button buttonXoa;
        private Button buttonSua;
        private Button buttonThem;
        private Button buttonTimKiem;
        private GroupBox groupBoxNoiThatPhong2;
        private DataGridView datagridViewNoiThatPhong;
        private GroupBox groupBoxNoiThatPhong1;
        private TextBox textBox6;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
    }
}