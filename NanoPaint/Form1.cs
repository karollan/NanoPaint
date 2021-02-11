using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NanoPaint
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            szerokosc = pictureBox1.MaximumSize.Width;
            wysokosc = pictureBox1.MaximumSize.Height;

            Rozmiar_linii.SelectedIndex = 0;
            rozmiarGumki.SelectedIndex = 0;

            Bitmap bmp = new Bitmap(szerokosc, wysokosc);
            pictureBox1.Image = bmp;
            g = Graphics.FromImage(pictureBox1.Image);
        }

        Graphics g;

        Color ostatniKolor = Color.White;
        Color kolorPoKliku = Color.Gray;
        Button ostatniKlikniety = null;

        bool rysuj = false;
   
        static int szerokosc;
        static int wysokosc;

        string sciezkaPliku = null;

        bool olowek = true;
        bool gumka = false;
        bool kolo = false;
        bool elipsa = false;
        bool prostokat = false;
        bool kwadrat = false;

        int rozmiar = 10;

        Point ostatniaPozycja = Point.Empty;


        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            ostatniaPozycja = e.Location;
            rysuj = true;

            int rozmiarKsztaltu = int.Parse(l_RozmiarKsztaltu.Text);

            if (kwadrat)
            {
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                SolidBrush sb = new SolidBrush(btn_wybierzKolor.BackColor);
                g.FillRectangle(sb, e.X-rozmiarKsztaltu/2, e.Y-rozmiarKsztaltu/2, rozmiarKsztaltu, rozmiarKsztaltu);
            }
            else if (kolo)
            {
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                SolidBrush sb = new SolidBrush(btn_wybierzKolor.BackColor);
                g.FillEllipse(sb, e.X-rozmiarKsztaltu/2, e.Y-rozmiarKsztaltu/2, rozmiarKsztaltu, rozmiarKsztaltu);
            }
            else if (prostokat)
            {
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                SolidBrush sb = new SolidBrush(btn_wybierzKolor.BackColor);
                g.FillRectangle(sb, e.X-rozmiarKsztaltu, e.Y-rozmiarKsztaltu/2, 2 * rozmiarKsztaltu, rozmiarKsztaltu);
            }
            else if (elipsa)
            {
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                SolidBrush sb = new SolidBrush(btn_wybierzKolor.BackColor);
                g.FillEllipse(sb, e.X-rozmiarKsztaltu, e.Y-rozmiarKsztaltu/2, 2 * rozmiarKsztaltu, rozmiarKsztaltu);
            } else if (olowek)
            {
                try
                {
                    float rozmiar = float.Parse(Rozmiar_linii.Text);
                    if (rozmiar <= 0)
                    {
                        rysuj = false;
                        MessageBox.Show("Rozmiar nie może być ujemny lub równy zero!");
                    }
                    else
                    {
                        g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                        g.FillEllipse(new SolidBrush(btn_wybierzKolor.BackColor), e.X - rozmiar / 2, e.Y - rozmiar / 2, rozmiar, rozmiar);
                        g.DrawLine(new Pen(btn_wybierzKolor.BackColor, rozmiar), ostatniaPozycja, e.Location);
                    }
                }
                catch (Exception ex)
                {
                    rysuj = false;
                    MessageBox.Show("Nie wybrano poprawnego rozmiaru linii!");
                }
            }
            pictureBox1.Invalidate();
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            ostatniaPozycja = Point.Empty;
            rysuj = false;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (rysuj)
            {
                if (ostatniaPozycja != null)
                {
                    if (olowek)
                    {
                        try
                        {
                            float rozmiar = float.Parse(Rozmiar_linii.Text);
                            if (rozmiar <= 0)
                            {
                                rysuj = false;
                                MessageBox.Show("Rozmiar nie może być ujemny lub równy zero!");
                            }
                            else
                            {
                                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                                g.FillEllipse(new SolidBrush(btn_wybierzKolor.BackColor), e.X - rozmiar / 2, e.Y - rozmiar / 2, rozmiar, rozmiar);
                                g.DrawLine(new Pen(btn_wybierzKolor.BackColor, rozmiar), ostatniaPozycja, e.Location);
                            }
                        }
                        catch (Exception ex)
                        {
                            rysuj = false;
                            MessageBox.Show("Nie wybrano poprawnego rozmiaru linii!");
                        }

                    }
                    else if (gumka)
                    {

                        try
                        {
                            float rozmiar = float.Parse(rozmiarGumki.Text);
                            if (rozmiar <= 0)
                            {
                                MessageBox.Show("Rozmiar nie może być ujemny lub równy zero!");
                                rysuj = false;
                            }
                            else
                            {
                                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                                g.FillEllipse(new SolidBrush(kolorTla.BackColor), e.X - rozmiar / 2, e.Y - rozmiar / 2, rozmiar, rozmiar);
                                g.DrawLine(new Pen(kolorTla.BackColor, rozmiar), ostatniaPozycja, e.Location);
                            }
                        }
                        catch (Exception ex)
                        {
                            rysuj = false;
                            MessageBox.Show("Nie wybrano poprawnego rozmiaru gumki!");
                        }

                    }
                    pictureBox1.Invalidate();
                    ostatniaPozycja = e.Location;
                }
            }
        }

        private void btn_wybierzKolor_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK)
            {
                btn_wybierzKolor.BackColor = cd.Color;
            }
        }

        private void nowyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                if (MessageBox.Show("Czy chcesz zapisać zmiany przed rozpoczęciem nowej pracy?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    zapiszToolStripMenuItem.PerformClick();
                    sciezkaPliku = null;
                    nowyObraz();
                }
                else
                {
                    nowyObraz();
                }

                Invalidate();
            }
        }

        private void nowyObraz()
        {
            Cursor kursor = Cursor.Current;
            Cursor.Current = Cursors.WaitCursor;

            Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.Image = bmp;
            g = Graphics.FromImage(pictureBox1.Image);

            kolorTla.BackColor = Color.White;
            btn_wybierzKolor.BackColor = Color.Black;
            l_RozmiarKsztaltu.Text = "10";
            Rozmiar_linii.SelectedIndex = 0;
            rozmiarGumki.SelectedIndex = 0;
            btn_olowek.PerformClick();

            Cursor.Current = kursor;
            kursor.Dispose();
        }

        private void zapiszToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cursor kursor = Cursor.Current;
            Cursor.Current = Cursors.WaitCursor;

            ToolStripMenuItem item = (ToolStripMenuItem)sender;

            if (sciezkaPliku == null || item != zapiszToolStripMenuItem)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.FileName = "*.png";
                sfd.Filter = "Formaty obrazów |*.BMP;*.JPG;*.JPEG,*.PNG;*.GIF";
                sfd.FilterIndex = 2;

                ToolStripMenuItem btnSender = (ToolStripMenuItem)sender;

                if (btnSender == zapiszToolStripMenuItem || btnSender == obrazPNGToolStripMenuItem)
                {
                    sfd.FileName = "*.png";
                }
                else if (btnSender == obrazJPEGToolStripMenuItem)
                {
                    sfd.FileName = "*.jpg";
                }
                else if (btnSender == obrazBMPToolStripMenuItem)
                {
                    sfd.FileName = "*.bmp";
                }
                else if (btnSender == obrazGIFToolStripMenuItem)
                {
                    sfd.FileName = "*.gif";
                }

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                    pictureBox1.DrawToBitmap(bmp, new Rectangle(0, 0, pictureBox1.Width, pictureBox1.Height));
                    bmp.Save(sfd.FileName);
                    sciezkaPliku = sfd.FileName;
                    bmp.Dispose();
                }
            } else
            {
                Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                pictureBox1.DrawToBitmap(bmp, new Rectangle(0, 0, pictureBox1.Width, pictureBox1.Height));
                bmp.Save(sciezkaPliku);
                bmp.Dispose();
            }

            Cursor.Current = kursor;
            kursor.Dispose();

        }

        private void otworzToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cursor kursor = Cursor.Current;
            Cursor.Current = Cursors.WaitCursor;

            try
            {
                OpenFileDialog ofd = new OpenFileDialog();

                ofd.Filter = "Formaty obrazów (*.bmp;*.jpg;*.jpeg;*.png)|*.BMP;*.JPG;*.JPEG,*.PNG";


                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    Image image = Image.FromFile(ofd.FileName);
                    pictureBox1.Image = new Bitmap(FixedSize(image, szerokosc, wysokosc), szerokosc, wysokosc);
                    g = Graphics.FromImage(pictureBox1.Image);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nie wybrano pliku o prawidłowym formacie!");
            }

            Cursor.Current = kursor;
            kursor.Dispose();
        }

        private void zakonczToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            
            if (MessageBox.Show("Czy chcesz zapisać pracę przed zakończeniem?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                zapiszToolStripMenuItem.PerformClick();
                Application.Exit();
            } else
            {
                Application.Exit();
            }

        }

        private void rozmiarKsztaltu_Click(object sender, EventArgs e)
        {
            switch (rozmiar)
            {
                case 10:
                    rozmiar = 25;
                    break;
                case 25:
                    rozmiar = 50;
                    break;
                case 50:
                    rozmiar = 75;
                    break;
                case 75:
                    rozmiar = 100;
                    break;
                case 100:
                    rozmiar = 10;
                    break;
            }

            l_RozmiarKsztaltu.Text = rozmiar.ToString();
        }

        private void kolorTla_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK)
            {
                kolorTla.BackColor = cd.Color;
                SolidBrush sb = new SolidBrush(cd.Color);
                g.FillRectangle(sb, new Rectangle(0, 0, pictureBox1.Image.Width, pictureBox1.Image.Height));
                pictureBox1.Invalidate();
            }
        }

        private void rysuj_Click(object sender, EventArgs e)
        {
            Button btnSender = (Button)sender;

            olowek = false;
            gumka = false;
            kolo = false;
            elipsa = false;
            kwadrat = false;
            prostokat = false;

            if (ostatniKlikniety != null)
            {
                if (ostatniKlikniety != btnSender)
                {
                    ostatniKlikniety.BackColor = ostatniKolor;
                }
            }


            ostatniKlikniety = btnSender;
            ostatniKolor = btnSender.BackColor;
            btnSender.BackColor = kolorPoKliku;


            if (btnSender == btn_olowek)
            {
                olowek = true;
            }
            else if (btnSender == btn_gumka)
            {
                gumka = true;
            }
            else if (btnSender == btn_kolo)
            {
                kolo = true;
            }
            else if (btnSender == btn_elipsa)
            {
                elipsa = true;
            }
            else if (btnSender == btn_kwadrat)
            {
                kwadrat = true;
            }
            else if (btnSender == btn_prostokat)
            {
                prostokat = true;
            }

        }
        static Image FixedSize(Image imgPhoto, int Width, int Height)
        {
                int sourceWidth = imgPhoto.Width;
                int sourceHeight = imgPhoto.Height;
                int X = 0;
                int Y = 0;

                float nPercent = 0;
                float nPercentW = 0;
                float nPercentH = 0;

                nPercentW = ((float)Width / (float)sourceWidth);
                nPercentH = ((float)Height / (float)sourceHeight);
                if (nPercentH < nPercentW)
                {
                    nPercent = nPercentH;
                }
                else
                {
                    nPercent = nPercentW;
                }

                int destWidth = (int)(sourceWidth * nPercent);
                int destHeight = (int)(sourceHeight * nPercent);

                Bitmap bmPhoto = new Bitmap(destWidth, destHeight, PixelFormat.Format24bppRgb);

                bmPhoto.SetResolution(imgPhoto.HorizontalResolution,
                                                 imgPhoto.VerticalResolution);

                Graphics grPhoto = Graphics.FromImage(bmPhoto);

                grPhoto.DrawImage(imgPhoto,
                        new Rectangle(X, Y, destWidth, destHeight),
                        new Rectangle(X, Y, sourceWidth, sourceHeight),
                        GraphicsUnit.Pixel);

                grPhoto.Dispose();
                return bmPhoto;
        }

        private void skrotyKlawiszowe_KeyPress(object sender, KeyPressEventArgs e)
        {
                switch (e.KeyChar)
                {
                    case 'p':
                        btn_olowek.PerformClick();
                        break;
                    case 'P':
                        btn_olowek.PerformClick();
                        break;
                    case 'g':
                        btn_gumka.PerformClick();
                        break;
                    case 'G':
                        btn_olowek.PerformClick();
                        break;
                    case '1':
                        btn_kolo.PerformClick();
                        break;
                    case '2':
                        btn_elipsa.PerformClick();
                        break;
                    case '3':
                        btn_prostokat.PerformClick();
                        break;
                    case '4':
                        btn_kwadrat.PerformClick();
                        break;
                    case 'r':
                        rozmiarKsztaltu.PerformClick();
                        break;
                    case 'R':
                        btn_olowek.PerformClick();
                        break;
            }
        }

        private void pomocComboBox_MouseHover(object sender, EventArgs e)
        {
            ComboBox cb = (ComboBox)sender;
            if (cb == Rozmiar_linii)
            {
                toolTip1.Show("Wybierz szerokość ołówka.", cb);
            } else if (cb == rozmiarGumki)
            {
                toolTip1.Show("Wybierz wielkość gumki.", cb);
            }
        }

        private void pomocButton_MouseHover(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn == btn_olowek)
            {
                toolTip1.Show("Skrót - p \nNarysuj dowolną linię o wybranej długości.", btn);
            }
            else if (btn == rozmiarKsztaltu)
            {
                toolTip1.Show("Skrót - r \nZmień rozmiar rysowanego kształtu.", btn);
            }
            else if (btn == btn_gumka)
            {
                toolTip1.Show("Skrót - g \nWymaż część obrazu i zamień ją na kolor tła.", btn);
            }
            else if (btn == btn_kolo)
            {
                toolTip1.Show("Skrót - 1 \nNarysuj koło.", btn);
            }
            else if (btn == btn_elipsa)
            {
                toolTip1.Show("Skrót - 2 \nNarysuj elipsę.", btn);
            }
            else if (btn == btn_prostokat)
            {
                toolTip1.Show("Skrót - 3 \nNarysuj prostokąt.", btn);
            }
            else if (btn == btn_kwadrat)
            {
                toolTip1.Show("Skrót - 4 \nNarysuj kwadrat.", btn);
            }
            else if (btn == kolorTla)
            {
                toolTip1.Show("Kliknij tutaj, a następnie wybierz kolor z palety kolorów.\nBędzie on używany jako kolor tła. " +
                    "\nUwaga! Zmiana koloru tła powoduje usunięcie wszystkich rysunków!", btn);
            }
            else if (btn == btn_wybierzKolor)
            {
                toolTip1.Show("Kliknij tutaj, a następnie wybierz kolor z palety kolorów.\nBędzie on używany jako kolor ołówka i kształtów.", btn);
            }
        }

        private void oProgramieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 ab = new AboutBox1();
            ab.ShowDialog();
        }

        private void skrotyKlawiszowe_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.S)
            {
                zapiszToolStripMenuItem.PerformClick();
            }

            if (e.Control && e.KeyCode == Keys.O)
            {
                otworzToolStripMenuItem.PerformClick();
            }

            if (e.Control && e.KeyCode == Keys.N)
            {
                nowyToolStripMenuItem.PerformClick();
            }

            if (e.KeyCode == Keys.F12)
            {
                sciezkaPliku = null;
                zapiszToolStripMenuItem.PerformClick();
            }

        }

        private void pomocToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            ToolStripMenuItem item = (ToolStripMenuItem)sender;

            if (item == nowyToolStripMenuItem)
            {
                item.ToolTipText = "Nowy (Ctrl + N)\nUtwórz nowy obraz.";
            }
            else if (item == zapiszToolStripMenuItem)
            {
                item.ToolTipText = "Zapisz (Ctrl + S)\nZapisz bieżący obraz.";
            }
            else if (item == otworzToolStripMenuItem)
            {
                item.ToolTipText = "Otwórz (Ctrl + O)\nOtwórz istnięjący obraz.";
            }
            else if (item == zapiszJakoToolStripMenuItem)
            {
                item.ToolTipText = "Zapisz jako (F12)\nZapisz bieżący obraz jako nowy plik.";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btn_olowek.PerformClick();
        }
    }
}
