using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HuluwaToken.Common;
using HuluwaToken.Entity;
using Sunny.UI;

namespace HuluwaToken
{
    public partial class SelectUserForm : UIForm
    {
        private BindingList<UserEntity> userList = new BindingList<UserEntity>();
        public SelectUserForm()
        {
            InitializeComponent();
        }

        private void SelectUserForm_Load(object sender, EventArgs e)
        {
            uiDataGridView1.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "用户名称",
                DataPropertyName = "Name",
                Width = 150
            });
            uiDataGridView1.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "最后修改时间",
                DataPropertyName = "UpdateTime",
                Width = 250
            });
            InitTableData();
        }

        public void InitTableData()
        {
            var data = SqlSugarHelper.DB.Queryable<UserEntity>().ToList();
            userList = new BindingList<UserEntity>(data);
            uiDataGridView1.DataSource = userList;
            uiDataGridView1.Invalidate();
        }

        public UserEntity GetSelectUser()
        {
            if (uiDataGridView1.CurrentRow == null)
            {
                ShowErrorTip("请先选择一条数据");
                return null;
            }
            var selectRow = (UserEntity)uiDataGridView1.CurrentRow.DataBoundItem;
            if (selectRow == null)
            {
                ShowErrorTip("请先选择一条数据");
                return null;
            }
            return selectRow;
        }

        private void uiSymbolButton19_Click(object sender, EventArgs e)
        {
            string value = "";
            if (this.InputStringDialog(ref value, true, "请输入用户名：", true))
            {
                if (userList.Any(m => m.Name == value))
                {
                    ShowErrorTip("当前用户名已存在");
                    return;
                }
                var newData = UserEntity.Create(value);
                userList.Add(newData);

                SqlSugarHelper.DB.Insertable(newData).ExecuteCommand();
                uiDataGridView1.Invalidate();

                ShowSuccessTip("添加成功");
            }
        }

        private void uiSymbolButton22_Click(object sender, EventArgs e)
        {
            var user = GetSelectUser();
            if (user == null) return;
            string value = user.Name;
            string oldValue = user.Name;
            if (this.InputStringDialog(ref value, true, "请输入用户名：", true))
            {
                if (userList.Any(m => m.Name != user.Name && m.Name == value))
                {
                    ShowErrorTip("当前用户名已存在");
                    return;
                }
                user.Name = value;
                user.UpdateTime = DateTime.Now;

                SqlSugarHelper.DB.Deleteable<UserEntity>().Where(m => m.Name == oldValue).ExecuteCommand();
                SqlSugarHelper.DB.Insertable(user).ExecuteCommand();
                uiDataGridView1.Invalidate();
                ShowSuccessTip("修改成功");
            }
        }

        private void uiSymbolButton23_Click(object sender, EventArgs e)
        {
            var user = GetSelectUser();
            if (user == null) return;
            var ret = ShowAskDialog($"是否确认删除用户【{user.Name}】");
            if (ret)
            {
                userList.Remove(user);

                SqlSugarHelper.DB.Deleteable<UserEntity>().Where(m => m.Name == user.Name).ExecuteCommand();
                uiDataGridView1.Invalidate();
                ShowSuccessTip("删除成功");
            }
        }

        private void uiSymbolButton24_Click(object sender, EventArgs e)
        {
            InitTableData();
        }

        private void uiButton1_Click(object sender, EventArgs e)
        {
            var user = GetSelectUser();
            if (user == null) return;
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
