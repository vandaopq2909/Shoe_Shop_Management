
using DTO;
using GUI.DSShoeShopTableAdapters;
using System.Data;
using System.Net;
using System.Reflection.PortableExecutable;

namespace GUI
{
    public partial class frmMain : Form
    {
        public string? userName { get; set; }
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            List<string>? list=null;
            if (userName != string.Empty)
            {
                list = getGroup(userName);
            }
            Role(list);//Phân quyền
        }
        private void Role(List<string>? list)
        {
            ListScreenTableAdapter adap = new ListScreenTableAdapter();
            foreach (string groupID in list)
            {
                DataTable kq = new DataTable();
                kq = adap.GetListScreenByUserGroupID(groupID);
                foreach (DataRow row in kq.Rows)
                {
                    foreach (DataColumn column in kq.Columns)
                    {
                        Console.Write($"{column.ColumnName}\t"); // In tên cột
                    }
                    //
                    setRole(menuStrip1.Items, row[1].ToString(), int.Parse(row[2].ToString()) == 1);
                }
            }
        }
        private void setRole(ToolStripItemCollection menus, string? screenID, bool isActive)
        {
            foreach (ToolStripItem mnu in menus)
            {
                // Debug thông tin
                Console.WriteLine($"Checking menu: {mnu.Text}, Tag: {mnu.Tag}, Screen: {screenID}, HasPermission: {isActive}");

                if (mnu is ToolStripMenuItem menuItem)
                {
                    // Kiểm tra và gọi đệ quy nếu có item con
                    if (menuItem.DropDownItems.Count > 0)
                    {
                        setRole(menuItem.DropDownItems, screenID, isActive);
                        // Kiểm tra xem có item con nào được kích hoạt
                        bool hasEnabledChild = false;
                        foreach (ToolStripItem childItem in menuItem.DropDownItems)
                        {
                            if (childItem.Enabled)
                            {
                                hasEnabledChild = true;
                                break;
                            }
                        }
                        // Nếu không có item con nào được kích hoạt, đặt item cha thành không kích hoạt
                        menuItem.Enabled = hasEnabledChild;
                        menuItem.Visible = hasEnabledChild; // Cũng có thể đặt Visble theo ý bạn
                    }
                    else if (screenID.Equals(menuItem.Tag) && isActive)
                    {
                        menuItem.Enabled = true;
                        menuItem.Visible = true;
                    }
                }
            }
        }

        public List<string> getGroup(string? userName)
        {
            List<string> lsGroup = new List<string>();
            User_UserGroupTableAdapter adap = new User_UserGroupTableAdapter();
            DataTable kq = new DataTable();

            kq = adap.GetGroupByUserName(userName);
            foreach (DataRow row in kq.Rows)
            {
                string? userGroupID = row[1].ToString();
                lsGroup.Add(userGroupID);
            }
            return lsGroup;
        }
    }
}
