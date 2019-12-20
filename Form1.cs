using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Part_7___WinForms_ListBox_CSharp
{
    public partial class frmListBoxes : Form
    {
        Random generator = new Random();
        List<int> numbers = new List<int>();
        List<string> heroes = new List<string>();
        public frmListBoxes()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Setting up numbers list
            for (int i = 0; i < 30; i++)
                numbers.Add(generator.Next(100));
            lstNumbers.DataSource = numbers;

            //Setting up heroes list
            heroes.Add("Superman");
            heroes.Add("Batman");
            lstHeroes.DataSource = heroes;
        
        }

        private void LstNumbers_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnSortNumber_Click(object sender, EventArgs e)
        {
            numbers.Sort();
            lstNumbers.DataSource = null;
            lstNumbers.DataSource = numbers;
        }
    }
}
