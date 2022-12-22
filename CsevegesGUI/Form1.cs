using System.Security.Cryptography.X509Certificates;

namespace CsevegesGUI
{
    public partial class Form1 : Form
    {
        private static List<Beszelgetes> Beszelgetesek = new List<Beszelgetes>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Beszelgetes.Inicializalas(@"..\..\..\..\src\csevegesek.txt", Beszelgetesek);
            Inicializalas_cmbx();
        }

        private void Inicializalas_cmbx()
        {
            foreach (var beszelgetes in Beszelgetesek)
            {
                string Kezdemenyezo = beszelgetes.Kezdemenyezo;
                string Fogado = beszelgetes.Fogado;
                if (!cmbx_kezdemenyezo.Items.Contains(Kezdemenyezo))
                {
                    cmbx_kezdemenyezo.Items.Add(Kezdemenyezo);
                }
                if (!cmbx_fogado.Items.Contains(Fogado))
                {
                    cmbx_fogado.Items.Add(Fogado);
                }
            }
            cmbx_kezdemenyezo.SelectedIndex = 0;
            cmbx_fogado.SelectedIndex = cmbx_fogado.Items.Count - 1;
        }

        private void cmbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstb_csevegesek.Items.Clear();
            if (cmbx_fogado.Text == cmbx_kezdemenyezo.Text)
            {
                lstb_csevegesek.Items.Add("Nem történt beszélgetés.");
            }
            else
            {
                int Index = 0;
                string Fogado = cmbx_fogado.Text;
                string Kezdemenyezo = cmbx_kezdemenyezo.Text;

                foreach (var b in Beszelgetesek)
                {
                    if (Fogado == b.Fogado && Kezdemenyezo == b.Kezdemenyezo)
                    {
                        Index++;
                        string Item = $"{Index}. {b.Kezdet.ToString("yy.MM.dd-HH:mm:ss")} --> {b.Veg.ToString("yy.MM.dd-HH:mm:ss")}";
                        lstb_csevegesek.Items.Add(Item);
                    }
                }
            }
        }
    }
}