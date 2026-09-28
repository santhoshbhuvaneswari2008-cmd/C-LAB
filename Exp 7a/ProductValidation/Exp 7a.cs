using System;
using System.Windows.Forms;

namespace ProductValidation
{
    public class Form1 : Form
    {
        TextBox txtCode, txtProduct, txtQuantity, txtPrice;
        ComboBox cmbCategory;
        Button btnValidate;

        public Form1()
        {
            Text = "Product Order Validation";
            Width = 450;
            Height = 400;


            Label l1 = new Label();
            l1.Text = "Product Code:";
            l1.Left = 40;
            l1.Top = 40;

            txtCode = new TextBox();
            txtCode.Left = 170;
            txtCode.Top = 40;

            Label l2 = new Label();
            l2.Text = "Product Name:";
            l2.Left = 40;
            l2.Top = 90;

            txtProduct = new TextBox();
            txtProduct.Left = 170;
            txtProduct.Top = 90;

            Label l3 = new Label();
            l3.Text = "Quantity:";
            l3.Left = 40;
            l3.Top = 140;

            txtQuantity = new TextBox();
            txtQuantity.Left = 170;
            txtQuantity.Top = 140;

            Label l4 = new Label();
            l4.Text = "Category:";
            l4.Left = 40;
            l4.Top = 190;

            cmbCategory = new ComboBox();
            cmbCategory.Left = 170;
            cmbCategory.Top = 190;
            cmbCategory.Items.Add("Electronics");
            cmbCategory.Items.Add("Stationery");
            cmbCategory.Items.Add("Accessories");

            Label l5 = new Label();
            l5.Text = "Price:";
            l5.Left = 40;
            l5.Top = 240;

            txtPrice = new TextBox();
            txtPrice.Left = 170;
            txtPrice.Top = 240;

            btnValidate = new Button();
            btnValidate.Text = "Validate";
            btnValidate.Left = 170;
            btnValidate.Top = 290;
            btnValidate.Click += ValidateData;

            Controls.Add(l1);
            Controls.Add(txtCode);
            Controls.Add(l2);
            Controls.Add(txtProduct);
            Controls.Add(l3);
            Controls.Add(txtQuantity);
            Controls.Add(l4);
            Controls.Add(cmbCategory);
            Controls.Add(l5);
            Controls.Add(txtPrice);
            Controls.Add(btnValidate);
        }

        private void ValidateData(object sender, EventArgs e)
        {
            if (txtCode.Text == "")
            {
                MessageBox.Show("Enter Product Code");
                return;
            }

            if (txtProduct.Text == "")
            {
                MessageBox.Show("Enter Product Name");
                return;
            }

            if (!int.TryParse(txtQuantity.Text, out int quantity) ||
                quantity <= 0)
            {
                MessageBox.Show("Enter a valid Quantity");
                return;
            }

            if (cmbCategory.SelectedIndex == -1)
            {
                MessageBox.Show("Select a Category");
                return;
            }

            if (!double.TryParse(txtPrice.Text, out double price) ||
                price <= 0)
            {
                MessageBox.Show("Enter a valid Price");
                return;
            }

            MessageBox.Show(
                "Product Details Validated Successfully!");
        }

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.Run(new Form1());
        }
    }
}
