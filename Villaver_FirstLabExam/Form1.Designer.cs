using System.Drawing;
using System.Windows.Forms;

namespace Villaver_FirstLabExam
{
    partial class Form1
    {
        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.mainTitle = new Label();
            this.entryPanel = new Panel();
            this.reportPanel = new Panel();
            this.entryTitle = new Label();
            this.initialLabel = new Label();
            this.initialTextBox = new TextBox();
            this.salespersonKey = new Label();
            this.amountLabel = new Label();
            this.amountTextBox = new TextBox();
            this.submitButton = new Button();
            this.clearButton = new Button();
            this.statusLabel = new Label();
            this.reportTitle = new Label();
            this.printButton = new Button();
            this.danielleLabel = new Label();
            this.danielleTotalLabel = new Label();
            this.danielleDivider = new Panel();
            this.edwardLabel = new Label();
            this.edwardTotalLabel = new Label();
            this.edwardDivider = new Panel();
            this.fatimaLabel = new Label();
            this.fatimaTotalLabel = new Label();
            this.totalPanel = new Panel();
            this.grandTotalTitle = new Label();
            this.grandTotalLabel = new Label();
            this.entryPanel.SuspendLayout();
            this.reportPanel.SuspendLayout();
            this.totalPanel.SuspendLayout();
            this.SuspendLayout();

            // mainTitle
            this.mainTitle.Location = new Point(30, 17);
            this.mainTitle.Name = "mainTitle";
            this.mainTitle.Size = new Size(828, 50);
            this.mainTitle.Font = new Font("Segoe UI", 26F, FontStyle.Bold);
            this.mainTitle.Text = "Sales tracker";

            // entryPanel
            this.entryPanel.Location = new Point(30, 84);
            this.entryPanel.Name = "entryPanel";
            this.entryPanel.Size = new Size(436, 376);
            this.entryPanel.BackColor = Color.FromArgb(255, 255, 255);
            this.entryPanel.TabIndex = 0;
            this.entryPanel.Controls.Add(this.entryTitle);
            this.entryPanel.Controls.Add(this.initialLabel);
            this.entryPanel.Controls.Add(this.initialTextBox);
            this.entryPanel.Controls.Add(this.salespersonKey);
            this.entryPanel.Controls.Add(this.amountLabel);
            this.entryPanel.Controls.Add(this.amountTextBox);
            this.entryPanel.Controls.Add(this.submitButton);
            this.entryPanel.Controls.Add(this.clearButton);
            this.entryPanel.Controls.Add(this.statusLabel);

            // reportPanel
            this.reportPanel.Location = new Point(486, 84);
            this.reportPanel.Name = "reportPanel";
            this.reportPanel.Size = new Size(386, 376);
            this.reportPanel.BackColor = Color.FromArgb(20, 32, 56);
            this.reportPanel.ForeColor = Color.FromArgb(255, 255, 255);
            this.reportPanel.TabIndex = 1;
            this.reportPanel.Controls.Add(this.reportTitle);
            this.reportPanel.Controls.Add(this.printButton);
            this.reportPanel.Controls.Add(this.danielleLabel);
            this.reportPanel.Controls.Add(this.danielleTotalLabel);
            this.reportPanel.Controls.Add(this.danielleDivider);
            this.reportPanel.Controls.Add(this.edwardLabel);
            this.reportPanel.Controls.Add(this.edwardTotalLabel);
            this.reportPanel.Controls.Add(this.edwardDivider);
            this.reportPanel.Controls.Add(this.fatimaLabel);
            this.reportPanel.Controls.Add(this.fatimaTotalLabel);
            this.reportPanel.Controls.Add(this.totalPanel);

            // entryTitle
            this.entryTitle.Location = new Point(24, 18);
            this.entryTitle.Name = "entryTitle";
            this.entryTitle.Size = new Size(388, 36);
            this.entryTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            this.entryTitle.Text = "Record a sale";

            // initialLabel
            this.initialLabel.Location = new Point(24, 75);
            this.initialLabel.Name = "initialLabel";
            this.initialLabel.Size = new Size(388, 24);
            this.initialLabel.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            this.initialLabel.TabIndex = 1;
            this.initialLabel.Text = "Salesperson &initial";

            // initialTextBox
            this.initialTextBox.Location = new Point(24, 102);
            this.initialTextBox.Name = "initialTextBox";
            this.initialTextBox.Size = new Size(388, 34);
            this.initialTextBox.BackColor = Color.FromArgb(247, 249, 253);
            this.initialTextBox.BorderStyle = BorderStyle.FixedSingle;
            this.initialTextBox.Font = new Font("Segoe UI", 14F, FontStyle.Regular);
            this.initialTextBox.TabIndex = 2;
            this.initialTextBox.AccessibleName = "Salesperson initial";

            // salespersonKey
            this.salespersonKey.Location = new Point(24, 142);
            this.salespersonKey.Name = "salespersonKey";
            this.salespersonKey.Size = new Size(388, 24);
            this.salespersonKey.ForeColor = Color.FromArgb(77, 93, 119);
            this.salespersonKey.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
            this.salespersonKey.Text = "D — Danielle     /     E — Edward     /     F — Fatima";

