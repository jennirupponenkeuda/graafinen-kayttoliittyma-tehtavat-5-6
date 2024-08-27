namespace graafinentehtava5
{
    public partial class LukujenJarjestys : Form
    {
        List<int> jono = new List<int>();
        public LukujenJarjestys()
        {
            InitializeComponent();
        }

        private void uusiLukuTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) //Enterin toiminta
            {
                if (uusiLukuTB.Text == "-999")
                {
                    VastausLB.Text = "";//Tyhjennet‰‰n ensin
                    int[] taulukko = jono.ToArray(); //Taulukkomuuttuja
                    Array.Sort(taulukko); //Taulukko j‰rjestet‰‰n t‰ll‰
                    foreach (var jasen in taulukko) //Taulukko k‰yd‰‰n l‰pi yksi j‰sen kerrallaan
                    {
                        VastausLB.Text += jasen + " "; //Tulostus v‰lilyˆnnill‰ pienimm‰st‰ suurimpaan

                    }
                    VastausLB.Visible = true; // N‰ytet‰‰n vastaus

                }
                else
                {
                    jono.Add(Int32.Parse(uusiLukuTB.Text)); //kokonaislukujen muuttaminen vaatii t‰m‰n muutoksen, jotta ne saa j‰rjestykseen
                    uusiLukuTB.Text = "";

                }
            }
            if (e.KeyChar == (char)Keys.Escape)
            {
                Tyhjaa_Lomake();
            }
        }
            private void Tyhjaa_Lomake()
            {
                uusiLukuTB.Text = "";
            }
        }
    }


