namespace HuluwaToken
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.uiBtnInstall = new Sunny.UI.UIButton();
            this.uiBtnStart = new Sunny.UI.UIButton();
            this.uiTxbAppId = new Sunny.UI.UITextBox();
            this.uiLabel6 = new Sunny.UI.UILabel();
            this.uiTxbAppSecret = new Sunny.UI.UITextBox();
            this.uiLabel7 = new Sunny.UI.UILabel();
            this.uiTxbUrl = new Sunny.UI.UITextBox();
            this.uiLabel8 = new Sunny.UI.UILabel();
            this.uiSwitchCert = new Sunny.UI.UISwitch();
            this.uiTabControl1 = new Sunny.UI.UITabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.uiBtnTips = new Sunny.UI.UISymbolButton();
            this.uiTxbUser = new Sunny.UI.UITextBox();
            this.uiLabUser = new Sunny.UI.UILabel();
            this.uiDataGridView1 = new Sunny.UI.UIDataGridView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.uiBtnQl = new Sunny.UI.UIButton();
            this.uiLabel10 = new Sunny.UI.UILabel();
            this.uiSwitchQl = new Sunny.UI.UISwitch();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.uiTxbCaKey = new Sunny.UI.UITextBox();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.uiBtnCert = new Sunny.UI.UIButton();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.uiTxbCaCrt = new Sunny.UI.UITextBox();
            this.uiLabel4 = new Sunny.UI.UILabel();
            this.uiLabCertState = new Sunny.UI.UILabel();
            this.uiLabQlState = new Sunny.UI.UILabel();
            this.uiTabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiDataGridView1)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // uiBtnInstall
            // 
            this.uiBtnInstall.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uiBtnInstall.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiBtnInstall.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiBtnInstall.Location = new System.Drawing.Point(6, 443);
            this.uiBtnInstall.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiBtnInstall.Name = "uiBtnInstall";
            this.uiBtnInstall.Size = new System.Drawing.Size(100, 35);
            this.uiBtnInstall.TabIndex = 0;
            this.uiBtnInstall.Text = "安装证书";
            this.uiBtnInstall.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiBtnInstall.Click += new System.EventHandler(this.uiBtnInstall_Click);
            // 
            // uiBtnStart
            // 
            this.uiBtnStart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uiBtnStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiBtnStart.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiBtnStart.Location = new System.Drawing.Point(597, 443);
            this.uiBtnStart.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiBtnStart.Name = "uiBtnStart";
            this.uiBtnStart.Size = new System.Drawing.Size(100, 35);
            this.uiBtnStart.TabIndex = 3;
            this.uiBtnStart.Text = "启动代理";
            this.uiBtnStart.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiBtnStart.Click += new System.EventHandler(this.uiBtnStart_Click);
            // 
            // uiTxbAppId
            // 
            this.uiTxbAppId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uiTxbAppId.Enabled = false;
            this.uiTxbAppId.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiTxbAppId.Location = new System.Drawing.Point(183, 107);
            this.uiTxbAppId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTxbAppId.MinimumSize = new System.Drawing.Size(1, 16);
            this.uiTxbAppId.Name = "uiTxbAppId";
            this.uiTxbAppId.Padding = new System.Windows.Forms.Padding(5);
            this.uiTxbAppId.ShowText = false;
            this.uiTxbAppId.Size = new System.Drawing.Size(275, 29);
            this.uiTxbAppId.TabIndex = 23;
            this.uiTxbAppId.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiTxbAppId.Watermark = "青龙里面创建的应用";
            // 
            // uiLabel6
            // 
            this.uiLabel6.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel6.Location = new System.Drawing.Point(65, 113);
            this.uiLabel6.Name = "uiLabel6";
            this.uiLabel6.Size = new System.Drawing.Size(111, 29);
            this.uiLabel6.TabIndex = 21;
            this.uiLabel6.Text = "应用ID：";
            this.uiLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // uiTxbAppSecret
            // 
            this.uiTxbAppSecret.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uiTxbAppSecret.Enabled = false;
            this.uiTxbAppSecret.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiTxbAppSecret.Location = new System.Drawing.Point(183, 146);
            this.uiTxbAppSecret.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTxbAppSecret.MinimumSize = new System.Drawing.Size(1, 16);
            this.uiTxbAppSecret.Name = "uiTxbAppSecret";
            this.uiTxbAppSecret.Padding = new System.Windows.Forms.Padding(5);
            this.uiTxbAppSecret.PasswordChar = '*';
            this.uiTxbAppSecret.ShowText = false;
            this.uiTxbAppSecret.Size = new System.Drawing.Size(275, 29);
            this.uiTxbAppSecret.TabIndex = 24;
            this.uiTxbAppSecret.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiTxbAppSecret.Watermark = "对应应用的机密";
            // 
            // uiLabel7
            // 
            this.uiLabel7.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel7.Location = new System.Drawing.Point(60, 146);
            this.uiLabel7.Name = "uiLabel7";
            this.uiLabel7.Size = new System.Drawing.Size(116, 29);
            this.uiLabel7.TabIndex = 22;
            this.uiLabel7.Text = "应用机密：";
            this.uiLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // uiTxbUrl
            // 
            this.uiTxbUrl.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uiTxbUrl.Enabled = false;
            this.uiTxbUrl.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiTxbUrl.Location = new System.Drawing.Point(183, 68);
            this.uiTxbUrl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTxbUrl.MinimumSize = new System.Drawing.Size(1, 16);
            this.uiTxbUrl.Name = "uiTxbUrl";
            this.uiTxbUrl.Padding = new System.Windows.Forms.Padding(5);
            this.uiTxbUrl.ShowText = false;
            this.uiTxbUrl.Size = new System.Drawing.Size(275, 29);
            this.uiTxbUrl.TabIndex = 20;
            this.uiTxbUrl.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiTxbUrl.Watermark = "http://127.0.0.1:5700";
            // 
            // uiLabel8
            // 
            this.uiLabel8.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel8.Location = new System.Drawing.Point(64, 74);
            this.uiLabel8.Name = "uiLabel8";
            this.uiLabel8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.uiLabel8.Size = new System.Drawing.Size(112, 29);
            this.uiLabel8.TabIndex = 19;
            this.uiLabel8.Text = "青龙地址：";
            this.uiLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // uiSwitchCert
            // 
            this.uiSwitchCert.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiSwitchCert.Location = new System.Drawing.Point(226, 32);
            this.uiSwitchCert.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSwitchCert.Name = "uiSwitchCert";
            this.uiSwitchCert.Size = new System.Drawing.Size(75, 29);
            this.uiSwitchCert.TabIndex = 0;
            this.uiSwitchCert.Text = "uiSwitch1";
            this.uiSwitchCert.ValueChanged += new Sunny.UI.UISwitch.OnValueChanged(this.uiSwitchCert_ValueChanged);
            // 
            // uiTabControl1
            // 
            this.uiTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uiTabControl1.Controls.Add(this.tabPage3);
            this.uiTabControl1.Controls.Add(this.tabPage1);
            this.uiTabControl1.Controls.Add(this.tabPage2);
            this.uiTabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.uiTabControl1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(227)))), ((int)(((byte)(227)))));
            this.uiTabControl1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiTabControl1.ItemSize = new System.Drawing.Size(150, 40);
            this.uiTabControl1.Location = new System.Drawing.Point(3, 38);
            this.uiTabControl1.MainPage = "";
            this.uiTabControl1.MenuStyle = Sunny.UI.UIMenuStyle.Custom;
            this.uiTabControl1.Name = "uiTabControl1";
            this.uiTabControl1.SelectedIndex = 0;
            this.uiTabControl1.Size = new System.Drawing.Size(717, 308);
            this.uiTabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.uiTabControl1.TabBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.uiTabControl1.TabIndex = 5;
            this.uiTabControl1.TabSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.uiTabControl1.TabUnSelectedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiTabControl1.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(227)))), ((int)(((byte)(227)))));
            this.tabPage3.Controls.Add(this.uiBtnTips);
            this.tabPage3.Controls.Add(this.uiTxbUser);
            this.tabPage3.Controls.Add(this.uiLabUser);
            this.tabPage3.Controls.Add(this.uiDataGridView1);
            this.tabPage3.Location = new System.Drawing.Point(0, 40);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(717, 268);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "主界面";
            // 
            // uiBtnTips
            // 
            this.uiBtnTips.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.uiBtnTips.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiBtnTips.Font = new System.Drawing.Font("宋体", 12F);
            this.uiBtnTips.Location = new System.Drawing.Point(668, 15);
            this.uiBtnTips.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiBtnTips.Name = "uiBtnTips";
            this.uiBtnTips.Radius = 10;
            this.uiBtnTips.Size = new System.Drawing.Size(46, 35);
            this.uiBtnTips.Symbol = 61738;
            this.uiBtnTips.TabIndex = 105;
            this.uiBtnTips.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiBtnTips.TipsText = "复制";
            this.uiBtnTips.Click += new System.EventHandler(this.uiBtnTips_Click);
            // 
            // uiTxbUser
            // 
            this.uiTxbUser.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uiTxbUser.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiTxbUser.Location = new System.Drawing.Point(144, 15);
            this.uiTxbUser.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTxbUser.MinimumSize = new System.Drawing.Size(1, 16);
            this.uiTxbUser.Name = "uiTxbUser";
            this.uiTxbUser.Padding = new System.Windows.Forms.Padding(5);
            this.uiTxbUser.ReadOnly = true;
            this.uiTxbUser.ShowButton = true;
            this.uiTxbUser.ShowText = false;
            this.uiTxbUser.Size = new System.Drawing.Size(150, 29);
            this.uiTxbUser.TabIndex = 2;
            this.uiTxbUser.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiTxbUser.Watermark = "";
            this.uiTxbUser.ButtonClick += new System.EventHandler(this.uiTxbUser_ButtonClick);
            // 
            // uiLabUser
            // 
            this.uiLabUser.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabUser.Location = new System.Drawing.Point(15, 21);
            this.uiLabUser.Name = "uiLabUser";
            this.uiLabUser.Size = new System.Drawing.Size(122, 23);
            this.uiLabUser.TabIndex = 1;
            this.uiLabUser.Text = "当前用户：";
            this.uiLabUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // uiDataGridView1
            // 
            this.uiDataGridView1.AllowUserToAddRows = false;
            this.uiDataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uiDataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.uiDataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.uiDataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.uiDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.uiDataGridView1.ColumnHeadersHeight = 32;
            this.uiDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.uiDataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.uiDataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.uiDataGridView1.EnableHeadersVisualStyles = false;
            this.uiDataGridView1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiDataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.uiDataGridView1.Location = new System.Drawing.Point(0, 59);
            this.uiDataGridView1.Name = "uiDataGridView1";
            this.uiDataGridView1.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.uiDataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.uiDataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiDataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.uiDataGridView1.RowTemplate.Height = 27;
            this.uiDataGridView1.SelectedIndex = -1;
            this.uiDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.uiDataGridView1.Size = new System.Drawing.Size(717, 209);
            this.uiDataGridView1.StripeOddColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uiDataGridView1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(227)))), ((int)(((byte)(227)))));
            this.tabPage1.Controls.Add(this.uiBtnQl);
            this.tabPage1.Controls.Add(this.uiLabel10);
            this.tabPage1.Controls.Add(this.uiSwitchQl);
            this.tabPage1.Controls.Add(this.uiTxbUrl);
            this.tabPage1.Controls.Add(this.uiLabel8);
            this.tabPage1.Controls.Add(this.uiTxbAppId);
            this.tabPage1.Controls.Add(this.uiLabel7);
            this.tabPage1.Controls.Add(this.uiLabel6);
            this.tabPage1.Controls.Add(this.uiTxbAppSecret);
            this.tabPage1.Location = new System.Drawing.Point(0, 40);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(200, 60);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "青龙配置";
            // 
            // uiBtnQl
            // 
            this.uiBtnQl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uiBtnQl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiBtnQl.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiBtnQl.Location = new System.Drawing.Point(293, 1);
            this.uiBtnQl.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiBtnQl.Name = "uiBtnQl";
            this.uiBtnQl.Size = new System.Drawing.Size(1, 35);
            this.uiBtnQl.TabIndex = 8;
            this.uiBtnQl.Text = "应用配置";
            this.uiBtnQl.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiBtnQl.Click += new System.EventHandler(this.uiBtnQl_Click);
            // 
            // uiLabel10
            // 
            this.uiLabel10.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel10.Location = new System.Drawing.Point(20, 37);
            this.uiLabel10.Name = "uiLabel10";
            this.uiLabel10.Size = new System.Drawing.Size(156, 23);
            this.uiLabel10.TabIndex = 28;
            this.uiLabel10.Text = "自动上传青龙：";
            this.uiLabel10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // uiSwitchQl
            // 
            this.uiSwitchQl.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiSwitchQl.Location = new System.Drawing.Point(183, 31);
            this.uiSwitchQl.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSwitchQl.Name = "uiSwitchQl";
            this.uiSwitchQl.Size = new System.Drawing.Size(75, 29);
            this.uiSwitchQl.TabIndex = 27;
            this.uiSwitchQl.Text = "uiSwitch2";
            this.uiSwitchQl.ValueChanged += new Sunny.UI.UISwitch.OnValueChanged(this.uiSwitchQl_ValueChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(227)))), ((int)(((byte)(227)))));
            this.tabPage2.Controls.Add(this.uiLabel3);
            this.tabPage2.Controls.Add(this.uiTxbCaKey);
            this.tabPage2.Controls.Add(this.uiLabel1);
            this.tabPage2.Controls.Add(this.uiBtnCert);
            this.tabPage2.Controls.Add(this.uiSwitchCert);
            this.tabPage2.Controls.Add(this.uiLabel2);
            this.tabPage2.Controls.Add(this.uiTxbCaCrt);
            this.tabPage2.Location = new System.Drawing.Point(0, 40);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(200, 60);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "证书管理(可选)";
            // 
            // uiLabel3
            // 
            this.uiLabel3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel3.Location = new System.Drawing.Point(66, 126);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(153, 23);
            this.uiLabel3.TabIndex = 3;
            this.uiLabel3.Text = "证书key：";
            this.uiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // uiTxbCaKey
            // 
            this.uiTxbCaKey.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uiTxbCaKey.Enabled = false;
            this.uiTxbCaKey.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiTxbCaKey.Location = new System.Drawing.Point(226, 120);
            this.uiTxbCaKey.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTxbCaKey.MinimumSize = new System.Drawing.Size(1, 16);
            this.uiTxbCaKey.Name = "uiTxbCaKey";
            this.uiTxbCaKey.Padding = new System.Windows.Forms.Padding(5);
            this.uiTxbCaKey.ReadOnly = true;
            this.uiTxbCaKey.ShowButton = true;
            this.uiTxbCaKey.ShowText = false;
            this.uiTxbCaKey.Size = new System.Drawing.Size(288, 29);
            this.uiTxbCaKey.TabIndex = 2;
            this.uiTxbCaKey.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiTxbCaKey.Watermark = "";
            this.uiTxbCaKey.ButtonClick += new System.EventHandler(this.uiTxbCaKey_ButtonClick);
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel1.Location = new System.Drawing.Point(50, 38);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(169, 23);
            this.uiLabel1.TabIndex = 1;
            this.uiLabel1.Text = "自定义证书：";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // uiBtnCert
            // 
            this.uiBtnCert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiBtnCert.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiBtnCert.Location = new System.Drawing.Point(306, 201);
            this.uiBtnCert.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiBtnCert.Name = "uiBtnCert";
            this.uiBtnCert.Size = new System.Drawing.Size(100, 35);
            this.uiBtnCert.TabIndex = 2;
            this.uiBtnCert.Text = "应用配置";
            this.uiBtnCert.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiBtnCert.Click += new System.EventHandler(this.uiBtnCert_Click);
            // 
            // uiLabel2
            // 
            this.uiLabel2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel2.Location = new System.Drawing.Point(66, 81);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(153, 23);
            this.uiLabel2.TabIndex = 1;
            this.uiLabel2.Text = "证书公钥：";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // uiTxbCaCrt
            // 
            this.uiTxbCaCrt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uiTxbCaCrt.Enabled = false;
            this.uiTxbCaCrt.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiTxbCaCrt.Location = new System.Drawing.Point(226, 75);
            this.uiTxbCaCrt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTxbCaCrt.MinimumSize = new System.Drawing.Size(1, 16);
            this.uiTxbCaCrt.Name = "uiTxbCaCrt";
            this.uiTxbCaCrt.Padding = new System.Windows.Forms.Padding(5);
            this.uiTxbCaCrt.ReadOnly = true;
            this.uiTxbCaCrt.ShowButton = true;
            this.uiTxbCaCrt.ShowText = false;
            this.uiTxbCaCrt.Size = new System.Drawing.Size(288, 29);
            this.uiTxbCaCrt.TabIndex = 0;
            this.uiTxbCaCrt.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiTxbCaCrt.Watermark = "";
            this.uiTxbCaCrt.ButtonClick += new System.EventHandler(this.uiTxbCaCrt_ButtonClick);
            // 
            // uiLabel4
            // 
            this.uiLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uiLabel4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel4.Location = new System.Drawing.Point(3, 367);
            this.uiLabel4.Name = "uiLabel4";
            this.uiLabel4.Size = new System.Drawing.Size(115, 23);
            this.uiLabel4.TabIndex = 6;
            this.uiLabel4.Text = "当前证书：";
            this.uiLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // uiLabCertState
            // 
            this.uiLabCertState.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uiLabCertState.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabCertState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabCertState.Location = new System.Drawing.Point(124, 367);
            this.uiLabCertState.Name = "uiLabCertState";
            this.uiLabCertState.Size = new System.Drawing.Size(246, 23);
            this.uiLabCertState.TabIndex = 7;
            this.uiLabCertState.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabQlState
            // 
            this.uiLabQlState.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uiLabQlState.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabQlState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabQlState.Location = new System.Drawing.Point(12, 403);
            this.uiLabQlState.Name = "uiLabQlState";
            this.uiLabQlState.Size = new System.Drawing.Size(190, 23);
            this.uiLabQlState.TabIndex = 8;
            this.uiLabQlState.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(723, 500);
            this.Controls.Add(this.uiLabQlState);
            this.Controls.Add(this.uiLabCertState);
            this.Controls.Add(this.uiLabel4);
            this.Controls.Add(this.uiTabControl1);
            this.Controls.Add(this.uiBtnStart);
            this.Controls.Add(this.uiBtnInstall);
            this.Name = "MainForm";
            this.Text = "主界面";
            this.ZoomScaleRect = new System.Drawing.Rectangle(15, 15, 800, 450);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.uiTabControl1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.uiDataGridView1)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIButton uiBtnInstall;
        private Sunny.UI.UIButton uiBtnStart;
        private Sunny.UI.UITextBox uiTxbAppId;
        private Sunny.UI.UILabel uiLabel6;
        private Sunny.UI.UITextBox uiTxbAppSecret;
        private Sunny.UI.UILabel uiLabel7;
        private Sunny.UI.UITextBox uiTxbUrl;
        private Sunny.UI.UILabel uiLabel8;
        private Sunny.UI.UISwitch uiSwitchCert;
        private Sunny.UI.UITabControl uiTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UITextBox uiTxbCaKey;
        private Sunny.UI.UIButton uiBtnCert;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UITextBox uiTxbCaCrt;
        private Sunny.UI.UILabel uiLabel4;
        private Sunny.UI.UILabel uiLabCertState;
        private System.Windows.Forms.TabPage tabPage3;
        private Sunny.UI.UIDataGridView uiDataGridView1;
        private Sunny.UI.UILabel uiLabel10;
        private Sunny.UI.UISwitch uiSwitchQl;
        private Sunny.UI.UILabel uiLabUser;
        private Sunny.UI.UITextBox uiTxbUser;
        private Sunny.UI.UISymbolButton uiBtnTips;
        private Sunny.UI.UIButton uiBtnQl;
        private Sunny.UI.UILabel uiLabQlState;
    }
}

