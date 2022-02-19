using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lenguaje_Programacion_3_IPac2022
{
    public partial class Arreglos : Form
    {
        ArrayList NombreAlumnos;
        ArrayList EdadAlumnos;
        public Arreglos()
        {
            InitializeComponent();
            NombreAlumnos = new ArrayList();
            EdadAlumnos = new ArrayList();
        }

       
        //Utilice un ArrayList por que tuve problemas al hacerlo con un arreglo sencillo, el programa funciona bien guarda los datos.
      

        private void Agregarbutton_Click(object sender, EventArgs e)
        {
            NombreAlumnos.Add(NombretextBox.Text);
            EdadAlumnos.Add(Convert.ToInt32(EdadtextBox.Text));
        }

        private void Mostrarbutton_Click(object sender, EventArgs e)
        {
            for (int i=0; i<NombreAlumnos.Count; i++)
            {
                listBox1.Items.Add("El nombre del Alumno es: " + NombreAlumnos[i] + " Edad: " + EdadAlumnos[i] + " Años ");
            }
        }
    }

}
