namespace jianyi_winform
{
    partial class ConfigureFrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tb_m_code = new System.Windows.Forms.TextBox();
            this.lab_m_code = new System.Windows.Forms.Label();
            this.lab_sigin_pub_code = new System.Windows.Forms.Label();
            this.bt_server_url = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_save = new System.Windows.Forms.Button();
            this.rtb_sign_pub_key = new System.Windows.Forms.RichTextBox();
            this.lab_server_url = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tb_m_code, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lab_m_code, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lab_sigin_pub_code, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.bt_server_url, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.rtb_sign_pub_key, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lab_server_url, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 309F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(863, 566);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tb_m_code
            // 
            this.tb_m_code.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_m_code.Location = new System.Drawing.Point(435, 45);
            this.tb_m_code.Name = "tb_m_code";
            this.tb_m_code.Size = new System.Drawing.Size(424, 21);
            this.tb_m_code.TabIndex = 5;
            // 
            // lab_m_code
            // 
            this.lab_m_code.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lab_m_code.AutoSize = true;
            this.lab_m_code.Location = new System.Drawing.Point(192, 66);
            this.lab_m_code.Name = "lab_m_code";
            this.lab_m_code.Size = new System.Drawing.Size(47, 12);
            this.lab_m_code.TabIndex = 1;
            this.lab_m_code.Text = "机器码:";
            this.lab_m_code.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // lab_sigin_pub_code
            // 
            this.lab_sigin_pub_code.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lab_sigin_pub_code.AutoSize = true;
            this.lab_sigin_pub_code.Location = new System.Drawing.Point(186, 252);
            this.lab_sigin_pub_code.Name = "lab_sigin_pub_code";
            this.lab_sigin_pub_code.Size = new System.Drawing.Size(59, 12);
            this.lab_sigin_pub_code.TabIndex = 2;
            this.lab_sigin_pub_code.Text = "加密钥串:";
            // 
            // bt_server_url
            // 
            this.bt_server_url.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bt_server_url.Location = new System.Drawing.Point(435, 4);
            this.bt_server_url.Name = "bt_server_url";
            this.bt_server_url.Size = new System.Drawing.Size(424, 21);
            this.bt_server_url.TabIndex = 4;
            // 
            // panel1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.panel1, 2);
            this.panel1.Controls.Add(this.btn_save);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(4, 417);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(855, 145);
            this.panel1.TabIndex = 7;
            // 
            // btn_save
            // 
            this.btn_save.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_save.Location = new System.Drawing.Point(345, 44);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(136, 52);
            this.btn_save.TabIndex = 0;
            this.btn_save.Text = "保存配置";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // rtb_sign_pub_key
            // 
            this.rtb_sign_pub_key.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rtb_sign_pub_key.Location = new System.Drawing.Point(439, 165);
            this.rtb_sign_pub_key.Name = "rtb_sign_pub_key";
            this.rtb_sign_pub_key.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Horizontal;
            this.rtb_sign_pub_key.Size = new System.Drawing.Size(415, 186);
            this.rtb_sign_pub_key.TabIndex = 8;
            this.rtb_sign_pub_key.Text = "请输入加密钥串";
            // 
            // lab_server_url
            // 
            this.lab_server_url.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lab_server_url.AutoSize = true;
            this.lab_server_url.Location = new System.Drawing.Point(180, 15);
            this.lab_server_url.Name = "lab_server_url";
            this.lab_server_url.Size = new System.Drawing.Size(71, 12);
            this.lab_server_url.TabIndex = 0;
            this.lab_server_url.Text = "服务器地址:";
            // 
            // ConfigureFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 566);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ConfigureFrm";
            this.Text = "配置";
            this.Load += new System.EventHandler(this.ConfigureFrm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lab_server_url;
        private System.Windows.Forms.Label lab_m_code;
        private System.Windows.Forms.Label lab_sigin_pub_code;
        private System.Windows.Forms.TextBox bt_server_url;
        private System.Windows.Forms.TextBox tb_m_code;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.RichTextBox rtb_sign_pub_key;

    }
}