namespace Impiccats
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Invio.Enabled = false;
            Invio2.Enabled = false;
            Jolly.Enabled = false;
        }

        string parola = "";
        char[] parolaI;
        int Punteggio = 0;
        Random g = new Random();
        int tentativi = 0;
        char F;
        int Jollu = 2;
        string parolaUtente = "";

        void inizializzaParola(string filePath, int t)
        {
            string[] linee = File.ReadAllLines(filePath);
            int r = g.Next(linee.Length);
            parola = linee[r];
            tentativi = t;
            parolaI = new string('_', parola.Length).ToCharArray();
            Punteggio = 0;
            Jollu = 2;
            Parols.Text = new string(parolaI);
            L07.Text = "0";
            T00.Text = tentativi.ToString();
            II.Text = Jollu.ToString();
            Lista.Items.Clear();
            L01.Text = "";
            L02.Text = "";
            Invio.Enabled = true;
            Invio2.Enabled = true;
            Jolly.Enabled = true;
        }

        void Controllo_Lettera(char L)
        {
            if (tentativi == 0)
            {
                MessageBox.Show("Hai esaurito i tentativi. La parola era: " + parola);
                return;
            }

            if (L02.Text == parola)
            {
                MessageBox.Show("Hai indovinato la parola, seleziona un nuovo pulsante");
                return;
            }

            bool letteraTrovata = false;

            for (int j = 0; j < parola.Length; j++)
            {
                if (parola[j] == L)
                {
                    parolaI[j] = L;
                    letteraTrovata = true;
                    Punteggio += 1;
                    L07.Text = Punteggio.ToString();
                }
            }

            if (letteraTrovata)
            {
                Parols.Text = new string(parolaI);
            }
            else
            {
                tentativi -= 1;
                T00.Text = tentativi.ToString();
            }

            if (tentativi == 0)
            {
                MessageBox.Show("Hai esaurito i tentativi. La parola era: " + parola);
                Invio.Enabled = false;
                Invio2.Enabled = false;
                Jolly.Enabled = false;
            }
        }
        void Controllo_Parola()
        {
            parolaUtente = L02.Text;

            if (parolaUtente == parola)
            {
                Parols.Text = parola;
                MessageBox.Show("Hai completato il gioco, il tuo punteggio è di: " + Punteggio.ToString() + ".\nSeleziona una nuova categoria per continuare.");
            }
            else
            {
                tentativi = 0;
                T00.Text = "0";
                MessageBox.Show("Hai sbagliato. La parola era: " + parola + ".\nSeleziona una nuova categoria per continuare.");
            }

            Invio.Enabled = false;
            Invio2.Enabled = false;
            Jolly.Enabled = false;
        }

        void Uso_Jolly()
        {
            if (Jollu > 0)
            {
                Jollu--;
                II.Text = Jollu.ToString();

                for (int i = 0; i < parola.Length; i++)
                {
                    if (parolaI[i] == '_')
                    {
                        parolaI[i] = parola[i];
                        Parols.Text = new string(parolaI);
                        return;
                    }
                }
            }
        }

        private void Facils_Click(object sender, EventArgs e)
        {
            inizializzaParola("Parole_Facili.txt", 6);
        }

        private void medis_Click(object sender, EventArgs e)
        {
            inizializzaParola("Parole_Medie.txt", 4);
        }

        private void difficils_Click(object sender, EventArgs e)
        {
            inizializzaParola("Parole_Difficili.txt", 3);
        }

        private void Animals_Click(object sender, EventArgs e)
        {
            inizializzaParola("Animali.txt", 6);
        }

        private void Oggets_Click(object sender, EventArgs e)
        {
            inizializzaParola("Oggetto.txt", 6);
        }

        private void citts_Click(object sender, EventArgs e)
        {
            inizializzaParola("Città.txt", 6);
        }

        private void Invio_Click(object sender, EventArgs e)
        {
            if (L01.Text != "")
            {
                F = L01.Text[0];
                Controllo_Lettera(F);
                Lista.Items.Add(L01.Text);
                L01.Text = "";
            }
            else
            {
                MessageBox.Show("Inserisci una lettera.");
            }
        }

        private void Invio2_Click(object sender, EventArgs e)
        {
            if (L02.Text != "")
            {
                Lista.Items.Add(L02.Text);
                Controllo_Parola();
                L02.Text = "";
            }
            else
            {
                MessageBox.Show("Inserisci una parola.");
            }
        }

        private void Jolly_Click(object sender, EventArgs e)
        {
            Uso_Jolly();
        }
    }
}