            // amountLabel
            this.amountLabel.Location = new Point(24, 182);
            this.amountLabel.Name = "amountLabel";
            this.amountLabel.Size = new Size(388, 24);
            this.amountLabel.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            this.amountLabel.TabIndex = 3;
            this.amountLabel.Text = "Sale &amount (USD)";

            // amountTextBox
            this.amountTextBox.Location = new Point(24, 209);
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.Size = new Size(388, 34);
            this.amountTextBox.BackColor = Color.FromArgb(247, 249, 253);
            this.amountTextBox.BorderStyle = BorderStyle.FixedSingle;
            this.amountTextBox.Font = new Font("Segoe UI", 14F, FontStyle.Regular);
            this.amountTextBox.TabIndex = 4;
            this.amountTextBox.AccessibleName = "Sale amount in US dollars";

            // submitButton
            this.submitButton.Location = new Point(24, 261);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new Size(133, 41);
            this.submitButton.BackColor = Color.FromArgb(40, 74, 220);
            this.submitButton.ForeColor = Color.FromArgb(255, 255, 255);
            this.submitButton.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            this.submitButton.TabIndex = 5;
            this.submitButton.Text = "&Submit";
            this.submitButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(30, 59, 185);
            this.submitButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(23, 47, 152);
            this.submitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            this.submitButton.FlatStyle = FlatStyle.Flat;
            this.submitButton.FlatAppearance.BorderSize = 0;
            this.submitButton.UseVisualStyleBackColor = false;

            // clearButton
            this.clearButton.Location = new Point(167, 261);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new Size(91, 41);
            this.clearButton.BackColor = Color.FromArgb(232, 238, 249);
            this.clearButton.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            this.clearButton.TabIndex = 6;
            this.clearButton.Text = "&Clear";
            this.clearButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(218, 227, 245);
            this.clearButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(207, 218, 240);
            this.clearButton.Click += new System.EventHandler(this.ClearButton_Click);
            this.clearButton.FlatStyle = FlatStyle.Flat;
            this.clearButton.FlatAppearance.BorderSize = 0;
            this.clearButton.UseVisualStyleBackColor = false;

            // statusLabel
            this.statusLabel.Location = new Point(24, 316);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new Size(388, 46);
            this.statusLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
            this.statusLabel.Padding = new Padding(9, 4, 9, 4);
            this.statusLabel.TextAlign = ContentAlignment.MiddleLeft;
            this.statusLabel.AccessibleName = "Sales entry status";

            // reportTitle
            this.reportTitle.Location = new Point(24, 20);
            this.reportTitle.Name = "reportTitle";
            this.reportTitle.Size = new Size(224, 33);
            this.reportTitle.Font = new Font("Segoe UI", 19F, FontStyle.Bold);
            this.reportTitle.Text = "Summary report";

            // printButton
            this.printButton.Location = new Point(275, 21);
            this.printButton.Name = "printButton";
            this.printButton.Size = new Size(87, 34);
            this.printButton.BackColor = Color.FromArgb(35, 53, 89);
            this.printButton.ForeColor = Color.FromArgb(255, 255, 255);
            this.printButton.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.printButton.TabIndex = 0;
            this.printButton.Text = "&Print";
            this.printButton.AccessibleName = "Print summary report";
            this.printButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(49, 70, 110);
            this.printButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(57, 81, 127);
            this.printButton.Click += new System.EventHandler(this.PrintButton_Click);
            this.printButton.FlatStyle = FlatStyle.Flat;
            this.printButton.FlatAppearance.BorderSize = 0;
            this.printButton.UseVisualStyleBackColor = false;

            // danielleLabel
            this.danielleLabel.Location = new Point(24, 79);
            this.danielleLabel.Name = "danielleLabel";
            this.danielleLabel.Size = new Size(86, 32);
            this.danielleLabel.ForeColor = Color.FromArgb(200, 212, 236);
            this.danielleLabel.TextAlign = ContentAlignment.MiddleLeft;
            this.danielleLabel.Text = "Danielle";

            // danielleTotalLabel
            this.danielleTotalLabel.Location = new Point(111, 79);
            this.danielleTotalLabel.Name = "danielleTotalLabel";
            this.danielleTotalLabel.Size = new Size(251, 32);
            this.danielleTotalLabel.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            this.danielleTotalLabel.TextAlign = ContentAlignment.MiddleRight;
            this.danielleTotalLabel.Text = "$0.00";
            this.danielleTotalLabel.AccessibleName = "Danielle total sales";

            // danielleDivider
            this.danielleDivider.Location = new Point(24, 119);
            this.danielleDivider.Name = "danielleDivider";
            this.danielleDivider.Size = new Size(338, 1);
            this.danielleDivider.BackColor = Color.FromArgb(53, 69, 97);
            this.danielleDivider.TabStop = false;

