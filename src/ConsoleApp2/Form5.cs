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
    public partial class Form5 : Form
    {

        private static modelEntities db = new modelEntities();

        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            List<Country> list = db.Countries.ToList();
            foreach (var thing in list)
            {
                comboBox1.Items.Add(thing.Name);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Country> list = db.Countries.ToList();
            foreach (var thing in list)
            {
                if (thing.Name == comboBox1.Text)
                {
                    richTextBox1.Text = "";
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
                }
            }
        }
    }
}
