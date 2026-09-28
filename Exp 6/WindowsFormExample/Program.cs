using System;
using System.Drawing;
using System.Windows.Forms;

namespace ElectricityBillApp
{
    public class Form1 : Form
    {
        Label lblUnits, lblTariff, lblConnection;
        TextBox txtUnits;
        ComboBox cmbTariff;
        RadioButton rbDomestic, rbCommercial;
        CheckBox chkService;
        Button btnCalculate;

        public Form1()
        {
            Text = "Electricity Bill Calculator";
            Width = 500;
            Height = 400;

            this.BackColor=Color.LightYellow;
            this.ForeColor=Color.DarkBlue;

            // Units
            lblUnits = new Label();
            lblUnits.Text = "Units Consumed:";
            lblUnits.Location = new Point(50, 50);
            Controls.Add(lblUnits);

            txtUnits = new TextBox();
            txtUnits.Location = new Point(200, 50);
            Controls.Add(txtUnits);

            // Tariff
            lblTariff = new Label();
            lblTariff.Text = "Tariff Type:";
            lblTariff.Location = new Point(50, 100);
            Controls.Add(lblTariff);

            cmbTariff = new ComboBox();
            cmbTariff.Location = new Point(200, 100);
            cmbTariff.Items.Add("Normal");
            cmbTariff.Items.Add("Premium");
            cmbTariff.SelectedIndex = 0;
            Controls.Add(cmbTariff);

            // Connection type
            lblConnection = new Label();
            lblConnection.Text = "Connection:";
            lblConnection.Location = new Point(50, 150);
            Controls.Add(lblConnection);

            rbDomestic = new RadioButton();
            rbDomestic.Text = "Domestic";
            rbDomestic.Location = new Point(200, 150);
            rbDomestic.Checked = true;
            Controls.Add(rbDomestic);

            rbCommercial = new RadioButton();
            rbCommercial.Text = "Commercial";
            rbCommercial.Location = new Point(290, 150);
            Controls.Add(rbCommercial);

            // Additional service
            chkService = new CheckBox();
            chkService.Text = "Include Service Charge";
            chkService.Location = new Point(200, 200);
            Controls.Add(chkService);

            // Calculate button
            btnCalculate = new Button();
            btnCalculate.Text = "Calculate Bill";
            btnCalculate.Location = new Point(200, 250);
            btnCalculate.Click += CalculateBill;
            Controls.Add(btnCalculate);
        }

        private void CalculateBill(object sender, EventArgs e)
        {
            if (!double.TryParse(txtUnits.Text, out double units))
            {
                MessageBox.Show("Please enter valid units.");
                return;
            }

            double rate;

            if (cmbTariff.Text == "Normal")
                rate = 5;
            else
                rate = 8;

            if (rbCommercial.Checked)
                rate += 3;

            double bill = units * rate;

            if (chkService.Checked)
                bill += 50;

            MessageBox.Show(
                "Units Consumed: " + units +
                "\nTariff: " + cmbTariff.Text +
                "\nConnection: " +
                (rbDomestic.Checked ? "Domestic" : "Commercial") +
                "\nTotal Bill: ₹" + bill,
                "Electricity Bill");
        }

        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
