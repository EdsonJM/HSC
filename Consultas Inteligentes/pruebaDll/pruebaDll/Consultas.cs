﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pruebaDll
{
    public partial class Consultas : Form
    {
        string usuario = "";
        public Consultas(string user)
        {

            InitializeComponent();
            usuario = user;
            string[] alias = { "Cod Bodega", "Nombre", "Telefono", "Direccion", "Encargado", "Estado" };
            navegador1.asignarAlias(alias);
            navegador1.asignarSalida(this);
            navegador1.asignarColorFondo(Color.White);
            navegador1.asignarColorFuente(Color.Black);
            navegador1.asignarAyuda("1");
            navegador1.asignarTabla("tbl_bodega");
            navegador1.asignarNombreForm("Bodegas");
        }

        private void Consultas_Load(object sender, EventArgs e)
        {
            string aplicacionActiva = "1";
            navegador1.ObtenerIdUsuario(usuario);
            navegador1.botonesYPermisosInicial(usuario, aplicacionActiva);
            navegador1.ObtenerIdAplicacion(aplicacionActiva);
        }

        private void Navegador1_Load(object sender, EventArgs e)
        {

        }
    }
}
