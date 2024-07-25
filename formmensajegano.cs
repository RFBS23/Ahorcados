using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ahorcados
{
    public partial class formmensajegano : Form
    {
        public formmensajegano()
        {
            InitializeComponent();
        }

        private void piccontinuar_Click(object sender, EventArgs e)
        {
            frmniveles niveles = new frmniveles();
            niveles.Show();
            this.Hide();
        }
    }
}
