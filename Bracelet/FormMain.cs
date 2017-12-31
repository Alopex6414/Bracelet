using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Microsoft.Win32;

namespace Bracelet
{
    public partial class FormMain : Form
    {
        [DllImport("User32", EntryPoint = "GetSystemMetrics")]
        private static extern int GetSystemMetrics(int nIndex);
        [DllImport("User32", EntryPoint = "SetWindowPos")]
        private static extern int SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, int uFlags);

        #region 窗口初始化函数
        public FormMain()
        {
            InitializeComponent();
        }
        #endregion

        #region 窗口加载函数
        private void FormMain_Load(object sender, EventArgs e)
        {
            FormMain_InitWindow();//窗口位置初始化
        }
        #endregion

        #region 窗口位置初始化函数
        private void FormMain_InitWindow()
        {
            int nX = 0;
            int nY = 0;
            int nScreenWidth = 0;
            int nScreenHeight = 0;

            this.Width = 960;   //窗口宽度
            this.Height = 720;  //窗口高度

            nScreenWidth = GetSystemMetrics(0);     //屏幕宽度
            nScreenHeight = GetSystemMetrics(1);    //屏幕高度

            if(nScreenWidth >= this.Width && nScreenHeight >= this.Height)
            {
                nX = (nScreenWidth - this.Width) >> 1;
                nY = (nScreenHeight - this.Height) >> 1;
                SetWindowPos(this.Handle, (IntPtr)0, nX, nY, this.Width, this.Height, 64);  //设置窗口初始位置
            }

            this.DoubleBuffered = true; //窗口双缓冲
            this.FormBorderStyle = FormBorderStyle.FixedSingle; //窗口禁止改变大小
            this.MaximizeBox = false; //窗体禁止最大化
        }
        #endregion
    }
}
