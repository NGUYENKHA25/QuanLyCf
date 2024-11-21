using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCafe.Function
{
    public class Account
    {
        private void LoadData()
        {
            // Khởi tạo đối tượng datatable để lưu trữ dữ liệu
            DataTable dataTable = new DataTable();

            // Tạo kết nối tới cơ sở dữ liệu
            SqlConnection conn = new SqlConnection("Data Source=myServerAddress;Initial Catalog=myDataBase;User ID=myUsername;Password=myPassword");

            // Chuỗi truy vấn lấy dữ liệu từ bảng
            string query = "SELECT * FROM myTable";

            // Khởi tạo đối tượng SqlDataAdapter để thực hiện truy vấn
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);

            // Nạp dữ liệu vào DataTable
            adapter.Fill(dataTable);

            // Gán dữ liệu vào datagridview
            dtgv.DataSource = dataTable;
        }

    }
}
