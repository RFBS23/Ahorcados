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
            string tituloNivel1 = "Batman y sus amigos";
            frmnivel1 nivel1 = new frmnivel1(palabrasNivel1, tituloNivel1);
            nivel1.Show();
            this.Hide();
        }

        private void btnnivel2_Click(object sender, EventArgs e)
        {
            String[] nuevasPalabras = new string[] { "superman", "lexluthor", "loislane", "kryptonite", "brainiac" };
            string nuevoTitulo = "Superman y sus amigos";
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

        private void btnnivel3_Click(object sender, EventArgs e)
        {
            String[] PalabrasNivel3 = new string[] { "spiderman", "venom", "maryjane", "octopus", "mysterio", "goblin", "sandman" };
            string TituloNivel3 = "Spiderman";
            frmnivel1 nivel3 = new frmnivel1(PalabrasNivel3, TituloNivel3);
            nivel3.Show();
            this.Hide();
        }

        private void btnnivel4_Click(object sender, EventArgs e)
        {
            String[] PalabrasNivel4 = new string[] { "ironman", "thor", "hulk", "hawkeye", "wanda", "vision", "thanos" };
            string TituloNivel4 = "Los Vengadores";
            frmnivel1 nivel4 = new frmnivel1(PalabrasNivel4, TituloNivel4);
            nivel4.Show();
            this.Hide();
        }

        private void btnnivel5_Click(object sender, EventArgs e)
        {
            String[] PalabrasNivel5 = new string[] { "wolverine", "cyclops", "storm", "magneto", "rogue", "beast", "jeangrey" };
            string TituloNivel5 = "X-Men";
            frmnivel1 nivel5 = new frmnivel1(PalabrasNivel5, TituloNivel5);
            nivel5.Show();
            this.Hide();
        }

        private void btnnivel6_Click(object sender, EventArgs e)
        {
            String[] PalabrasNivel6 = new string[] { "joker", "darkseid", "riddler", "sinestro", "deathstroke", "blackadam", "harleyquinn" };
            string TituloNivel6 = "Villanos de DC";
            frmnivel1 nivel6 = new frmnivel1(PalabrasNivel6, TituloNivel6);
            nivel6.Show();
            this.Hide();
        }

        private void btnnivel7_Click(object sender, EventArgs e)
        {
            String[] PalabrasNivel7 = new string[] { "starlord", "gamora", "drax", "rocket", "groot", "yondu", "nebula" };
            string TituloNivel7 = "Guardianes de la Galaxia";
            frmnivel1 nivel7 = new frmnivel1(PalabrasNivel7, TituloNivel7);
            nivel7.Show();
            this.Hide();
        }

        private void btnnivel8_Click(object sender, EventArgs e)
        {
            String[] PalabrasNivel8 = new string[] { "batman", "superman", "wonderwoman", "flash", "aquaman", "cyborg", "greenlantern" };
            string TituloNivel8 = "Héroes de DC";
            frmnivel1 nivel8 = new frmnivel1(PalabrasNivel8, TituloNivel8);
            nivel8.Show();
            this.Hide();
        }

        private void btnnivel9_Click(object sender, EventArgs e)
        {
            String[] PalabrasNivel9 = new string[] { "blackpanther", "doctorstrange", "scarletwitch", "shangchi", "antman", "loki", "falcon" };
            string TituloNivel9 = "Héroes de Marvel";
            frmnivel1 nivel9 = new frmnivel1(PalabrasNivel9, TituloNivel9);
            nivel9.Show();
            this.Hide();
        }

        private void btnnivel10_Click(object sender, EventArgs e)
        {
            String[] PalabrasNivel10 = new string[] { "spidernoir", "milesmorales", "superboy", "batwoman", "ironspider", "supergirl", "kang" };
            string TituloNivel10 = "Multiverso";
            frmnivel1 nivel10 = new frmnivel1(PalabrasNivel10, TituloNivel10);
            nivel10.Show();
            this.Hide();
        }

        private void frmniveles_Load(object sender, EventArgs e)
        {
        }

        private void btnTelegram_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://t.me/fabridev");
        }
    }
}
