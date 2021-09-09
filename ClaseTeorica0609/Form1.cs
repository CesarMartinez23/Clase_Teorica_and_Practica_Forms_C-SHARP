using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClaseTeorica0609
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Evento load() inicia cuando se ejecuta la acción, sera el primer metodo leido dentro de la ejecución.
        private void Form1_Load(object sender, EventArgs e)
        {
            //Esta orientado a eventos y a objetos.
            //Objeto- elemento al que puedo modificar, se puede trabajar con el
            //los metodos-serian los evento.

            MessageBox.Show("Programación Computacional I");
        }
        //Evento Click(); se ejecutan cuando damos click sobre el objeto
        private void btnClic_Click(object sender, EventArgs e)
        {
            //declarar un arreglo de numero(coleccion)
            int[] nums = new int[] { 8, 9, 4, 6, 7, 10, 7, 8 };
            //llenar el listbox
            var num = from n in nums select n; //usamos sintaxis Linw para leer el arreglo.
            foreach (int i in num)
                lstData.Items.Add(i); //llenamos listbox
        }
    }
}