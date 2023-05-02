using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FourWins
{
    public partial class Menue : Form
    {
        TwoPlayers TwoPlayers;
        public int Nav_list_item_change = 1;

        public Menue()
        {
            InitializeComponent();

        }

        private void Nav_list_item_MouseEnter(object sender, EventArgs e)
        {
            Label? l = sender as Label;
            if (l != null)
            {
                if (Nav_list_item_change == 1)
                {
                    string value = l.Text;
                    l.Location = new Point(l.Location.X + 2, l.Location.Y);
                    l.Text = "» " + value;
                    Nav_list_item_change = 0;
                }
            }
        }

        private void Nav_list_item_MouseLeave(object sender, EventArgs e)
        {
            Label? l = sender as Label;
            if (l != null)
            {
                if (Nav_list_item_change == 0)
                {
                    string value = l.Text.Remove(0, 2);
                    l.Location = new Point(l.Location.X - 2, l.Location.Y);
                    l.Text = value;
                    Nav_list_item_change = 1;
                }
            }
        }

        private void Nav_list_item_Click(object sender, EventArgs e)
        {
            Label? label = sender as Label;
            if (label != null)
            {
                switch (label.Tag)
                {
                    case "twoplayers":
                        TwoPlayers singleplayer = new TwoPlayers(this);
                        singleplayer.Show();
                        this.Hide();
                        break;
                    default:
                        MessageBox.Show("d");
                        break;
                }
            }
        }
    }
}
