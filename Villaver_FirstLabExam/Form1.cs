using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Globalization;
using System.Windows.Forms;

namespace Villaver_FirstLabExam
{
    public partial class Form1 : Form
    {
        private static readonly CultureInfo UsCurrency = CultureInfo.GetCultureInfo("en-US");
        private readonly string[] salespersonNames = { "Danielle", "Edward", "Fatima" };
        private readonly decimal[] salespersonTotals = new decimal[3];
        private decimal grandTotal;

        public Form1()
        {
            InitializeComponent();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            string initial = initialTextBox.Text.Trim().ToUpperInvariant();
            int salesperson = initial.Length == 1 ? "DEF".IndexOf(initial[0]) : -1;
            if (salesperson < 0)
            {
                ShowInputError("Enter D for Danielle, E for Edward, or F for Fatima.", initialTextBox);
                return;
            }

            if (!decimal.TryParse(amountTextBox.Text, NumberStyles.Currency, UsCurrency, out decimal amount)
                || amount <= 0 || decimal.Round(amount, 2) != amount)
            {
                ShowInputError("Enter a positive amount in dollars and cents, such as 100.50.", amountTextBox);
                return;
            }

            try
            {
                decimal updatedGrandTotal = grandTotal + amount;
                salespersonTotals[salesperson] += amount;
                grandTotal = updatedGrandTotal;
            }
            catch (OverflowException)
            {
                ShowInputError("This amount is too large to add to the sales totals.", amountTextBox);
                return;
            }

            danielleTotalLabel.Text = FormatCurrency(salespersonTotals[0]);
            edwardTotalLabel.Text = FormatCurrency(salespersonTotals[1]);
            fatimaTotalLabel.Text = FormatCurrency(salespersonTotals[2]);
            grandTotalLabel.Text = FormatCurrency(grandTotal);

            string name = salespersonNames[salesperson];
            statusLabel.BackColor = Color.FromArgb(232, 247, 241);
            statusLabel.ForeColor = Color.FromArgb(20, 92, 63);
            statusLabel.Text = $"Recorded {FormatCurrency(amount)} in sales for {name}."
                + Environment.NewLine + $"{name}'s total sales are {FormatCurrency(salespersonTotals[salesperson])}.";
            amountTextBox.Focus();
            amountTextBox.SelectAll();
        }

        private void ShowInputError(string message, TextBox input)
        {
            statusLabel.BackColor = Color.FromArgb(254, 237, 240);
            statusLabel.ForeColor = Color.FromArgb(149, 36, 54);
            statusLabel.Text = message;
            input.Focus();
            input.SelectAll();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            initialTextBox.Clear();
            amountTextBox.Clear();
            statusLabel.Text = string.Empty;
            statusLabel.BackColor = Color.Transparent;
            initialTextBox.Focus();
        }

        private void PrintButton_Click(object sender, EventArgs e)
        {
            using (var document = new PrintDocument())
            using (var preview = new PrintPreviewDialog())
            {
                if (!document.PrinterSettings.IsValid)
                {
                    MessageBox.Show(this, "Set a default printer in Windows to preview or print the report.",
                        "Summary Report", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                document.DocumentName = "Sales Summary Report";
                document.PrintPage += PrintSummaryPage;
                preview.Document = document;
                preview.ClientSize = new Size(850, 650);
                preview.StartPosition = FormStartPosition.CenterParent;
                preview.ShowDialog(this);
            }
        }

        private void PrintSummaryPage(object sender, PrintPageEventArgs e)
        {
            Rectangle margins = e.MarginBounds;
            Graphics graphics = e.Graphics;

            using (var headingFont = new Font("Segoe UI", 22, FontStyle.Bold))
            using (var bodyFont = new Font("Segoe UI", 12))
            using (var totalFont = new Font("Segoe UI", 14, FontStyle.Bold))
            using (var rightAligned = new StringFormat { Alignment = StringAlignment.Far })
            {
                graphics.DrawString(reportTitle.Text, headingFont, Brushes.Black, margins.Left, margins.Top);

                float top = margins.Top + 65;
                for (int index = 0; index < salespersonNames.Length; index++)
                {
                    graphics.DrawString(salespersonNames[index] + " Total Sales", bodyFont, Brushes.Black, margins.Left, top);
                    graphics.DrawString(FormatCurrency(salespersonTotals[index]), bodyFont, Brushes.Black,
                        margins.Right, top, rightAligned);
                    top += 32;
                }

                graphics.DrawLine(Pens.Gray, margins.Left, top, margins.Right, top);
                top += 14;
                graphics.DrawString(grandTotalTitle.Text, totalFont, Brushes.Black, margins.Left, top);
                graphics.DrawString(FormatCurrency(grandTotal), totalFont, Brushes.Black, margins.Right, top, rightAligned);
            }
        }

        private static string FormatCurrency(decimal amount)
        {
            return amount.ToString("C2", UsCurrency);
        }
    }
}
