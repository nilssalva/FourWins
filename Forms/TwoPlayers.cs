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
    public partial class TwoPlayers : Form
    {
        Menue menue;


         
        

        public TwoPlayers(Menue menue)
        {
            InitializeComponent();
            this.menue = menue;
            var circle = new System.Drawing.Drawing2D.GraphicsPath();
            circle.AddEllipse(0, 0, 100, 100);
        }

        Label[,] field = new Label[7, 6]; //x=7,y=6
        Label ddad = new Label();
        
    }
}
