using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio101
{
    public partial class frm2 : Form
    {
        public frm2()
        {
            InitializeComponent();
        }

        public frm2(string nombre, string apellido, string materia)
        :this()
        {
            if (string.IsNullOrEmpty(nombre) && string.IsNullOrEmpty(apellido))
            {
                MessageBox.Show("se debe ingresar los siguientes campos \nNombre \nApellido","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (string.IsNullOrWhiteSpace(nombre))
                {
                    MessageBox.Show("se deb ingresar los siguientes campos \nNombre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    if (string.IsNullOrEmpty(apellido))
                    {
                        MessageBox.Show("se debe ingresar los siguientes campos \nApellido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {

                        string frase = $"soy {nombre} {apellido} y mi materia favorita es {materia}";
                        lbNombreMateria.Text = frase;
                    }
                }
            }
      
        }

        private void frm2_Load(object sender, EventArgs e)
        {
           
        }


    }
}
