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
    public partial class Form3 : Form
    {

        private static modelEntities db = new modelEntities();

        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Country a = new Country();
            bool failedtoset = false;
            bool failedtoset2 = false;

            if (textBox1.Text != "")
            {
                a.Code = textBox1.Text;
            }
            else
            {
                failedtoset2 = true;
            }
            if (textBox2.Text != "")
            {
                a.Name = textBox2.Text;
            }
            else
            {
                failedtoset2 = true;
            }
            if (textBox3.Text != "")
            {
                a.Continent = textBox3.Text;
            }
            else
            {
                failedtoset2 = true;
            }
            if (float.TryParse(textBox4.Text, out float result))
            {
                a.SurfaceArea = float.Parse(textBox4.Text);
            }
            else if (textBox4.Text == "")
            {
                a.SurfaceArea = null;
            }
            else
            {
                failedtoset = true;
            }

            if (float.TryParse(textBox5.Text, out float result2))
            {
                a.Population = int.Parse(textBox5.Text);
            }
            else if (textBox5.Text == "")
            {
                a.Population = null;
            }
            else
            {
                failedtoset = true;
            }

            if (float.TryParse(textBox6.Text, out float result3))
            {
                a.LifeExpectancy = float.Parse(textBox6.Text);
            }
            else if (textBox6.Text == "")
            {
                a.LifeExpectancy = null;
            }
            else
            {
                failedtoset = true;
            }

            if (float.TryParse(textBox7.Text, out float result4))
            {
                a.GNP = float.Parse(textBox7.Text);
            }
            else if(textBox7.Text == "")
            {
                a.GNP = null;
            }
            else
            {
                failedtoset = true;
            }

            if (textBox8.Text == "")
            {
                a.HeadOfState = null;
            }
            else
            {
                a.HeadOfState = textBox8.Text;
            }

            if (failedtoset)
            {
                MessageBox.Show("Could not parse a value. Please try again.");
            }
            else if (failedtoset2)
            {
                MessageBox.Show("Code, Name, and Continent must have a value.");
            }
            else
            {
                db.Countries.Add(a);
                db.SaveChanges();
                Close();
            }
        }

        private static Random random = new Random();
        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Text = RandomStringCaps(1) + RandomStringLower(random.Next(4, 11));
            textBox1.Text =  ThreeLetterCode(textBox2.Text);
            textBox3.Text = RandomContinent();
            textBox4.Text = Convert.ToString(random.Next(10000, 500001));
            textBox5.Text = Convert.ToString(RandomPop());
            textBox6.Text = RandomAge();
            textBox7.Text = Convert.ToString(RandomGNP());
            textBox8.Text = RandomName();
        }

        public static string RandomStringCaps(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            return new string(Enumerable.Repeat(chars, length).Select(s => s[random.Next(s.Length)]).ToArray());
        }
        public static string RandomStringLower(int length)
        {
            const string chars = "abcdefghijklmnopqrstubwxyz";
            return new string(Enumerable.Repeat(chars, length).Select(s => s[random.Next(s.Length)]).ToArray());
        }
        public static string ThreeLetterCode(string name)
        {
            string char1 = name.Substring(0, 1);
            string name2 = name.Substring(1, name.Length - 1);
            int index = random.Next(0, name2.Length - 2);
            string char2 = name2.Substring(index, 1);
            string name3 = name2.Substring(index + 1, name2.Length - index);
            string char3 = name2.Substring(index, 1);
            return char1 + char2.ToUpper() + char3.ToUpper();
        }
        public static string RandomContinent()
        {
            int contnum = random.Next(1, 31);
            if (contnum >= 1 && contnum <= 9) //9
            {
                return "Europe";
            }
            else if(contnum >= 10 && contnum <= 15) //6
            {
                return "Asia";
            }
            else if (contnum >= 16 && contnum <= 19) //4
            {
                return "Oceania";
            }
            else if (contnum >= 20 && contnum <= 23) //4
            {
                return "South America";
            }
            else if (contnum >= 24 && contnum <= 26) //3
            {
                return "Africa";
            }
            else if (contnum >= 27 && contnum <= 29) //3
            {
                return "North America";
            }
            else //1
            {
                return "Antarctica";
            }
        }
        public static string RandomName()
        {
            string[] first = { "James", "John", "Robert", "Michael", "William", "David", "Richard", "Charles", "Joseph", "Thomas", "Mary", "Patricia", "Linda", "Barbara", "Elizabeth", "Jennifer", "Maria", "Susan", "Margaret", "Dorothy" };
            string[] last = { "Smith", "Johnson", "Williams", "Jones", "Brown", "Davis", "Miller", "Wilson", "Moore", "Taylor", "Anderson", "Thomas", "Jackson", "White", "Harris", "Martin", "Thompson", "Garcia", "Martinez", "Robinson" };
            return first[random.Next(0, 20)] + " " + last[random.Next(0, 20)];
        }
        public static string RandomPop()
        {
            int magnitude = random.Next(1, 6);
            if (magnitude == 1) //1
            {
                return Convert.ToString(random.Next(5000000, 10000001));
            }
            else if (magnitude == 2 || magnitude == 3) //2
            {
                return Convert.ToString(random.Next(10000001, 100000001));
            }
            else if (magnitude == 4 || magnitude == 5) //2
            {
                return Convert.ToString(random.Next(100000001, 1000000001));
            }
            else
            {
                return Convert.ToString(random.Next(5000000, 1000000001));
            }
        }
        public static string RandomGNP()
        {
            int magnitude = random.Next(1, 4);
            if (magnitude == 1) //1
            {
                return Convert.ToString(random.Next(500000, 1000001) + "000000");
            }
            else if (magnitude == 2 || magnitude == 3) //2
            {
                return Convert.ToString(random.Next(1000001, 10000001) + "000000");
            }
            else
            {
                return Convert.ToString(random.Next(500000, 10000001) + "000000");
            }
        }
        public static string RandomAge()
        {
            int magnitude = random.Next(1, 3);
            if (magnitude == 1) //1
            {
                return Convert.ToString(random.Next(70, 80) + Math.Round(random.NextDouble(), 2));
            }
            else //1
            {
                return Convert.ToString(random.Next(80, 86) + Math.Round(random.NextDouble(), 2));
            }
        }
    }
}
