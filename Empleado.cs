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
    public partial class Empleado : Form
    {
        public Empleado()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string c1 = cantidad1.Text;
            int C1 = Int32.Parse(c1);
            string c2 = cantidad2.Text;
            int C2 = Int32.Parse(c2);
            string c3 = cantidad3.Text;
            int C3 = Int32.Parse(c3);
            richTextBox1.AppendText((C1 + C2 + C3) + "\r\n");
            richTextBox1.AppendText((C1 * 1000 + C2 * 500 + C3 * 2000) + "\r\n");
            int total = (C1 * 1000 + C2 * 500 + C3 * 2000);
            string Total = Convert.ToString(total);
            total1.AppendText(Total);
            richTextBox1.AppendText(nombrecl.Text + "\r\n");
            richTextBox1.AppendText(CC.Text + "\r\n");
            richTextBox1.AppendText(fecha.Text + "\r\n");
        }

        private void exportar_Click(object sender, EventArgs e)
        {
            Administrador ventatotal = new Administrador();
            ventatotal.richTextBox2.Text = richTextBox1.Text;
            ventatotal.Show();
        }
    }
}
