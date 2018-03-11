using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cinema
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            yerler();
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {

            

        }
       
        public static List<CheckBox> oturacaqlar = new List<CheckBox>();
        public static List<CheckBox> buy = new List<CheckBox>();
        public static List<CheckBox> reserve = new List<CheckBox>();
        public int kes = -5;
        public int x = 50;
        public int qiymet = 5;
        public int Nefer = 1;
        public int y =50;
        public int c = 1;
        public int v = 1;
    
        public void yerler()
        {
            
            for (int i = 0; i < 10; i++)
            {
                var text = new Label();
                text.Text =  v.ToString();
                v++;
                text.Width = 30;
                text.Height = 50;
                text.Font = new Font("Microsoft Sans Serif", 13.6f);
                text.Top = 57 + (i * 50);
                text.Left = 17;
                text.BackColor = Color.Transparent;
                text.ForeColor = Color.White;
               
                this.Controls.Add(text);
                c = 1;
                for (int a = 0; a < 7; a++)
                {
                               
                    var yer = new CheckBox();
                    yer.Text = c.ToString();
                    c ++;
                    yer.Width = 40;
                    
                    yer.Height = 40;
                    yer.Left =x+(a*70);
                    yer.Top = y+(i*50);
                    yer.Appearance = Appearance.Button;
                    yer.FlatAppearance.BorderSize = 2;
                    yer.BackColor = Color.White;
                    oturacaqlar.Add(yer);
                    yer.Click += new EventHandler(Button1_Click);
                   
                       
                   
                    this.Controls.Add(yer);

                }
            }


        }
        
        private void textBox1_MouseDown(object sender, MouseEventArgs e)
        {
            
        }


        
        
        private void label1_Click(object sender, EventArgs e)
        {

        }
        Random say = new Random();
        
        private void Button1_Click(object sender, EventArgs e)
        {

            int result = Nefer * qiymet;
            int result2 = result - 5;
           

            CheckBox btn = (CheckBox)sender;
            if (btn.CheckState == CheckState.Checked)
            {
                Nefer++;
                label1.Text = result.ToString();
                btn.BackColor = Color.Aqua;
                buy.Add(btn);
                reserve.Add(btn);
                
            }
            if (btn.CheckState == CheckState.Unchecked)
            {
                Nefer--;
                label1.Text = (result - 10).ToString();
                buy.Remove(btn);
                reserve.Remove(btn);
                btn.BackColor = Color.Empty;
            }
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int texmini = say.Next(1000,9999);
            for (int i = 0; i < buy.Count; i++)
            {
                buy[i].BackColor = Color.Red;
                
            }
            MessageBox.Show("Bilet aldiginiz ucun tesekkur edirik!" + "\r\n" + "Sizin bilet kodunuz " + texmini + " kodurur." + "\r\n" + "P.S: Kod bir daha gosterilmir!");
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            int texmini = say.Next(1000, 9999);
            for (int i = 0; i < reserve.Count; i++)
            {
                reserve[i].BackColor = Color.Green;

            }
            MessageBox.Show("Bileti bron etdiniz!" + "\r\n" + "Sizin bilet kodunuz " + texmini + " kodurur." + "\r\n" + "P.S: Kod bir daha gosterilmir!");
            this.Hide();
        }
    }

}
