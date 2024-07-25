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
    public partial class frmniveles : Form
    {
        public frmniveles()
        {
            InitializeComponent();
            this.FormClosed += new FormClosedEventHandler(frmniveles_FormClosed);
        }

        private Form activeForm = null;
        private void abrirformulario(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelniveles.Controls.Add(childForm);
            panelniveles.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnnivel1_Click(object sender, EventArgs e)
        {
            String[] palabrasNivel1 = new string[] { "batman", "joker", "alfred", "batgirl", "bane", "anubis", "amadeus" };
            string tituloNivel1 = "Nivel 1: Batman y sus amigos";
            frmnivel1 nivel1 = new frmnivel1(palabrasNivel1, tituloNivel1);
            nivel1.Show();
            this.Hide();
        }

        private void btnnivel2_Click(object sender, EventArgs e)
        {
            String[] nuevasPalabras = new string[] { "superman", "lexluthor", "loislane", "kryptonite", "brainiac" }; // Nuevas palabras
            string nuevoTitulo = "Nivel 2: Superman y sus amigos";
            frmnivel1 nivel2 = new frmnivel1(nuevasPalabras, nuevoTitulo);
            nivel2.Show();
            this.Hide();
        }

        private void frmniveles_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms["Inicio"] == null)
            {
                Inicio inicio = new Inicio();
                inicio.Show();
            }
            else
            {
                Application.OpenForms["Inicio"].Show();
            }
        }
    }
}
