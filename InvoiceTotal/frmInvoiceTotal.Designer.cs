namespace InvoiceTotal
{
    partial class frmInvoiceTotal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtSubtotal = new TextBox();
            label2 = new Label();
            txtDiscountPct = new TextBox();
            label3 = new Label();
            txtDiscountAmt = new TextBox();
            label4 = new Label();
            txtTotal = new TextBox();
            btnCalculate = new Button();
            btnExit = new Button();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtNumberOfInvoices = new TextBox();
            txtTotalOfInvoices = new TextBox();
            txtInvoiceAverage = new TextBox();
            btnClear = new Button();
            label8 = new Label();
            txtEnterSubtotal = new TextBox();
            label9 = new Label();
            label10 = new Label();
            txtLargestInvoice = new TextBox();
            txtSmallestInvoice = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 48);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 12;
            label1.Text = "&Subtotal:";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtSubtotal
            // 
            txtSubtotal.Location = new Point(131, 45);
            txtSubtotal.Name = "txtSubtotal";
            txtSubtotal.ReadOnly = true;
            txtSubtotal.Size = new Size(100, 23);
            txtSubtotal.TabIndex = 1;
            txtSubtotal.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 77);
            label2.Name = "label2";
            label2.Size = new Size(100, 15);
            label2.TabIndex = 13;
            label2.Text = "Discount Percent:";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtDiscountPct
            // 
            txtDiscountPct.Location = new Point(131, 74);
            txtDiscountPct.Name = "txtDiscountPct";
            txtDiscountPct.ReadOnly = true;
            txtDiscountPct.Size = new Size(100, 23);
            txtDiscountPct.TabIndex = 2;
            txtDiscountPct.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 106);
            label3.Name = "label3";
            label3.Size = new Size(104, 15);
            label3.TabIndex = 14;
            label3.Text = "Discount Amount:";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtDiscountAmt
            // 
            txtDiscountAmt.Location = new Point(131, 103);
            txtDiscountAmt.Name = "txtDiscountAmt";
            txtDiscountAmt.ReadOnly = true;
            txtDiscountAmt.Size = new Size(100, 23);
            txtDiscountAmt.TabIndex = 3;
            txtDiscountAmt.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 135);
            label4.Name = "label4";
            label4.Size = new Size(35, 15);
            label4.TabIndex = 15;
            label4.Text = "Total:";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(131, 132);
            txtTotal.Name = "txtTotal";
            txtTotal.ReadOnly = true;
            txtTotal.Size = new Size(100, 23);
            txtTotal.TabIndex = 4;
            txtTotal.TabStop = false;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(284, 172);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(75, 23);
            btnCalculate.TabIndex = 8;
            btnCalculate.Text = "&Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(446, 172);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 23);
            btnExit.TabIndex = 10;
            btnExit.Text = "E&xit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(289, 19);
            label5.Name = "label5";
            label5.Size = new Size(114, 15);
            label5.TabIndex = 16;
            label5.Text = "Number of invoices:";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(289, 48);
            label6.Name = "label6";
            label6.Size = new Size(95, 15);
            label6.TabIndex = 17;
            label6.Text = "Total of invoices:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(289, 77);
            label7.Name = "label7";
            label7.Size = new Size(92, 15);
            label7.TabIndex = 18;
            label7.Text = "Invoice average:";
            // 
            // txtNumberOfInvoices
            // 
            txtNumberOfInvoices.Location = new Point(422, 16);
            txtNumberOfInvoices.Name = "txtNumberOfInvoices";
            txtNumberOfInvoices.ReadOnly = true;
            txtNumberOfInvoices.Size = new Size(100, 23);
            txtNumberOfInvoices.TabIndex = 5;
            txtNumberOfInvoices.TabStop = false;
            // 
            // txtTotalOfInvoices
            // 
            txtTotalOfInvoices.Location = new Point(422, 45);
            txtTotalOfInvoices.Name = "txtTotalOfInvoices";
            txtTotalOfInvoices.ReadOnly = true;
            txtTotalOfInvoices.Size = new Size(100, 23);
            txtTotalOfInvoices.TabIndex = 6;
            txtTotalOfInvoices.TabStop = false;
            txtTotalOfInvoices.TextChanged += txtTotalOfInvoices_TextChanged;
            // 
            // txtInvoiceAverage
            // 
            txtInvoiceAverage.Location = new Point(422, 74);
            txtInvoiceAverage.Name = "txtInvoiceAverage";
            txtInvoiceAverage.ReadOnly = true;
            txtInvoiceAverage.Size = new Size(100, 23);
            txtInvoiceAverage.TabIndex = 7;
            txtInvoiceAverage.TabStop = false;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(365, 172);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 9;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(21, 19);
            label8.Name = "label8";
            label8.Size = new Size(83, 15);
            label8.TabIndex = 11;
            label8.Text = "Enter subtotal:";
            label8.Click += label8_Click;
            // 
            // txtEnterSubtotal
            // 
            txtEnterSubtotal.Location = new Point(131, 16);
            txtEnterSubtotal.Name = "txtEnterSubtotal";
            txtEnterSubtotal.Size = new Size(100, 23);
            txtEnterSubtotal.TabIndex = 0;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(289, 106);
            label9.Name = "label9";
            label9.Size = new Size(89, 15);
            label9.TabIndex = 19;
            label9.Text = "Largest invoice:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(289, 135);
            label10.Name = "label10";
            label10.Size = new Size(95, 15);
            label10.TabIndex = 20;
            label10.Text = "Smallest invoice:";
            label10.Click += label10_Click;
            // 
            // txtLargestInvoice
            // 
            txtLargestInvoice.Location = new Point(422, 103);
            txtLargestInvoice.Name = "txtLargestInvoice";
            txtLargestInvoice.ReadOnly = true;
            txtLargestInvoice.Size = new Size(100, 23);
            txtLargestInvoice.TabIndex = 21;
            txtLargestInvoice.TabStop = false;
            // 
            // txtSmallestInvoice
            // 
            txtSmallestInvoice.Location = new Point(422, 132);
            txtSmallestInvoice.Name = "txtSmallestInvoice";
            txtSmallestInvoice.ReadOnly = true;
            txtSmallestInvoice.Size = new Size(100, 23);
            txtSmallestInvoice.TabIndex = 22;
            txtSmallestInvoice.TabStop = false;
            // 
            // frmInvoiceTotal
            // 
            AcceptButton = btnCalculate;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnExit;
            ClientSize = new Size(549, 222);
            Controls.Add(txtSmallestInvoice);
            Controls.Add(txtLargestInvoice);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(txtEnterSubtotal);
            Controls.Add(label8);
            Controls.Add(btnClear);
            Controls.Add(txtInvoiceAverage);
            Controls.Add(txtTotalOfInvoices);
            Controls.Add(txtNumberOfInvoices);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(btnExit);
            Controls.Add(btnCalculate);
            Controls.Add(txtTotal);
            Controls.Add(label4);
            Controls.Add(txtDiscountAmt);
            Controls.Add(label3);
            Controls.Add(txtDiscountPct);
            Controls.Add(label2);
            Controls.Add(txtSubtotal);
            Controls.Add(label1);
            Name = "frmInvoiceTotal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Invoice Total";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtSubtotal;
        private Label label2;
        private TextBox txtDiscountPct;
        private Label label3;
        private TextBox txtDiscountAmt;
        private Label label4;
        private TextBox txtTotal;
        private Button btnCalculate;
        private Button btnExit;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtNumberOfInvoices;
        private TextBox txtTotalOfInvoices;
        private TextBox txtInvoiceAverage;
        private Button btnClear;
        private Label label8;
        private TextBox txtEnterSubtotal;
        private Label label9;
        private Label label10;
        private TextBox txtLargestInvoice;
        private TextBox txtSmallestInvoice;
    }
}