namespace InvoiceTotal
{
    public partial class frmInvoiceTotal : Form
    {
        public frmInvoiceTotal()
        {
            InitializeComponent();
        }

        int numberOfInvoices = 0;
        decimal totalOfInvoices = 0m;
        decimal invoiceAverage = 0m;

        decimal maxInvoice = decimal.MinValue;
        decimal minInvoice = decimal.MaxValue;

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            decimal subtotal = Decimal.Parse(txtEnterSubtotal.Text);
            decimal discountPct = .25m;
            decimal discountAmt = Math.Round(subtotal * discountPct, 2);
            decimal invoiceTotal = Math.Round(subtotal - discountAmt);

            txtSubtotal.Text = subtotal.ToString("c");
            txtDiscountPct.Text = discountPct.ToString("p1");
            txtDiscountAmt.Text = discountAmt.ToString("c");
            txtTotal.Text = invoiceTotal.ToString("c");

            numberOfInvoices++;
            totalOfInvoices += invoiceTotal;
            invoiceAverage = totalOfInvoices / numberOfInvoices;

            txtNumberOfInvoices.Text = numberOfInvoices.ToString("n0");
            txtTotalOfInvoices.Text = totalOfInvoices.ToString("c");
            txtInvoiceAverage.Text = invoiceAverage.ToString("c");

            if (invoiceTotal > maxInvoice)
            {
                maxInvoice = invoiceTotal;
            }
            if (invoiceTotal < minInvoice)
            {
                minInvoice = invoiceTotal;
            }

            txtLargestInvoice.Text = maxInvoice.ToString("c");
            txtSmallestInvoice.Text = minInvoice.ToString("c");

            txtEnterSubtotal.Text = "";
            txtEnterSubtotal.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void txtTotalOfInvoices_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            numberOfInvoices = 0;
            totalOfInvoices = 0m;
            invoiceAverage = 0m;

            maxInvoice = decimal.MinValue;
            minInvoice = decimal.MaxValue;

            txtSubtotal.Text = "";
            txtDiscountPct.Text = "";
            txtDiscountAmt.Text = "";
            txtTotal.Text = "";


            txtNumberOfInvoices.Text = "";
            txtTotalOfInvoices.Text = "";
            txtInvoiceAverage.Text = "";


            txtLargestInvoice.Text = "";
            txtSmallestInvoice.Text = "";

            txtEnterSubtotal.Text = "";
            txtEnterSubtotal.Focus();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}