            // edwardLabel
            this.edwardLabel.Location = new Point(24, 128);
            this.edwardLabel.Name = "edwardLabel";
            this.edwardLabel.Size = new Size(86, 32);
            this.edwardLabel.ForeColor = Color.FromArgb(200, 212, 236);
            this.edwardLabel.TextAlign = ContentAlignment.MiddleLeft;
            this.edwardLabel.Text = "Edward";

            // edwardTotalLabel
            this.edwardTotalLabel.Location = new Point(111, 128);
            this.edwardTotalLabel.Name = "edwardTotalLabel";
            this.edwardTotalLabel.Size = new Size(251, 32);
            this.edwardTotalLabel.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            this.edwardTotalLabel.TextAlign = ContentAlignment.MiddleRight;
            this.edwardTotalLabel.Text = "$0.00";
            this.edwardTotalLabel.AccessibleName = "Edward total sales";

            // edwardDivider
            this.edwardDivider.Location = new Point(24, 168);
            this.edwardDivider.Name = "edwardDivider";
            this.edwardDivider.Size = new Size(338, 1);
            this.edwardDivider.BackColor = Color.FromArgb(53, 69, 97);
            this.edwardDivider.TabStop = false;

            // fatimaLabel
            this.fatimaLabel.Location = new Point(24, 177);
            this.fatimaLabel.Name = "fatimaLabel";
            this.fatimaLabel.Size = new Size(86, 32);
            this.fatimaLabel.ForeColor = Color.FromArgb(200, 212, 236);
            this.fatimaLabel.TextAlign = ContentAlignment.MiddleLeft;
            this.fatimaLabel.Text = "Fatima";

            // fatimaTotalLabel
            this.fatimaTotalLabel.Location = new Point(111, 177);
            this.fatimaTotalLabel.Name = "fatimaTotalLabel";
            this.fatimaTotalLabel.Size = new Size(251, 32);
            this.fatimaTotalLabel.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            this.fatimaTotalLabel.TextAlign = ContentAlignment.MiddleRight;
            this.fatimaTotalLabel.Text = "$0.00";
            this.fatimaTotalLabel.AccessibleName = "Fatima total sales";

            // totalPanel
            this.totalPanel.Location = new Point(24, 247);
            this.totalPanel.Name = "totalPanel";
            this.totalPanel.Size = new Size(338, 105);
            this.totalPanel.BackColor = Color.FromArgb(35, 53, 89);
            this.totalPanel.TabStop = false;
            this.totalPanel.Controls.Add(this.grandTotalTitle);
            this.totalPanel.Controls.Add(this.grandTotalLabel);

            // grandTotalTitle
            this.grandTotalTitle.Location = new Point(14, 11);
            this.grandTotalTitle.Name = "grandTotalTitle";
            this.grandTotalTitle.Size = new Size(310, 23);
            this.grandTotalTitle.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            this.grandTotalTitle.ForeColor = Color.FromArgb(221, 232, 255);
            this.grandTotalTitle.Text = "Total sales";

            // grandTotalLabel
            this.grandTotalLabel.Location = new Point(12, 36);
            this.grandTotalLabel.Name = "grandTotalLabel";
            this.grandTotalLabel.Size = new Size(314, 55);
            this.grandTotalLabel.Font = new Font("Segoe UI", 27F, FontStyle.Bold);
            this.grandTotalLabel.TextAlign = ContentAlignment.MiddleLeft;
            this.grandTotalLabel.Text = "$0.00";
            this.grandTotalLabel.AccessibleName = "Total sales";

            // Form1
            this.AcceptButton = this.submitButton;
            this.AutoScaleDimensions = new SizeF(96F, 96F);
            this.AutoScaleMode = AutoScaleMode.Dpi;
            this.BackColor = Color.FromArgb(238, 243, 250);
            this.ClientSize = new Size(902, 488);
            this.Controls.Add(this.mainTitle);
            this.Controls.Add(this.entryPanel);
            this.Controls.Add(this.reportPanel);
            this.Font = new Font("Segoe UI", 11F);
            this.ForeColor = Color.FromArgb(22, 33, 56);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Sales Tracker";
            this.totalPanel.ResumeLayout(false);
            this.reportPanel.ResumeLayout(false);
            this.entryPanel.ResumeLayout(false);
            this.entryPanel.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private Label mainTitle;
        private Panel entryPanel;
        private Panel reportPanel;
        private Label entryTitle;
        private Label initialLabel;
        private TextBox initialTextBox;
        private Label salespersonKey;
        private Label amountLabel;
        private TextBox amountTextBox;
        private Button submitButton;
        private Button clearButton;
        private Label statusLabel;
        private Label reportTitle;
        private Button printButton;
        private Label danielleLabel;
        private Label danielleTotalLabel;
        private Panel danielleDivider;
        private Label edwardLabel;
        private Label edwardTotalLabel;
        private Panel edwardDivider;
        private Label fatimaLabel;
        private Label fatimaTotalLabel;
        private Panel totalPanel;
        private Label grandTotalTitle;
        private Label grandTotalLabel;
    }
}
