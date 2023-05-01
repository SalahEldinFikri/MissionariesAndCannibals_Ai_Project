using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication31
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void picgoat_Click(object sender, EventArgs e)
        {
          
            if (piccarrot.Location == new Point(616, 312)) { piccarrot.Location = new Point(838, 312); }
            if (picwolf.Location == new Point(616, 312)) { picwolf.Location = new Point(762, 312); }

            if (piccarrot.Location == new Point(335, 312)) { piccarrot.Location = new Point(86, 312); }
            if (picwolf.Location == new Point(335, 312)) { picwolf.Location = new Point(10, 312); }


            if (picgoat.Location == new Point(914, 312) && picship.Location == new Point(547, 413))
            {
                picgoat.Location = new Point(616, 312);

            }
            else if (picgoat.Location == new Point(335, 312))
            {
                picgoat.Location = new Point(162, 312);
                gamelogic();
            }
            else if (picgoat.Location == new Point(162, 312) && picship.Location == new Point(270, 413))
            {
                picgoat.Location = new Point(335, 312);
               


            }
            else if(picship.Location == new Point(547, 413)&& picgoat.Location == new Point(616, 312))
            {
                picgoat.Location = new Point(914, 312);
            }
            
        }

        private void piccarrot_Click(object sender, EventArgs e)
        {
          
            if (picgoat.Location == new Point(616, 312)) { picgoat.Location = new Point(914, 312); }
            if (picwolf.Location == new Point(616, 312)) { picwolf.Location = new Point(762, 312); }

            if (picgoat.Location == new Point(335, 312)) { picgoat.Location = new Point(162, 312); }
            if (picwolf.Location == new Point(335, 312)) { picwolf.Location = new Point(10, 312); }



            if (piccarrot.Location == new Point(838, 312) && picship.Location == new Point(547, 413))
            {
                piccarrot.Location = new Point(616, 312);
               
            }
          else  if (piccarrot.Location == new Point(335, 312))
            {
                piccarrot.Location = new Point(86, 312);
                gamelogic();

            }
            else if (piccarrot.Location == new Point(86, 312) && picship.Location == new Point(270, 413))
            {
                piccarrot.Location = new Point(335, 312);
                gamelogic();


            }
            else if (picship.Location == new Point(547, 413)&& piccarrot.Location == new Point(616, 312))
            {
                piccarrot.Location = new Point(838, 312);
            }
           
        }

        private void picwolf_Click(object sender, EventArgs e)
        {
            
            if (picgoat.Location == new Point(616, 312)) { picgoat.Location = new Point(914, 312); }
            if (piccarrot.Location == new Point(616, 312)) { piccarrot.Location = new Point(838, 312); }

            if (picgoat.Location == new Point(335, 312)) { picgoat.Location = new Point(162, 312); }
            if (piccarrot.Location == new Point(335, 312)) { piccarrot.Location = new Point(86, 312); }


                if (picwolf.Location == new Point(762, 312) && picship.Location==new Point(547, 413))
            {
                picwolf.Location = new Point(616, 312);
            }
            else if (picwolf.Location == new Point(335, 312))
            {
                picwolf.Location = new Point(10, 312);
                gamelogic();
            }
            else if (picwolf.Location == new Point(10, 312) && picship.Location == new Point(270, 413))
            {
                picwolf.Location = new Point(335, 312);
                gamelogic();
            }

            else if (picship.Location == new Point(547, 413)&& picwolf.Location == new Point(616, 312))
            {
                picwolf.Location = new Point(762, 312);
            }
           

        }

        private void picship_Click(object sender, EventArgs e)
        {
            if (picwolf.Location == new Point(616, 312))
            {
                picship.Location = new Point(270, 413); picwolf.Location = new Point(335, 312);
            }
            else if (piccarrot.Location == new Point(616, 312))
            {
                picship.Location = new Point(270, 413); piccarrot.Location = new Point(335, 312);
            }
            else if (picgoat.Location == new Point(616, 312))
            {
                picship.Location = new Point(270, 413); picgoat.Location = new Point(335, 312);
            }

            
            else if (picwolf.Location == new Point(335, 312))
            {
                picship.Location = new Point(547, 413); picwolf.Location = new Point(616, 312);
            }
            else if (piccarrot.Location == new Point(335, 312))
            {
                picship.Location = new Point(547, 413); piccarrot.Location = new Point(616, 312);
            }
            else if (picgoat.Location == new Point(335, 312) )
            {
                picship.Location = new Point(547, 413); picgoat.Location = new Point(616, 312);
            }

           

            else
            {
                picship.Location = new Point(547, 413);

            }
         
        }
        public void gamelogic()
        {
  if  (picwolf.Location == new Point(10, 312) &&  picgoat.Location == new Point(162, 312) &&  piccarrot.Location == new Point(86, 312))
            {
                label1.Text = "Win ";
                piccarrot.Hide();
                picgoat.Hide();
                picwolf.Hide();
            }
          
                else if (picwolf.Location == new Point(10, 312) && picgoat.Location == new Point(162, 312))
            {
                label1.Text = " The divl kill the human ";
                piccarrot.Hide();
                picgoat.Hide();
                picwolf.Hide();
            }
           else if ( picgoat.Location == new Point(162, 312) && piccarrot.Location == new Point(86, 312))
            {
                label1.Text = " The human eat the ice cream";
                piccarrot.Hide();
                picgoat.Hide();
                picwolf.Hide();
            }

           else if (picwolf.Location == new Point(10, 312) && picgoat.Location == new Point(914, 312) && piccarrot.Location == new Point(838, 312))
            {
                label1.Text = "The human eat the ice cream";
                piccarrot.Hide();
                picgoat.Hide();
                picwolf.Hide();
            }
         else if (picwolf.Location == new Point(762, 312) && picgoat.Location == new Point(914, 312) && piccarrot.Location == new Point(86, 312))
            {
                label1.Text = "The divl kill the human";
                piccarrot.Hide();
                picgoat.Hide();
                picwolf.Hide();
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {
            picwolf.Location = new Point(762, 312);
            picgoat.Location = new Point(914, 312);
            piccarrot.Location = new Point(838, 312);
            picship.Location = new Point(547, 413);

            picwolf.Show();
            picgoat.Show();
            piccarrot.Show();
            label1.Text = ".........";
        }
    }
}
