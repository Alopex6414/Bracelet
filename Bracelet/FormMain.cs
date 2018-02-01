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

        private Rectangle m_MainRect;       //窗口矩形区域
        private Rectangle m_ToolRect;       //窗口工具栏矩形区域

        #region 窗口初始化函数
        public FormMain()
        {
            InitializeComponent();//窗口初始化(Native)
        }
        #endregion

        #region 窗口加载函数
        private void FormMain_Load(object sender, EventArgs e)
        {
            FormMain_InitWindow();//窗口位置形状初始化
            FormMain_InitWindowTool();//窗口工具栏形状初始化
            FormMain_InitWindowAttribute();//窗口属性初始化
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

            m_MainRect.X = 0;
            m_MainRect.Y = 0;
            m_MainRect.Width = this.Width;
            m_MainRect.Height = this.Height;
        }
        #endregion

        #region 窗口工具栏形状初始化
        private void FormMain_InitWindowTool()
        {
            m_ToolRect.X = m_MainRect.X;
            m_ToolRect.Y = m_MainRect.Y;
            m_ToolRect.Width = 64;
            m_ToolRect.Height = m_MainRect.Height;
        }
        #endregion

        #region 窗口属性初始化
        private void FormMain_InitWindowAttribute()
        {
            this.DoubleBuffered = true; //窗口双缓冲
            this.FormBorderStyle = FormBorderStyle.None; //窗口无边框
            this.MaximizeBox = false; //窗体禁止最大化
        }
        #endregion

        #region 窗口样式初始化设置函数
        private void FormMain_SetWindowStyle()
        {

        }
        #endregion

        #region 窗口重绘
        private void FormMain_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            SolidBrush SolidBrushMain = new SolidBrush(Color.FromArgb(245, 245, 245));
            SolidBrush SolidBrushTool = new SolidBrush(Color.FromArgb(39, 42, 47));

            graphics.FillRectangle(SolidBrushMain, m_MainRect);
            graphics.FillRectangle(SolidBrushTool, m_ToolRect);
        }
        #endregion

        #region 关闭按钮
        //FormMain_Panel_Close进入
        private void FormMain_Panel_Close_MouseEnter(object sender, EventArgs e)
        {
            this.FormMain_Panel_Close.BackgroundImage = Properties.Resources.close_hor;
        }

        //FormMain_Panel_Close离开
        private void FormMain_Panel_Close_MouseLeave(object sender, EventArgs e)
        {
            this.FormMain_Panel_Close.BackgroundImage = Properties.Resources.close;
        }

        //FormMain_Panel_Close按下
        private void FormMain_Panel_Close_MouseDown(object sender, MouseEventArgs e)
        {
            this.FormMain_Panel_Close.BackgroundImage = Properties.Resources.close_focus;
        }

        //FormMain_Panel_Close释放
        private void FormMain_Panel_Close_MouseUp(object sender, MouseEventArgs e)
        {
            this.FormMain_Panel_Close.BackgroundImage = Properties.Resources.close_hor;
        }

        //FormMain_Panel_Close单击
        private void FormMain_Panel_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region 最大化按钮
        //FormMain_Panel_Max进入
        private void FormMain_Panel_Max_MouseEnter(object sender, EventArgs e)
        {
            this.FormMain_Panel_Max.BackgroundImage = Properties.Resources.max_hor;
        }

        //FormMain_Panel_Max离开
        private void FormMain_Panel_Max_MouseLeave(object sender, EventArgs e)
        {
            this.FormMain_Panel_Max.BackgroundImage = Properties.Resources.max;
        }

        //FormMain_Panel_Max按下
        private void FormMain_Panel_Max_MouseDown(object sender, MouseEventArgs e)
        {
            this.FormMain_Panel_Max.BackgroundImage = Properties.Resources.max_focus;
        }

        //FormMain_Panel_Max释放
        private void FormMain_Panel_Max_MouseUp(object sender, MouseEventArgs e)
        {
            this.FormMain_Panel_Max.BackgroundImage = Properties.Resources.max_hor;
        }

        //FormMain_Panel_Max单击
        private void FormMain_Panel_Max_Click(object sender, EventArgs e)
        {
           //this.WindowState = FormWindowState.Normal;
        }
        #endregion

        #region 最小化按钮
        //FormMain_Panel_Min进入
        private void FormMain_Panel_Min_MouseEnter(object sender, EventArgs e)
        {
            this.FormMain_Panel_Min.BackgroundImage = Properties.Resources.min_hor;
        }

        //FormMain_Panel_Min离开
        private void FormMain_Panel_Min_MouseLeave(object sender, EventArgs e)
        {
            this.FormMain_Panel_Min.BackgroundImage = Properties.Resources.min;
        }

        //FormMain_Panel_Min按下
        private void FormMain_Panel_Min_MouseDown(object sender, MouseEventArgs e)
        {
            this.FormMain_Panel_Min.BackgroundImage = Properties.Resources.min_focus;
        }

        //FormMain_Panel_Min释放
        private void FormMain_Panel_Min_MouseUp(object sender, MouseEventArgs e)
        {
            this.FormMain_Panel_Min.BackgroundImage = Properties.Resources.min_hor;
        }

        //FormMain_Panel_Min单击
        private void FormMain_Panel_Min_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        #endregion

    }
}
