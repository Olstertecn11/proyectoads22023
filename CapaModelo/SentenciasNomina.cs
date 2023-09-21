﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaModelo
{
   public class SentenciasNomina : SentenciasGenerales
    {
        private string tabla;
        public SentenciasNomina()
        {
            this.tabla = "tbl_nomina";
        }

        public void agregarEmpleadoNomina(Dictionary<string, string> parameters)
        {
            string query = this.getQuery(parameters, tabla);
            this.insertarSQL(query);

        }


    }
}
