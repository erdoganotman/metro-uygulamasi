namespace metrouygulaması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            progressBar1.Value += 20;
            if (progressBar1.Value == 20)
            {
                radioButton1.BackColor = Color.Green;
                if(radioButton1.BackColor == Color.Green)
                {
                    radioButton1.BackColor= Color.Red;
                }
                 if (radioButton1.BackColor == Color.Red)
                {
                    radioButton1.BackColor = Color.Green;
                }
                
               
            }
            if (progressBar1.Value == 40)
            {
                radioButton2.BackColor = Color.Green;

            }
            if (progressBar1.Value == 60)
            {
                radioButton3.BackColor = Color.Green;
            }
            if (progressBar1.Value == 80)
            {
                radioButton4.BackColor = Color.Green;
            }
            if (progressBar1.Value == 100)
            {
                radioButton5.BackColor = Color.Green;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
            progressBar1.ForeColor = Color.Gray;
            progressBar1.BackColor = Color.Gray;
        }
    }
}