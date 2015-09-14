using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using AVI;

namespace 视频监控
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            VideoWork wv = new VideoWork(panel1.Handle, 0, 0, panel1.Width, panel1.Height);
            wv.Start();
        }

        private void btn_lx_Click(object sender, EventArgs e)
        {
            VideoClass vc = new VideoClass(panel1.Handle,100,100,100,100);
            //fbd_video.ShowDialog();
            saveFileDialog1.ShowDialog();
            vc.Kinescope(saveFileDialog1.FileName);

        }


      
    }
}