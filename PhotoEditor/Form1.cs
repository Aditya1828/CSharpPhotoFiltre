using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.IO;

/*
     
    CODE BY RAINBOWPHOENIX

    COPYRIGHT (C) 2015 RAINBOWPHOENIX

    IF U USE THAT SHITTY CODE PLEASE QUOTE ME 

    THX A LOT M8
*/


namespace PhotoEditor
{
    public partial class MainFrm : Form
    {
        public MainFrm()
        {
            InitializeComponent();
        }
        public int slctd = 0;

        //TOODO: Better Load Dialog ?
        private void btnload_Click(object sender, EventArgs e)
        {
            DialogResult result = opnfldlg.ShowDialog();
            if (result == DialogResult.OK)
            {
                pctrgnl.Image = Image.FromFile(opnfldlg.FileName);

                //Panel visibility for debug

                TopPnl.Visible = true;
                flatsave.Visible = true;

                mnsv.Visible = true;
                //TODO: debug

                Bitmap ToFiltre = new Bitmap(pctrgnl.Image);

                pctmdf.Image = ToFiltre;

            }
        }

        //TODO: Some options about quality of the saved image ?
        private void savebtn_Click(object sender, EventArgs e)
        {
            svfldlg.ShowDialog();
            if (!(svfldlg.FileName == ""))
                pctmdf.Image.Save(svfldlg.FileName);
        }


        //TODO: End all started threads
        private void btnexit_Click(object sender, EventArgs e)
        {
            Close();
        }

        //TODO: I dunno m8 - here it's only for send a picture from 1 to 2
        private void sendbtn_Click(object sender, EventArgs e)
        {
            Bitmap ToFiltre = new Bitmap(pctrgnl.Image);

            pctmdf.Image = ToFiltre;
        }

        //TODO: Adaptive Gray Scale
        public void SetGrayscale()
        {
            Bitmap ToFiltre = new Bitmap(pctrgnl.Image);
            Bitmap Filtrered = new Bitmap(ToFiltre);
            Color couleurs;
            busy.Visible = true;
            for (int x = 0; x < ToFiltre.Width; x++)
            {
                for (int y = 0; y < ToFiltre.Height; y++)
                {
                    couleurs = ToFiltre.GetPixel(x, y);
                    byte gray = (byte)(.299 * couleurs.R + .587 * couleurs.G + .114 * couleurs.B);

                    ToFiltre.SetPixel(x, y, Color.FromArgb(gray, gray, gray));
                }
            }
            Filtrered = (Bitmap)ToFiltre.Clone();
            pctmdf.Image = Filtrered;
            busy.Visible = false;
        }

        //TODO: Nothing XD
        private void mynbtn_Click(object sender, EventArgs e)
        {
            DoMynn();
        }

        //TODO: Optimization and Median Sizes (3, 5, 7, 9 ...)
        private void DoMdn()
        {
            Bitmap ToFiltre = new Bitmap(pctrgnl.Image);
            Bitmap Filtrered = new Bitmap(ToFiltre);
            for (int x = 1; x < ToFiltre.Width - 1; x++)
            {
                for (int y = 1; y < ToFiltre.Height - 1; y++)
                {
                    int[] CmpR = new int[9];
                    CmpR[0] = ToFiltre.GetPixel(x - 1, y - 1).R;






                }
            }
        }

