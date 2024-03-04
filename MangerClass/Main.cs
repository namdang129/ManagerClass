using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ManagerClass
{
    public partial class ManagerClass : Form
    {
        string str = "Data Source=DESKTOP-EJKHI6Q;Initial Catalog=ManagerClass;Integrated Security=True";
        SqlConnection connection;
        SqlCommand cmd;
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable dt1 = new DataTable();
        DataTable dt2 = new DataTable();

        public ManagerClass()
        {
            InitializeComponent();
        }

        private void ManagerClass_Load(object sender, EventArgs e)
        {
            try
            {
                connection = new SqlConnection(str);
                connection.Open();
                LoadDataClass();
                LoadDataStudent();
                LoadCombo();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi khi tải dữ liệu: " + ex.Message);
            }
        }

        private void LoadDataClass()
        {
            try
            {
                cmd = connection.CreateCommand();
                cmd.CommandText = "SELECT * FROM Class";
                adapter.SelectCommand = cmd;
                dt1.Clear();
                adapter.Fill(dt1);
                DGV_Class.DataSource = dt1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi khi tải dữ liệu lớp: " + ex.Message);
            }
        }

        private void LoadDataStudent()
        {
            try
            {
                cmd = connection.CreateCommand();
                cmd.CommandText = "SELECT * FROM Student";
                cmd.CommandText = "select a.StId,a.StName, a.StBorn,a.StPlace,b.ClassName From Class b JOIN Student a ON a.Class = b.ClassId";
                adapter.SelectCommand = cmd;
                dt2.Clear();
                adapter.Fill(dt2);
                DGV_Stu.DataSource = dt2;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi khi tải dữ liệu học sinh: " + ex.Message);
            }
        }

        private void DGV_Class_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int i = DGV_Class.CurrentRow.Index;
                tb_ClassId.Text = DGV_Class.Rows[i].Cells[0].Value.ToString();
                tb_Class.Text = DGV_Class.Rows[i].Cells[1].Value.ToString();
                cb_Grade.Text = DGV_Class.Rows[i].Cells[2].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi đọc dữ liệu lớp: " + ex.Message);
            }
        }

        private void btn_AddC_Click(object sender, EventArgs e)
        {
            try
            {
                cmd = connection.CreateCommand();
                cmd.CommandText = "Insert into Class values('" + tb_Class.Text + "','" + cb_Grade.Text + "')";
                cmd.ExecuteNonQuery();
                LoadDataClass();
                LoadCombo();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi khi thêm lớp: " + ex.Message);
            }
        }

        private void btn_Del_Click(object sender, EventArgs e)
        {
            try
            {
                cmd = connection.CreateCommand();
                cmd.CommandText = "Delete from Class where ClassId = '" + tb_ClassId.Text + "'";
                cmd.ExecuteNonQuery();
                LoadDataClass();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi khi xóa lớp: " + ex.Message);
            }
        }

        private void btn_UpdateC_Click(object sender, EventArgs e)
        {
            try
            {
                cmd = connection.CreateCommand();
                cmd.CommandText = "Update Class set ClassName = '" + tb_Class.Text + "' where ClassId = '" + tb_ClassId.Text + "'";
                cmd.ExecuteNonQuery();
                LoadDataClass();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi khi cập nhật lớp: " + ex.Message);
            }
        }

        private void DGV_Stu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int j = DGV_Stu.CurrentRow.Index;
                tb_IdStu.Text = DGV_Stu.Rows[j].Cells[0].Value.ToString();
                tb_NameS.Text = DGV_Stu.Rows[j].Cells[1].Value.ToString();
                dtpBorn.Text = DGV_Stu.Rows[j].Cells[2].Value.ToString();
                tb_Adres.Text = DGV_Stu.Rows[j].Cells[3].Value.ToString();
                cb_Class.SelectedItem = DGV_Stu.Rows[j].Cells[4].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi đọc dữ liệu học sinh: " + ex.Message);
            }
        }

        private void btn_AddS_Click(object sender, EventArgs e)
        {
            /*try
            {
                if (cb_Class.SelectedItem != null)
                {
                    if (int.TryParse(cb_Class.SelectedItem.ToString(), out int selectedClassId))
                    {*/
            cmd = connection.CreateCommand();
            cmd.CommandText = "Insert into Student values(N'" + tb_NameS.Text + "','" + dtpBorn.Text + "',N'" + tb_Adres.Text + "','" + cb_Class + "')";//selectedClassId thay dính lỗi chưa fix đc
            cmd.ExecuteNonQuery();
            LoadDataStudent();
                        /*}
                        else
                        {
                            MessageBox.Show("Giá trị lớp không hợp lệ được chọn.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng chọn lớp.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã xảy ra lỗi khi thêm học sinh: " + ex.Message);
                }*/
                    }

                    private void btn_UpdateS_Click(object sender, EventArgs e)
        {
            try
            {
                cmd = connection.CreateCommand();
                cmd.CommandText = "Update Student set StName = N'" + tb_NameS.Text + "',StBorn='" + dtpBorn.Text + "',StPlace =N'" + tb_Adres.Text + "',Class ='" + cb_Class.Text + "' WHERE StId = '" + tb_IdStu.Text + "'";
                cmd.ExecuteNonQuery();
                LoadDataStudent();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi khi cập nhật học sinh: " + ex.Message);
            }
        }

        private void btn_DelS_Click(object sender, EventArgs e)
        {
            try
            {
                cmd = connection.CreateCommand();
                cmd.CommandText = "Delete from Student where StId = '" + tb_IdStu.Text + "'";
                cmd.ExecuteNonQuery();
                LoadDataStudent();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi khi xóa học sinh: " + ex.Message);
            }
        }

        void LoadCombo()
        {
            try
            {
                cb_Class.Items.Clear();
                using (SqlConnection conn = new SqlConnection(str))
                {
                    conn.Open();
                    string query = "SELECT ClassName FROM Class";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                cb_Class.Items.Add(reader["ClassName"].ToString());
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi khi tải dữ liệu lớp cho ComboBox: " + ex.Message);
            }
        }

        private void cb_Class_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cb_Class.SelectedItem != null)
                {
                    string selectedClass = cb_Class.SelectedItem.ToString();
                    MessageBox.Show("Lớp được chọn: " + selectedClass);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi trong sự kiện thay đổi lựa chọn ComboBox: " + ex.Message);
            }
        }
    }
}
