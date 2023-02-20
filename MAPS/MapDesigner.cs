using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Caster
{
    public partial class MapDesigner : Form
    {
        static Map map;
        private Bitmap bmp;
        static Graphics g;
        static bool isMouseDown;
        static Brush brush, eraser;
        Color c;
        string tmp;
        static char token;
        
        public MapDesigner()
        {
            InitializeComponent();
            map = new Map(new char[25, 25]);
            Init();
        }

        private void Init()
        {
            token               = '1';
          
            isMouseDown         = false;
            bmp                 = new Bitmap(PCT_CANVAS.Width, PCT_CANVAS.Height);
            PCT_CANVAS.Image    = bmp;
            g                   = Graphics.FromImage(bmp);
            brush               = new SolidBrush(Color.FromArgb(0, 255, 255));
            eraser              = new SolidBrush(Color.FromArgb(50, 50, 50));
            
            for (int x = 0; x < 25; x++)
                for (int y = 0; y < 25; y++)
                {
                    InitRectangle(x, y);
                }

            g.DrawRectangle(Pens.Gray, 0, 0, bmp.Width - 1, bmp.Height - 1);
            CHK_BOX.Select();
        }

        private void InitRectangle(int x, int y)
        {
            char c = map.map[x, y];   

            if(c=='0')
                g.FillRectangle(eraser, x * 10, y * 10, 10, 10);
            else
                g.FillRectangle(brush, x * 10, y * 10, 10, 10);

            g.DrawRectangle(Pens.Gray, x * 10, y * 10, 10, 10);
        }

        private void PCT_CANVAS_MouseMove(object sender, MouseEventArgs e)
        {
            Point p = new Point(e.X / 10, e.Y / 10);
            if (isMouseDown)
            {
                PaintEwct(p, brush);
            }
            LBL_STATUS.Text = "X:" + p.X + "  Y:" + p.Y;
        }

        private void PCT_CANVAS_MouseDown(object sender, MouseEventArgs e)
        {
            isMouseDown = true;
        }

        private void PCT_CANVAS_MouseUp(object sender, MouseEventArgs e)
        {
            isMouseDown = false;
        }

        private void PCT_CANVAS_MouseClick(object sender, MouseEventArgs e)
        {
            PaintEwct(new Point(e.X / 10, e.Y / 10), brush);
        }

        private void PaintEwct(Point p,Brush brush)
        {
            if (p.X > 25 || p.Y > 25)
                return;

            if (!CHK_BOX.Checked)
            {
                map.map[p.X, p.Y] = token;
                g.FillRectangle(brush, p.X * 10, p.Y * 10, 10, 10);
                PCT_CANVAS.Invalidate(new Rectangle(p.X * 10, p.Y * 10, 10, 10), true);
            }
            else
            {
                InitRectangle(p.X, p.Y);
                PCT_CANVAS.Invalidate(new Rectangle(p.X * 10, p.Y * 10, 10, 10), true);
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {         
            switch (keyData)
            {
                case Keys.E:                    
                    CHK_BOX.Select();                                   
                    CHK_BOX.Checked = !CHK_BOX.Checked;
                    TXT_R.Text = tmp;
                    break;
                case Keys.C:
                    TXT_R.Select();
                    TXT_R.Text = tmp;                                      
                    break;
            }              

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void CHK_BOX_CheckStateChanged(object sender, EventArgs e)
        {
            TXT_R.Text = tmp;
        }

        private void BTN_SAVE_Click(object sender, EventArgs e)
        {
            map.Save();
        }

        private void BTN_OPEN_Click(object sender, EventArgs e)
        {
            map = new Map("mtx.mx");
            Init();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int r, g, b;

            r = int.Parse(TXT_R.Text);
            g = int.Parse(TXT_G.Text);
            b = int.Parse(TXT_B.Text);

            c = Color.FromArgb(r, g, b);
            brush = new SolidBrush(c);
            PCT_PICKER.BackColor = c;
            token = char.Parse(TXT_TOKEN.Text);
            tmp = TXT_R.Text;
        }

        /*
        protected override bool ProcessKeyPreview(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_KEYDOWN:
                    //LBL_STATUS.Text = "key down" + m.LParam;
                    break;

                case WM_KEYUP:
                    //LBL_STATUS.Text = "key up " + m.LParam;
                    break;
            }
            /*
            isCtrl = IsControlDown();
            return base.ProcessKeyPreview(ref m);
        }//*/
    }
}