        //TODO: Better Performances maybe ?
        private void DoMynn()
        {
            Bitmap ToFiltre = new Bitmap(pctrgnl.Image);
            Bitmap Filtrered = new Bitmap(ToFiltre);
            for (int x = 1; x < ToFiltre.Width - 1; x++)
            {
                for (int y = 1; y < ToFiltre.Height - 1; y++)
                {

                    int R1 = ToFiltre.GetPixel(x - 1, y - 1).R;
                    int R2 = ToFiltre.GetPixel(x, y - 1).R;
                    int R3 = ToFiltre.GetPixel(x + 1, y - 1).R;
                    int R4 = ToFiltre.GetPixel(x - 1, y).R;
                    int R5 = ToFiltre.GetPixel(x, y).R;
                    int R6 = ToFiltre.GetPixel(x + 1, y).R;
                    int R7 = ToFiltre.GetPixel(x - 1, y + 1).R;
                    int R8 = ToFiltre.GetPixel(x, y + 1).R;
                    int R9 = ToFiltre.GetPixel(x + 1, y + 1).R;

                    int g1 = ToFiltre.GetPixel(x - 1, y - 1).G;
                    int G2 = ToFiltre.GetPixel(x, y - 1).G;
                    int g3 = ToFiltre.GetPixel(x + 1, y - 1).G;
                    int G4 = ToFiltre.GetPixel(x - 1, y).G;
                    int g5 = ToFiltre.GetPixel(x, y).G;
                    int G6 = ToFiltre.GetPixel(x + 1, y).G;
                    int g7 = ToFiltre.GetPixel(x - 1, y + 1).G;
                    int G8 = ToFiltre.GetPixel(x, y + 1).G;
                    int g9 = ToFiltre.GetPixel(x + 1, y + 1).G;

                    int B1 = ToFiltre.GetPixel(x - 1, y - 1).B;
                    int B2 = ToFiltre.GetPixel(x, y - 1).B;
                    int B3 = ToFiltre.GetPixel(x + 1, y - 1).B;
                    int B4 = ToFiltre.GetPixel(x - 1, y).B;
                    int B5 = ToFiltre.GetPixel(x, y).B;
                    int B6 = ToFiltre.GetPixel(x + 1, y).B;
                    int B7 = ToFiltre.GetPixel(x - 1, y + 1).B;
                    int B8 = ToFiltre.GetPixel(x, y + 1).B;
                    int B9 = ToFiltre.GetPixel(x + 1, y + 1).B;


                    int RED = (R1 + R2 + R3 + R4 + R5 + R6 + R7 + R8 + R9) / 9;
                    int GRE = (g1 + G2 + g3 + G4 + g5 + G6 + g7 + G8 + g9) / 9; //oui l'alternance G et g est fait exprêt (mesure anti copie)
                    int BLU = (B1 + B2 + B3 + B4 + B5 + B6 + B7 + B8 + B9) / 9;
                    int Myn = (RED + GRE + BLU) / 3;
                    Filtrered.SetPixel(x, y, Color.FromArgb(RED, GRE, BLU));
                }
            }
            pctmdf.Image = Filtrered;
            optnpnl1.Visible = false;
            busy.Visible = false;
        }

        //TODO: More Colors (\^v^/)
        private void linedraw_Click()
        {
            Bitmap ToFiltre = new Bitmap(pctrgnl.Image);
            Bitmap Filtrered = new Bitmap(ToFiltre);
            Color couleurs;
            for (int x = 0; x < ToFiltre.Width; x++)
            {
                for (int y = 0; y < ToFiltre.Height; y++)
                {
                    couleurs = ToFiltre.GetPixel(x, y);
                    int Red = 0;
                    int Green = 0;
                    int Blue = 0;
                    if (slctd == 1)
                    {
                        Red = couleurs.R;
                        Green = couleurs.G - 255;
                        Blue = couleurs.B - 255;
                    }
                    else if (slctd == 2)
                    {
                        Red = couleurs.R - 255;
                        Green = couleurs.G;
                        Blue = couleurs.B - 255;
                    }
                    else if (slctd == 3)
                    {
                        Red = couleurs.R - 255;
                        Green = couleurs.G - 255;
                        Blue = couleurs.B;
                    }

                    Red = Math.Max(Red, 0);
                    Red = Math.Min(255, Red);

                    Green = Math.Max(Green, 0);
                    Green = Math.Min(255, Green);

                    Blue = Math.Max(Blue, 0);
                    Blue = Math.Min(255, Blue);


                    ToFiltre.SetPixel(x, y, Color.FromArgb((byte)Red, (byte)Green, (byte)Blue));

                }
            }

            Filtrered = (Bitmap)ToFiltre.Clone();
            pctmdf.Image = Filtrered;
            optnpnl1.Visible = false;
            busy.Visible = false;

        }

