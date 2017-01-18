namespace Live_Performance
{
    partial class Pizzeria
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblBestelling = new System.Windows.Forms.Label();
            this.cbOverigeProducten = new System.Windows.Forms.ComboBox();
            this.cbPizza = new System.Windows.Forms.ComboBox();
            this.cbIngrediënten = new System.Windows.Forms.ComboBox();
            this.btmBestellingOpslaan = new System.Windows.Forms.Button();
            this.btnProducten = new System.Windows.Forms.Button();
            this.btnStndPizza = new System.Windows.Forms.Button();
            this.btnPizzaOpslaan = new System.Windows.Forms.Button();
            this.btnIngrediënten = new System.Windows.Forms.Button();
            this.lblSamenstellen = new System.Windows.Forms.Label();
            this.lblFormaat = new System.Windows.Forms.Label();
            this.lblBodem = new System.Windows.Forms.Label();
            this.nUDBreedte = new System.Windows.Forms.NumericUpDown();
            this.nUDDiepte = new System.Windows.Forms.NumericUpDown();
            this.nUDLengteDiameter = new System.Windows.Forms.NumericUpDown();
            this.lbProducten = new System.Windows.Forms.ListBox();
            this.lbIngrediënten = new System.Windows.Forms.ListBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.cblBodemsoort = new System.Windows.Forms.CheckedListBox();
            this.clbOphalen = new System.Windows.Forms.CheckedListBox();
            this.lblVorm = new System.Windows.Forms.Label();
            this.tbAdres = new System.Windows.Forms.TextBox();
            this.tbNaam = new System.Windows.Forms.TextBox();
            this.tbKlantNummer = new System.Windows.Forms.TextBox();
            this.cblGluten = new System.Windows.Forms.CheckedListBox();
            this.lblGluten = new System.Windows.Forms.Label();
            this.lblProductenAanpassen = new System.Windows.Forms.Label();
            this.lblSoortAanpassen = new System.Windows.Forms.Label();
            this.cbAanpassen = new System.Windows.Forms.ComboBox();
            this.clbAanpassen = new System.Windows.Forms.CheckedListBox();
            this.tbNaamProduct = new System.Windows.Forms.TextBox();
            this.tbInkoop = new System.Windows.Forms.TextBox();
            this.tbVerkoop = new System.Windows.Forms.TextBox();
            this.cbNaamProduct = new System.Windows.Forms.ComboBox();
            this.btnAanpassen = new System.Windows.Forms.Button();
            this.btnToevoegen = new System.Windows.Forms.Button();
            this.btnVerwijderen = new System.Windows.Forms.Button();
            this.clbHalal = new System.Windows.Forms.CheckedListBox();
            this.lblHalal = new System.Windows.Forms.Label();
            this.lblVeganistisch = new System.Windows.Forms.Label();
            this.checkedListBox2 = new System.Windows.Forms.CheckedListBox();
            this.nUDLengteDiaAanpassen = new System.Windows.Forms.NumericUpDown();
            this.nUDDiepteAanpassen = new System.Windows.Forms.NumericUpDown();
            this.nUDBreedteAanpassen = new System.Windows.Forms.NumericUpDown();
            this.lblFormaatAanpassen = new System.Windows.Forms.Label();
            this.lblBestellingBekijken = new System.Windows.Forms.Label();
            this.tbBestellingID = new System.Windows.Forms.TextBox();
            this.btnBestellingBekijken = new System.Windows.Forms.Button();
            this.lblBestellingKlaar = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnWinstOmzetBekijken = new System.Windows.Forms.Button();
            this.lblWinstOmzet = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nUDBreedte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDDiepte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDLengteDiameter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDLengteDiaAanpassen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDDiepteAanpassen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDBreedteAanpassen)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBestelling
            // 
            this.lblBestelling.AutoSize = true;
            this.lblBestelling.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBestelling.Location = new System.Drawing.Point(8, 6);
            this.lblBestelling.Name = "lblBestelling";
            this.lblBestelling.Size = new System.Drawing.Size(130, 29);
            this.lblBestelling.TabIndex = 0;
            this.lblBestelling.Text = "Bestelling";
            // 
            // cbOverigeProducten
            // 
            this.cbOverigeProducten.FormattingEnabled = true;
            this.cbOverigeProducten.Items.AddRange(new object[] {
            "Kleine salade",
            "Grote salade",
            "Frisdrank",
            "Bier",
            "Water"});
            this.cbOverigeProducten.Location = new System.Drawing.Point(12, 68);
            this.cbOverigeProducten.Name = "cbOverigeProducten";
            this.cbOverigeProducten.Size = new System.Drawing.Size(121, 24);
            this.cbOverigeProducten.TabIndex = 1;
            this.cbOverigeProducten.Text = "Producten";
            // 
            // cbPizza
            // 
            this.cbPizza.FormattingEnabled = true;
            this.cbPizza.Items.AddRange(new object[] {
            "Margherita, 25cm",
            "Margherita, 30cm",
            "Calzone, 25cm",
            "Hawaï, 20cm",
            "Giulia, 15x20x30cm",
            "Studento, 20x22cm"});
            this.cbPizza.Location = new System.Drawing.Point(12, 38);
            this.cbPizza.Name = "cbPizza";
            this.cbPizza.Size = new System.Drawing.Size(121, 24);
            this.cbPizza.TabIndex = 2;
            this.cbPizza.Text = "Pizza";
            // 
            // cbIngrediënten
            // 
            this.cbIngrediënten.FormattingEnabled = true;
            this.cbIngrediënten.Location = new System.Drawing.Point(12, 405);
            this.cbIngrediënten.Name = "cbIngrediënten";
            this.cbIngrediënten.Size = new System.Drawing.Size(121, 24);
            this.cbIngrediënten.TabIndex = 3;
            // 
            // btmBestellingOpslaan
            // 
            this.btmBestellingOpslaan.Location = new System.Drawing.Point(12, 682);
            this.btmBestellingOpslaan.Name = "btmBestellingOpslaan";
            this.btmBestellingOpslaan.Size = new System.Drawing.Size(168, 23);
            this.btmBestellingOpslaan.TabIndex = 4;
            this.btmBestellingOpslaan.Text = "Bestelling Opslaan";
            this.btmBestellingOpslaan.UseVisualStyleBackColor = true;
            // 
            // btnProducten
            // 
            this.btnProducten.Location = new System.Drawing.Point(139, 68);
            this.btnProducten.Name = "btnProducten";
            this.btnProducten.Size = new System.Drawing.Size(99, 23);
            this.btnProducten.TabIndex = 5;
            this.btnProducten.Text = "Toevoegen";
            this.btnProducten.UseVisualStyleBackColor = true;
            // 
            // btnStndPizza
            // 
            this.btnStndPizza.Location = new System.Drawing.Point(139, 39);
            this.btnStndPizza.Name = "btnStndPizza";
            this.btnStndPizza.Size = new System.Drawing.Size(99, 23);
            this.btnStndPizza.TabIndex = 6;
            this.btnStndPizza.Text = "Toevoegen";
            this.btnStndPizza.UseVisualStyleBackColor = true;
            // 
            // btnPizzaOpslaan
            // 
            this.btnPizzaOpslaan.Location = new System.Drawing.Point(12, 561);
            this.btnPizzaOpslaan.Name = "btnPizzaOpslaan";
            this.btnPizzaOpslaan.Size = new System.Drawing.Size(120, 23);
            this.btnPizzaOpslaan.TabIndex = 7;
            this.btnPizzaOpslaan.Text = "Pizza Opslaan";
            this.btnPizzaOpslaan.UseVisualStyleBackColor = true;
            // 
            // btnIngrediënten
            // 
            this.btnIngrediënten.Location = new System.Drawing.Point(13, 435);
            this.btnIngrediënten.Name = "btnIngrediënten";
            this.btnIngrediënten.Size = new System.Drawing.Size(167, 30);
            this.btnIngrediënten.TabIndex = 8;
            this.btnIngrediënten.Text = "Ingrediënt Toevoegen";
            this.btnIngrediënten.UseVisualStyleBackColor = true;
            // 
            // lblSamenstellen
            // 
            this.lblSamenstellen.AutoSize = true;
            this.lblSamenstellen.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSamenstellen.Location = new System.Drawing.Point(13, 105);
            this.lblSamenstellen.Name = "lblSamenstellen";
            this.lblSamenstellen.Size = new System.Drawing.Size(147, 17);
            this.lblSamenstellen.TabIndex = 9;
            this.lblSamenstellen.Text = "Pizza samenstellen";
            // 
            // lblFormaat
            // 
            this.lblFormaat.AutoSize = true;
            this.lblFormaat.Location = new System.Drawing.Point(10, 351);
            this.lblFormaat.Name = "lblFormaat";
            this.lblFormaat.Size = new System.Drawing.Size(60, 17);
            this.lblFormaat.TabIndex = 10;
            this.lblFormaat.Text = "Formaat";
            // 
            // lblBodem
            // 
            this.lblBodem.AutoSize = true;
            this.lblBodem.Location = new System.Drawing.Point(13, 122);
            this.lblBodem.Name = "lblBodem";
            this.lblBodem.Size = new System.Drawing.Size(84, 17);
            this.lblBodem.TabIndex = 11;
            this.lblBodem.Text = "Bodemsoort";
            // 
            // nUDBreedte
            // 
            this.nUDBreedte.Location = new System.Drawing.Point(65, 377);
            this.nUDBreedte.Name = "nUDBreedte";
            this.nUDBreedte.Size = new System.Drawing.Size(42, 22);
            this.nUDBreedte.TabIndex = 12;
            // 
            // nUDDiepte
            // 
            this.nUDDiepte.Location = new System.Drawing.Point(113, 377);
            this.nUDDiepte.Name = "nUDDiepte";
            this.nUDDiepte.Size = new System.Drawing.Size(43, 22);
            this.nUDDiepte.TabIndex = 13;
            // 
            // nUDLengteDiameter
            // 
            this.nUDLengteDiameter.Location = new System.Drawing.Point(12, 377);
            this.nUDLengteDiameter.Name = "nUDLengteDiameter";
            this.nUDLengteDiameter.Size = new System.Drawing.Size(47, 22);
            this.nUDLengteDiameter.TabIndex = 14;
            // 
            // lbProducten
            // 
            this.lbProducten.FormattingEnabled = true;
            this.lbProducten.ItemHeight = 16;
            this.lbProducten.Location = new System.Drawing.Point(138, 471);
            this.lbProducten.Name = "lbProducten";
            this.lbProducten.Size = new System.Drawing.Size(120, 84);
            this.lbProducten.TabIndex = 15;
            // 
            // lbIngrediënten
            // 
            this.lbIngrediënten.FormattingEnabled = true;
            this.lbIngrediënten.ItemHeight = 16;
            this.lbIngrediënten.Location = new System.Drawing.Point(12, 471);
            this.lbIngrediënten.Name = "lbIngrediënten";
            this.lbIngrediënten.Size = new System.Drawing.Size(120, 84);
            this.lbIngrediënten.TabIndex = 16;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Rond",
            "Vierkant",
            "Driehoek"});
            this.checkedListBox1.Location = new System.Drawing.Point(13, 259);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(120, 89);
            this.checkedListBox1.TabIndex = 17;
            // 
            // cblBodemsoort
            // 
            this.cblBodemsoort.FormattingEnabled = true;
            this.cblBodemsoort.Items.AddRange(new object[] {
            "Dun",
            "Dik"});
            this.cblBodemsoort.Location = new System.Drawing.Point(13, 142);
            this.cblBodemsoort.Name = "cblBodemsoort";
            this.cblBodemsoort.Size = new System.Drawing.Size(120, 89);
            this.cblBodemsoort.TabIndex = 18;
            // 
            // clbOphalen
            // 
            this.clbOphalen.FormattingEnabled = true;
            this.clbOphalen.Items.AddRange(new object[] {
            "Ophalen",
            "Bezorgen"});
            this.clbOphalen.Location = new System.Drawing.Point(13, 585);
            this.clbOphalen.Name = "clbOphalen";
            this.clbOphalen.Size = new System.Drawing.Size(120, 89);
            this.clbOphalen.TabIndex = 19;
            // 
            // lblVorm
            // 
            this.lblVorm.AutoSize = true;
            this.lblVorm.Location = new System.Drawing.Point(10, 239);
            this.lblVorm.Name = "lblVorm";
            this.lblVorm.Size = new System.Drawing.Size(83, 17);
            this.lblVorm.TabIndex = 20;
            this.lblVorm.Text = "Bodemvorm";
            // 
            // tbAdres
            // 
            this.tbAdres.Location = new System.Drawing.Point(139, 646);
            this.tbAdres.Name = "tbAdres";
            this.tbAdres.Size = new System.Drawing.Size(100, 22);
            this.tbAdres.TabIndex = 21;
            this.tbAdres.Text = "Adres";
            // 
            // tbNaam
            // 
            this.tbNaam.Location = new System.Drawing.Point(138, 618);
            this.tbNaam.Name = "tbNaam";
            this.tbNaam.Size = new System.Drawing.Size(100, 22);
            this.tbNaam.TabIndex = 22;
            this.tbNaam.Text = "Naam";
            // 
            // tbKlantNummer
            // 
            this.tbKlantNummer.Location = new System.Drawing.Point(139, 590);
            this.tbKlantNummer.Name = "tbKlantNummer";
            this.tbKlantNummer.Size = new System.Drawing.Size(100, 22);
            this.tbKlantNummer.TabIndex = 23;
            this.tbKlantNummer.Text = "Klantnummer";
            // 
            // cblGluten
            // 
            this.cblGluten.FormattingEnabled = true;
            this.cblGluten.Items.AddRange(new object[] {
            "Ja",
            "Nee"});
            this.cblGluten.Location = new System.Drawing.Point(139, 142);
            this.cblGluten.Name = "cblGluten";
            this.cblGluten.Size = new System.Drawing.Size(120, 89);
            this.cblGluten.TabIndex = 24;
            // 
            // lblGluten
            // 
            this.lblGluten.AutoSize = true;
            this.lblGluten.Location = new System.Drawing.Point(145, 122);
            this.lblGluten.Name = "lblGluten";
            this.lblGluten.Size = new System.Drawing.Size(68, 17);
            this.lblGluten.TabIndex = 25;
            this.lblGluten.Text = "Glutenvrij";
            // 
            // lblProductenAanpassen
            // 
            this.lblProductenAanpassen.AutoSize = true;
            this.lblProductenAanpassen.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductenAanpassen.ForeColor = System.Drawing.Color.Black;
            this.lblProductenAanpassen.Location = new System.Drawing.Point(392, 9);
            this.lblProductenAanpassen.Name = "lblProductenAanpassen";
            this.lblProductenAanpassen.Size = new System.Drawing.Size(460, 17);
            this.lblProductenAanpassen.TabIndex = 26;
            this.lblProductenAanpassen.Text = "Producten/ ingrediënten aanpassen, verwijderen of toevoegen";
            // 
            // lblSoortAanpassen
            // 
            this.lblSoortAanpassen.AutoSize = true;
            this.lblSoortAanpassen.Location = new System.Drawing.Point(392, 38);
            this.lblSoortAanpassen.Name = "lblSoortAanpassen";
            this.lblSoortAanpassen.Size = new System.Drawing.Size(254, 17);
            this.lblSoortAanpassen.TabIndex = 27;
            this.lblSoortAanpassen.Text = "Selecteer wat u wilt aanpassen en hoe.";
            // 
            // cbAanpassen
            // 
            this.cbAanpassen.FormattingEnabled = true;
            this.cbAanpassen.Items.AddRange(new object[] {
            "Standaard Pizza",
            "Overige Producten",
            "Ingrediënten"});
            this.cbAanpassen.Location = new System.Drawing.Point(395, 58);
            this.cbAanpassen.Name = "cbAanpassen";
            this.cbAanpassen.Size = new System.Drawing.Size(121, 24);
            this.cbAanpassen.TabIndex = 28;
            this.cbAanpassen.SelectedIndexChanged += new System.EventHandler(this.cbAanpassen_SelectedIndexChanged);
            // 
            // clbAanpassen
            // 
            this.clbAanpassen.FormattingEnabled = true;
            this.clbAanpassen.Items.AddRange(new object[] {
            "Toevoegen",
            "Aanpassen",
            "Verwijderen"});
            this.clbAanpassen.Location = new System.Drawing.Point(522, 58);
            this.clbAanpassen.Name = "clbAanpassen";
            this.clbAanpassen.Size = new System.Drawing.Size(120, 89);
            this.clbAanpassen.TabIndex = 29;
            // 
            // tbNaamProduct
            // 
            this.tbNaamProduct.Location = new System.Drawing.Point(395, 163);
            this.tbNaamProduct.Name = "tbNaamProduct";
            this.tbNaamProduct.Size = new System.Drawing.Size(100, 22);
            this.tbNaamProduct.TabIndex = 31;
            this.tbNaamProduct.Text = "Naam";
            // 
            // tbInkoop
            // 
            this.tbInkoop.Location = new System.Drawing.Point(501, 163);
            this.tbInkoop.Name = "tbInkoop";
            this.tbInkoop.Size = new System.Drawing.Size(100, 22);
            this.tbInkoop.TabIndex = 32;
            this.tbInkoop.Text = "Inkoop";
            // 
            // tbVerkoop
            // 
            this.tbVerkoop.Location = new System.Drawing.Point(607, 163);
            this.tbVerkoop.Name = "tbVerkoop";
            this.tbVerkoop.Size = new System.Drawing.Size(100, 22);
            this.tbVerkoop.TabIndex = 33;
            this.tbVerkoop.Text = "Verkoop";
            // 
            // cbNaamProduct
            // 
            this.cbNaamProduct.FormattingEnabled = true;
            this.cbNaamProduct.Items.AddRange(new object[] {
            "Standaard Pizza",
            "Overige Producten",
            "Ingrediënten"});
            this.cbNaamProduct.Location = new System.Drawing.Point(395, 88);
            this.cbNaamProduct.Name = "cbNaamProduct";
            this.cbNaamProduct.Size = new System.Drawing.Size(121, 24);
            this.cbNaamProduct.TabIndex = 34;
            // 
            // btnAanpassen
            // 
            this.btnAanpassen.Location = new System.Drawing.Point(395, 285);
            this.btnAanpassen.Name = "btnAanpassen";
            this.btnAanpassen.Size = new System.Drawing.Size(99, 23);
            this.btnAanpassen.TabIndex = 35;
            this.btnAanpassen.Text = "Aanpassen";
            this.btnAanpassen.UseVisualStyleBackColor = true;
            // 
            // btnToevoegen
            // 
            this.btnToevoegen.Location = new System.Drawing.Point(502, 285);
            this.btnToevoegen.Name = "btnToevoegen";
            this.btnToevoegen.Size = new System.Drawing.Size(99, 23);
            this.btnToevoegen.TabIndex = 36;
            this.btnToevoegen.Text = "Toevoegen";
            this.btnToevoegen.UseVisualStyleBackColor = true;
            // 
            // btnVerwijderen
            // 
            this.btnVerwijderen.Location = new System.Drawing.Point(607, 285);
            this.btnVerwijderen.Name = "btnVerwijderen";
            this.btnVerwijderen.Size = new System.Drawing.Size(99, 23);
            this.btnVerwijderen.TabIndex = 37;
            this.btnVerwijderen.Text = "Verwijderen";
            this.btnVerwijderen.UseVisualStyleBackColor = true;
            // 
            // clbHalal
            // 
            this.clbHalal.FormattingEnabled = true;
            this.clbHalal.Items.AddRange(new object[] {
            "Ja",
            "Nee"});
            this.clbHalal.Location = new System.Drawing.Point(394, 218);
            this.clbHalal.Name = "clbHalal";
            this.clbHalal.Size = new System.Drawing.Size(100, 38);
            this.clbHalal.TabIndex = 38;
            // 
            // lblHalal
            // 
            this.lblHalal.AutoSize = true;
            this.lblHalal.Location = new System.Drawing.Point(392, 198);
            this.lblHalal.Name = "lblHalal";
            this.lblHalal.Size = new System.Drawing.Size(40, 17);
            this.lblHalal.TabIndex = 39;
            this.lblHalal.Text = "Halal";
            // 
            // lblVeganistisch
            // 
            this.lblVeganistisch.AutoSize = true;
            this.lblVeganistisch.Location = new System.Drawing.Point(500, 198);
            this.lblVeganistisch.Name = "lblVeganistisch";
            this.lblVeganistisch.Size = new System.Drawing.Size(88, 17);
            this.lblVeganistisch.TabIndex = 41;
            this.lblVeganistisch.Text = "Veganistisch";
            // 
            // checkedListBox2
            // 
            this.checkedListBox2.FormattingEnabled = true;
            this.checkedListBox2.Items.AddRange(new object[] {
            "Ja",
            "Nee"});
            this.checkedListBox2.Location = new System.Drawing.Point(502, 218);
            this.checkedListBox2.Name = "checkedListBox2";
            this.checkedListBox2.Size = new System.Drawing.Size(100, 38);
            this.checkedListBox2.TabIndex = 40;
            // 
            // nUDLengteDiaAanpassen
            // 
            this.nUDLengteDiaAanpassen.Location = new System.Drawing.Point(617, 234);
            this.nUDLengteDiaAanpassen.Name = "nUDLengteDiaAanpassen";
            this.nUDLengteDiaAanpassen.Size = new System.Drawing.Size(47, 22);
            this.nUDLengteDiaAanpassen.TabIndex = 45;
            // 
            // nUDDiepteAanpassen
            // 
            this.nUDDiepteAanpassen.Location = new System.Drawing.Point(718, 234);
            this.nUDDiepteAanpassen.Name = "nUDDiepteAanpassen";
            this.nUDDiepteAanpassen.Size = new System.Drawing.Size(43, 22);
            this.nUDDiepteAanpassen.TabIndex = 44;
            // 
            // nUDBreedteAanpassen
            // 
            this.nUDBreedteAanpassen.Location = new System.Drawing.Point(670, 234);
            this.nUDBreedteAanpassen.Name = "nUDBreedteAanpassen";
            this.nUDBreedteAanpassen.Size = new System.Drawing.Size(42, 22);
            this.nUDBreedteAanpassen.TabIndex = 43;
            // 
            // lblFormaatAanpassen
            // 
            this.lblFormaatAanpassen.AutoSize = true;
            this.lblFormaatAanpassen.Location = new System.Drawing.Point(614, 198);
            this.lblFormaatAanpassen.Name = "lblFormaatAanpassen";
            this.lblFormaatAanpassen.Size = new System.Drawing.Size(60, 17);
            this.lblFormaatAanpassen.TabIndex = 42;
            this.lblFormaatAanpassen.Text = "Formaat";
            // 
            // lblBestellingBekijken
            // 
            this.lblBestellingBekijken.AutoSize = true;
            this.lblBestellingBekijken.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBestellingBekijken.ForeColor = System.Drawing.Color.Black;
            this.lblBestellingBekijken.Location = new System.Drawing.Point(391, 351);
            this.lblBestellingBekijken.Name = "lblBestellingBekijken";
            this.lblBestellingBekijken.Size = new System.Drawing.Size(145, 17);
            this.lblBestellingBekijken.TabIndex = 46;
            this.lblBestellingBekijken.Text = "Bestelling Bekijken";
            // 
            // tbBestellingID
            // 
            this.tbBestellingID.Location = new System.Drawing.Point(395, 377);
            this.tbBestellingID.Name = "tbBestellingID";
            this.tbBestellingID.Size = new System.Drawing.Size(100, 22);
            this.tbBestellingID.TabIndex = 47;
            this.tbBestellingID.Text = "BestellingID";
            // 
            // btnBestellingBekijken
            // 
            this.btnBestellingBekijken.Location = new System.Drawing.Point(507, 373);
            this.btnBestellingBekijken.Name = "btnBestellingBekijken";
            this.btnBestellingBekijken.Size = new System.Drawing.Size(135, 30);
            this.btnBestellingBekijken.TabIndex = 48;
            this.btnBestellingBekijken.Text = "Bestelling Bekijken";
            this.btnBestellingBekijken.UseVisualStyleBackColor = true;
            // 
            // lblBestellingKlaar
            // 
            this.lblBestellingKlaar.AutoSize = true;
            this.lblBestellingKlaar.Location = new System.Drawing.Point(392, 412);
            this.lblBestellingKlaar.Name = "lblBestellingKlaar";
            this.lblBestellingKlaar.Size = new System.Drawing.Size(204, 17);
            this.lblBestellingKlaar.TabIndex = 49;
            this.lblBestellingKlaar.Text = "Bestelling is klaar over minuten";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(394, 471);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(213, 22);
            this.dateTimePicker1.TabIndex = 50;
            // 
            // btnWinstOmzetBekijken
            // 
            this.btnWinstOmzetBekijken.Location = new System.Drawing.Point(394, 499);
            this.btnWinstOmzetBekijken.Name = "btnWinstOmzetBekijken";
            this.btnWinstOmzetBekijken.Size = new System.Drawing.Size(135, 30);
            this.btnWinstOmzetBekijken.TabIndex = 51;
            this.btnWinstOmzetBekijken.Text = "Bekijken";
            this.btnWinstOmzetBekijken.UseVisualStyleBackColor = true;
            // 
            // lblWinstOmzet
            // 
            this.lblWinstOmzet.AutoSize = true;
            this.lblWinstOmzet.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWinstOmzet.ForeColor = System.Drawing.Color.Black;
            this.lblWinstOmzet.Location = new System.Drawing.Point(391, 451);
            this.lblWinstOmzet.Name = "lblWinstOmzet";
            this.lblWinstOmzet.Size = new System.Drawing.Size(184, 17);
            this.lblWinstOmzet.TabIndex = 52;
            this.lblWinstOmzet.Text = "Winst en omzet bekijken";
            // 
            // Pizzeria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 717);
            this.Controls.Add(this.lblWinstOmzet);
            this.Controls.Add(this.btnWinstOmzetBekijken);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lblBestellingKlaar);
            this.Controls.Add(this.btnBestellingBekijken);
            this.Controls.Add(this.tbBestellingID);
            this.Controls.Add(this.lblBestellingBekijken);
            this.Controls.Add(this.nUDLengteDiaAanpassen);
            this.Controls.Add(this.nUDDiepteAanpassen);
            this.Controls.Add(this.nUDBreedteAanpassen);
            this.Controls.Add(this.lblFormaatAanpassen);
            this.Controls.Add(this.lblVeganistisch);
            this.Controls.Add(this.checkedListBox2);
            this.Controls.Add(this.lblHalal);
            this.Controls.Add(this.clbHalal);
            this.Controls.Add(this.btnVerwijderen);
            this.Controls.Add(this.btnToevoegen);
            this.Controls.Add(this.btnAanpassen);
            this.Controls.Add(this.cbNaamProduct);
            this.Controls.Add(this.tbVerkoop);
            this.Controls.Add(this.tbInkoop);
            this.Controls.Add(this.tbNaamProduct);
            this.Controls.Add(this.clbAanpassen);
            this.Controls.Add(this.cbAanpassen);
            this.Controls.Add(this.lblSoortAanpassen);
            this.Controls.Add(this.lblProductenAanpassen);
            this.Controls.Add(this.lblGluten);
            this.Controls.Add(this.cblGluten);
            this.Controls.Add(this.tbKlantNummer);
            this.Controls.Add(this.tbNaam);
            this.Controls.Add(this.tbAdres);
            this.Controls.Add(this.lblVorm);
            this.Controls.Add(this.clbOphalen);
            this.Controls.Add(this.cblBodemsoort);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.lbIngrediënten);
            this.Controls.Add(this.lbProducten);
            this.Controls.Add(this.nUDLengteDiameter);
            this.Controls.Add(this.nUDDiepte);
            this.Controls.Add(this.nUDBreedte);
            this.Controls.Add(this.lblBodem);
            this.Controls.Add(this.lblFormaat);
            this.Controls.Add(this.lblSamenstellen);
            this.Controls.Add(this.btnIngrediënten);
            this.Controls.Add(this.btnPizzaOpslaan);
            this.Controls.Add(this.btnStndPizza);
            this.Controls.Add(this.btnProducten);
            this.Controls.Add(this.btmBestellingOpslaan);
            this.Controls.Add(this.cbIngrediënten);
            this.Controls.Add(this.cbPizza);
            this.Controls.Add(this.cbOverigeProducten);
            this.Controls.Add(this.lblBestelling);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Pizzeria";
            this.Text = "Pizzeria";
            ((System.ComponentModel.ISupportInitialize)(this.nUDBreedte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDDiepte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDLengteDiameter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDLengteDiaAanpassen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDDiepteAanpassen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDBreedteAanpassen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBestelling;
        private System.Windows.Forms.ComboBox cbOverigeProducten;
        private System.Windows.Forms.ComboBox cbPizza;
        private System.Windows.Forms.ComboBox cbIngrediënten;
        private System.Windows.Forms.Button btmBestellingOpslaan;
        private System.Windows.Forms.Button btnProducten;
        private System.Windows.Forms.Button btnStndPizza;
        private System.Windows.Forms.Button btnPizzaOpslaan;
        private System.Windows.Forms.Button btnIngrediënten;
        private System.Windows.Forms.Label lblSamenstellen;
        private System.Windows.Forms.Label lblFormaat;
        private System.Windows.Forms.Label lblBodem;
        private System.Windows.Forms.NumericUpDown nUDBreedte;
        private System.Windows.Forms.NumericUpDown nUDDiepte;
        private System.Windows.Forms.NumericUpDown nUDLengteDiameter;
        private System.Windows.Forms.ListBox lbProducten;
        private System.Windows.Forms.ListBox lbIngrediënten;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.CheckedListBox cblBodemsoort;
        private System.Windows.Forms.CheckedListBox clbOphalen;
        private System.Windows.Forms.Label lblVorm;
        private System.Windows.Forms.TextBox tbAdres;
        private System.Windows.Forms.TextBox tbNaam;
        private System.Windows.Forms.TextBox tbKlantNummer;
        private System.Windows.Forms.CheckedListBox cblGluten;
        private System.Windows.Forms.Label lblGluten;
        private System.Windows.Forms.Label lblProductenAanpassen;
        private System.Windows.Forms.Label lblSoortAanpassen;
        private System.Windows.Forms.ComboBox cbAanpassen;
        private System.Windows.Forms.CheckedListBox clbAanpassen;
        private System.Windows.Forms.TextBox tbNaamProduct;
        private System.Windows.Forms.TextBox tbInkoop;
        private System.Windows.Forms.TextBox tbVerkoop;
        private System.Windows.Forms.ComboBox cbNaamProduct;
        private System.Windows.Forms.Button btnAanpassen;
        private System.Windows.Forms.Button btnToevoegen;
        private System.Windows.Forms.Button btnVerwijderen;
        private System.Windows.Forms.CheckedListBox clbHalal;
        private System.Windows.Forms.Label lblHalal;
        private System.Windows.Forms.Label lblVeganistisch;
        private System.Windows.Forms.CheckedListBox checkedListBox2;
        private System.Windows.Forms.NumericUpDown nUDLengteDiaAanpassen;
        private System.Windows.Forms.NumericUpDown nUDDiepteAanpassen;
        private System.Windows.Forms.NumericUpDown nUDBreedteAanpassen;
        private System.Windows.Forms.Label lblFormaatAanpassen;
        private System.Windows.Forms.Label lblBestellingBekijken;
        private System.Windows.Forms.TextBox tbBestellingID;
        private System.Windows.Forms.Button btnBestellingBekijken;
        private System.Windows.Forms.Label lblBestellingKlaar;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnWinstOmzetBekijken;
        private System.Windows.Forms.Label lblWinstOmzet;
    }
}

