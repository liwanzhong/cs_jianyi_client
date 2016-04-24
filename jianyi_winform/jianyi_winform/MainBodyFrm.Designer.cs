namespace jianyi_winform
{
    partial class MainFrm
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFrm));
            this.toolbar_imglist = new System.Windows.Forms.ImageList(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.toolBar_main = new System.Windows.Forms.ToolBar();
            this.toolBarButton1 = new System.Windows.Forms.ToolBarButton();
            this.toolBarButton2 = new System.Windows.Forms.ToolBarButton();
            this.toolBarButton3 = new System.Windows.Forms.ToolBarButton();
            this.panel_body = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolbar_imglist
            // 
            this.toolbar_imglist.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("toolbar_imglist.ImageStream")));
            this.toolbar_imglist.TransparentColor = System.Drawing.Color.White;
            this.toolbar_imglist.Images.SetKeyName(0, "examine-active.png");
            this.toolbar_imglist.Images.SetKeyName(1, "question-active.png");
            this.toolbar_imglist.Images.SetKeyName(2, "setting-active.png");
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.toolBar_main, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel_body, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.87709F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 82.1229F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1008, 882);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // toolBar_main
            // 
            this.toolBar_main.AutoSize = false;
            this.toolBar_main.Buttons.AddRange(new System.Windows.Forms.ToolBarButton[] {
            this.toolBarButton1,
            this.toolBarButton2,
            this.toolBarButton3});
            this.toolBar_main.Cursor = System.Windows.Forms.Cursors.Default;
            this.toolBar_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolBar_main.DropDownArrows = true;
            this.toolBar_main.ImageList = this.toolbar_imglist;
            this.toolBar_main.Location = new System.Drawing.Point(3, 3);
            this.toolBar_main.Name = "toolBar_main";
            this.toolBar_main.ShowToolTips = true;
            this.toolBar_main.Size = new System.Drawing.Size(1002, 94);
            this.toolBar_main.TabIndex = 1;
            this.toolBar_main.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(this.toolBar_main_ButtonClick);
            // 
            // toolBarButton1
            // 
            this.toolBarButton1.ImageIndex = 0;
            this.toolBarButton1.Name = "toolBarButton1";
            this.toolBarButton1.ToolTipText = "会员管理";
            // 
            // toolBarButton2
            // 
            this.toolBarButton2.ImageIndex = 2;
            this.toolBarButton2.Name = "toolBarButton2";
            this.toolBarButton2.ToolTipText = "配置管理";
            // 
            // toolBarButton3
            // 
            this.toolBarButton3.ImageIndex = 1;
            this.toolBarButton3.Name = "toolBarButton3";
            this.toolBarButton3.ToolTipText = "常见问题";
            // 
            // panel_body
            // 
            this.panel_body.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_body.Location = new System.Drawing.Point(3, 160);
            this.panel_body.Name = "panel_body";
            this.panel_body.Size = new System.Drawing.Size(1002, 719);
            this.panel_body.TabIndex = 2;
            // 
            // MainFrm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1008, 882);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainFrm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "人体机能检测平台";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolBarButton tBB_custom_check;
        private System.Windows.Forms.ToolBarButton tBB_configure;
        private System.Windows.Forms.ToolBarButton tBB_normal_question;
        private System.Windows.Forms.ImageList toolbar_imglist;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        internal System.Windows.Forms.ToolBar toolBar_main;
        private System.Windows.Forms.ToolBarButton toolBarButton1;
        private System.Windows.Forms.ToolBarButton toolBarButton2;
        private System.Windows.Forms.ToolBarButton toolBarButton3;
        private System.Windows.Forms.Panel panel_body;

    }
}

