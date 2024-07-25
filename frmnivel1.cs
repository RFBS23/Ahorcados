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
    public partial class frmnivel1 : Form
    {
        char[] PalabrasAdivinadas; int Oportunidades;
        char[] PalabraSeleccionada;
        char[] Alfabeto;
        String[] Palabras;

        public frmnivel1(String[] palabras, string titulo)
        {
            InitializeComponent();
            Palabras = palabras;
            lbltitulo.Text = titulo;
        }

        private void frmnivel1_Load(object sender, EventArgs e)
        {
            IniciarJuego();            
        }

        public void IniciarJuego()
        {
            //valores Iniciales del juego
            flFichasDeJuego.Controls.Clear();
            flFichasDeJuego.Enabled = true;
            picAhorcados.Image = null;
            lblMensaje.Visible = false;
            picmensaje.Visible = false;
            Oportunidades = 0; // si el jugador fallo
            btniniciarjuego.Image = Properties.Resources.reiniciar;
            Alfabeto = "ABCDEFGHIJKLMNÑOPQRSTUVWXYZ".ToCharArray();

            //palabras aleatorias - adivinar
            Random random = new Random();
            int IndicePalabraSeleccionada = random.Next(0, Palabras.Length);
            PalabraSeleccionada = Palabras[IndicePalabraSeleccionada].ToUpper().ToCharArray();
            PalabrasAdivinadas = PalabraSeleccionada;

            //Ciclo que carga el alfabeto de un flowLayout --> flFichasDeJuego
            foreach (char LetraAlfabeto in Alfabeto)
            {
                Button btnLetra = new Button();
                btnLetra.Tag = "";
                btnLetra.Text = LetraAlfabeto.ToString();
                btnLetra.Width = 60;
                btnLetra.Height = 40;
                btnLetra.Click += Compara;
                btnLetra.ForeColor = Color.White;
                btnLetra.Font = new Font(btnLetra.Font.Name, 15, FontStyle.Bold);
                btnLetra.BackgroundImageLayout = ImageLayout.Center;
                btnLetra.BackColor = Color.Green;
                btnLetra.Name = LetraAlfabeto.ToString();
                flFichasDeJuego.Controls.Add(btnLetra);
            }
            flPalabra.Controls.Clear();

            //ciclo que agrega la palabra en un flowlayout (palabra a adivinar)
            for (int IndiceValorLetra = 0; IndiceValorLetra < PalabraSeleccionada.Length; IndiceValorLetra++)
            {
                Button Letra = new Button();
                Letra.Tag = PalabraSeleccionada[IndiceValorLetra].ToString();
                Letra.Width = 50;
                Letra.Height = 80;
                Letra.ForeColor = Color.Black;
                Letra.Text = "-";
                Letra.Font = new Font(Letra.Font.Name, 32, FontStyle.Bold);
                Letra.BackgroundImageLayout = ImageLayout.Center;
                Letra.BackColor = Color.White;
                Letra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                Letra.Name = "Adivinado" + IndiceValorLetra.ToString();
                Letra.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.cuadrado));
                flPalabra.Controls.Add(Letra);
            }
        }

        void Compara(object sender, EventArgs e)
        {
            bool encontrado = false;
            // al presionar el boton se desactiva
            Button btn = (Button)sender;
            btn.BackColor = Color.Red;
            btn.ForeColor = Color.Black;
            btn.Enabled = false;

            //compara letra selecionada con las letras de la palabra
            for (int indiceRevisar = 0; indiceRevisar < PalabrasAdivinadas.Length; indiceRevisar++)
            {
                if (PalabrasAdivinadas[indiceRevisar] == Char.Parse(btn.Text))
                {
                    //si existe la letra actualiza la palabra agregando el valor correspondiente
                    Button tbx = Controls.Find("Adivinado" + indiceRevisar, true).FirstOrDefault() as Button;
                    tbx.Text = PalabrasAdivinadas[indiceRevisar].ToString();
                    PalabrasAdivinadas[indiceRevisar] = '-';
                    encontrado = true;
                }
            }

            //verifica si todas las letras de la palabra estan destapadas
            bool Ganaste = true;
            for (int indiceAnalizadorGanador = 0; indiceAnalizadorGanador < PalabrasAdivinadas.Length; indiceAnalizadorGanador++)
            {
                //si el usuario tiene las letras pendientes por destapar se cambia el estatus
                if (PalabrasAdivinadas[indiceAnalizadorGanador] != '-')
                {
                    Ganaste = false;
                }
            }

            //si el estatus de la variable no cambia quiere decr¿ir que el usuario gano.
            if (Ganaste)
            {
                formmensajegano mostrarmensaje = new formmensajegano();
                mostrarmensaje.Show();
                //this.Hide();
            }

            if (!encontrado)
            {
                Oportunidades = Oportunidades + 1;
                picAhorcados.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject("ahorcado" + Oportunidades);

                //si las oportunidades de acabaron (mostrar la palabra)
                if (Oportunidades == 7)
                {
                    lblMensaje.Visible = true;
                    picmensaje.Visible = true;
                    //muestra la palabra que el usuario intentaba descubrir
                    for (int IndiceValorLetra = 0; IndiceValorLetra < PalabraSeleccionada.Length; IndiceValorLetra++)
                    {
                        Button btnLetra = this.Controls.Find("Adivinado" + IndiceValorLetra, true).FirstOrDefault() as Button;
                        btnLetra.Text = btnLetra.Tag.ToString();
                    }

                    //Desactivamos las fichas y cambia el boton de reinicio
                    flFichasDeJuego.Enabled = false;
                    btniniciarjuego.Image = Properties.Resources.iniciar;
                }
            }
        }

        private void btniniciarjuego_Click(object sender, EventArgs e)
        {
            IniciarJuego();
        }

        private void btnregresar_Click(object sender, EventArgs e)
        {
            frmniveles niveles = new frmniveles();
            niveles.Show();
            this.Hide();
        }

        private void frmnivel1_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmniveles niveles = new frmniveles();
            niveles.Show();
            this.Hide();
        }
        
    }
}
