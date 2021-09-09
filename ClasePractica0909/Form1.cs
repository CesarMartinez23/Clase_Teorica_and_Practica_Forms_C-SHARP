using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClasePractica0909
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_getName_Click(object sender, EventArgs e)
        {
            //Llamado al metodo selectName
            selectName();
        }

        //Metodo para obtener los nombres de la coleccion

        private void selectName()
        {
            //Consulta
            List<string> query = (
                from student in Student.GetStudents()
                select student.firstName
                ).ToList();

            foreach(var name in query)
            {
                //Llamar lastNames
                lstNames.Items.Add(name);
            }

        }
        //Boton getData()
        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
