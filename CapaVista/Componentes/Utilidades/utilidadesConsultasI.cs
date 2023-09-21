﻿using CapaControlador;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVista.Componentes.Utilidades
{
    public class utilidadesConsultasI
    {
        public ControladorNavegador ctrNav = new ControladorNavegador();
        public ControladorRegistro ctrReg = new ControladorRegistro();
        public utilidadesConsultasI(ControladorNavegador ctrlNav)
        {
            this.ctrNav = ctrNav;
        }
        public utilidadesConsultasI()
        {
            
        }
        public void guardarReservacion(Form child)
        {
            var dictionary = new Dictionary<string, string>();
            List<string> columns = this.ctrNav.getColumns("empleado");

            foreach (Control c in child.Controls)
            {
                if (c is TextBox)
                {
                    string tag = c.Tag.ToString();
                    if (columns.Contains(tag))
                    {
                        dictionary.Add(tag, c.Text);
                    }
                    c.Text = "";
                }
            }
            this.ctrNav.agregarEmpleado(dictionary);
            MessageBox.Show("Empleado creado");
        }


        public void guardarUsuario(Form child)
        {
            ControladorRegistro ctrol = new ControladorRegistro();
            var dictionary = new Dictionary<string, string>();
            List<string> columns = this.ctrNav.getColumns("usuario");

            foreach (Control c in child.Controls)
            {
                if (c is TextBox)
                {
                    string tag = c.Tag.ToString();
                    if (columns.Contains(tag))
                    {
                        dictionary.Add(tag, c.Text);
                    }
                    c.Text = "";
                }
            }
            ctrol.agregarUsuario(dictionary);
            MessageBox.Show("Usuario Creado Correctamente");
        }
        public void guardarUsuarioNomina(Form child)
        {
            ControladorNomina ctrnomi = new ControladorNomina();
            var dictionary = new Dictionary<string, string>();
            List<string> columns = this.ctrNav.getColumns("tbl_nomina");

            foreach (Control c in child.Controls)
            {
                if (c is TextBox)
                {
                    string tag = c.Tag.ToString();
                    if (columns.Contains(tag))
                    {
                        dictionary.Add(tag, c.Text);
                    }
                    c.Text = "";
                }
            }
            ctrnomi.agregarEmpleado(dictionary);
            MessageBox.Show("Usuario Creado Correctamente");
        }

    }
}
