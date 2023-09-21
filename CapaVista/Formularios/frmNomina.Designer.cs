
namespace CapaVista.Formularios
{
    partial class frmNomina
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.lbl_apellido = new System.Windows.Forms.Label();
            this.lbl_fecha = new System.Windows.Forms.Label();
            this.lbl_salario = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.txt_apellido = new System.Windows.Forms.TextBox();
            this.txt_fecha_pago = new System.Windows.Forms.TextBox();
            this.txt_salario_base = new System.Windows.Forms.TextBox();
            this.txt_horas = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nomina";
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombre.Location = new System.Drawing.Point(21, 106);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(150, 20);
            this.lbl_nombre.TabIndex = 1;
            this.lbl_nombre.Text = "Nombre Empleado:";
            // 
            // lbl_apellido
            // 
            this.lbl_apellido.AutoSize = true;
            this.lbl_apellido.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_apellido.Location = new System.Drawing.Point(21, 150);
            this.lbl_apellido.Name = "lbl_apellido";
            this.lbl_apellido.Size = new System.Drawing.Size(151, 20);
            this.lbl_apellido.TabIndex = 2;
            this.lbl_apellido.Text = "Apellido Empleado:";
            // 
            // lbl_fecha
            // 
            this.lbl_fecha.AutoSize = true;
            this.lbl_fecha.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fecha.Location = new System.Drawing.Point(21, 190);
            this.lbl_fecha.Name = "lbl_fecha";
            this.lbl_fecha.Size = new System.Drawing.Size(102, 20);
            this.lbl_fecha.TabIndex = 3;
            this.lbl_fecha.Text = "Fecha Pago:";
            // 
            // lbl_salario
            // 
            this.lbl_salario.AutoSize = true;
            this.lbl_salario.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_salario.Location = new System.Drawing.Point(21, 232);
            this.lbl_salario.Name = "lbl_salario";
            this.lbl_salario.Size = new System.Drawing.Size(96, 20);
            this.lbl_salario.TabIndex = 4;
            this.lbl_salario.Text = "Salario Base";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 274);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Horas Extra:";
            // 
            // btn_guardar
            // 
            this.btn_guardar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardar.Location = new System.Drawing.Point(209, 324);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(106, 40);
            this.btn_guardar.TabIndex = 12;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Id:";
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(194, 70);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(246, 20);
            this.txt_id.TabIndex = 14;
            this.txt_id.Tag = "Pk_id_empleados";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(194, 108);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(246, 20);
            this.txt_nombre.TabIndex = 15;
            this.txt_nombre.Tag = "nbr_nombre";
            // 
            // txt_apellido
            // 
            this.txt_apellido.Location = new System.Drawing.Point(194, 150);
            this.txt_apellido.Name = "txt_apellido";
            this.txt_apellido.Size = new System.Drawing.Size(246, 20);
            this.txt_apellido.TabIndex = 16;
            this.txt_apellido.Tag = "nbr_apellido";
            // 
            // txt_fecha_pago
            // 
            this.txt_fecha_pago.Location = new System.Drawing.Point(194, 192);
            this.txt_fecha_pago.Name = "txt_fecha_pago";
            this.txt_fecha_pago.Size = new System.Drawing.Size(246, 20);
            this.txt_fecha_pago.TabIndex = 17;
            this.txt_fecha_pago.Tag = "nbr_fecha_pago";
            // 
            // txt_salario_base
            // 
            this.txt_salario_base.Location = new System.Drawing.Point(194, 234);
            this.txt_salario_base.Name = "txt_salario_base";
            this.txt_salario_base.Size = new System.Drawing.Size(246, 20);
            this.txt_salario_base.TabIndex = 18;
            this.txt_salario_base.Tag = "nbr_salario_base";
            // 
            // txt_horas
            // 
            this.txt_horas.Location = new System.Drawing.Point(194, 276);
            this.txt_horas.Name = "txt_horas";
            this.txt_horas.Size = new System.Drawing.Size(246, 20);
            this.txt_horas.TabIndex = 19;
            this.txt_horas.Tag = "nbr_horas_extra";
            // 
            // frmNomina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(235)))), ((int)(((byte)(223)))));
            this.ClientSize = new System.Drawing.Size(520, 423);
            this.Controls.Add(this.txt_horas);
            this.Controls.Add(this.txt_salario_base);
            this.Controls.Add(this.txt_fecha_pago);
            this.Controls.Add(this.txt_apellido);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_salario);
            this.Controls.Add(this.lbl_fecha);
            this.Controls.Add(this.lbl_apellido);
            this.Controls.Add(this.lbl_nombre);
            this.Controls.Add(this.label1);
            this.Name = "frmNomina";
            this.Tag = "fNomina";
            this.Text = "frmNomina";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.Label lbl_apellido;
        private System.Windows.Forms.Label lbl_fecha;
        private System.Windows.Forms.Label lbl_salario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.TextBox txt_apellido;
        private System.Windows.Forms.TextBox txt_fecha_pago;
        private System.Windows.Forms.TextBox txt_salario_base;
        private System.Windows.Forms.TextBox txt_horas;
    }
}