using QuanLyQuanTraSua.DAO;
using QuanLyQuanTraSua.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Menu = QuanLyQuanTraSua.DTO.Menu;

namespace QuanLyQuanTraSua
{
    public partial class Frm_QuanLyQuan : Form
    {

        private Account loginAccount;

        public Account LoginAccount
        {
            get { return loginAccount; }
            set { loginAccount = value; ChangeAccount(loginAccount.Type); }
        }
        public Frm_QuanLyQuan(Account account)
        {
            
            InitializeComponent();
            
            this.LoginAccount = account;
            LoadTable();
            LoadCategory();
            
        }
        void ChangeAccount(int type)
        {
            mnAdmin.Enabled = type == 1;
            mnThongTinTaiKhoan.Text += " (" + LoginAccount.DisplayName + ")";
        }
        void LoadCategory()
        {
            List<Category> listCategory = CategoryDAO.Instance.GetListCategory();
            cmbCategory.DataSource = listCategory;
            cmbCategory.DisplayMember = "Name";
        }
        void LoadFoodListByCategoryID(int id)
        {
            List<Food> listFood = FoodDAO.Instance.GetFoodByCategoryID(id);
            cmbFood.DataSource = listFood;
            cmbFood.DisplayMember = "Name";
        }
        void LoadTable()
        {
            flTable.Controls.Clear();
            List<Table> tableList = TableDAO.Instance.LoadTableList();

            foreach (Table item in tableList)
            {
                Button btn = new Button() { Width = TableDAO.TableWidth, Height = TableDAO.TableHeight };
                btn.Text = item.Name + Environment.NewLine + item.Status;
                btn.Click += btn_Click;
                btn.Tag = item;
                switch (item.Status)
                {
                    case "Trống":
                        btn.BackColor = Color.LightSkyBlue;
                        break;
                    default:
                        btn.BackColor = Color.LightPink;
                        break;
                }


                flTable.Controls.Add(btn);
            }
        }
        void ShowBill(int id)
        {
            lsvHoaDon.Items.Clear();
            List<QuanLyQuanTraSua.DTO.Menu> listBillInfo = MenuDAO.Instance.GetListMenuByTable(id);
            float totalPrice = 0;
            foreach (Menu item in listBillInfo)
            {
                ListViewItem listViewItem = new ListViewItem(item.FoodName.ToString());
                listViewItem.SubItems.Add(item.Count.ToString());
                listViewItem.SubItems.Add(item.Price.ToString());
                listViewItem.SubItems.Add(item.TotalPrice.ToString());
                totalPrice += item.TotalPrice;
                lsvHoaDon.Items.Add(listViewItem);
            }
            txtThanhToan.Text = totalPrice.ToString();
            
        }
        private void btn_Click(object sender, EventArgs e)
        {
            int tableID = ((sender as Button).Tag as Table).ID;
            lsvHoaDon.Tag = (sender as Button).Tag;
            ShowBill(tableID);
        }

        private void mnDangXuat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mnThongTinCaNhan_Click(object sender, EventArgs e)
        {
            Frm_TaiKhoan f = new Frm_TaiKhoan(LoginAccount);
            f.UpdateAccount += f_UpdateAccount;
            f.ShowDialog();
        }
        void f_UpdateAccount(object sender, EventArgs e)
        {
            
        }
        private void mnAdmin_Click(object sender, EventArgs e)
        {
            Frm_Admin frm_Admin = new Frm_Admin();
            frm_Admin.ShowDialog();
        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = 0;
            ComboBox cb = sender as ComboBox;
            if (cb.SelectedItem == null)
                return;
            Category selected = cb.SelectedItem as Category;
            id = selected.ID;
            LoadFoodListByCategoryID(id);
        }

        private void btnThemNuoc_Click(object sender, EventArgs e)
        {
            Table table = lsvHoaDon.Tag as Table;

            if (table == null)
            {
                MessageBox.Show("Hãy chọn bàn");
                return;
            }

            int idBill = BillDAO.Instance.GetUncheckBillIDByTableID(table.ID);
            int foodID = (cmbFood.SelectedItem as Food).ID;
            int count = (int)nmGioiHanThem.Value;

            if (idBill == -1)
            {
                BillDAO.Instance.InsertBill(table.ID);
                BillInfoDAO.Instance.InsertBillInfo(BillDAO.Instance.GetMaxIDBill(), foodID, count);
            }
            else
            {
                BillInfoDAO.Instance.InsertBillInfo(idBill, foodID, count);
            }

            ShowBill(table.ID);

            LoadTable();
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            Table table = lsvHoaDon.Tag as Table;
            int idBill = BillDAO.Instance.GetUncheckBillIDByTableID(table.ID);
            double totalPrice = Convert.ToDouble(txtThanhToan.Text.Split(',')[0]);
            
            if (idBill!=-1)
            {
                if (MessageBox.Show(string.Format("Bạn có chắc thanh toán hóa đơn cho bàn {0}",table.Name), "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                {
                    BillDAO.Instance.CheckOut(idBill,(float)totalPrice);
                    ShowBill(table.ID);
                    LoadTable();
                }
            }
        }
    }
}
