using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DaluxUninstaller
{
    public partial class Uninstalling : Form
    {
        public Uninstalling()
        {
            InitializeComponent();
        }

        private void Caluculate(int i)
        {
            double pow = Math.Pow(i, i);
        }

        private async void Uninstalling_Load(object sender, EventArgs e)
        {
            progressBar1.Maximum = 100000;
            progressBar1.Step = 1;
            for (int j = 0; j < 100000; j++)
            {
                Caluculate(j);
                progressBar1.PerformStep();
            }
            await Task.Delay(2000);
            DialogResult res2 = MessageBox.Show("Dalux has been Uninstalled!");
            if(res2 == System.Windows.Forms.DialogResult.OK)
            {
                Application.Exit();
            }
        }
    }
}
