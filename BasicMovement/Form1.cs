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
        private int _x;
        private int _y;
        private Position _objPosition;

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

        private void timer1_Tick(object sender, EventArgs e)
        {
            //_x += 2;
            //if (_x >= 500)
            //{
            //    _y += 2;
            //}
            if (_objPosition == Position.Kanan)
            {
                _x += 3;
            }
            else if (_objPosition == Position.Kiri)
            {
                _x -= 3;

            }
            else if (_objPosition == Position.Atas)
            {
                _y += 3;
            }
            else if (_objPosition == Position.Bawah)
            {
                _y -= 3;
            }

            Invalidate();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                _objPosition = Position.Kiri;

            }
            else if (e.KeyCode == Keys.Right)
            {
                _objPosition = Position.Kanan;
            }
            else if (e.KeyCode == Keys.Up)
            {
                _objPosition = Position.Atas;
            }
            else if (e.KeyCode == Keys.Down)
            {
                _objPosition = Position.Bawah;
            }
        }
    }
}
