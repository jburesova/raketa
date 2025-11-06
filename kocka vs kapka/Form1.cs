using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KockaAkapka
{
    public partial class Raketa : Form
    {
        int kockaSpeed = 10; 
        int kapkaSpeed = 10; 
        int score = 0; 
        int lives = 3; 
        int fuel = 100;

        bool moveLeft = false; // ovládání kocky
        bool moveRight = false;

        // pole kapek a srdcí
        PictureBox[] kapka;
        PictureBox[] srdce;

        public Okno()
        {
            InitializeComponent();

        //form zachytí stisk kláves
        this.KeyPreview = true;
        this.KeyDown += Okno_KeyDown; // definování metody pro stisk z klávesnice
        this.KeyUp += Okno_KeyUp;

        //inicalizace kocky
        pictureBox_kocka.Left = groupBox_hraciPlocha.Width / 2 - pictureBox_kocka.Width / 2;
        pictureBox_kocka.Top = groupBox_hraciPlocha.Height - pictureBox_kocka.Height - 10;

        //Inicializace kapek
        PictureBox kapka = pictureBox_stop; // stop z návrhu
        PictureBox kapka2 = new PictureBox();
        kapka2.Size = kapka.Size;
        kapka2.SizeMode = PictureBoxSizeMode.Zoom;
        kapka2.Image = kapka.Image;
        groupBox_hraciPlocha.Controls.Add(kapka2);

        kapka = new PictureBox[] { kapka, kapka2 };
        foreach (var kapka in kapek)
        Resetstop(kapka);

        // inicializace srdcí
        srdce = new PictureBox[] { pictureBox_srdce1, pictureBox_srdce2, pictureBox_srdce3 };

        Casovac.Interval = 50;
        Casovac.Tick += GameLoop


        }

        Random rnd = new Random();
        public Raketa()
        {
            InitializeComponent();
        }

        private void GameLoop(object sender, EventArgs e)
        { 

        }  
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox_kocka_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
