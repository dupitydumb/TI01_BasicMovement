using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicMovement
{
    public partial class Form1 : Form
    {
        //Deklarasi variabel X dan Y
        private int _x;
        private int _y;

        public Form1()
        {

            InitializeComponent();
            // Initial location
            _x = 50;
            _y = 50;

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            // Object Ractangle Di posisi _x _y dengan ukuran 200
            e.Graphics.FillRectangle(Brushes.DarkMagenta, _x, _y, 100, 100);


        }
    }
}
