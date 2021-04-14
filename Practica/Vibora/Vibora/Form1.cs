using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Vibora
{
    public partial class Form1 : Form
    {
        private enum TDireccion { izquierda, derecha, arriba, abajo };
        private TDireccion Direccion { get; set; } = TDireccion.derecha;
        private LinkedList<Punto> lista1 = new LinkedList<Punto>();
        private Punto Fruta { get; set; } = new Punto(10, 10);
        private int Pendientes { get; set; } = 0;

        public Form1()
        {
            InitializeComponent();
            lista1.AddFirst(new Punto(0, 0));
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Direccion == TDireccion.derecha)
                lista1.AddFirst(new Punto(lista1.First.Value.X + 1, lista1.First.Value.Y));
            if (Direccion == TDireccion.izquierda)
                lista1.AddFirst(new Punto(lista1.First.Value.X - 1, lista1.First.Value.Y));
            if (Direccion == TDireccion.arriba)
                lista1.AddFirst(new Punto(lista1.First.Value.X, lista1.First.Value.Y - 1));
            if (Direccion == TDireccion.abajo)
                lista1.AddFirst(new Punto(lista1.First.Value.X, lista1.First.Value.Y + 1));
            SaleMapa();
            SePisa();
            TocaFruta();
            RemoverCola();
            Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            foreach (var ele in lista1)
                e.Graphics.FillRectangle(new SolidBrush(Color.Red), ele.X * 10, ele.Y * 10, 9, 9);
            e.Graphics.FillRectangle(new SolidBrush(Color.Green), Fruta.X * 10, Fruta.Y * 10, 9, 9);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
                Direccion = TDireccion.derecha;
            if (e.KeyCode == Keys.Left)
                Direccion = TDireccion.izquierda;
            if (e.KeyCode == Keys.Up)
                Direccion = TDireccion.arriba;
            if (e.KeyCode == Keys.Down)
                Direccion = TDireccion.abajo;
        }

        private void TocaFruta()
        {
            if (lista1.First.Value.X == Fruta.X && lista1.First.Value.Y == Fruta.Y)
            {
                Pendientes = 5;
                Fruta.X = new Random().Next(1, 40);
                Fruta.Y = new Random().Next(1, 40);
            }
        }

        private void RemoverCola()
        {
            if (Pendientes == 0)
                lista1.RemoveLast();
            else
                Pendientes--;
        }

        private void SaleMapa()
        {
            if (lista1.First.Value.X == -1 || lista1.First.Value.Y == -1 ||
                lista1.First.Value.X == 40 || lista1.First.Value.Y == 40)
            {
                timer1.Enabled = false;
                MessageBox.Show("Perdio");
            }
        }

        private void SePisa()
        {
            foreach(var ele in lista1)
            {
                if (lista1.First.Value!=ele)
                    if (ele.X==lista1.First.Value.X &&
                        ele.Y==lista1.First.Value.Y)
                    {
                        timer1.Enabled = false;
                        MessageBox.Show("Perdio");
                    }
            }
        }


    }

    public class Punto
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Punto(int x, int y)
        {
            X = x;
            Y = y;
        }
    }

}
