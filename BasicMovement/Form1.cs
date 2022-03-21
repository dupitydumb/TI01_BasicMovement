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
        enum Position
        {
            Atas, Bawah, Kanan, Kiri
        }
        //Deklarasi variabel X dan Y
        //private int _x;
        //private int _y;
        //private int _z;

        // Variabel Point Segitiga
        private int _1x;
        private int _1y;
        private int _2x;
        private int _2y;
        private int _3x;
        private int _3y;
        private Position _objPosition;

        public Form1()
        {

            InitializeComponent();
            // Initial location
            //_x = 150;
            //_y = 100;

            // Posisi titik segitaga
            _1x = 100;
            _1y = 180;
            _2x = 300;
            _2y = 180;
            _3x = 200;
            _3y = 70;


        }


        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            // Object Ractangle Di posisi _x _y dengan ukuran 200
            // e.Graphics.FillRectangle(Brushes.DarkMagenta, _x, _y, 100, 100);

            //Point Array Segitiga
            Point p1 = new Point(_1x, _1y);
            Point p2 = new Point(_2x, _2y);
            Point p3 = new Point(_3x, _3y);

            Point[] pointArray = { p1, p2, p3, };

            e.Graphics.FillPolygon(Brushes.DarkMagenta, pointArray);


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //_x += 2;
            //if (_x >= 500)
            //{
            //    _y += 2;
            //}
            if (_objPosition == Position.Kanan)
            {
                
                _1x += 3;
                _2x += 3;
                _3x += 3;
            }
            else if (_objPosition == Position.Kiri)
            {
                _1x -= 3;
                _2x -= 3;
                _3x -= 3;

            }
            else if (_objPosition == Position.Atas)
            {
                _1y -= 3;
                _2y -= 3;
                _3y -= 3;
            }
            else if (_objPosition == Position.Bawah)
            {
                _1y += 3;
                _2y += 3;
                _3y += 3;
            }

            Invalidate();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
            {
                _objPosition = Position.Kiri;

            }
            else if (e.KeyCode == Keys.D)
            {
                _objPosition = Position.Kanan;
            }
            else if (e.KeyCode == Keys.W)
            {
                _objPosition = Position.Atas;
            }
            else if (e.KeyCode == Keys.S)
            {
                _objPosition = Position.Bawah;
            }
        }
    }
}
