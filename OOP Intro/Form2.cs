using OOP_Intro.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Intro
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        Player p;

        private void btnOpenCharacter_Click(object sender, EventArgs e)
        {
            p = new Player();
            p.Balance = 400;
            p.Name = txtPlayerOne.Text;
            btnPlay.Enabled = false;

        }

        private void PutInterest_Click(object sender, EventArgs e)
        {
            if(p.PlaceABet())
            {
                MessageBox.Show($"Bet Placed Actual Balance:{p.Name} >>{p.Balance}");

                btnPlay.Enabled = true;
                PutInterest.Enabled= false;
            }
            else
            {
                Application.Exit();
            }


        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            label1.Text = p.ToDice().ToString();
            PutInterest.Enabled = true;
            btnPlay.Enabled = false;
        }
    }
}
