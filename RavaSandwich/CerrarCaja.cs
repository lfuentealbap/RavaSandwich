﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Npgsql;

namespace RavaSandwich
{
    public partial class CerrarCaja : Form
    {
        int aux = 0;
        public CerrarCaja()
        {
            InitializeComponent();
            //Carga los valores guardados de los otros form
            Caja c = new Caja();
            txtDineroCaja.Text = c.getDineroEnCaja() + "";
            txtDineroFisico.Text = c.getDineroFisico() + "";

            aux = c.getDineroFisico() - c.getDineroEnCaja();
            txtCuadre.Text = aux + "";

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            String fechaHora = DateTime.Now.ToString("d");
            Caja c = new Caja();
            CajaGastos g = new CajaGastos();

            //Datos de conexión a BD
            NpgsqlConnection conn = new NpgsqlConnection("Server = localhost; Port = 5432; User Id = postgres; Password = censurado; Database = Rava_Sandwich");
            //Abrir BD
            conn.Open();
            //Crear objeto de comandos
            NpgsqlCommand comm = new NpgsqlCommand();
            //Crear objeto conexión
            comm.Connection = conn;
            //No se que hace xd
            comm.CommandType = CommandType.Text;
            //Actualiza el producto
            comm.CommandText = "INSERT into caja VALUES (fecha, rut_planchero, nombre_planchero, rut_cajero, nombre_cajero, cuadre_caja, total_ventas, descripcion_gasto, gasto, sueldo_cajero, sueldo_planchero, billetes_monedas )" +
                            "VALUES('" + fechaHora + "',rut_planchero, nombre_planchero, rut_cajero, nombre_cajero," + aux + "," + c.getTotalVenta() + ",'" + g.getDescripcionGastos() + "'," + g.getTotalGastos() + ", sueldo_cajero, sueldo_planchero," + b.getTotal() + ")";            //Leer BD
            NpgsqlDataReader dr = comm.ExecuteReader();
            MessageBox.Show("Se ha cerrado la caja", "Caja cerrada", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            //Cerrar comandos
            comm.Dispose();
            //Desconectar BD
            conn.Close();
            GestionarPersonal gp = new GestionarPersonal();
            gp.Show();
            this.Close();

        }
    }
}
