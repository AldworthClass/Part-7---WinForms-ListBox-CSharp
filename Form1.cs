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

        private void BtnSortNumber_Click(object sender, EventArgs e)
        {
            numbers.Sort();
            lstNumbers.DataSource = null;
            lstNumbers.DataSource = numbers;
            lblStatusUpdate.Text = "Status: numbers sorted";
        }

        private void BtnNewNumbers_Click(object sender, EventArgs e)
        {
            numbers.Clear();
            for (int i = 0; i < 30; i++)
                numbers.Add(generator.Next(100));
            lstNumbers.DataSource = null;
            lstNumbers.DataSource = numbers;
            lblStatusUpdate.Text = "Status: new number list";
        }

        private void BtnSortHero_Click(object sender, EventArgs e)
        {
            heroes.Sort();
            lstHeroes.DataSource = null;
            lstHeroes.DataSource = heroes;
            lblStatusUpdate.Text = "Status: heroes sorted";
        }

        private void BtnClearHeroes_Click(object sender, EventArgs e)
        {
            heroes.Clear();
            heroes.Add("Superman");
            heroes.Add("Batman");
            lstHeroes.DataSource = null;
            lstHeroes.DataSource = heroes;
            lblStatusUpdate.Text = "Status: new hero list";
        }

        private void BtnRemoveNumber_Click(object sender, EventArgs e)
        {
            //Make sure that something is selected in ListBox
            if (lstNumbers.SelectedIndex != -1)
            {
                //numbers.Remove((Int32)lstNumbers.SelectedItem);   Remove by value
                numbers.RemoveAt(lstNumbers.SelectedIndex);       //Remove by index
                lstNumbers.DataSource = null;
                lstNumbers.DataSource = numbers;
                lblStatusUpdate.Text = "Status: item removed";
            }
            else
                lblStatusUpdate.Text = "Status: no item selected";
        }

        private void BtnRemoveHero_Click(object sender, EventArgs e)
        {
            string removeHeroe = txtRemoveHero.Text.Trim();
            
            lstHeroes.DataSource = null;
            lstHeroes.DataSource = heroes;
            if (heroes.Remove(removeHeroe))
            {
                lstHeroes.DataSource = null;
                lstHeroes.DataSource = heroes;
                lblStatusUpdate.Text = "Status: item removed";
            }
            else
                lblStatusUpdate.Text = "Status: heroe not found";
            // Removes all instances with a predicate
            // heroes.RemoveAll(hero => hero.ToLower() == removeHeroe.ToLower());

        }

        private void BtnRemoveAllNumbers_Click(object sender, EventArgs e)
        {
            if (lstNumbers.SelectedIndex != -1)//Verifies that an item is selected
            {
                int numRemoved = 0;
                while (numbers.Remove((Int32)lstNumbers.SelectedItem))
                    numRemoved++;
                lstNumbers.DataSource = null;
                lstNumbers.DataSource = numbers;
                lblStatusUpdate.Text = $"Status: {numRemoved} item(s) removed";
            }
            else
                lblStatusUpdate.Text = "Status: nothing to remove";           
            //This removes all items using a Predicate.  It returns the number of removed elements.
            //numRemoved = numbers.RemoveAll(number => number == (Int32)lstNumbers.SelectedItem);
        }

        private void BtnAddHero_Click(object sender, EventArgs e)
        {
            string addHero = txtAddHero.Text.Trim();
            if (addHero.Length > 0)
            {
                heroes.Add(addHero);
                txtAddHero.Text = "";
                lstHeroes.DataSource = null;
                lstHeroes.DataSource = heroes;
                lblStatusUpdate.Text = "Status: item removed";
            }
            else
                lblStatusUpdate.Text = "Status: no hero to add";
        }
    }
}
