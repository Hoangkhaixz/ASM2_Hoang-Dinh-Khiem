using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ASM2
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        public void SetBillInformation(string name, string phone, string customerType,
                                    string waterLastMonth, string waterThisMonth,
                                    string waterUsed, string price, string envTax,
                                    string vat, string total)
        {
            txtname.Text = name;
            txtphone.Text = phone;
            txttype.Text = customerType;
            txtlast.Text = waterLastMonth;
            txtthis.Text = waterThisMonth;
            txtused.Text = waterUsed;
            txtprice.Text = price;
            txtenvi.Text = envTax;
            txtvat.Text = vat;
            txttotal.Text = total;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void txtlast_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
