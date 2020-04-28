using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pantallas1
{
    public partial class Form1_R : Form
    {
        public Form1_R()
        {
            InitializeComponent();
        }

        private void button2_C_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_Nombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_A_Click(object sender, EventArgs e)
        {
            string nombre = textBox1_Nombre.Text;
            string apellido = textBox2_Apellido.Text;
            int edad = Convert.ToInt32(textBox3_edad.Text);
            int telefono = Convert.ToInt32(textBox4_Telefono.Text);
            string sexo = "";
            DateTime fecha = Convert.ToDateTime(dateTimePicker1.Text);

            foreach(Control control in this.groupBox1.Controls)
            {
                if(control is RadioButton)
                {
                    RadioButton radio = control as RadioButton;

                    if (radio.Checked)
                    {
                        sexo = radio.Text;
                    }
                }
            }

            DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
            row.Cells[0].Value = nombre;
            row.Cells[1].Value = apellido;
            row.Cells[2].Value = edad;
            row.Cells[3].Value = telefono;
            row.Cells[4].Value = sexo;
            row.Cells[5].Value = fecha;

            dataGridView1.Rows.Add(row);

        }

        private void button_L_Click(object sender, EventArgs e)
        {
            Limpiar limpiar = new Limpiar();
            limpiar.borrarCampos(this, groupBox1);
        }
    }
}