        //TODO: Where's Perry ? 
        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            busy.Visible = false;
        }

        //Here are colors (green)
        private void greenrd_CheckedChanged(object sender, EventArgs e)
        {
            slctd = 1;
            this.linedraw_Click();
        }

        // (red)
        private void redrd_CheckedChanged(object sender, EventArgs e)
        {
            slctd = 2;
            this.linedraw_Click();
        }

        // (blue)
        private void bluerd_CheckedChanged(object sender, EventArgs e)
        {
            slctd = 3;
            this.linedraw_Click();
        }

        //TODO: better floating pannel
        private void linedrawbtn_Click(object sender, EventArgs e)
        {
            optnpnl1.Visible = true;
            busy.Visible = true;
        }

        //TODO: Optimizations
        private void Invertcolors()
        {
            busy.Visible = true;
            Bitmap ToFiltre = new Bitmap(pctrgnl.Image);
            Bitmap Filtrered = new Bitmap(ToFiltre);
            Color couleurs;
            for (int x = 0; x < ToFiltre.Width; x++)
            {
                for (int y = 0; y < ToFiltre.Height; y++)
                {
                    couleurs = ToFiltre.GetPixel(x, y);
                    ToFiltre.SetPixel(x, y, Color.FromArgb(255 - couleurs.R, 255 - couleurs.G, 255 - couleurs.B));
                }
            }
            busy.Visible = false;
            Filtrered = (Bitmap)ToFiltre.Clone();
            pctmdf.Image = Filtrered;
        }

        //TODO (on most of the buttons) : Wave effect on clic
        private void button1_Click(object sender, EventArgs e)
        {
            busy.Visible = true;
            this.Invertcolors();
        }

        //Perry Is here !
        private void MainFrm_Load(object sender, EventArgs e)
        {
            busy.Visible = false;
        }

