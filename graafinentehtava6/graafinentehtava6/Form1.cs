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

                // Kun käyttäjätunnus ja salasana ovat oikein, salasanapaneeli on piilossa ja salasanaoikein on näkyvillä
            }
            else
            {
                VirheviestiLB.Text = "Käyttäjätunnus tai salasana on virheellinen";
                VirheviestiLB.Visible = true;

                // Teksti ilmaantuu näyttöön
            }

        }
    }
}
