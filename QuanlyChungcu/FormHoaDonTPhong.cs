using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace QuanlyChungcu
{
    public partial class FormHoaDonTPhong : Form
    {
        String oldMa = "";
        public FormHoaDonTPhong()
        {
            InitializeComponent();
        }

        private void FormHoaDonTPhong_Load(object sender, EventArgs e)
        {
            loadHoaDonTPhong();
        }

        void loadHoaDonTPhong()
        {
            datagridViewHoaDonTPThang.DataSource = DataConnect.GetData("SELECT * FROM HoaDonTPhong WHERE MaHopDong in (" +
                                                                       "SELECT MaHopDong FROM HopDong WHERE KyHanThanhToan = N'Tháng')", null);
            datagridViewHoaDonTPThang.AllowUserToAddRows = false;
            datagridViewHoaDonTPThang.RowHeadersVisible = false;
        }

        private void datagridViewHoaDonTPThang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = datagridViewHoaDonTPThang.CurrentRow.Index;
            DateTime ngayTT = new DateTime();

            textBoxThoiGianSD.Text = datagridViewHoaDonTPThang.Rows[i].Cells[2].Value.ToString();
            textBoxHoaDon.Text = datagridViewHoaDonTPThang.Rows[i].Cells[0].Value.ToString();
            if (datagridViewHoaDonTPThang.Rows[i].Cells[3].Value.ToString() == "True")
                comboBoxTrangThaiTT.Text = "Đã thanh toán";
            else
                comboBoxTrangThaiTT.Text = "Chưa thanh toán";

            textBoxNgayTT.Text = datagridViewHoaDonTPThang.Rows[i].Cells[4].Value.ToString();
            if (datagridViewHoaDonTPThang.Rows[i].Cells[4].Value.ToString() != "")
            {
                ngayTT = DateTime.Parse(datagridViewHoaDonTPThang.Rows[i].Cells[4].Value.ToString());
                textBoxNgayTT.Text = ngayTT.ToString("dd/MM/yyyy");
            }

            textBoxHopDong.Text = datagridViewHoaDonTPThang.Rows[i].Cells[6].Value.ToString();
            oldMa = datagridViewHoaDonTPThang.Rows[i].Cells[0].Value.ToString();
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            if (comboBoxTrangThaiTT.Text == "Đã thanh toán")
                themHoaDonTPhongThang_TT();
            else
                themHoaDonTPhongThang_CTT();
            loadHoaDonTPhong();
        }

        private void buttonSua_Click(object sender, EventArgs e)
        {
            if (comboBoxTrangThaiTT.Text == "Đã thanh toán")
                suaHoaDonTPThang_TT();
            else
                suaHoaDonTPhongThang_CTT();
            loadHoaDonTPhong();
        }

        private void buttonKhoiTao_Click(object sender, EventArgs e)
        {
            khoitaoHoaDonTPhong();
            loadHoaDonTPhong();
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            xoaHoaDonTPhong();
            loadHoaDonTPhong();
        }

        private void buttonTimKiem_Click(object sender, EventArgs e)
        {
            timkiemHoaDonTPhong();
        }

        private void khoitaoHoaDonTPhong()
        {
            textBoxHoaDon.Text = "";
            textBoxHopDong.Text = "";
            comboBoxTrangThaiTT.Text = "";
            textBoxNgayTT.Text = "";
            textBoxThoiGianSD.Text = "";
            comboBoxTrangThaiTT.SelectedIndex = -1;
        }

        private void themHoaDonTPhongThang_TT()
        {
            if (textBoxThoiGianSD.Text == "" || textBoxNgayTT.Text == "" || textBoxHoaDon.Text == "" || textBoxHopDong.Text == "" || comboBoxTrangThaiTT.Text == "")
                MessageBox.Show("Lỗi: Chưa nhập đủ dữ liệu");
            else
            {
                try
                {
                    SqlParameter[] para =
                    {
                    new SqlParameter("@maHoaDonTPhong", SqlDbType.NChar),
                    new SqlParameter("@ThoiGianSD", SqlDbType.NVarChar),
                    new SqlParameter("@TrangThaiTT", SqlDbType.Bit),
                    new SqlParameter("@ngayTT", SqlDbType.Date),
                    new SqlParameter("@maHopDong", SqlDbType.NChar)
                };

                    DateTime ngayTT = new DateTime();
                    ngayTT = DateTime.ParseExact(textBoxNgayTT.Text.Trim(), "d/M/yyyy", CultureInfo.InvariantCulture);

                    checkThang(textBoxThoiGianSD.Text);

                    para[0].Value = textBoxHoaDon.Text;
                    para[1].Value = textBoxThoiGianSD.Text;
                    para[2].Value = "True";
                    para[3].Value = ngayTT;
                    para[4].Value = textBoxHopDong.Text;

                    DataConnect.Proc("them_HDTPThang_TT", para);
                }
                catch (System.FormatException ex)
                {
                    if (ex.Message.Contains("was not recognized as a valid DateTime."))
                        MessageBox.Show("Lỗi: Nhập theo định dạng dd/MM/yyyy");
                    if (ex.Message.Contains("' is not supported in calendar 'System.Globalization.GregorianCalendar'.'\r\n"))
                        MessageBox.Show("Lỗi: Nhập ngày tháng hợp lệ.");
                    MessageBox.Show("Lỗi");
                }
                catch (NhapsaiThang ex)
                {
                    MessageBox.Show(ex.Message);
                }
                catch (Microsoft.Data.SqlClient.SqlException ex)
                {
                    if (ex.Message.Contains("Violation of PRIMARY KEY constraint "))
                        MessageBox.Show("Lỗi: Mã hóa đơn đã tồn tại");
                    if (ex.Message.Contains("The conflict occurred in database \"QUAN_LY_CHUNG_CU\", table \"dbo.HopDong\", column 'MaHopDong"))
                        MessageBox.Show("Lỗi: Mã hợp đồng không tồn tại");
                    if (ex.Message.Contains("The UPDATE statement conflicted with the REFERENCE constraint \"FK_PhieuSDDV_HoaDonDV\"."))
                        MessageBox.Show("Lỗi: Không sửa mã hóa đơn");
                    MessageBox.Show("Lỗi");
                }
            }
        }

        private void themHoaDonTPhongThang_CTT()
        {
            if (textBoxThoiGianSD.Text == "" || textBoxHoaDon.Text == "" || textBoxHopDong.Text == "" || comboBoxTrangThaiTT.Text == "")
                MessageBox.Show("Lỗi: Chưa nhập đủ dữ liệu");
            else
            {
                try
                {
                    SqlParameter[] para =
                    {
                    new SqlParameter("@maHoaDonTPhong", SqlDbType.NChar),
                    new SqlParameter("@ThoiGianSD", SqlDbType.NVarChar),
                    new SqlParameter("@TrangThaiTT", SqlDbType.Bit),
                    new SqlParameter("@maHopDong", SqlDbType.NChar)
                };


                    checkThang(textBoxThoiGianSD.Text);

                    para[0].Value = textBoxHoaDon.Text;
                    para[2].Value = "False";
                    para[1].Value = textBoxThoiGianSD.Text;
                    para[3].Value = textBoxHopDong.Text;

                    DataConnect.Proc("them_HDTPThang_CTT", para);
                }
                catch (System.FormatException ex)
                {
                    if (ex.Message.Contains("was not recognized as a valid DateTime."))
                        MessageBox.Show("Lỗi: Nhập theo định dạng dd/MM/yyyy");
                    if (ex.Message.Contains("' is not supported in calendar 'System.Globalization.GregorianCalendar'.'\r\n"))
                        MessageBox.Show("Lỗi: Nhập ngày tháng hợp lệ.");
                    MessageBox.Show("Lỗi");
                }
                catch (NhapsaiThang ex)
                {
                    MessageBox.Show(ex.Message);
                }
                catch (Microsoft.Data.SqlClient.SqlException ex)
                {
                    if (ex.Message.Contains("Violation of PRIMARY KEY constraint "))
                        MessageBox.Show("Lỗi: Mã hóa đơn đã tồn tại");
                    if (ex.Message.Contains("The conflict occurred in database \"QUAN_LY_CHUNG_CU\", table \"dbo.HopDong\", column 'MaHopDong"))
                        MessageBox.Show("Lỗi: Mã hợp đồng không tồn tại");
                    if (ex.Message.Contains("The UPDATE statement conflicted with the REFERENCE constraint \"FK_PhieuSDDV_HoaDonDV\"."))
                        MessageBox.Show("Lỗi: Không sửa mã hóa đơn");
                    MessageBox.Show("Lỗi");
                }
            }
        }

        private void suaHoaDonTPThang_TT()
        {
            if (textBoxThoiGianSD.Text == "" || textBoxNgayTT.Text == "" || textBoxHoaDon.Text == "" || textBoxHopDong.Text == "" || comboBoxTrangThaiTT.Text == "")
                MessageBox.Show("Lỗi: Chưa nhập đủ dữ liệu");
            else
            {
                try
                {
                    SqlParameter[] para =
                    {
                    new SqlParameter("@maHoaDonTPhong", SqlDbType.NChar),
                    new SqlParameter("@ThoiGianSD", SqlDbType.NVarChar),
                    new SqlParameter("@TrangThaiTT", SqlDbType.Bit),
                    new SqlParameter("@ngayTT", SqlDbType.Date),
                    new SqlParameter("@maHopDong", SqlDbType.NChar),
                    new SqlParameter("@oldMa", SqlDbType.NChar)
                    };

                    checkThang(textBoxThoiGianSD.Text);

                    DateTime ngayTT = new DateTime();
                    ngayTT = DateTime.ParseExact(textBoxNgayTT.Text.Trim(), "d/M/yyyy", CultureInfo.InvariantCulture);

                    para[0].Value = textBoxHoaDon.Text;
                    para[1].Value = textBoxThoiGianSD.Text;
                    para[2].Value = "True";
                    para[3].Value = ngayTT;
                    para[4].Value = textBoxHopDong.Text;
                    para[5].Value = oldMa;

                    DataConnect.Proc("sua_HDTPThang_TT", para);
                }
                catch (System.FormatException ex)
                {
                    if (ex.Message.Contains("was not recognized as a valid DateTime."))
                        MessageBox.Show("Lỗi: Nhập theo định dạng dd/MM/yyyy");
                    if (ex.Message.Contains("' is not supported in calendar 'System.Globalization.GregorianCalendar'.'\r\n"))
                        MessageBox.Show("Lỗi: Nhập ngày tháng hợp lệ.");
                    MessageBox.Show("Lỗi");
                }
                catch (NhapsaiThang ex)
                {
                    MessageBox.Show(ex.Message);
                }
                catch (Microsoft.Data.SqlClient.SqlException ex)
                {
                    if (ex.Message.Contains("Violation of PRIMARY KEY constraint "))
                        MessageBox.Show("Lỗi: Mã hóa đơn đã tồn tại");
                    if (ex.Message.Contains("The conflict occurred in database \"QUAN_LY_CHUNG_CU\", table \"dbo.HopDong\", column 'MaHopDong"))
                        MessageBox.Show("Lỗi: Mã hợp đồng không tồn tại");
                    if (ex.Message.Contains("The UPDATE statement conflicted with the REFERENCE constraint \"FK_PhieuSDDV_HoaDonDV\"."))
                        MessageBox.Show("Lỗi: Không sửa mã hóa đơn");
                    MessageBox.Show("Lỗi");
                }
            }
        }

        private void suaHoaDonTPhongThang_CTT()
        {
            if (textBoxThoiGianSD.Text == "" || textBoxHoaDon.Text == "" || textBoxHopDong.Text == "" || comboBoxTrangThaiTT.Text == "")
                MessageBox.Show("Lỗi: Chưa nhập đủ dữ liệu");
            else
            {
                try
                {
                    SqlParameter[] para =
                    {
                    new SqlParameter("@maHoaDonTPhong", SqlDbType.NChar),
                    new SqlParameter("@ThoiGianSD", SqlDbType.NVarChar),
                    new SqlParameter("@TrangThaiTT", SqlDbType.Bit),
                    new SqlParameter("@maHopDong", SqlDbType.NChar),
                    new SqlParameter("@oldMa", SqlDbType.NChar)
                    };

                    checkThang(textBoxThoiGianSD.Text);

                    para[0].Value = textBoxHoaDon.Text;
                    para[1].Value = textBoxThoiGianSD.Text;
                    para[2].Value = "False";
                    para[3].Value = textBoxHopDong.Text;
                    para[4].Value = oldMa;

                    DataConnect.Proc("sua_HDTPThang_CTT", para);
                }
                catch (NhapsaiThang ex)
                {
                    MessageBox.Show(ex.Message);
                }
                catch (Microsoft.Data.SqlClient.SqlException ex)
                {
                    if (ex.Message.Contains("Violation of PRIMARY KEY constraint "))
                        MessageBox.Show("Lỗi: Mã hóa đơn đã tồn tại");
                    if (ex.Message.Contains("The conflict occurred in database \"QUAN_LY_CHUNG_CU\", table \"dbo.HopDong\", column 'MaHopDong"))
                        MessageBox.Show("Lỗi: Mã hợp đồng không tồn tại");
                    if (ex.Message.Contains("The UPDATE statement conflicted with the REFERENCE constraint \"FK_PhieuSDDV_HoaDonDV\"."))
                        MessageBox.Show("Lỗi: Không sửa mã hóa đơn");
                    MessageBox.Show("Lỗi");
                }
            }
        }

        private void xoaHoaDonTPhong()
        {
            if (textBoxThoiGianSD.Text == "" && textBoxNgayTT.Text == "" && textBoxHoaDon.Text == "" && textBoxHopDong.Text == "" && comboBoxTrangThaiTT.Text == "")
                MessageBox.Show("Lỗi: Chưa nhập dữ liệu");
            else
            {
                try
                {
                    SqlParameter[] para =
                    {
                    new SqlParameter("@maHoaDonTP", SqlDbType.NChar),
                    new SqlParameter("@ThoiGianSD", SqlDbType.NVarChar, 50),
                    new SqlParameter("@TrangThaiTT", SqlDbType.NVarChar,50),
                    new SqlParameter("@ngayTT", SqlDbType.NVarChar, 50),
                    new SqlParameter("@maHopDong", SqlDbType.NVarChar, 50)
                };

                    para[0].Value = textBoxHoaDon.Text.Trim();
                    para[1].Value = textBoxThoiGianSD.Text.Trim();
                    if (comboBoxTrangThaiTT.Text == "Đã thanh toán")
                        para[2].Value = "True";
                    else if (comboBoxTrangThaiTT.Text == "Chưa thanh toán")
                        para[2].Value = "False";
                    else
                        para[2].Value = "";
                    para[3].Value = textBoxNgayTT.Text.Trim();
                    para[4].Value = textBoxHopDong.Text.Trim();

                    DataConnect.Proc("xoa_HDTPThang", para);
                }
                catch (System.FormatException ex)
                {
                    if (ex.Message.Contains("was not recognized as a valid DateTime."))
                        MessageBox.Show("Lỗi: Nhập theo định dạng dd/MM/yyyy");
                    if (ex.Message.Contains("' is not supported in calendar 'System.Globalization.GregorianCalendar'.'\r\n"))
                        MessageBox.Show("Lỗi: Nhập ngày tháng hợp lệ.");
                    MessageBox.Show("Lỗi");
                }
                catch (NhapsaiThang ex)
                {
                    MessageBox.Show(ex.Message);
                }
                catch (Microsoft.Data.SqlClient.SqlException ex)
                {
                    if (ex.Message.Contains("Violation of PRIMARY KEY constraint "))
                        MessageBox.Show("Lỗi: Mã hóa đơn đã tồn tại");
                    if (ex.Message.Contains("The conflict occurred in database \"QUAN_LY_CHUNG_CU\", table \"dbo.HopDong\", column 'MaHopDong"))
                        MessageBox.Show("Lỗi: Mã hợp đồng không tồn tại");
                    if (ex.Message.Contains("The UPDATE statement conflicted with the REFERENCE constraint \"FK_PhieuSDDV_HoaDonDV\"."))
                        MessageBox.Show("Lỗi: Không sửa mã hóa đơn");
                    if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                        MessageBox.Show("Lỗi: Xóa gây mất dữ liệu");
                    MessageBox.Show("Lỗi");
                }
            }
        }

        private void timkiemHoaDonTPhong()
        {
            try
            {
                SqlParameter[] para =
                {
                    new SqlParameter("@maHoaDonTP", SqlDbType.NVarChar, 10),
                    new SqlParameter("@ThoiGianSD", SqlDbType.NVarChar, 50),
                    new SqlParameter("@TrangThaiTT", SqlDbType.NVarChar, 50),
                    new SqlParameter("@ngayTT", SqlDbType.NVarChar, 50),
                    new SqlParameter("@maHopDong", SqlDbType.NVarChar, 10)
                };

                para[0].Value = textBoxHoaDon.Text;
                para[1].Value = textBoxThoiGianSD.Text;
                if (comboBoxTrangThaiTT.Text == "Đã thanh toán")
                    para[2].Value = "True";
                else if (comboBoxTrangThaiTT.Text == "Chưa thanh toán")
                    para[2].Value = "False";
                else
                    para[2].Value = "";
                para[3].Value = textBoxNgayTT.Text;
                para[4].Value = textBoxHopDong.Text;

                datagridViewHoaDonTPThang.DataSource = DataConnect.ProcSelec("timkiem_HDTPThang", para);
                datagridViewHoaDonTPThang.AllowUserToAddRows = false;
                datagridViewHoaDonTPThang.RowHeadersVisible = false;
                datagridViewHoaDonTPThang.Columns["NgayThanhToan"].DefaultCellStyle.Format = "dd/MM/yyyy";

            }
            catch (System.FormatException ex)
            {
                if (ex.Message.Contains("was not recognized as a valid DateTime."))
                    MessageBox.Show("Lỗi: Nhập theo định dạng dd/MM/yyyy");
                if (ex.Message.Contains("' is not supported in calendar 'System.Globalization.GregorianCalendar'.'\r\n"))
                    MessageBox.Show("Lỗi: Nhập ngày tháng hợp lệ.");
                MessageBox.Show("Lỗi");
            }
            catch (NhapsaiThang ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Microsoft.Data.SqlClient.SqlException ex)
            {
                if (ex.Message.Contains("Violation of PRIMARY KEY constraint "))
                    MessageBox.Show("Lỗi: Mã hóa đơn đã tồn tại");
                if (ex.Message.Contains("The conflict occurred in database \"QUAN_LY_CHUNG_CU\", table \"dbo.HopDong\", column 'MaHopDong"))
                    MessageBox.Show("Lỗi: Mã hợp đồng không tồn tại");
                if (ex.Message.Contains("The UPDATE statement conflicted with the REFERENCE constraint \"FK_PhieuSDDV_HoaDonDV\"."))
                    MessageBox.Show("Lỗi: Không sửa mã hóa đơn");
                MessageBox.Show("Lỗi");
            }
        }

        public class NhapsaiThang : Exception
        {
            public NhapsaiThang()
            : base("Lỗi: Nhập định dạng tháng 'T_MM/yy'. Ex: 'T04/2024'") { }

            public NhapsaiThang(String ex)
            : base(ex) { }
        }

        private void checkThang(String Thang)
        {
            Regex re = new Regex(@"^T\d{2}/\d{4}$");
            if (!re.IsMatch(Thang))
                throw new NhapsaiThang();
            else
            {
                if (int.Parse(Thang.Substring(1, 2)) < 1 || int.Parse(Thang.Substring(1, 2)) > 12)
                    throw new NhapsaiThang("Nhập đúng giá trị tháng 01-12");
            }
        }

        private void comboBoxTrangThaiTT_TextChanged(object sender, EventArgs e)
        {
            if (comboBoxTrangThaiTT.Text == "Đã thanh toán")
                textBoxNgayTT.ReadOnly = false;
            else
            {
                textBoxNgayTT.Text = "";
                textBoxNgayTT.ReadOnly = true;
            }
        }

        private void datagridViewHoaDonTPThang_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if(e.Value == null || e.Value == DBNull.Value)
            {
                e.Value = "NULL";
                e.FormattingApplied = true;
            }
        }
    }
}
