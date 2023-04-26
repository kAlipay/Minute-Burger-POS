using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MuniteBurgerSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double muniteburger = 43.0, doublemuniteburger = 64.0, cheesyburger = 52.0, doublecheesyburger = 80.0, cheesyburgeroverload = 146.0, chimipesto = 89.0;
        double chickenveggieburger = 86.0, baconcheeseburger = 98.0, chickenroastedsesame = 96, blackpepperburger = 98, beefshawarmaburger = 90;
        double muniteburgerp, doublemuniteburgerp, cheesyburgerp, doublecheesyburgerp, cheesyburgeroverloadp, chimipestop;
        double chickenveggieburgerp, baconcheeseburgerp, chickenroastedsesamep, blackpepperburgerp, beefshawarmaburgerp;
       
        double subtotal = 0, tax, total;

        private void Form1_Load(object sender, EventArgs e)
        {
            statusstriptime.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
            var dt1 = DateTime.Now;
            string dates = dt1.ToString("dddd, dd MMMM yyyy");
            statusstripdate.Text = dates;
        }

        private void cbxbeefshawarmaburger_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxbeefshawarmaburger.Checked == true)
            {
                txtbeefshawarmaburger.Enabled = true;
            }
            if (cbxbeefshawarmaburger.Checked == false)
            {
                txtbeefshawarmaburger.Enabled = false;
                txtbeefshawarmaburger.Text = "0";
            }
        }

        private void cbxminuteburger_CheckedChanged_1(object sender, EventArgs e)
        {
            if (cbxminuteburger.Checked == true)
            {
                txtminuteburger.Enabled = true;
            }
            if (cbxminuteburger.Checked == false)
            {
                txtminuteburger.Enabled = false;
                txtminuteburger.Text = "0";
            }
        }

        private void lbltotal_Click(object sender, EventArgs e)
        {

        }

        private void cbxminuteburger_CheckedChanged(object sender, EventArgs e)
        {
       
        }

        private void cbxblackpepperburger_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxblackpepperburger.Checked == true)
            {
                txtblackpepperburger.Enabled = true;
            }
            if (cbxblackpepperburger.Checked == false)
            {
                txtblackpepperburger.Enabled = false;
                txtblackpepperburger.Text = "0";
            }
        }


        private void btnadd_Click(object sender, EventArgs e)
        {
           

            var dt1 = DateTime.Now;
            string dates = dt1.ToString("dddd, dd MMMM yyyy");
            muniteburgerp = muniteburger * Convert.ToDouble(txtminuteburger.Text);
            doublemuniteburgerp = doublemuniteburger * Convert.ToDouble(txtdoubleminuteburger.Text);
            cheesyburgerp = cheesyburger * Convert.ToDouble(txtcheesyburger.Text);
            doublecheesyburgerp = doublecheesyburger * Convert.ToDouble(txtdoublecheesyburger.Text);
            cheesyburgeroverloadp = cheesyburgeroverload * Convert.ToDouble(txtcheeseburgeroverload.Text);
            chimipestop = chimipesto * Convert.ToDouble(txtchimipestoburger.Text);
            chickenveggieburgerp = chickenveggieburger * Convert.ToDouble(txtchickenveggieburger.Text);
            baconcheeseburgerp = baconcheeseburger * Convert.ToDouble(txtbaconcheeseburger.Text);
            chickenroastedsesamep = chickenroastedsesame * Convert.ToDouble(txtchickenroastedsesame.Text);
            blackpepperburgerp = blackpepperburger * Convert.ToDouble(txtblackpepperburger.Text);
            beefshawarmaburgerp = beefshawarmaburger * Convert.ToDouble(txtbeefshawarmaburger.Text);
            richtextbox.Clear();
            richtextbox.AppendText(Environment.NewLine);
            richtextbox.AppendText("\t\t\t\t Minute Burger" + Environment.NewLine);
            richtextbox.AppendText("\t\t\t\t*****************" + Environment.NewLine);
            richtextbox.AppendText("\t\t\t" + dates + "\t" + statusstriptime.Text + Environment.NewLine);
            richtextbox.AppendText(Environment.NewLine);
            richtextbox.AppendText(Environment.NewLine);
            int count = 0;
            if (cbxminuteburger.Checked == true)
            {
                count++;
                richtextbox.AppendText("\t" + Convert.ToString(count) + "Minute Burger                 " + txtminuteburger.Text + " QTY " + "     Pesos " +  muniteburgerp + Environment.NewLine);
                subtotal = subtotal + muniteburgerp;
                lblsubtotal.Text = "Item total: " + "" + Convert.ToString(subtotal);
            }
            if (cbxdoubleminuteburger.Checked == true)
            {
                count++;
                richtextbox.AppendText("\t" + Convert.ToString(count) + "Double Munite Burger          " + txtdoubleminuteburger.Text + " QTY " + "     Pesos " + doublemuniteburgerp + Environment.NewLine);
                subtotal = subtotal + doublemuniteburgerp;
                lblsubtotal.Text = "Item total: " + "" + Convert.ToString(subtotal);
            }
            if (cbxcheesyburger.Checked == true)
            {
                count++;
                richtextbox.AppendText("\t" + Convert.ToString(count) + "Cheesy Burger          " + txtcheesyburger.Text + " QTY " + "     Pesos " + cheesyburgerp + Environment.NewLine);
                subtotal = subtotal + cheesyburgerp;
                lblsubtotal.Text = "Item total: " + "" + Convert.ToString(subtotal);
            }
            if (cbxdoublecheesyburger.Checked == true)
            {
                count++;
                richtextbox.AppendText("\t" + Convert.ToString(count) + "Double Cheesy Burger          " + txtdoublecheesyburger.Text + " QTY " + "     Pesos " + doublecheesyburgerp + Environment.NewLine);
                subtotal = subtotal + doublecheesyburgerp;
                lblsubtotal.Text = "Item total: " + "" + Convert.ToString(subtotal);
            }
            if (cbxcheeseburgeroverload.Checked == true)
            {
                count++;
                richtextbox.AppendText("\t" + Convert.ToString(count) + "Cheesy Burger Overload          " + txtcheeseburgeroverload.Text + " QTY " + "     Pesos " + cheesyburgeroverloadp + Environment.NewLine);
                subtotal = subtotal + cheesyburgeroverloadp;
                lblsubtotal.Text = "Item total: " + "" + Convert.ToString(subtotal);
            }
            if (cbxchimipestoburger.Checked == true)
            {
                count++;
                richtextbox.AppendText("\t" + Convert.ToString(count) + "Chimi-Pesto Crispy Chicken Burger         " + txtchimipestoburger.Text + " QTY " + "     Pesos " + chimipestop + Environment.NewLine);
                subtotal = subtotal + chimipestop;
                lblsubtotal.Text = "Item total: " + "" + Convert.ToString(subtotal);
            }
            if (cbxchickenveggieburger.Checked == true)
            {
                count++;
                richtextbox.AppendText("\t" + Convert.ToString(count) + "50/50 Chicken Veggie Burger         " + txtchickenveggieburger.Text + " QTY " + "     Pesos " + chickenveggieburgerp + Environment.NewLine);
                subtotal = subtotal + chickenveggieburgerp;
                lblsubtotal.Text = "Item total: " + "" + Convert.ToString(subtotal);
            }
            if (cbxbaconcheeseburger.Checked == true)
            {
                count++;
                richtextbox.AppendText("\t" + Convert.ToString(count) + "Bacon Cheese Burger         " + txtbaconcheeseburger.Text + " QTY " + "     Pesos " + baconcheeseburgerp + Environment.NewLine);
                subtotal = subtotal + baconcheeseburgerp;
                lblsubtotal.Text = "Item total: " + "" + Convert.ToString(subtotal);
            }
            if (cbxchickenroastedsesame.Checked == true)
            {
                count++;
                richtextbox.AppendText("\t" + Convert.ToString(count) + "Crispy Chicken Burger with Sesame         " + txtchickenroastedsesame.Text + " QTY " + "     Pesos " + chickenroastedsesamep + Environment.NewLine);
                subtotal = subtotal + chickenroastedsesamep;
                lblsubtotal.Text = "Item total: " + "" + Convert.ToString(subtotal);
            }
            if (cbxblackpepperburger.Checked == true)
            {
                count++;
                richtextbox.AppendText("\t" + Convert.ToString(count) + "Black Pepper Burger         " + txtblackpepperburger.Text + " QTY " + "     Pesos " + blackpepperburgerp + Environment.NewLine);
                subtotal = subtotal + blackpepperburgerp;
                lblsubtotal.Text = "Item total: " + "" + Convert.ToString(subtotal);
            }
            if (cbxbeefshawarmaburger.Checked == true)
            {
                count++;
                richtextbox.AppendText("\t" + Convert.ToString(count) + "Beef Shawarma Burger        " + txtbeefshawarmaburger.Text + " QTY " + "     Pesos " + beefshawarmaburgerp + Environment.NewLine);
                subtotal = subtotal + beefshawarmaburgerp;
                lblsubtotal.Text = "Item total: " + "" + Convert.ToString(subtotal);
            }

            tax = subtotal * 0.10;
            total = subtotal + tax;
            lblvat.Text = "Item Vat: " + "" + Convert.ToString(tax) ;
            lbltotal.Text = "Total: " + "" + Convert.ToString(total) ;
            richtextbox.AppendText(Environment.NewLine);
            richtextbox.AppendText(Environment.NewLine);
        }

        private void cbxchickenroastedsesame_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxchickenroastedsesame.Checked == true)
            {
                txtchickenroastedsesame.Enabled = true;
            }
            if (cbxchickenroastedsesame.Checked == false)
            {
                txtchickenroastedsesame.Enabled = false;
                txtchickenroastedsesame.Text = "0";
            }
        }

        private void cbxchimipestoburger_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxchimipestoburger.Checked == true)
            {
                txtchimipestoburger.Enabled = true;
            }
            if (cbxchimipestoburger.Checked == false)
            {
                txtchimipestoburger.Enabled = false;
                txtchimipestoburger.Text = "0";
            }
        }

        private void cbxbaconcheeseburger_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxbaconcheeseburger.Checked == true)
            {
                txtbaconcheeseburger.Enabled = true;
            }
            if (cbxbaconcheeseburger.Checked == false)
            {
                txtbaconcheeseburger.Enabled = false;
                txtbaconcheeseburger.Text = "0";
            }
        }

        private void cbxchickenveggieburger_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxchickenveggieburger.Checked == true)
            {
                txtchickenveggieburger.Enabled = true;
            }
            if (cbxchickenveggieburger.Checked == false)
            {
                txtchickenveggieburger.Enabled = false;
                txtchickenveggieburger.Text = "0";
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbxcheeseburgeroverload_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxcheeseburgeroverload.Checked == true)
            {
                txtcheeseburgeroverload.Enabled = true;
            }
            if (cbxcheeseburgeroverload.Checked == false)
            {
                txtcheeseburgeroverload.Enabled = false;
                txtcheeseburgeroverload.Text = "0";
            }
        }

        private void richtextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            cbxminuteburger.Checked = false;
            cbxdoubleminuteburger.Checked = false;
            cbxcheesyburger.Checked = false;
            cbxdoublecheesyburger.Checked = false;
            cbxcheeseburgeroverload.Checked = false;
            cbxchimipestoburger.Checked = false;
            cbxchickenveggieburger.Checked = false;
            cbxbaconcheeseburger.Checked = false;
            cbxchickenroastedsesame.Checked = false;
            cbxblackpepperburger.Checked = false;
            cbxbeefshawarmaburger.Checked = false;
            lblsubtotal.Text = "Item total:";
            lblvat.Text = "Item vat:";
            lbltotal.Text = "Total:";
            richtextbox.Clear();

        }

        private void cbxdoubleminuteburger_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxdoubleminuteburger.Checked == true)
            {
                txtdoubleminuteburger.Enabled = true;
            }
            if (cbxdoubleminuteburger.Checked == false)
            {
                txtdoubleminuteburger.Enabled = false;
                txtdoubleminuteburger.Text = "0";
            }
        }

        private void cbxdoublecheesyburger_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxdoublecheesyburger.Checked == true)
            {
                txtdoublecheesyburger.Enabled = true;
            }
            if (cbxdoublecheesyburger.Checked == false)
            {
                txtdoublecheesyburger.Enabled = false;
                txtdoublecheesyburger.Text = "0";
            }
        }

        private void cbxdoublecheesyburger_CheckedChanged_1(object sender, EventArgs e)
        {
            if (cbxdoublecheesyburger.Checked == true)
            {
                txtdoublecheesyburger.Enabled = true;
            }
            if (cbxdoublecheesyburger.Checked == false)
            {
                txtdoublecheesyburger.Enabled = false;
                txtdoublecheesyburger.Text = "0";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbxcheesyburger_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxcheesyburger.Checked == true)
            {
                txtcheesyburger.Enabled = true;
            }
            if (cbxcheesyburger.Checked == false)
            {
                txtcheesyburger.Enabled = false;
                txtcheesyburger.Text = "0";
            }
        }

        private void btnprint_Click(object sender, EventArgs e)
        {
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            statusstriptime.Text = DateTime.Now.ToLongTimeString();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(richtextbox.Text + " Subtotal: " + lblsubtotal.Text + "; VAT: " + lblvat.Text + "; Total: " + lbltotal.Text, new Font("Century Gothic", 17, FontStyle.Regular), Brushes.Blue, new Point(130));
        }
    }
}
