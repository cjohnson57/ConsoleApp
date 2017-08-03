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
    public partial class Form2 : Form
    {

        private static modelEntities db = new modelEntities();

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
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
            int key = 0;
            string name = comboBox1.Text;
            foreach (var thing in list)
            {
                if (String.Compare(thing.Name, name, true) == 0)
                {
                    break;
                }
                key += 1;
            }
            db.Countries.Remove(list[key]);
            db.SaveChanges();
            Close();
        }
    }
}
