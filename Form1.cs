using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Onlypans
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void loginbutton_Click(object sender, EventArgs e)
        {
            string EmpU = "Acuna";
            string EmpC = "UPBGA";
            string AdmU = "AdminSupremo";
            string AdmC = "SuperAdmin";
            if (loginuser.Text == EmpU && loginpassword.Text == EmpC)
            {
                Empleado empleado = new Empleado();
                Empleado Ventana2 = empleado;
                Ventana2.Show();
            }

            if (loginuser.Text == AdmU && loginpassword.Text == AdmC)
            {
                Administrador administrador = new Administrador();
                Administrador Ventana3 = administrador;
                Ventana3.Show();
                Empleado empleado = new Empleado();
                Empleado Ventana2 = empleado;
                Ventana2.Show();
            }
        }
    }
}
