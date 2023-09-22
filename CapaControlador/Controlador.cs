﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaModelo;

namespace CapaControlador
{
    public class Controlador
    {
        public Sentencias sn;
        public string tabla = "david";


        public Controlador()
        {
            this.sn = new Sentencias();
        }
        public void setTabla(string tabla)
        {
            this.tabla = tabla;
            this.sn = new Sentencias(tabla);
        }

        public void guardar(Dictionary<string, string> parameters)
        {
            this.sn.guardar(parameters);
        }
        public List<string> getColumns(string tabla)
        {
            return this.sn.getColumns(tabla);
        }
    }
}
