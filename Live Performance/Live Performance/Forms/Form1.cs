using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Live_Performance.Domain_Classes;

namespace Live_Performance
{
    public partial class Pizzeria : Form
    {
        private List<Producten> ProductenList;
        private Producten pizza;
        public Pizzeria()
        {
            pizza = new Pizza();
            InitializeComponent();
        }

        private void clbGebruiker_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (clbGebruiker.SelectedItem.ToString() == "Ja")
            {
                lblKlantnummer.Hide();
                nUDKlantnummer.Hide();
                tbNaam.Show();
                tbAdres.Show();
            }

            else if (clbGebruiker.SelectedItem.ToString() == "Nee")
            {
                lblKlantnummer.Show();
                nUDKlantnummer.Show();
                tbNaam.Hide();
                tbAdres.Hide();
            }
        }

        private void clbBodemVorm_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (clbBodemVorm.SelectedItem.ToString() == "Rond")
            {
                nUDBreedte.Hide();
                nUDDiepte.Hide();
                nUDLengteDiameter.Show();
            }

            else if (clbBodemVorm.SelectedItem.ToString() == "Vierkant")
            {
                nUDBreedte.Show();
                nUDDiepte.Hide();
                nUDLengteDiameter.Show();
            }

            else if (clbBodemVorm.SelectedItem.ToString() == "Driehoek")
            {
                nUDBreedte.Show();
                nUDDiepte.Show();
                nUDLengteDiameter.Show();
            }
        }

        private void cbAanpassen_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbAanpassen.SelectedItem.ToString() == "Standaard Pizza")
            {
                lblBodemVormAanpassen.Show();
                lblBodemsoortAanpassen.Show();
                lblGlutenAanpassen.Show();
                clbVormAanpassen.Show();
                clbBodemAanpassen.Show();
                clbAanpassen.Show();
                lblFormaatAanpassen.Show();
                nUDBreedteAanpassen.Show();
                nUDDiepteAanpassen.Show();
                nUDLengteDiaAanpassen.Show();
                lblAlcohol.Hide();
                lblHalal.Hide();
                clbHalalAlcohol.Hide();
                lblVeganistisch.Hide();
                clbVega.Hide();
                tbInkoop.Hide();
                tbVerkoop.Hide();
            }

            else if (cbAanpassen.SelectedItem.ToString() == "Ingrediënten")
            {
                lblBodemVormAanpassen.Hide();
                lblBodemsoortAanpassen.Hide();
                lblGlutenAanpassen.Hide();
                clbVormAanpassen.Hide();
                cblGluten.Hide();
                clbBodemAanpassen.Hide();
                lblFormaatAanpassen.Hide();
                nUDBreedteAanpassen.Hide();
                nUDDiepteAanpassen.Hide();
                nUDLengteDiaAanpassen.Hide();
                lblHalal.Show();
                lblAlcohol.Hide();
                clbHalalAlcohol.Show();
                lblVeganistisch.Show();
                clbVega.Show();
                tbInkoop.Show();
                tbVerkoop.Show();
            }

            else if (cbAanpassen.SelectedItem.ToString() == "Overige Producten")
            {
                lblBodemVormAanpassen.Hide();
                lblBodemsoortAanpassen.Hide();
                lblGlutenAanpassen.Hide();
                clbVormAanpassen.Hide();
                clbBodemAanpassen.Hide();
                clbAanpassen.Hide();
                lblFormaatAanpassen.Hide();
                nUDBreedteAanpassen.Hide();
                nUDDiepteAanpassen.Hide();
                nUDLengteDiaAanpassen.Hide();
                lblHalal.Hide();
                lblAlcohol.Show();
                clbHalalAlcohol.Show();
                lblVeganistisch.Hide();
                clbVega.Hide();
                tbInkoop.Show();
                tbVerkoop.Show();
            }
        }


        private void Pizzeria_Load(object sender, EventArgs e)
        {
            lblBodemVormAanpassen.Show();
            lblBodemsoortAanpassen.Show();
            lblGlutenAanpassen.Show();
            clbVormAanpassen.Show();
            clbBodemAanpassen.Show();
            clbAanpassen.Show();
            lblFormaatAanpassen.Show();
            nUDBreedteAanpassen.Show();
            nUDDiepteAanpassen.Show();
            nUDLengteDiaAanpassen.Show();
            lblAlcohol.Hide();
            lblHalal.Hide();
            clbHalalAlcohol.Hide();
            lblVeganistisch.Hide();
            clbVega.Hide();
            tbInkoop.Hide();
            tbVerkoop.Hide();
            Producten StandaardPizza = new Pizza();
            foreach (var pizza in StandaardPizza.AlleStandaardPizza())
            {
                cbPizza.Items.Add(pizza.Naam +";"+pizza.Formaat+ ";"+ pizza.Vorm+ ";"+ pizza.Soort + ";"+ pizza.ID);
            }

            Producten OverigeProducten = new OverigeProducten();
            foreach (var overigProduct in OverigeProducten.AllOverigeProducten())
            {
                string alcohol = "";
                if (overigProduct.Alcohol == true)
                {
                    alcohol = "Ja";
                }
                else
                {
                    alcohol = "Nee";
                }
                cbOverigeProducten.Items.Add(overigProduct.Naam + ";" + overigProduct.Verkoopprijs+ ";"+ alcohol);
            }
            Ingrediënten ingrediënten = new Ingrediënten();
            foreach (var ingrediënt in ingrediënten.AlleIngrediënten())
            {
                string halal = "";
                string vega = "";
                if (ingrediënt.Halal == true)
                {
                    halal = "Ja";
                }
                else
                {
                    halal = "Nee";
                }

                if (ingrediënt.Veganistisch == true)
                {
                    vega = "Ja";
                }

                else
                {
                    vega = "Nee";
                }
                cbIngrediënten.Items.Add(ingrediënt.Naam + ";" + ingrediënt.Verkoop + ";" + halal + ";" + vega);
            }
        }

        private void btnStndPizza_Click(object sender, EventArgs e)
        {
            CheckOfLijstLeegIs();
            string[] subStringPizza = cbPizza.SelectedItem.ToString().Split(';');
            Ingrediënten ingrediënten = new Ingrediënten();
            Producten pizza = new Pizza(subStringPizza[0],this.pizza.PrijsBepalen(ingrediënten.IngrediëntenBijPizza(subStringPizza[0], Convert.ToInt32(subStringPizza[1])),Convert.ToInt32(subStringPizza[1])),Convert.ToInt32(subStringPizza[1]), subStringPizza[2], subStringPizza[3],false,Convert.ToInt32(subStringPizza[4]));
            ProductenLijstUpdate(pizza);
        }

        private void btnProducten_Click(object sender, EventArgs e)
        {
            CheckOfLijstLeegIs();
            string[] subStringOverigeProducten = cbOverigeProducten.SelectedItem.ToString().Split(';');
            bool alcohol;
            if (subStringOverigeProducten[2] == "Ja")
            {
                alcohol = true;
            }
            else
            {
                alcohol = false;
            }
            Producten overigeProduct = new OverigeProducten(subStringOverigeProducten[0],alcohol,Convert.ToDecimal(subStringOverigeProducten[1])/100,0);
            ProductenLijstUpdate(overigeProduct);
        }

        public void ProductenLijstUpdate(Producten product)
        {
            CheckOfLijstLeegIs();
            lbProducten.Items.Clear();
            ProductenList.Add(product);
            foreach (var productenInLijst in ProductenList)
            {
                lbProducten.Items.Add(productenInLijst.Naam+";"+ productenInLijst.Verkoopprijs +";"+productenInLijst.ID);
            }
        }

        public void CheckOfLijstLeegIs()
        {
            if (ProductenList == null)
            {
                ProductenList = new List<Producten>();
            }
        }

        private void btnIngrediënten_Click(object sender, EventArgs e)
        {
            lbIngrediënten.Items.Add(cbIngrediënten.SelectedItem.ToString());
        }

        public void btnPizzaOpslaan_Click(object sender, EventArgs e)
        {
            try
            {
                List<Ingrediënten> ingrediënten = new List<Ingrediënten>();
                Ingrediënten ingredïent;
                bool gluten;
                foreach (var item in lbIngrediënten.Items)
                {
                    string[] substringIngrediënten = item.ToString().Split(';');
                    bool halal;
                    bool vega;
                    if (substringIngrediënten[2] == "Ja")
                    {
                        halal = true;
                    }

                    else
                    {
                        halal = false;
                    }

                    if (substringIngrediënten[3] == "Ja")
                    {
                        vega = true;
                    }

                    else
                    {
                        vega = false;
                    }
                    ingredïent = new Ingrediënten(substringIngrediënten[0], Convert.ToDecimal(substringIngrediënten[1]),
                        halal, vega);
                    ingrediënten.Add(ingredïent);
                    ingrediënten.Add(ingredïent.BodemBijPizza(cblBodemsoort.SelectedItem.ToString()));
                }

                if (cblGluten.SelectedItem.ToString() == "Ja")
                {
                    gluten = true;
                }
                else
                {
                    gluten = false;
                }
                    Producten CustomPizza = new Pizza("CustumPizza"+DateTime.Now.ToString(),
                        this.pizza.PrijsBepalen(ingrediënten, FormaatPizza()),
                        FormaatPizza(), clbBodemVorm.SelectedItem.ToString(), cblBodemsoort.SelectedItem.ToString(),
                        gluten,0);
                    ProductenLijstUpdate(CustomPizza);
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Niet alle velden zijn ingevuld");
            }
        }

        public decimal FormaatPizza()
        {
            if (clbBodemVorm.SelectedItem.ToString() == "Rond")
            {
                return this.pizza.RondOppervlakBerekenen(Convert.ToInt32(nUDLengteDiameter.Value));
            }

            else if (clbBodemVorm.SelectedItem.ToString() == "Vierkant")
            {
                return this.pizza.VierkantOppervlakBereken(Convert.ToInt32(nUDLengteDiameter.Value),Convert.ToInt32(nUDBreedte.Value));
            }

            else if (clbBodemVorm.SelectedItem.ToString() == "Driehoek")
            {
                return this.pizza.DrieHoekBerekenen(Convert.ToInt32(nUDLengteDiameter.Value), Convert.ToInt32(nUDBreedte.Value),Convert.ToInt32(nUDDiepte.Value));
            }
            return 0;
        }

        private void btmBestellingOpslaan_Click(object sender, EventArgs e)
        {
            Klant klant = null;
            if (nUDKlantnummer.Value != 0)
            {
                klant = new Klant(Convert.ToInt32(nUDKlantnummer.Value));
            }

            else if (tbNaam.Text != "" || tbNaam.Text != "Naam" && tbAdres.Text != "" || tbAdres.Text != "Adres")
            {
                klant = new Klant(tbNaam.Text,tbAdres.Text);
            }

            Bestelling bestelling = new Bestelling();
            bestelling.BestellingToevoegen(klant,ProductenList);
        }

        private void btnVerwijderen_Click(object sender, EventArgs e)
        {

        }

        private void btnAanpassen_Click(object sender, EventArgs e)
        {
            try
            {
                bool gluten;
                if (clbAanpassen.SelectedItem.ToString() == "Ja")
                {
                    gluten = true;
                }

                else
                {
                    gluten = false;
                }
                Pizza pizza = new Pizza(tbNaamProduct.Text, 0, FormaatPizzaAanpassen(),
                    clbVormAanpassen.SelectedItem.ToString(), clbBodemVorm.SelectedItem.ToString(), gluten, 0);
                pizza.AanpassenPizza(pizza);
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Niet alle velden zijn ingevuld");
            }
        }

        private void clbVormAanpassen_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (clbVormAanpassen.SelectedItem.ToString() == "Rond")
            {
                nUDLengteDiaAanpassen.Hide();
                nUDBreedteAanpassen.Hide();
                nUDDiepteAanpassen.Show();
            }

            else if (clbVormAanpassen.SelectedItem.ToString() == "Vierkant")
            {
                nUDLengteDiaAanpassen.Show();
                nUDBreedteAanpassen.Hide();
                nUDDiepteAanpassen.Show();
            }

            else if (clbVormAanpassen.SelectedItem.ToString() == "Driehoek")
            {
                nUDLengteDiaAanpassen.Show();
                nUDBreedteAanpassen.Show();
                nUDDiepteAanpassen.Show();
            }
        }
        public decimal FormaatPizzaAanpassen()
        {
            if (clbVormAanpassen.SelectedItem.ToString() == "Rond")
            {
                return this.pizza.RondOppervlakBerekenen(Convert.ToInt32(nUDLengteDiameter.Value));
            }

            else if (clbVormAanpassen.SelectedItem.ToString() == "Vierkant")
            {
                return this.pizza.VierkantOppervlakBereken(Convert.ToInt32(nUDLengteDiameter.Value), Convert.ToInt32(nUDBreedte.Value));
            }

            else if (clbVormAanpassen.SelectedItem.ToString() == "Driehoek")
            {
                return this.pizza.DrieHoekBerekenen(Convert.ToInt32(nUDLengteDiameter.Value), Convert.ToInt32(nUDBreedte.Value), Convert.ToInt32(nUDDiepte.Value));
            }
            return 0;
        }
    }
}