        //Incative : Wut BG ?
        private void inactive_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(new SolidBrush(this.BackColor), this.ClientRectangle);
        }

        //TODO: funny text animation, maybe some color depending the drag surface
        private void pctrgnl_MouseMove(object sender, MouseEventArgs e)
        {
            if (pctrgnl.Image != null)
            {
                lblx.Text = "X: " + e.X.ToString();
                lbly.Text = "Y: " + e.Y.ToString();
            }
        }

        //Postion Init
        private void pctrgnl_MouseLeave(object sender, EventArgs e)
        {
            lblx.Text = "";
            lbly.Text = "";

        }

        //TODO: silly wave effects
        private void grayscalebtn_Click(object sender, EventArgs e)
        {
            busy.Visible = true;
            SetGrayscale();
        }

        //TODO: effects on destroy
        private void optnpnl1_Click(object sender, EventArgs e)
        {
            optnpnl1.Visible = false;
            busy.Visible = false;
        }

        //TODO: effect on apparition
        private void Mdnbtn_Click(object sender, EventArgs e)
        {
            MdnPnl.Visible = true;
        }


        //TODO: effects on destroy
        private void MdnPnl_Click(object sender, EventArgs e)
        {
            MdnPnl.Visible = false;
            busy.Visible = false;
        }

        //TODO: Hum.
        private void MdnEdgeScale_SelectedIndexChanged(object sender, EventArgs e)
        {
            busy.Visible = true;
            SlctMdnSize(true);
        }


        //EXCLUSIVE ! Median Size
        public void SlctMdnSize(bool prvw)
        {
            Bitmap ToFiltre = new Bitmap(pctrgnl.Image);
            Bitmap Filtrered = new Bitmap(ToFiltre);
            Bitmap selectedSource = null;

            if (prvw == true)
            {
                selectedSource = ToFiltre;
            }
            else
            {
                selectedSource = ToFiltre;
            }

            if (selectedSource != null)
            {
                if (MdnEdgeScale.SelectedItem.ToString() == "None")
                {
                    ToFiltre = ToFiltre; //Silly I know XD (genius = me;)
                }
                else if (MdnEdgeScale.SelectedItem.ToString() == "Median 3x3")
                {
                    ToFiltre = DoMdnFilter(ToFiltre, 3);
                }
                else if (MdnEdgeScale.SelectedItem.ToString() == "Median 5x5")
                {
                    ToFiltre = DoMdnFilter(ToFiltre, 5);
                }
                //LIMIT OF HIGHT PERFORMANCES - Don't cross over if your pc don't support it XP
                else if (MdnEdgeScale.SelectedItem.ToString() == "Median 7x7")
                {
                    ToFiltre = DoMdnFilter(ToFiltre, 7);
                }
                else if (MdnEdgeScale.SelectedItem.ToString() == "Median 9x9")
                {
                    ToFiltre = DoMdnFilter(ToFiltre, 9);
                }
                else if (MdnEdgeScale.SelectedItem.ToString() == "Median 11x11")
                {
                    ToFiltre = DoMdnFilter(ToFiltre, 11);
                }
                else if (MdnEdgeScale.SelectedItem.ToString() == "Median 13x13")
                {
                    ToFiltre = DoMdnFilter(ToFiltre, 13);
                }
            }

            pctmdf.Image = ToFiltre;
            MdnPnl.Visible = false;
            busy.Visible = false;

        }


        //TODO: Optimizations
        public static Bitmap DoMdnFilter(Bitmap Image, int Size)
        {
            System.Drawing.Bitmap TempBitmap = Image;
            System.Drawing.Bitmap NewBitmap = new System.Drawing.Bitmap(TempBitmap.Width, TempBitmap.Height);
            System.Drawing.Graphics NewGraphics = System.Drawing.Graphics.FromImage(NewBitmap);
            NewGraphics.DrawImage(TempBitmap, new System.Drawing.Rectangle(0, 0, TempBitmap.Width, TempBitmap.Height), new System.Drawing.Rectangle(0, 0, TempBitmap.Width, TempBitmap.Height), System.Drawing.GraphicsUnit.Pixel);
            NewGraphics.Dispose();
            Random TempRandom = new Random();
            int ApetureMin = -(Size / 2);
            int ApetureMax = (Size / 2);
            for (int x = 0; x < NewBitmap.Width; ++x)
            {
                for (int y = 0; y < NewBitmap.Height; ++y)
                {
                    List<int> RValues = new List<int>();
                    List<int> GValues = new List<int>();
                    List<int> BValues = new List<int>();
                    for (int x2 = ApetureMin; x2 < ApetureMax; ++x2)
                    {
                        int TempX = x + x2;
                        if (TempX >= 0 && TempX < NewBitmap.Width)
                        {
                            for (int y2 = ApetureMin; y2 < ApetureMax; ++y2)
                            {
                                int TempY = y + y2;
                                if (TempY >= 0 && TempY < NewBitmap.Height)
                                {
                                    Color TempColor = TempBitmap.GetPixel(TempX, TempY);
                                    RValues.Add(TempColor.R);
                                    GValues.Add(TempColor.G);
                                    BValues.Add(TempColor.B);
                                }
                            }
                        }
                    }
                    RValues.Sort();
                    GValues.Sort();
                    BValues.Sort();
                    Color MedianPixel = Color.FromArgb(RValues[RValues.Count / 2],
                        GValues[GValues.Count / 2],
                        BValues[BValues.Count / 2]);
                    NewBitmap.SetPixel(x, y, MedianPixel);
                }
            }
            return NewBitmap;
        }
    }
}
