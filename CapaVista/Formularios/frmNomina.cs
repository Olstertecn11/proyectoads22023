using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaControlador;
using CapaVista.Componentes.Utilidades;

namespace CapaVista.Formularios
{
    public partial class frmNomina : Form
    {
        
        private utilidadesConsultasI utilConsultasI;

        public frmNomina()
        {
            InitializeComponent();    
            utilConsultasI = new utilidadesConsultasI();
        }

        public void identificarFormularioReg(Form child, string operacion)
        {
            MessageBox.Show("Idenfiticando");
            if (child.Tag.ToString().Equals("fNomina"))
            {
                MessageBox.Show("IF");
                if (operacion.Equals("g")) this.utilConsultasI.guardarUsuarioNomina(child);
            }
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            try
            {

                this.identificarFormularioReg(this, "g");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Crear Empleado" + ex);

            }
        }

       
    }
    
}
