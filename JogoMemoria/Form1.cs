namespace JogoMemoria
{
    public partial class Form1 : Form
    {
        static public bool login = false;
        const int nCartas = 20;

        byte nCliques = 0;
        byte restantesCt = nCartas / 2;
        Button cartaAnterior;
        public Form1()
        {
            InitializeComponent();
        }
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            FormLogin frm = new FormLogin();
            frm.ShowDialog();
            if (login)
            {
                DistribuirCartas();
                AtribuirTags();
            }
        }

        private void AtribuirTags()
        {
            int[] tags = new int[nCartas];
            Random rnd = new Random();
            int i = 0;
            int n;
            while(i<nCartas)
            {
                n = rnd.Next(1,nCartas + 1);
                if (Array.IndexOf(tags, n) == -1)
                {
                    tags[i] = n;
                    i++;
                }
            }

            for (int j = 0; j < nCartas; j++)
                if (tags[j] > nCartas / 2)
                    tags[j] = tags[j] - (nCartas / 2);
            //for (int j = 0; j < nCartas; j++)
            //MessageBox.Show("tags[" + j + "]=" + tags[j]);
            i = 0;
            foreach (Control x in this.Controls)
                if (x is Button && x.Tag.ToString() == "c")
                {
                    x.Tag = tags[i];
                    i++;
                }
        }

        private void DistribuirCartas()
        {
            foreach (Control x in this.Controls)
                if (x is Button && x.Tag.ToString() == "c")
                {
                    x.BackgroundImage = Properties.Resources.ak;
                    x.Visible = true;
                }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Ocultar();
            tsLabelData.Text = DateTime.Now.ToLongDateString();
            timer1.Enabled= true;
        }

        private void Ocultar()
        {
            foreach(Control x in this.Controls)
                if(x is Button && x.Tag.ToString()=="c")
                    x.Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tsLabelHora.Text = DateTime.Now.ToLongTimeString();
        }

        private void buttonMostrar_Click(object sender, EventArgs e)
        {
            foreach(Control x in this.Controls)
                if(x is Button && x.Tag.ToString() != "o")
                {
                    string s = "_" + x.Tag.ToString();
                    object o=Properties.Resources.ResourceManager.GetObject(s);
                    x.BackgroundImage = (System.Drawing.Image)o;
                }
            Application.DoEvents();
            System.Threading.Thread.Sleep(800);
            
            foreach (Control x in this.Controls)
                if (x is Button && x.Tag.ToString() != "o")
                    x.BackgroundImage = Properties.Resources.ak;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button cartaAtual = (sender as Button);
            string s = "_" + cartaAtual.Tag.ToString();
            object o = Properties.Resources.ResourceManager.GetObject(s);
            cartaAtual.BackgroundImage= (System.Drawing.Image)o;

            if (nCliques == 0)
            {
                cartaAnterior = cartaAtual;
                nCliques++;
            }
            else
                CompararCartas(cartaAnterior, cartaAtual);
        }

        private void CompararCartas(Button cAnterior, Button cAtual)
        {
            Application.DoEvents();
            System.Threading.Thread.Sleep(600);

            if(cAnterior==cAtual)
            {
                MessageBox.Show("Selecionou a mesma carta");
                nCliques = 0;
                cAtual.BackgroundImage = Properties.Resources.ak;
            }
            else
            {
                if (cAtual.Tag.ToString() == cAnterior.Tag.ToString())
                {
                    restantesCt--;
                    nCliques = 0;
                    cAnterior.Visible = false;
                    cAtual.Visible = false;
                    VerificarSeGanhou();
                }
                else
                {
                    nCliques= 0;
                    cAnterior.BackgroundImage = Properties.Resources.ak;
                    cAtual.BackgroundImage = Properties.Resources.ak;
                }
            }
        }

        private void VerificarSeGanhou()
        {

        }
    }
}