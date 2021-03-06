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
    public partial class CajaSueldos : Form
    {
        public static int sueldoCajere = 0;
        public static int sueldoPlanchere = 0;
        static String nombreC = "";
        static String nombreP = "";
        static String rutC = "";
        static String rutP = "";
        public CajaSueldos()
        {
            InitializeComponent();

            //Datos de conexión a BD
            NpgsqlConnection conn1 = new NpgsqlConnection("Server = localhost; Port = 5432; User Id = postgres; Password = TomiMati2005; Database = Rava");
            //Abrir BD
            conn1.Open();
            //Crear objeto de comandos
            NpgsqlCommand comm1 = new NpgsqlCommand();
            //Crear objeto conexión
            comm1.Connection = conn1;
            comm1.CommandType = CommandType.Text;
            //Consulta 
            comm1.CommandText="SELECT rut, puesto FROM turno WHERE fecha = '"+DTP_CajaSueldos.Value.ToString("d")+"'";
            NpgsqlDataReader dr1 = comm1.ExecuteReader();
            while (dr1.Read())
            {
                if (dr1.GetString(1).Equals("Caja"))//Equals equivale a == 
                {
                    cBoxRutCajero.Items.Add(dr1.GetString(0));
                }
                if (dr1.GetString(1) == "Plancha")
                {
                    cBoxRutPlanchero.Items.Add(dr1.GetString(0));
                }
            }
            //Cerrar comandos
            comm1.Dispose();
            //Desconectar BD
            conn1.Close();
            txtValorHoraC.Text = "1500";
            txtValorHoraP.Text = "1700";
            //MessageBox.Show("Esta persona no ha cerrado su turno!!!\nPor favor, cierre su turno ", "No se sabe la hora de salida", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Caja c = new Caja();
            try
            {
                sueldoPlanchere = (int)(float.Parse(txtTotalHorasP.Text) * int.Parse(txtValorHoraP.Text));
                txtTotalP.Text = sueldoPlanchere + "";
                sueldoCajere = (int)((float.Parse(txtTotalHorasC.Text) * int.Parse(txtValorHoraC.Text)));
                txtTotalC.Text = sueldoCajere + "";
                if (cBoxRutPlanchero.SelectedItem != null)
                {
                    rutP = cBoxRutPlanchero.SelectedItem.ToString();
                }
                if (cBoxRutCajero.SelectedItem != null) { 
                rutC = cBoxRutCajero.SelectedItem.ToString();
                }
                nombreC = labelNombreCajero.Text;
                nombreP = labelNombrePlanchero.Text;
                c.Show();
                this.Close();
            }
            catch (FormatException)
            {
                MessageBox.Show("Falta un dato importante!!!\nPor favor, revise las casillas ", "Falta datos!!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void cBoxRutCajero_SelectedIndexChanged(object sender, EventArgs e)
        {

            //Datos de conexión a BD
            NpgsqlConnection conn = new NpgsqlConnection("Server = localhost; Port = 5432; User Id = postgres; Password = TomiMati2005; Database = Rava");
            //Abrir BD
            conn.Open();
            //Crear objeto de comandos
            NpgsqlCommand comm = new NpgsqlCommand();
            //Crear objeto conexión
            comm.Connection = conn;
            //No se que hace xd
            comm.CommandType = CommandType.Text;
            //Consulta
            //Realiza la consulta si los datos ingresados por el textbox son iguales a las que están en la BD
            comm.CommandText = "SELECT hora_ingreso, hora_salida, puesto, rut, fecha FROM turno WHERE rut ='" + cBoxRutCajero.SelectedItem.ToString() + "' and puesto = 'Caja'";
            NpgsqlDataReader dr = comm.ExecuteReader();
            if (dr.Read())
            {
                if (dr.GetString(4) == DTP_CajaSueldos.Value.ToString("d"))
                {
                    
                    txtHoraIngresoC.Text = dr.GetString(0);
                    txtHoraSalidaC.Text = dr.GetString(1);
                    labelNombreCajero.Text = getNombrePersona(dr.GetString(3));
                }
            }
            //Cerrar comandos
            comm.Dispose();
            //Desconectar BD
            conn.Close();

            String fechaH1 = DTP_CajaSueldos.Value.ToString("d") + ' ' + txtHoraIngresoC.Text;
            String fechaH2 = DTP_CajaSueldos.Value.ToString("d") + ' ' + txtHoraSalidaC.Text;
            try
            {
                DateTime horaInicioCaja = DateTime.Parse(fechaH1);
                DateTime horaFinalCaja = DateTime.Parse(fechaH2);
            }
            catch (FormatException)
            {
                MessageBox.Show("Esta persona no ha cerrado su turno!!!\nPor favor, cierre su turno ", "No se sabe la hora de salida", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            }

            
        }

        private void cBoxRutPlanchero_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Datos de conexión a BD
            NpgsqlConnection conn = new NpgsqlConnection("Server = localhost; Port = 5432; User Id = postgres; Password = TomiMati2005; Database = Rava");
            //Abrir BD
            conn.Open();
            //Crear objeto de comandos
            NpgsqlCommand comm = new NpgsqlCommand();
            //Crear objeto conexión
            comm.Connection = conn;
            //No se que hace xd
            comm.CommandType = CommandType.Text;
            //Consulta
            comm.CommandText=("SELECT hora_ingreso, hora_salida, puesto, rut, fecha FROM turno WHERE rut ='" + cBoxRutPlanchero.SelectedItem.ToString() + "'AND puesto = 'Plancha'");
            NpgsqlDataReader dr = comm.ExecuteReader();
            if (dr.Read())
            {
                if (dr.GetString(4) == DTP_CajaSueldos.Value.ToString("d"))
                {
                    txtHoraIngresoP.Text = dr.GetString(0);
                    txtHoraSalidaP.Text = dr.GetString(1);
                    labelNombrePlanchero.Text = getNombrePersona(dr.GetString(3));
                }
            }
            //Cerrar comandos
            comm.Dispose();
            //Desconectar BD
            conn.Close();

            String fechaH1 = DTP_CajaSueldos.Value.ToString("d") + ' ' + txtHoraIngresoP.Text;
            String fechaH2 = DTP_CajaSueldos.Value.ToString("d") + ' ' + txtHoraSalidaP.Text;
            try
            {
                DateTime horaInicioPlancha = DateTime.Parse(fechaH1);
                DateTime horaFinalPlancha = DateTime.Parse(fechaH2);
           
            }
            catch(FormatException)
            {
                MessageBox.Show("Esta persona no ha cerrado su turno!!!\nPor favor, cierre su turno ","No se sabe la hora de salida", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            }
            

        }
        public int getSueldoCajero()
        {
            return sueldoCajere;
        }
        public int getSueldoPlanchero()
        {
            return sueldoPlanchere;
        }
        private String getNombrePersona(String rut)
        {
            String nombre = "";
            //Datos de conexión a BD
            NpgsqlConnection conn = new NpgsqlConnection("Server = localhost; Port = 5432; User Id = postgres; Password = TomiMati2005; Database = Rava");
            //Abrir BD
            conn.Open();
            //Crear objeto de comandos
            NpgsqlCommand comm = new NpgsqlCommand();
            //Crear objeto conexión
            comm.Connection = conn;
            //No se que hace xd
            comm.CommandType = CommandType.Text;
            //Consulta
            //Realiza la consulta si los datos ingresados por el textbox son iguales a las que están en la BD
            comm.CommandText = ("SELECT nombre FROM usuarios WHERE  rut = '" + rut + "'");
            NpgsqlDataReader dr = comm.ExecuteReader();
            if (dr.Read())
            {
                nombre = dr.GetString(0);
            }
            //Cerrar comandos
            comm.Dispose();
            //Desconectar BD
            conn.Close();
            return nombre;
        }
        public String getRutPlanchero()
        {
            return rutP;
        }

        public String getNombrePlanchero()
        {
            return nombreP;
        }

        public String getRutCajero()
        {
            return rutC;
        }

        public String getNombreCajero()
        {
            return nombreC;
        }

        private void DTP_CajaSueldos_ValueChanged(object sender, EventArgs e)
        {
            cBoxRutCajero.Items.Clear();
            cBoxRutPlanchero.Items.Clear();
            //Datos de conexión a BD
            NpgsqlConnection conn1 = new NpgsqlConnection("Server = localhost; Port = 5432; User Id = postgres; Password = TomiMati2005; Database = Rava");
            //Abrir BD
            conn1.Open();
            //Crear objeto de comandos
            NpgsqlCommand comm1 = new NpgsqlCommand();
            //Crear objeto conexión
            comm1.Connection = conn1;
            comm1.CommandType = CommandType.Text;
            //Consulta 
            comm1.CommandText = "SELECT rut, puesto FROM turno WHERE fecha = '" + DTP_CajaSueldos.Value.ToString("d") + "'";
            NpgsqlDataReader dr1 = comm1.ExecuteReader();
            while (dr1.Read())
            {
                if (dr1.GetString(1).Equals("Caja"))//Equals equivale a == 
                {
                    cBoxRutCajero.Items.Add(dr1.GetString(0));
                }
                if (dr1.GetString(1) == "Plancha")
                {
                    cBoxRutPlanchero.Items.Add(dr1.GetString(0));
                }
            }
            //Cerrar comandos
            comm1.Dispose();
            //Desconectar BD
            conn1.Close();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Caja c = new Caja();
            c.Show();
            this.Close();
        }
    }
}
