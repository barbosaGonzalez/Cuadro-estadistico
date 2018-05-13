/* 
 * Desarrollado por Edsel Barbosa Gonzalez (torby@outlook.com) 
 *
 * Copyright (C) 2013
 * 
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estadistica
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        //Funcion Verificar donde Compara el Usuario y la Contraseña
        private void Verificar()
        {
            //Compara el usuario y contraseña
            if (txtNombre.Text == "Edsel" && txtContraseña.Text == "e.-94B:_41")   //Si es correcta la comparacion
            {
                frmSecundario frm = new frmSecundario();   //Llama al segundo formulario
                this.Hide();
                frm.ShowDialog();   //Ejecuta el Segundo Formulario sin permitir regresarse al primer formulario
                this.Show();
                txtNombre.Clear();   //Borra lo que tenga la Caja de Texto Nombre
                txtContraseña.Clear();   //Borra lo que tenga la Caja de Texto Contraseña
                //Poner el cursos en el TextBox
                txtNombre.Select();
            }
            else
            {
                MessageBox.Show("Usuario y/o Contraseña Incorrectos");   //Muestra mensaje de error
                txtNombre.Clear();   //Borra lo que tenga la Caja de Texto Nombre
                txtContraseña.Clear();   //Borra lo que tenga la Caja de Texto Contraseña
                //Poner el cursos en el TextBox
                txtNombre.Select();
            }
        }
        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            //Poner el cursos en el TextBox
            txtNombre.Select();
        }

        private void bntLogear_Click(object sender, EventArgs e)
        {
            Verificar();   //Manda llamar a la funcion Verificar
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();   //Cierra la aplicacion
        }

        private void txtContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)   //Si se presiona enter se ejecuta el programa
            {
                Verificar();   //Manda llamar a la funcion Verificar
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Establecer la Fecha y la Hora
            lblHora.Text = DateTime.Now.ToString();
        }
    }
}
