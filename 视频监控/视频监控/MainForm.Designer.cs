namespace 视频监控
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_start = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_lx = new System.Windows.Forms.Button();
            this.fbd_video = new System.Windows.Forms.FolderBrowserDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(246, 186);
            this.panel1.TabIndex = 0;
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(301, 243);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(75, 23);
            this.btn_start.TabIndex = 1;
            this.btn_start.Text = "开始";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(200, 243);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(75, 23);
            this.btn_close.TabIndex = 2;
            this.btn_close.Text = "停止";
            this.btn_close.UseVisualStyleBackColor = true;
            // 
            // btn_lx
            // 
            this.btn_lx.Location = new System.Drawing.Point(301, 287);
            this.btn_lx.Name = "btn_lx";
            this.btn_lx.Size = new System.Drawing.Size(75, 23);
            this.btn_lx.TabIndex = 3;
            this.btn_lx.Text = "录像";
            this.btn_lx.UseVisualStyleBackColor = true;
            this.btn_lx.Click += new System.EventHandler(this.btn_lx_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 313);
            this.Controls.Add(this.btn_lx);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.panel1);
            this.Name = "MainForm";
            this.Text = "视频监控";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_lx;
        private System.Windows.Forms.FolderBrowserDialog fbd_video;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

