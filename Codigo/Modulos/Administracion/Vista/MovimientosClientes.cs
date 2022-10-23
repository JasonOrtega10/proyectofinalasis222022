﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComprasVista
{
    public partial class MovimientosClientes : Form
    {
        ComprasControlador.csContralador AdminCn = new ComprasControlador.csContralador();
        public MovimientosClientes()
        {
            InitializeComponent();
        }

        public DataGridView tabla;

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        public void limpiar()
        {
            txtIdCliente.Text = " ";

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            string texto = txtIdCliente.Text;
            if (texto == "")
            {
                string message = "Debe Ingresar un ID Usuario";
                MessageBox.Show(message);
            }
            else
            {
                tabla = Dgv_MovimientoCliente;
                AdminCn.fillTableMovClient(tabla.Tag.ToString(), Dgv_MovimientoCliente, "FkId_Clientes", txtIdCliente.Text);

            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}
