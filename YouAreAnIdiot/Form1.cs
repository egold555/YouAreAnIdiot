using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YouAreAnIdiot
{
    public partial class Form1 : Form
    {
        Random random = new Random();

        public Form1()
        {
            InitializeComponent();
            webBrowser1.Url = new Uri (Path.GetFullPath("youare.swf"));
            //webBrowser1.WebBrowserShortcutsEnabled = false;
            this.Focus();
            webBrowser1.PreviewKeyDown += new PreviewKeyDownEventHandler(webBrowser1_PreviewKeyDown);

        }

       
        private void webBrowser1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.A)
            {
                Environment.Exit(0);
            }

            //MessageBox.Show("You Are an Idiot!");
            new Form1().Show();
        }

        

        private void timer1_Tick(object sender, EventArgs e)
        {
            int width = Screen.PrimaryScreen.WorkingArea.Width;
            int height = Screen.PrimaryScreen.WorkingArea.Height;
            int x = random.Next(width);
            int y = random.Next(height);
            int wx = random.Next(width / 2);
            int wy = random.Next(height / 2);

            this.Left = x;
            this.Top = y;
            this.Width = wx;
            this.Height = wx;
            //form.Show();
            //new Form1().Show();

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            new Form1().Show();
            
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            MessageBox.Show("You Are an Idiot!");
        }
    }
}
