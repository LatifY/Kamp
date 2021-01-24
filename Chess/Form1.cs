using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chess
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			Button[,] buttons = new Button[8, 8];
			for (int x = 0; x <= buttons.GetUpperBound(0); x++)
			{
				for (int y = 0; y <= buttons.GetUpperBound(1); y++)
				{
					buttons[x, y] = new Button();
					buttons[x, y].Width = 50;
					buttons[x, y].Height = 50;
					buttons[x, y].Top = x * 50;
					buttons[x, y].Left = y * 50;
					if ((x+y) % 2 == 0){ buttons[x, y].BackColor = Color.Black;}
					else{ buttons[x, y].BackColor = Color.White; }
					buttons[x, y].Text = ($"{x+1}-{y+1}");
					this.Controls.Add(buttons[x, y]);
				}
			}
		}
	}
}
