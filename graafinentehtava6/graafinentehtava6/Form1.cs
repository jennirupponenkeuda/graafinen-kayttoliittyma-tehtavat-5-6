namespace graafinentehtava6
{
    public partial class SalasanaForm : Form
    {
        public SalasanaForm()
        {
            InitializeComponent();
        }

        private void TarkistaBT_Click(object sender, EventArgs e)
        {
            if(KayttajaTB.Text == "Jyri" && SalasanaTB.Text == "Ja@kk0Ku1ta")
            {
                SalasanaPanel.Visible = false;
                SalasanaOikeinPanel.Visible = true;

                // Kun k�ytt�j�tunnus ja salasana ovat oikein, salasanapaneeli on piilossa ja salasanaoikein on n�kyvill�
            }
            else
            {
                VirheviestiLB.Text = "K�ytt�j�tunnus tai salasana on virheellinen";
                VirheviestiLB.Visible = true;

                // Teksti ilmaantuu n�ytt��n
            }

        }
    }
}
