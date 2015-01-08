using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class frmPantallaPrincipal : Form
    {
        Boolean cerosite = true;
        Double num1,num2, equal = 0;
        string operation = "";
       List<Pedido> Pedidos = new List<Pedido>();
       int dineroCaja = 0;
  
        public frmPantallaPrincipal(int dineroCajaInicial)
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.txtCuenta.Focus();
            dineroCaja = dineroCajaInicial;
        }


        private void btnCaja_Click(object sender, EventArgs e)
        {
            this.txtCuenta.Focus();
        }

        private void frmPantallaPrincipal_KeyDown(object sender, KeyEventArgs e)
        {   
            if (e.KeyCode == Keys.D1 || e.KeyCode == Keys.NumPad1)
            {
                this.btnC1.BackColor = System.Drawing.Color.White;
                //this.btnC1.PerformClick();
            }
            if (e.KeyCode == Keys.D2 || e.KeyCode == Keys.NumPad2)
            {
                this.btnC2.BackColor = System.Drawing.Color.White;
                //this.btnC2.PerformClick();
            }
            if (e.KeyCode == Keys.D3 || e.KeyCode == Keys.NumPad3)
            {
                this.btnC3.BackColor = System.Drawing.Color.White;
                //this.btnC3.PerformClick();
            }
            if (e.KeyCode == Keys.D4 || e.KeyCode == Keys.NumPad4)
            {
                this.btnC4.BackColor = System.Drawing.Color.White;
                //this.btnC4.PerformClick();
            }
            if (e.KeyCode == Keys.D5 || e.KeyCode == Keys.NumPad5)
            {
                this.btnC5.BackColor = System.Drawing.Color.White;
                //this.btnC5.PerformClick();
            }
            if (e.KeyCode == Keys.D6 || e.KeyCode == Keys.NumPad6)
            {
                this.btnC6.BackColor = System.Drawing.Color.White;
                //this.btnC6.PerformClick();
            }
            if (e.KeyCode == Keys.D7 || e.KeyCode == Keys.NumPad7)
            {
                this.btnC7.BackColor = System.Drawing.Color.White;
                // this.btnC7.PerformClick();
            }
            if (e.KeyCode == Keys.D8 || e.KeyCode == Keys.NumPad8)
            {
                this.btnC8.BackColor = System.Drawing.Color.White;
                //this.btnC8.PerformClick();
            }
            if (e.KeyCode == Keys.D9 || e.KeyCode == Keys.NumPad9)
            {
                this.btnC9.BackColor = System.Drawing.Color.White;
                // this.btnC9.PerformClick();
            }
            if (e.KeyCode == Keys.D0 || e.KeyCode == Keys.NumPad0)
            {
                this.btnC10.BackColor = System.Drawing.Color.White;
               // this.btnC10.PerformClick();
            }
        }

        private void frmPantallaPrincipal_KeyUp(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.D1 || e.KeyCode == Keys.NumPad1)
            {
                this.btnC1.BackColor = System.Drawing.Color.Orange;
                this.btnC1.PerformClick();
            }
            if (e.KeyCode == Keys.D2 || e.KeyCode == Keys.NumPad2)
            {
                this.btnC2.BackColor = System.Drawing.Color.Orange;
                this.btnC2.PerformClick();
            }
            if (e.KeyCode == Keys.D3 || e.KeyCode == Keys.NumPad3)
            {
                this.btnC3.BackColor = System.Drawing.Color.Orange;
                this.btnC3.PerformClick();
            }
            if (e.KeyCode == Keys.D4 || e.KeyCode == Keys.NumPad4)
            {
                this.btnC4.BackColor = System.Drawing.Color.Orange;
                this.btnC4.PerformClick();
            }
            if (e.KeyCode == Keys.D5 || e.KeyCode == Keys.NumPad5)
            {
                this.btnC5.BackColor = System.Drawing.Color.Orange;
                this.btnC5.PerformClick();
            }
            if (e.KeyCode == Keys.D6 || e.KeyCode == Keys.NumPad6)
            {
                this.btnC6.BackColor = System.Drawing.Color.Orange;
                this.btnC6.PerformClick();
            }
            if (e.KeyCode == Keys.D7 || e.KeyCode == Keys.NumPad7)
            {
                this.btnC7.BackColor = System.Drawing.Color.Orange;
                this.btnC7.PerformClick();
            }
            if (e.KeyCode == Keys.D8 || e.KeyCode == Keys.NumPad8)
            {
                this.btnC8.BackColor = System.Drawing.Color.Orange;
                this.btnC8.PerformClick();
            }
            if (e.KeyCode == Keys.D9 || e.KeyCode == Keys.NumPad9)
            {
                this.btnC9.BackColor = System.Drawing.Color.Orange;
                this.btnC9.PerformClick();
            }
            if (e.KeyCode == Keys.D0 || e.KeyCode == Keys.NumPad0)
            {
                this.btnC10.BackColor = System.Drawing.Color.Orange;
                this.btnC10.PerformClick();
            }
        }

        private void frmPantallaPrincipal_Load(object sender, EventArgs e)
        {
            cboItem.Items.Add("Apuntes");
            cboItem.Items.Add("Lapicera");
        }

        private void botonNumerico(string num)
        {
            if (cerosite)
            {
                txtCuenta.Text = "";
                txtCuenta.Text = num;
                cerosite = false;
            }
            else
                this.txtCuenta.Text = this.txtCuenta.Text + num;
        }

        private void btnC1_Click(object sender, EventArgs e)
        {
            botonNumerico("1");
        }

        private void btnC2_Click(object sender, EventArgs e)
        {
            botonNumerico("2");
        }

        private void btnC3_Click(object sender, EventArgs e)
        {
            botonNumerico("3");
        }

        private void btnC4_Click(object sender, EventArgs e)
        {
            botonNumerico("4");
        }

        private void btnC5_Click(object sender, EventArgs e)
        {
            botonNumerico("5");
        }

        private void btnC6_Click(object sender, EventArgs e)
        {
            botonNumerico("6");
        }

        private void btnC7_Click(object sender, EventArgs e)
        {
            botonNumerico("7");
        }

        private void btnC8_Click(object sender, EventArgs e)
        {
            botonNumerico("8");
        }

        private void btnC9_Click(object sender, EventArgs e)
        {
            botonNumerico("9");
        }

        private void btnC10_Click(object sender, EventArgs e)
        {
            botonNumerico("0");
        }

        private void txtCuenta_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnC16_Click(object sender, EventArgs e)
        {
            num2 = double.Parse(txtCuenta.Text);
            cerosite = true;
            switch (operation)
            { 
                case"+":
                    equal = num1 + num2;
                    txtCuenta.Text = equal.ToString();
                    break;
                case"-":
                    equal = num1 + num2;
                    txtCuenta.Text = equal.ToString();
                    break;
                case "*":
                    equal = num1 * num2;
                    txtCuenta.Text = equal.ToString();
                    break;
                case "/":
                    equal = num1 / num2;
                    txtCuenta.Text = equal.ToString();
                    break;
                case "C":
                    equal = num1 / num2;
                    txtCuenta.Text = equal.ToString();
                    break;
                default:
                    num1 = 0;
                    equal = num1 + num2;
                    txtCuenta.Text = equal.ToString();
                    break;
                
            }
        }

        private void btnC11_Click(object sender, EventArgs e)
        {
            num2 = double.Parse(txtCuenta.Text);
            num1 += num2;
            txtCuenta.Text = num1.ToString();
            operation = "+";
            cerosite = true;
            num1 = double.Parse(txtCuenta.Text);
        }

        private void btnC15_Click(object sender, EventArgs e)
        {
            if (cerosite)
            {
                if (txtCuenta.Text.Contains(","))
                    return;
                cerosite = false;
            }
            else
            {
                if (txtCuenta.Text.Contains(","))
                    return;
                txtCuenta.Text = txtCuenta.Text + ",";
            }
        }

        private void btnC14_Click(object sender, EventArgs e)
        {
            operation = "C";
            txtCuenta.Text = "0";
            cerosite = true;
            num1 = 0;
            num2 = 0;
        }

        private void btnC12_Click(object sender, EventArgs e)
        {
            double total = 0;
            foreach (Pedido ped in Pedidos)
            {
                total += double.Parse(ped.Precio);
                txtTotal.Text = total.ToString();

            }
        }

        private void btnC13_Click(object sender, EventArgs e)
        {
            num2 = double.Parse(txtCuenta.Text);
            num1 *= num2;
            txtCuenta.Text = num1.ToString();
            operation = "*";
            cerosite = true;
            num1 = double.Parse(txtCuenta.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            num2 = double.Parse(txtCuenta.Text);
            num1 -= num2;
            txtCuenta.Text = num1.ToString();
            operation = "-";
            cerosite = true;
            num1 = double.Parse(txtCuenta.Text);
        }

        private void btn16_Click(object sender, EventArgs e)
        {

            lbPedido.Items.Clear();
            num1 = 0;
            Pedidos.Add(new Pedido() { Item = cboItem.Text, Precio = txtCuenta.Text });
            foreach (Pedido ped in Pedidos)
            {
                lbPedido.Items.Add(ped);
            }
            
        }

        private void btnC11_Enter(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



    }
}
