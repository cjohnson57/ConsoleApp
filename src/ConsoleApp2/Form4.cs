using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsoleApp2
{
    public partial class Form4 : Form
    {
        private static modelEntities db = new modelEntities();

        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            DisplayCountries();
        }

        public void DisplayCountries()
        {
            richTextBox1.Text = "";
            db = new modelEntities();
            List<Country> list = db.Countries.ToList();
            foreach (var thing in list)
            {
                richTextBox1.Text += "Code: " + thing.Code + "\r\n";
                richTextBox1.Text += "Name: " + thing.Name + "\r\n";
                richTextBox1.Text += "Continent: " + thing.Continent + "\r\n";
                if (thing.SurfaceArea == null)
                {
                    richTextBox1.Text += "Surface Area: N/A \r\n";
                }
                else
                {
                    richTextBox1.Text += "Surface Area: " + thing.SurfaceArea + "\r\n";
                }
                if (thing.Population == null)
                {
                    richTextBox1.Text += "Population: N/A \r\n";
                }
                else
                {
                    richTextBox1.Text += "Population: " + thing.Population + "\r\n";
                }
                if (thing.LifeExpectancy == null)
                {
                    richTextBox1.Text += "Life Expectancy: N/A \r\n";
                }
                else
                {
                    richTextBox1.Text += "Life Expectancy: " + thing.LifeExpectancy + "\r\n";
                }
                if (thing.GNP == null)
                {
                    richTextBox1.Text += "GNP: N/A \r\n";
                }
                else
                {
                    richTextBox1.Text += "GNP: " + thing.GNP + "\r\n";
                }
                if (thing.HeadOfState == null)
                {
                    richTextBox1.Text += "Head of State: N/A \r\n";
                }
                else
                {
                    richTextBox1.Text += "Head of State: " + thing.HeadOfState + "\r\n";
                }
                richTextBox1.Text += "-------------------------------------------------------------------------------------------------------------------------------------------------------------------";
                if (thing.ID != list[list.Count - 1].ID)
                {
                    richTextBox1.Text += "\r\n";
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.ShowDialog();
            DisplayCountries();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.ShowDialog();
            DisplayCountries();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            frm3.ShowDialog();
            DisplayCountries();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form5 frm5 = new Form5();
            frm5.ShowDialog();
            DisplayCountries();
        }
    }
}
