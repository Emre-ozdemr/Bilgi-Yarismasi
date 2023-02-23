namespace Bilgi_Yarismasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button3_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnSonraki.Enabled = true;

            label5.Text = btnC.Text;
            if (label4.Text == label5.Text)
            {
                dogru++;
                lblD.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                lblY.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }
        int soruno = 0,dogru = 0, yanlis = 0;

        private void btnB_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnSonraki.Enabled = true;

            label5.Text = btnB.Text;
            if (label4.Text == label5.Text)
            {
                dogru++;
                lblD.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                lblY.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnSonraki.Enabled = true;

            label5.Text = btnD.Text;
            if (label4.Text == label5.Text)
            {
                dogru++;
                lblD.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                lblY.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;   
            btnD.Enabled = false;
            btnSonraki.Enabled = true;

            label5.Text = btnA.Text;
            if (label4.Text == label5.Text)
            {
                dogru++;
                lblD.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                lblY.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void btnSonraki_Click(object sender, EventArgs e)
        {
            btnA.Enabled = true;
            btnB.Enabled = true;
            btnC.Enabled = true;
            btnD.Enabled = true;
            btnSonraki.Enabled = false;


            pictureBox1.Visible = false;
            pictureBox2.Visible = false;


            soruno++;
            lblSoruno.Text = soruno.ToString();

            if (soruno == 1)
            {
                richTextBox1.Text = "Cumhuriyet ka� y�l�nda ilan edilmi�tir?";
                btnA.Text = "1920";
                btnB.Text = "1921";
                btnC.Text = "1922";
                btnD.Text = "1923";
                label4.Text = "1923";
            }
            if (soruno == 2)
            {
                richTextBox1.Text = "Hangi il ege b�lgemizde bulunmaz?";
                btnA.Text = "�zmir";
                btnB.Text = "Bal�kesir";
                btnC.Text = "Ayd�n";
                btnD.Text = "Manisa";
                label4.Text = "Bal�kesir";
            }
            if (soruno == 3)
            {
                richTextBox1.Text = "Son ku�lar hangi yazar�m�za aittir?";
                btnA.Text = "Sait Faik";
                btnB.Text = "Cemal S�reyya";
                btnC.Text = "Atilla �lhan";
                btnD.Text = "Re�at Nuri";
                label4.Text = "Sait Faik";
                btnSonraki.Text = "Sonu�lar";
            }
            if (soruno == 4)
            {
                btnA.Enabled = false;
                btnB.Enabled = false;
                btnC.Enabled = false;
                btnD.Enabled = false;
                btnSonraki.Enabled = false;
                MessageBox.Show("Do�ru: " + dogru + "\n" + "Yanl��: " + yanlis);
            }
        }
    }
}