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
            
            for (int i = 0; i < 30; i++)
                numbers.Add(generator.Next(100));
            lstNumbers.DataSource = numbers;

        
        }

        private void LstNumbers_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
