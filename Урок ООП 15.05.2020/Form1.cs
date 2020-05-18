using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Урок_ООП_15._05._2020
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (button2.Location.X - 10 > 0) button2.Location = new Point(button2.Location.X - 10, button2.Location.Y);
            else if (button2.Location.X - 10 > - 10) button2.Location = new Point(0, button2.Location.Y);
            else button2.Location = new Point(Size.Width - button2.Size.Width - 17, button2.Location.Y); 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button2.Location.X + 10 < Size.Width - button2.Size.Width - 17) button2.Location = new Point(button2.Location.X + 10, button2.Location.Y);
            else button2.Location = new Point(Size.Width - button2.Size.Width - 17, button2.Location.Y);
        }
    }
}
