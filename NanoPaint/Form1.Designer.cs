namespace NanoPaint
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.plikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nowyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otworzToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zapiszToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zapiszJakoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.obrazPNGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.obrazJPEGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.obrazBMPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.obrazGIFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zakonczToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oProgramieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.l_olowek = new System.Windows.Forms.Label();
            this.btn_olowek = new System.Windows.Forms.Button();
            this.rozmiarGumki = new System.Windows.Forms.ComboBox();
            this.l_rozmiarGumkiTekst = new System.Windows.Forms.Label();
            this.btn_gumka = new System.Windows.Forms.Button();
            this.l_RozmiarKsztaltu = new System.Windows.Forms.Label();
            this.rozmiarKsztaltu = new System.Windows.Forms.Button();
            this.l_Ksztalt = new System.Windows.Forms.Label();
            this.btn_prostokat = new System.Windows.Forms.Button();
            this.btn_kwadrat = new System.Windows.Forms.Button();
            this.l_kolorTla = new System.Windows.Forms.Label();
            this.kolorTla = new System.Windows.Forms.Button();
            this.l_RozmiarLinii = new System.Windows.Forms.Label();
            this.Rozmiar_linii = new System.Windows.Forms.ComboBox();
            this.l_Kolor = new System.Windows.Forms.Label();
            this.btn_wybierzKolor = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btn_kolo = new NanoPaint.RoundButton();
            this.btn_elipsa = new NanoPaint.RoundButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(0, 120);
            this.pictureBox1.MaximumSize = new System.Drawing.Size(1280, 720);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1250, 513);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plikToolStripMenuItem,
            this.oProgramieToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1244, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // plikToolStripMenuItem
            // 
            this.plikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nowyToolStripMenuItem,
            this.otworzToolStripMenuItem,
            this.zapiszToolStripMenuItem,
            this.zapiszJakoToolStripMenuItem,
            this.zakonczToolStripMenuItem});
            this.plikToolStripMenuItem.Name = "plikToolStripMenuItem";
            this.plikToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.plikToolStripMenuItem.Text = "Plik";
            // 
            // nowyToolStripMenuItem
            // 
            this.nowyToolStripMenuItem.Name = "nowyToolStripMenuItem";
            this.nowyToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.nowyToolStripMenuItem.Text = "Nowy";
            this.nowyToolStripMenuItem.Click += new System.EventHandler(this.nowyToolStripMenuItem_Click);
            this.nowyToolStripMenuItem.MouseHover += new System.EventHandler(this.pomocToolStripMenuItem_MouseHover);
            // 
            // otworzToolStripMenuItem
            // 
            this.otworzToolStripMenuItem.Name = "otworzToolStripMenuItem";
            this.otworzToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.otworzToolStripMenuItem.Text = "Otwórz";
            this.otworzToolStripMenuItem.Click += new System.EventHandler(this.otworzToolStripMenuItem_Click);
            this.otworzToolStripMenuItem.MouseHover += new System.EventHandler(this.pomocToolStripMenuItem_MouseHover);
            // 
            // zapiszToolStripMenuItem
            // 
            this.zapiszToolStripMenuItem.Name = "zapiszToolStripMenuItem";
            this.zapiszToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.zapiszToolStripMenuItem.Text = "Zapisz";
            this.zapiszToolStripMenuItem.Click += new System.EventHandler(this.zapiszToolStripMenuItem_Click);
            this.zapiszToolStripMenuItem.MouseHover += new System.EventHandler(this.pomocToolStripMenuItem_MouseHover);
            // 
            // zapiszJakoToolStripMenuItem
            // 
            this.zapiszJakoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.obrazPNGToolStripMenuItem,
            this.obrazJPEGToolStripMenuItem,
            this.obrazGIFToolStripMenuItem,
            this.obrazBMPToolStripMenuItem});
            this.zapiszJakoToolStripMenuItem.Name = "zapiszJakoToolStripMenuItem";
            this.zapiszJakoToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.zapiszJakoToolStripMenuItem.Text = "Zapisz jako";
            this.zapiszJakoToolStripMenuItem.MouseHover += new System.EventHandler(this.pomocToolStripMenuItem_MouseHover);
            // 
            // obrazPNGToolStripMenuItem
            // 
            this.obrazPNGToolStripMenuItem.Name = "obrazPNGToolStripMenuItem";
            this.obrazPNGToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.obrazPNGToolStripMenuItem.Text = "Obraz PNG";
            this.obrazPNGToolStripMenuItem.Click += new System.EventHandler(this.zapiszToolStripMenuItem_Click);
            // 
            // obrazJPEGToolStripMenuItem
            // 
            this.obrazJPEGToolStripMenuItem.Name = "obrazJPEGToolStripMenuItem";
            this.obrazJPEGToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.obrazJPEGToolStripMenuItem.Text = "Obraz JPEG";
            this.obrazJPEGToolStripMenuItem.Click += new System.EventHandler(this.zapiszToolStripMenuItem_Click);
            // 
            // obrazBMPToolStripMenuItem
            // 
            this.obrazBMPToolStripMenuItem.Name = "obrazBMPToolStripMenuItem";
            this.obrazBMPToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.obrazBMPToolStripMenuItem.Text = "Obraz BMP";
            this.obrazBMPToolStripMenuItem.Click += new System.EventHandler(this.zapiszToolStripMenuItem_Click);
            // 
            // obrazGIFToolStripMenuItem
            // 
            this.obrazGIFToolStripMenuItem.Name = "obrazGIFToolStripMenuItem";
            this.obrazGIFToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.obrazGIFToolStripMenuItem.Text = "Obraz GIF";
            this.obrazGIFToolStripMenuItem.Click += new System.EventHandler(this.zapiszToolStripMenuItem_Click);
            // 
            // zakonczToolStripMenuItem
            // 
            this.zakonczToolStripMenuItem.Name = "zakonczToolStripMenuItem";
            this.zakonczToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.zakonczToolStripMenuItem.Text = "Zakończ";
            this.zakonczToolStripMenuItem.Click += new System.EventHandler(this.zakonczToolStripMenuItem_Click);
            // 
            // oProgramieToolStripMenuItem
            // 
            this.oProgramieToolStripMenuItem.Name = "oProgramieToolStripMenuItem";
            this.oProgramieToolStripMenuItem.Size = new System.Drawing.Size(108, 24);
            this.oProgramieToolStripMenuItem.Text = "O programie";
            this.oProgramieToolStripMenuItem.Click += new System.EventHandler(this.oProgramieToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.l_olowek);
            this.panel1.Controls.Add(this.btn_olowek);
            this.panel1.Controls.Add(this.btn_kolo);
            this.panel1.Controls.Add(this.btn_elipsa);
            this.panel1.Controls.Add(this.rozmiarGumki);
            this.panel1.Controls.Add(this.l_rozmiarGumkiTekst);
            this.panel1.Controls.Add(this.btn_gumka);
            this.panel1.Controls.Add(this.l_RozmiarKsztaltu);
            this.panel1.Controls.Add(this.rozmiarKsztaltu);
            this.panel1.Controls.Add(this.l_Ksztalt);
            this.panel1.Controls.Add(this.btn_prostokat);
            this.panel1.Controls.Add(this.btn_kwadrat);
            this.panel1.Controls.Add(this.l_kolorTla);
            this.panel1.Controls.Add(this.kolorTla);
            this.panel1.Controls.Add(this.l_RozmiarLinii);
            this.panel1.Controls.Add(this.Rozmiar_linii);
            this.panel1.Controls.Add(this.l_Kolor);
            this.panel1.Controls.Add(this.btn_wybierzKolor);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1244, 92);
            this.panel1.TabIndex = 2;
            // 
            // l_olowek
            // 
            this.l_olowek.AutoSize = true;
            this.l_olowek.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.l_olowek.Location = new System.Drawing.Point(915, 54);
            this.l_olowek.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.l_olowek.Name = "l_olowek";
            this.l_olowek.Size = new System.Drawing.Size(70, 20);
            this.l_olowek.TabIndex = 32;
            this.l_olowek.Text = "Ołówek";
            // 
            // btn_olowek
            // 
            this.btn_olowek.BackColor = System.Drawing.Color.White;
            this.btn_olowek.BackgroundImage = global::NanoPaint.Properties.Resources.pencil_64x64;
            this.btn_olowek.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_olowek.Location = new System.Drawing.Point(928, 10);
            this.btn_olowek.Name = "btn_olowek";
            this.btn_olowek.Size = new System.Drawing.Size(45, 43);
            this.btn_olowek.TabIndex = 31;
            this.btn_olowek.UseVisualStyleBackColor = false;
            this.btn_olowek.Click += new System.EventHandler(this.rysuj_Click);
            this.btn_olowek.KeyDown += new System.Windows.Forms.KeyEventHandler(this.skrotyKlawiszowe_KeyDown);
            this.btn_olowek.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.skrotyKlawiszowe_KeyPress);
            this.btn_olowek.MouseHover += new System.EventHandler(this.pomocButton_MouseHover);
            // 
            // rozmiarGumki
            // 
            this.rozmiarGumki.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.rozmiarGumki.FormattingEnabled = true;
            this.rozmiarGumki.Items.AddRange(new object[] {
            "10",
            "20",
            "30",
            "40",
            "50"});
            this.rozmiarGumki.Location = new System.Drawing.Point(162, 49);
            this.rozmiarGumki.Margin = new System.Windows.Forms.Padding(4);
            this.rozmiarGumki.Name = "rozmiarGumki";
            this.rozmiarGumki.Size = new System.Drawing.Size(51, 24);
            this.rozmiarGumki.TabIndex = 28;
            this.rozmiarGumki.KeyDown += new System.Windows.Forms.KeyEventHandler(this.skrotyKlawiszowe_KeyDown);
            this.rozmiarGumki.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.skrotyKlawiszowe_KeyPress);
            this.rozmiarGumki.MouseHover += new System.EventHandler(this.pomocComboBox_MouseHover);
            // 
            // l_rozmiarGumkiTekst
            // 
            this.l_rozmiarGumkiTekst.AutoSize = true;
            this.l_rozmiarGumkiTekst.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.l_rozmiarGumkiTekst.Location = new System.Drawing.Point(8, 50);
            this.l_rozmiarGumkiTekst.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.l_rozmiarGumkiTekst.Name = "l_rozmiarGumkiTekst";
            this.l_rozmiarGumkiTekst.Size = new System.Drawing.Size(140, 20);
            this.l_rozmiarGumkiTekst.TabIndex = 27;
            this.l_rozmiarGumkiTekst.Text = "Rozmiar gumki:";
            // 
            // btn_gumka
            // 
            this.btn_gumka.BackColor = System.Drawing.Color.Pink;
            this.btn_gumka.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_gumka.Location = new System.Drawing.Point(64, 12);
            this.btn_gumka.Margin = new System.Windows.Forms.Padding(4);
            this.btn_gumka.Name = "btn_gumka";
            this.btn_gumka.Size = new System.Drawing.Size(103, 30);
            this.btn_gumka.TabIndex = 26;
            this.btn_gumka.Text = "Gumka";
            this.btn_gumka.UseVisualStyleBackColor = false;
            this.btn_gumka.Click += new System.EventHandler(this.rysuj_Click);
            this.btn_gumka.KeyDown += new System.Windows.Forms.KeyEventHandler(this.skrotyKlawiszowe_KeyDown);
            this.btn_gumka.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.skrotyKlawiszowe_KeyPress);
            this.btn_gumka.MouseHover += new System.EventHandler(this.pomocButton_MouseHover);
            // 
            // l_RozmiarKsztaltu
            // 
            this.l_RozmiarKsztaltu.AutoSize = true;
            this.l_RozmiarKsztaltu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.l_RozmiarKsztaltu.Location = new System.Drawing.Point(273, 48);
            this.l_RozmiarKsztaltu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.l_RozmiarKsztaltu.Name = "l_RozmiarKsztaltu";
            this.l_RozmiarKsztaltu.Size = new System.Drawing.Size(36, 25);
            this.l_RozmiarKsztaltu.TabIndex = 25;
            this.l_RozmiarKsztaltu.Text = "10";
            // 
            // rozmiarKsztaltu
            // 
            this.rozmiarKsztaltu.BackColor = System.Drawing.Color.White;
            this.rozmiarKsztaltu.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.rozmiarKsztaltu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rozmiarKsztaltu.Location = new System.Drawing.Point(229, 10);
            this.rozmiarKsztaltu.Margin = new System.Windows.Forms.Padding(4);
            this.rozmiarKsztaltu.Name = "rozmiarKsztaltu";
            this.rozmiarKsztaltu.Size = new System.Drawing.Size(131, 32);
            this.rozmiarKsztaltu.TabIndex = 24;
            this.rozmiarKsztaltu.Text = "Rozmiar kształtu";
            this.rozmiarKsztaltu.UseVisualStyleBackColor = false;
            this.rozmiarKsztaltu.Click += new System.EventHandler(this.rozmiarKsztaltu_Click);
            this.rozmiarKsztaltu.KeyDown += new System.Windows.Forms.KeyEventHandler(this.skrotyKlawiszowe_KeyDown);
            this.rozmiarKsztaltu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.skrotyKlawiszowe_KeyPress);
            this.rozmiarKsztaltu.MouseHover += new System.EventHandler(this.pomocButton_MouseHover);
            // 
            // l_Ksztalt
            // 
            this.l_Ksztalt.AutoSize = true;
            this.l_Ksztalt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.l_Ksztalt.Location = new System.Drawing.Point(492, 57);
            this.l_Ksztalt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.l_Ksztalt.Name = "l_Ksztalt";
            this.l_Ksztalt.Size = new System.Drawing.Size(127, 20);
            this.l_Ksztalt.TabIndex = 23;
            this.l_Ksztalt.Text = "Wstaw kształt";
            // 
            // btn_prostokat
            // 
            this.btn_prostokat.BackColor = System.Drawing.Color.Gold;
            this.btn_prostokat.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_prostokat.FlatAppearance.BorderSize = 0;
            this.btn_prostokat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_prostokat.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_prostokat.Location = new System.Drawing.Point(571, 14);
            this.btn_prostokat.Margin = new System.Windows.Forms.Padding(4);
            this.btn_prostokat.Name = "btn_prostokat";
            this.btn_prostokat.Size = new System.Drawing.Size(69, 37);
            this.btn_prostokat.TabIndex = 22;
            this.btn_prostokat.UseVisualStyleBackColor = false;
            this.btn_prostokat.Click += new System.EventHandler(this.rysuj_Click);
            this.btn_prostokat.KeyDown += new System.Windows.Forms.KeyEventHandler(this.skrotyKlawiszowe_KeyDown);
            this.btn_prostokat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.skrotyKlawiszowe_KeyPress);
            this.btn_prostokat.MouseHover += new System.EventHandler(this.pomocButton_MouseHover);
            // 
            // btn_kwadrat
            // 
            this.btn_kwadrat.BackColor = System.Drawing.Color.YellowGreen;
            this.btn_kwadrat.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_kwadrat.FlatAppearance.BorderSize = 0;
            this.btn_kwadrat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_kwadrat.Location = new System.Drawing.Point(679, 14);
            this.btn_kwadrat.Margin = new System.Windows.Forms.Padding(4);
            this.btn_kwadrat.Name = "btn_kwadrat";
            this.btn_kwadrat.Size = new System.Drawing.Size(40, 37);
            this.btn_kwadrat.TabIndex = 21;
            this.btn_kwadrat.UseVisualStyleBackColor = false;
            this.btn_kwadrat.Click += new System.EventHandler(this.rysuj_Click);
            this.btn_kwadrat.KeyDown += new System.Windows.Forms.KeyEventHandler(this.skrotyKlawiszowe_KeyDown);
            this.btn_kwadrat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.skrotyKlawiszowe_KeyPress);
            this.btn_kwadrat.MouseHover += new System.EventHandler(this.pomocButton_MouseHover);
            // 
            // l_kolorTla
            // 
            this.l_kolorTla.AutoSize = true;
            this.l_kolorTla.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.l_kolorTla.Location = new System.Drawing.Point(779, 54);
            this.l_kolorTla.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.l_kolorTla.Name = "l_kolorTla";
            this.l_kolorTla.Size = new System.Drawing.Size(80, 20);
            this.l_kolorTla.TabIndex = 20;
            this.l_kolorTla.Text = "Kolor tła";
            // 
            // kolorTla
            // 
            this.kolorTla.BackColor = System.Drawing.Color.White;
            this.kolorTla.Location = new System.Drawing.Point(751, 15);
            this.kolorTla.Margin = new System.Windows.Forms.Padding(4);
            this.kolorTla.Name = "kolorTla";
            this.kolorTla.Size = new System.Drawing.Size(141, 28);
            this.kolorTla.TabIndex = 19;
            this.kolorTla.UseVisualStyleBackColor = false;
            this.kolorTla.Click += new System.EventHandler(this.kolorTla_Click);
            this.kolorTla.KeyDown += new System.Windows.Forms.KeyEventHandler(this.skrotyKlawiszowe_KeyDown);
            this.kolorTla.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.skrotyKlawiszowe_KeyPress);
            this.kolorTla.MouseHover += new System.EventHandler(this.pomocButton_MouseHover);
            // 
            // l_RozmiarLinii
            // 
            this.l_RozmiarLinii.AutoSize = true;
            this.l_RozmiarLinii.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.l_RozmiarLinii.Location = new System.Drawing.Point(1015, 54);
            this.l_RozmiarLinii.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.l_RozmiarLinii.Name = "l_RozmiarLinii";
            this.l_RozmiarLinii.Size = new System.Drawing.Size(115, 20);
            this.l_RozmiarLinii.TabIndex = 18;
            this.l_RozmiarLinii.Text = "Rozmiar linii";
            // 
            // Rozmiar_linii
            // 
            this.Rozmiar_linii.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Rozmiar_linii.FormattingEnabled = true;
            this.Rozmiar_linii.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "10"});
            this.Rozmiar_linii.Location = new System.Drawing.Point(1033, 19);
            this.Rozmiar_linii.Margin = new System.Windows.Forms.Padding(4);
            this.Rozmiar_linii.Name = "Rozmiar_linii";
            this.Rozmiar_linii.Size = new System.Drawing.Size(81, 24);
            this.Rozmiar_linii.TabIndex = 17;
            this.Rozmiar_linii.KeyDown += new System.Windows.Forms.KeyEventHandler(this.skrotyKlawiszowe_KeyDown);
            this.Rozmiar_linii.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.skrotyKlawiszowe_KeyPress);
            this.Rozmiar_linii.MouseHover += new System.EventHandler(this.pomocComboBox_MouseHover);
            // 
            // l_Kolor
            // 
            this.l_Kolor.AutoSize = true;
            this.l_Kolor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.l_Kolor.Location = new System.Drawing.Point(1149, 54);
            this.l_Kolor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.l_Kolor.Name = "l_Kolor";
            this.l_Kolor.Size = new System.Drawing.Size(53, 20);
            this.l_Kolor.TabIndex = 2;
            this.l_Kolor.Text = "Kolor";
            // 
            // btn_wybierzKolor
            // 
            this.btn_wybierzKolor.BackColor = System.Drawing.Color.Black;
            this.btn_wybierzKolor.Location = new System.Drawing.Point(1153, 8);
            this.btn_wybierzKolor.Name = "btn_wybierzKolor";
            this.btn_wybierzKolor.Size = new System.Drawing.Size(44, 43);
            this.btn_wybierzKolor.TabIndex = 0;
            this.btn_wybierzKolor.UseVisualStyleBackColor = false;
            this.btn_wybierzKolor.Click += new System.EventHandler(this.btn_wybierzKolor_Click);
            this.btn_wybierzKolor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.skrotyKlawiszowe_KeyDown);
            this.btn_wybierzKolor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.skrotyKlawiszowe_KeyPress);
            this.btn_wybierzKolor.MouseHover += new System.EventHandler(this.pomocButton_MouseHover);
            // 
            // btn_kolo
            // 
            this.btn_kolo.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_kolo.FlatAppearance.BorderSize = 0;
            this.btn_kolo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_kolo.Location = new System.Drawing.Point(387, 11);
            this.btn_kolo.Name = "btn_kolo";
            this.btn_kolo.Size = new System.Drawing.Size(44, 44);
            this.btn_kolo.TabIndex = 30;
            this.btn_kolo.UseVisualStyleBackColor = false;
            this.btn_kolo.Click += new System.EventHandler(this.rysuj_Click);
            this.btn_kolo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.skrotyKlawiszowe_KeyDown);
            this.btn_kolo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.skrotyKlawiszowe_KeyPress);
            this.btn_kolo.MouseHover += new System.EventHandler(this.pomocButton_MouseHover);
            // 
            // btn_elipsa
            // 
            this.btn_elipsa.BackColor = System.Drawing.Color.LightCoral;
            this.btn_elipsa.FlatAppearance.BorderSize = 0;
            this.btn_elipsa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_elipsa.Location = new System.Drawing.Point(460, 13);
            this.btn_elipsa.Name = "btn_elipsa";
            this.btn_elipsa.Size = new System.Drawing.Size(89, 41);
            this.btn_elipsa.TabIndex = 29;
            this.btn_elipsa.UseVisualStyleBackColor = false;
            this.btn_elipsa.Click += new System.EventHandler(this.rysuj_Click);
            this.btn_elipsa.KeyDown += new System.Windows.Forms.KeyEventHandler(this.skrotyKlawiszowe_KeyDown);
            this.btn_elipsa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.skrotyKlawiszowe_KeyPress);
            this.btn_elipsa.MouseHover += new System.EventHandler(this.pomocButton_MouseHover);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1244, 634);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "NanoPaint";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.skrotyKlawiszowe_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.skrotyKlawiszowe_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_wybierzKolor;
        private System.Windows.Forms.ToolStripMenuItem plikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nowyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zapiszToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem otworzToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zakonczToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zapiszJakoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem obrazPNGToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem obrazJPEGToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem obrazBMPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem obrazGIFToolStripMenuItem;
        private System.Windows.Forms.Label l_Kolor;
        private System.Windows.Forms.ComboBox rozmiarGumki;
        private System.Windows.Forms.Label l_rozmiarGumkiTekst;
        private System.Windows.Forms.Button btn_gumka;
        private System.Windows.Forms.Label l_RozmiarKsztaltu;
        private System.Windows.Forms.Button rozmiarKsztaltu;
        private System.Windows.Forms.Label l_Ksztalt;
        private System.Windows.Forms.Button btn_prostokat;
        private System.Windows.Forms.Button btn_kwadrat;
        private System.Windows.Forms.Label l_kolorTla;
        private System.Windows.Forms.Button kolorTla;
        private System.Windows.Forms.Label l_RozmiarLinii;
        private System.Windows.Forms.ComboBox Rozmiar_linii;
        private RoundButton btn_kolo;
        private RoundButton btn_elipsa;
        private System.Windows.Forms.Button btn_olowek;
        private System.Windows.Forms.Label l_olowek;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolStripMenuItem oProgramieToolStripMenuItem;
    }
}

