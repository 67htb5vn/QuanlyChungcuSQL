using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace QuanlyChungcu
{
    public static class DataConnect  //do lớp này là static nên ko gần tạo đối tượng
    {                             
        private static SqlConnection conn;
                
        static DataConnect()            //khởi tạo này tự động chạy
        {                               //chạy đúng 1 lần duy nhất khi bất kỳ phương thức nào đầu tiên được gọi 
            conn = new SqlConnection("Data Source=P117F001;Initial Catalog=QUAN_LY_CHUNG_CU;Integrated Security=True;Trust Server Certificate=True");
        }

        public static SqlCommand createCommand()
        {
            return conn.CreateCommand();
        }

        public static void Open()      //mở kết nối
        {
            conn.Open();
        }

        public static void Close()    //đóng kết nối
        {
            conn.Close();
        }
        public static DataTable GetData(String str)         //lấy dữ liệu đổ vào table
        {

            DataTable dt = new DataTable();

            //SqlDataAdapter adapter = new SqlDataAdapter(str, conn);

            SqlCommand cmd;                   //khai báo lệnh
            cmd=conn.CreateCommand();         //liên kết lệnh với kết nối
            cmd.CommandText=str;

            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;      //trung gian nhận thực thi lệnh, lấy kết quả 

            conn.Open();                      //khi kết nối bật, tiến hành truy vấn
            adapter.Fill(dt);                 //trung gian đổ kết quả vào table
            conn.Close();
            return dt;
        }

        //Chỉ cần stored procedure có SELECT, thì SQL Server sẽ tự động trả về cái SELECT đầu tiên,
        //và SqlDataAdapter.Fill() có thể lấy được. Này cũng giống kiểu viết tường minh.
        public static void Proc(String procName, SqlParameter[] para)
        {
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText= procName;
            cmd.CommandType = CommandType.StoredProcedure;
            if(para != null ) 
                cmd.Parameters.AddRange(para);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}
