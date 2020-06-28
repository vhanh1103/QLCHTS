using QuanLyQuanTraSua.DAO;
using QuanLyQuanTraSua.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanTraSua
{
    
    public partial class Frm_Admin : Form
    {
        BindingSource accountList = new BindingSource();
        public Frm_Admin()
        {
            InitializeComponent();
            Load();
        }
        void Load()
        {
            dgvTaiKhoan.DataSource = accountList;
            LoadListBillByDate(dtpkFromDate.Value, dtpkToDate.Value);
            LoadListFood();
            AddFoodBinding();
            LoadCategoryIntoCombobox(cmbDanhMucNuoc);
            AddAccountBinding();
            LoadAccount();
            
        }
        void AddAccountBinding()
        {
            txtTenTaiKhoan.DataBindings.Add(new Binding("Text", dgvTaiKhoan.DataSource, "UserName", true, DataSourceUpdateMode.Never));
            txtTenHienThi.DataBindings.Add(new Binding("Text", dgvTaiKhoan.DataSource, "DisplayName", true, DataSourceUpdateMode.Never));
            nmLoaiTaiKhoan.DataBindings.Add(new Binding("Value", dgvTaiKhoan.DataSource, "Type", true, DataSourceUpdateMode.Never));
        }
        void LoadListBillByDate(DateTime checkIn, DateTime checkOut)
        {
            dgvBill.DataSource = BillDAO.Instance.GetBillListByDate(checkIn, checkOut);
        }
        private void btnThongKe_Click(object sender, EventArgs e)
        {
            LoadListBillByDate(dtpkFromDate.Value, dtpkToDate.Value);
        }
        void LoadListFood()
        {
            dgvNuocUong.DataSource = FoodDAO.Instance.GetListFood();
        }
        private void btnXemNuoc_Click(object sender, EventArgs e)
        {
            LoadListFood();
        }
        void AddFoodBinding()
        {
            txtTenNuoc.DataBindings.Add(new Binding("Text", dgvNuocUong.DataSource, "Name", true, DataSourceUpdateMode.Never));
            txtIDNuoc.DataBindings.Add(new Binding("Text", dgvNuocUong.DataSource, "ID", true, DataSourceUpdateMode.Never));
            nmPriceNuoc.DataBindings.Add(new Binding("Value", dgvNuocUong.DataSource, "Price", true, DataSourceUpdateMode.Never));
        }
        void LoadCategoryIntoCombobox(ComboBox cb)
        {
            cb.DataSource = CategoryDAO.Instance.GetListCategory();
            cb.DisplayMember = "Name";
        }

        private void btnThemNuoc_Click(object sender, EventArgs e)
        {
            string name = txtTenNuoc.Text;
            int categoryID = (cmbDanhMucNuoc.SelectedItem as Category).ID;
            float price = (float)nmPriceNuoc.Value;
            if(FoodDAO.Instance.InsertFood(name,categoryID,price))
            {
                MessageBox.Show("Thêm món thành công");
                LoadListFood();
            }
            else
            {
                MessageBox.Show("Có lỗi khi thêm món");
            }
        }

        private void btnSuaNuoc_Click(object sender, EventArgs e)
        {
            string name = txtTenNuoc.Text;
            int categoryID = (cmbDanhMucNuoc.SelectedItem as Category).ID;
            float price = (float)nmPriceNuoc.Value;
            int id = Convert.ToInt32(txtIDNuoc.Text);
            if (FoodDAO.Instance.UpdateFood(id, name, categoryID, price))
            {
                MessageBox.Show("Sửa món thành công");
                LoadListFood();
            }
            else
            {
                MessageBox.Show("Có lỗi khi sửa món");
            }
        }

        private void btnXoaNuoc_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtIDNuoc.Text);
            if (FoodDAO.Instance.DeleteFood(id))
            {
                MessageBox.Show("Xóa món thành công");
                LoadListFood();
            }
            else
            {
                MessageBox.Show("Có lỗi khi xóa món");
            }
        }
        void LoadAccount()
        {
            accountList.DataSource = AccountDAO.Instance.GetListAccount();
        }
        private void btnXemTaiKhoan_Click(object sender, EventArgs e)
        {
            LoadAccount();
        }
        void AddAccount(string userName, string displayName, int type)
        {
            if (AccountDAO.Instance.InsertAccount(userName, displayName, type))
            {
                MessageBox.Show("Thêm tài khoản thành công");
            }
            else
            {
                MessageBox.Show("Thêm tài khoản thất bại");
            }

            LoadAccount();
        }
        void EditAccount(string userName, string displayName, int type)
        {
            if (AccountDAO.Instance.UpdateAccount(userName, displayName, type))
            {
                MessageBox.Show("Cập nhật tài khoản thành công");
            }
            else
            {
                MessageBox.Show("Cập nhật tài khoản thất bại");
            }

            LoadAccount();
        }

        void DeleteAccount(string userName)
        {
            
            if (AccountDAO.Instance.DeleteAccount(userName))
            {
                MessageBox.Show("Xóa tài khoản thành công");
            }
            else
            {
                MessageBox.Show("Xóa tài khoản thất bại");
            }

            LoadAccount();
        }

        void ResetPass(string userName)
        {
            if (AccountDAO.Instance.ResetPassword(userName))
            {
                MessageBox.Show("Đặt lại mật khẩu thành công");
            }
            else
            {
                MessageBox.Show("Đặt lại mật khẩu thất bại");
            }
        }
        private void btnThemTaiKhoan_Click(object sender, EventArgs e)
        {
            string userName = txtTenTaiKhoan.Text;
            string displayName = txtTenHienThi.Text;
            int type = (int)nmLoaiTaiKhoan.Value;
            AddAccount(userName, displayName, type);
        }

        private void btnXoaTaiKhoan_Click(object sender, EventArgs e)
        {
            string userName = txtTenTaiKhoan.Text;
            DeleteAccount(userName);
        }

        private void btnSuaTaiKhoan_Click(object sender, EventArgs e)
        {
            string userName = txtTenTaiKhoan.Text;
            string displayName = txtTenHienThi.Text;
            int type = (int)nmLoaiTaiKhoan.Value;

            EditAccount(userName, displayName, type);
        }

        private void btnDatLaiMatKhau_Click(object sender, EventArgs e)
        {
            string userName = txtTenTaiKhoan.Text;
            ResetPass(userName);
        }
    }
}
