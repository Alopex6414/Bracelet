namespace Bracelet
{
    partial class FormMain
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
            this.FormMain_Panel_Min = new System.Windows.Forms.Panel();
            this.FormMain_Panel_Max = new System.Windows.Forms.Panel();
            this.FormMain_Panel_Close = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // FormMain_Panel_Min
            // 
            this.FormMain_Panel_Min.BackgroundImage = global::Bracelet.Properties.Resources.min;
            this.FormMain_Panel_Min.Location = new System.Drawing.Point(858, 0);
            this.FormMain_Panel_Min.Name = "FormMain_Panel_Min";
            this.FormMain_Panel_Min.Size = new System.Drawing.Size(34, 34);
            this.FormMain_Panel_Min.TabIndex = 2;
            this.FormMain_Panel_Min.Click += new System.EventHandler(this.FormMain_Panel_Min_Click);
            this.FormMain_Panel_Min.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormMain_Panel_Min_MouseDown);
            this.FormMain_Panel_Min.MouseEnter += new System.EventHandler(this.FormMain_Panel_Min_MouseEnter);
            this.FormMain_Panel_Min.MouseLeave += new System.EventHandler(this.FormMain_Panel_Min_MouseLeave);
            this.FormMain_Panel_Min.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FormMain_Panel_Min_MouseUp);
            // 
            // FormMain_Panel_Max
            // 
            this.FormMain_Panel_Max.BackgroundImage = global::Bracelet.Properties.Resources.max;
            this.FormMain_Panel_Max.Location = new System.Drawing.Point(892, 0);
            this.FormMain_Panel_Max.Name = "FormMain_Panel_Max";
            this.FormMain_Panel_Max.Size = new System.Drawing.Size(34, 34);
            this.FormMain_Panel_Max.TabIndex = 1;
            this.FormMain_Panel_Max.Click += new System.EventHandler(this.FormMain_Panel_Max_Click);
            this.FormMain_Panel_Max.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormMain_Panel_Max_MouseDown);
            this.FormMain_Panel_Max.MouseEnter += new System.EventHandler(this.FormMain_Panel_Max_MouseEnter);
            this.FormMain_Panel_Max.MouseLeave += new System.EventHandler(this.FormMain_Panel_Max_MouseLeave);
            this.FormMain_Panel_Max.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FormMain_Panel_Max_MouseUp);
            // 
            // FormMain_Panel_Close
            // 
            this.FormMain_Panel_Close.BackgroundImage = global::Bracelet.Properties.Resources.close;
            this.FormMain_Panel_Close.Location = new System.Drawing.Point(926, 0);
            this.FormMain_Panel_Close.Name = "FormMain_Panel_Close";
            this.FormMain_Panel_Close.Size = new System.Drawing.Size(34, 34);
            this.FormMain_Panel_Close.TabIndex = 0;
            this.FormMain_Panel_Close.Click += new System.EventHandler(this.FormMain_Panel_Close_Click);
            this.FormMain_Panel_Close.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormMain_Panel_Close_MouseDown);
            this.FormMain_Panel_Close.MouseEnter += new System.EventHandler(this.FormMain_Panel_Close_MouseEnter);
            this.FormMain_Panel_Close.MouseLeave += new System.EventHandler(this.FormMain_Panel_Close_MouseLeave);
            this.FormMain_Panel_Close.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FormMain_Panel_Close_MouseUp);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 720);
            this.Controls.Add(this.FormMain_Panel_Min);
            this.Controls.Add(this.FormMain_Panel_Max);
            this.Controls.Add(this.FormMain_Panel_Close);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FormMain_Paint);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel FormMain_Panel_Close;
        private System.Windows.Forms.Panel FormMain_Panel_Max;
        private System.Windows.Forms.Panel FormMain_Panel_Min;
    }
}

