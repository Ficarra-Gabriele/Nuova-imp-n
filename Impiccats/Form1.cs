namespace Impiccats
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string parola = "";
        char[] parolaI;
        int Punteggio = 0;
        Random g = new Random();
        int tentativi = 0;
        char let;
        char L, F, R;
        int Jollu = 2;

        void inizializzaParola(string filePath, int t)
        {
            string[] linee = File.ReadAllLines(filePath);
            int r = g.Next(linee.Length);
            parola = linee[r];
            tentativi = t;
            T00.Text = tentativi.ToString();
            parolaI = new string('_', parola.Length).ToCharArray();
            Parols.Text = new string(parolaI);
        }

        void Controllo_Lettera(char L)
        {
            bool letteraTrovata = false;

            if (tentativi == 0)
            {
                MessageBox.Show("Hai esaurito i tentativi. La parola era: " + parola);
            }
            if (tentativi > 0 && L02.Text == parola.ToString())
            {
                MessageBox.Show("Hai indovinato la parola ");
            }

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
        }
        void Controllo_Parola()
        {
            if (L02.Text == parola)
            {
                Parols.Text = parola;
                MessageBox.Show("Complimenti! Hai indovinato la parola: " + parola);
            }
            else
            {
                tentativi -= 1;
                T00.Text = tentativi.ToString();
                if (tentativi == 0)
                {
                    MessageBox.Show("Hai esaurito i tentativi. La parola era: " + parola);
                }
            }
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
            F = L01.Text[0];
            Controllo_Lettera(F);
            Lista.Items.Add(L01.Text);
        }

        private void Invio2_Click(object sender, EventArgs e)
        {
            Controllo_Parola();
            Lista.Items.Add(L02.Text);
        }
        private void Jolly_Click(object sender, EventArgs e)
        {
            Uso_Jolly();
        }
    }
}
