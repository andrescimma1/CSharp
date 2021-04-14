using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProblemaPila1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Stack<char> pila1;
            pila1 = new Stack<char>();
            string cadena = textBox1.Text;
            for (int f = 0; f < cadena.Length; f++)
            {
                if (cadena.ElementAt(f) == '(' || cadena.ElementAt(f) == '[' || cadena.ElementAt(f) == '{')
                {
                    pila1.Push(cadena.ElementAt(f));
                }
                else
                {
                    if (cadena.ElementAt(f) == ')')
                    {
                        if (pila1.Count == 0 || pila1.Pop() != '(')
                        {
                            Text = "Incorrecta";
                            return;
                        }
                    }
                    else
                    {
                        if (cadena.ElementAt(f) == ']')
                        {
                            if (pila1.Count == 0 || pila1.Pop() != '[')
                            {
                                Text = "Incorrecta";
                                return;
                            }
                        }
                        else
                        {
                            if (cadena.ElementAt(f) == '}')
                            {
                                if (pila1.Count == 0 || pila1.Pop() != '{')
                                {
                                    Text = "Incorrecta";
                                    return;
                                }
                            }
                        }
                    }
                }
            }
            if (pila1.Count == 0)
            {
                Text = "Correcta";
            }
            else
            {
                Text = "Incorrecta";
            }
        }
    }
}
