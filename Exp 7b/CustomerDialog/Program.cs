using System;
using System.Windows.Forms;

namespace CustomerDialog
{
    public class CustomerForm : Form
    {
        TextBox txtCustomerId;
        TextBox txtCompany;
        TextBox txtCity;
        ComboBox cmbType;
        Button btnSave;
        Button btnClear;
        Button btnClose;

        public CustomerForm()
        {
            Text = "Customer Dialog Box";
            Width = 450;
            Height = 350;

            Label l1 = new Label();
            l1.Text = "Customer ID:";
            l1.Left = 40;
            l1.Top = 40;

            txtCustomerId = new TextBox();
            txtCustomerId.Left = 160;
            txtCustomerId.Top = 40;
            txtCustomerId.Width = 200;

            Label l2 = new Label();
            l2.Text = "Company:";
            l2.Left = 40;
            l2.Top = 90;

            txtCompany = new TextBox();
            txtCompany.Left = 160;
            txtCompany.Top = 90;
            txtCompany.Width = 200;

            Label l3 = new Label();
            l3.Text = "City:";
            l3.Left = 40;
            l3.Top = 140;

            txtCity = new TextBox();
            txtCity.Left = 160;
            txtCity.Top = 140;
            txtCity.Width = 200;

            Label l4 = new Label();
            l4.Text = "Customer Type:";
            l4.Left = 40;
            l4.Top = 190;

            cmbType = new ComboBox();
            cmbType.Left = 160;
            cmbType.Top = 190;
            cmbType.Width = 200;

            cmbType.Items.Add("Regular");
            cmbType.Items.Add("Premium");
            cmbType.Items.Add("Corporate");

            btnSave = new Button();
            btnSave.Text = "Save";
            btnSave.Left = 70;
            btnSave.Top = 240;
            btnSave.Click += SaveCustomer;

            btnClear = new Button();
            btnClear.Text = "Clear";
            btnClear.Left = 160;
            btnClear.Top = 240;
            btnClear.Click += ClearCustomer;

            btnClose = new Button();
            btnClose.Text = "Close";
            btnClose.Left = 250;
            btnClose.Top = 240;
            btnClose.Click += CloseDialog;

            Controls.Add(l1);
            Controls.Add(txtCustomerId);
            Controls.Add(l2);
            Controls.Add(txtCompany);
            Controls.Add(l3);
            Controls.Add(txtCity);
            Controls.Add(l4);
            Controls.Add(cmbType);
            Controls.Add(btnSave);
            Controls.Add(btnClear);
            Controls.Add(btnClose);
        }

        private void SaveCustomer(object sender, EventArgs e)
        {
            if (txtCustomerId.Text == "" ||
                txtCompany.Text == "" ||
                txtCity.Text == "" ||
                cmbType.SelectedIndex == -1)
            {
                MessageBox.Show("Please enter all customer details.");
                return;
            }

            MessageBox.Show(
                "Customer Details Saved Successfully!\n\n" +
                "Customer ID: " + txtCustomerId.Text +
                "\nCompany: " + txtCompany.Text +
                "\nCity: " + txtCity.Text +
                "\nCustomer Type: " + cmbType.Text,
                "Customer Details");
        }

        private void ClearCustomer(object sender, EventArgs e)
        {
            txtCustomerId.Clear();
            txtCompany.Clear();
            txtCity.Clear();
            cmbType.SelectedIndex = -1;
        }

        private void CloseDialog(object sender, EventArgs e)
        {
            Close();
        }

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.Run(new CustomerForm());
        }
    }
}
