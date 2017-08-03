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
    public partial class Form1 : Form
    {

        private static modelEntities db = new modelEntities();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Country> list = db.Countries.ToList();
            foreach (var thing in list)
            {
                comboBox1.Items.Add(thing.Name);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Country> list = db.Countries.ToList();
            string name = comboBox1.Text;
            string property = comboBox2.Text;
            string newvalue = textBox1.Text;
            int key = 0;
            float result;
            foreach (var thing in list)
            {
                if (String.Compare(thing.Name, name, true) == 0)
                {
                    break;
                }
                key += 1;
            }

            if (String.Compare(property, "Code", true) == 0)
            {
                if (textBox1.Text != "")
                {
                    list[key].Code = newvalue;
                    db.SaveChanges();
                    Close();
                }
                else
                {
                    MessageBox.Show("Code, Name, and Continent must have a value.");
                }
            }
            else if (String.Compare(property, "Name", true) == 0)
            {
                if (textBox1.Text != "")
                {
                    list[key].Name = newvalue;
                    db.SaveChanges();
                    Close();
                }
                else
                {
                    MessageBox.Show("Code, Name, and Continent must have a value.");
                }
            }
            else if (String.Compare(property, "Continent", true) == 0)
            {
                if (textBox1.Text != "")
                {
                    list[key].Continent = newvalue;
                    db.SaveChanges();
                    Close();
                }
                else
                {
                    MessageBox.Show("Code, Name, and Continent must have a value.");
                }
            }
            else if (String.Compare(property, "Surface Area", true) == 0)
            {
                if (float.TryParse(newvalue, out result))
                {
                    list[key].SurfaceArea = float.Parse(newvalue);
                    db.SaveChanges();
                    Close();
                }
                else if (newvalue == "")
                {
                    list[key].SurfaceArea = null;
                    db.SaveChanges();
                    Close();
                }
                else
                {
                    MessageBox.Show("Could not parse property. Please try again.");
                }
            }
            else if (String.Compare(property, "Population", true) == 0)
            {
                if (int.TryParse(newvalue, out int result2))
                {
                    list[key].Population = int.Parse(newvalue);
                    db.SaveChanges();
                    Close();
                }
                else if (newvalue == "")
                {
                    list[key].Population = null;
                    db.SaveChanges();
                    Close();
                }
                else
                {
                    MessageBox.Show("Could not parse property. Please try again.");
                }
            }
            else if (String.Compare(property, "Life Expectancy", true) == 0)
            {
                if (float.TryParse(newvalue, out result))
                {
                    list[key].LifeExpectancy = float.Parse(newvalue);
                    db.SaveChanges();
                    Close();
                }
                else if (newvalue == "")
                {
                    list[key].LifeExpectancy = null;
                    db.SaveChanges();
                    Close();
                }
                else
                {
                    MessageBox.Show("Could not parse property. Please try again.");
                }
            }
            else if (String.Compare(property, "GNP", true) == 0)
            {
                if (float.TryParse(newvalue, out result))
                {
                    list[key].GNP = float.Parse(newvalue);
                    db.SaveChanges();
                    Close();
                }
                else if (newvalue == "")
                {
                    list[key].GNP = null;
                    db.SaveChanges();
                    Close();
                }
                else
                {
                    MessageBox.Show("Could not parse property. Please try again.");
                }
            }
            else if (String.Compare(property, "Head of State", true) == 0)
            {
                if (newvalue == "")
                {
                    list[key].HeadOfState = null;
                    db.SaveChanges();
                    Close();
                }
                else
                {
                    list[key].HeadOfState = newvalue;
                    db.SaveChanges();
                    Close();
                }
            }
        }
    }
}
