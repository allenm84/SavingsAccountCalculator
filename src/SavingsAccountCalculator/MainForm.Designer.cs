namespace SavingsAccountCalculator
{
  partial class MainForm
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
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
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
      this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
      this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.numInterest = new System.Windows.Forms.NumericUpDown();
      this.label3 = new System.Windows.Forms.Label();
      this.numStartingBalance = new System.Windows.Forms.NumericUpDown();
      this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
      this.label4 = new System.Windows.Forms.Label();
      this.numDepositAmount = new System.Windows.Forms.NumericUpDown();
      this.label5 = new System.Windows.Forms.Label();
      this.cboFrequency = new System.Windows.Forms.ComboBox();
      this.calStartDate = new System.Windows.Forms.DateTimePicker();
      this.label6 = new System.Windows.Forms.Label();
      this.label7 = new System.Windows.Forms.Label();
      this.gridResults = new System.Windows.Forms.DataGridView();
      this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
      this.label8 = new System.Windows.Forms.Label();
      this.numCalculateAmount = new System.Windows.Forms.NumericUpDown();
      this.cboUnits = new System.Windows.Forms.ComboBox();
      this.btnCalculate = new System.Windows.Forms.Button();
      this.tableLayoutPanel1.SuspendLayout();
      this.tableLayoutPanel2.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.numInterest)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numStartingBalance)).BeginInit();
      this.tableLayoutPanel3.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.numDepositAmount)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.gridResults)).BeginInit();
      this.tableLayoutPanel4.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.numCalculateAmount)).BeginInit();
      this.SuspendLayout();
      // 
      // tableLayoutPanel1
      // 
      this.tableLayoutPanel1.ColumnCount = 1;
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
      this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 1);
      this.tableLayoutPanel1.Controls.Add(this.label7, 0, 2);
      this.tableLayoutPanel1.Controls.Add(this.gridResults, 0, 3);
      this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 0, 4);
      this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel1.Location = new System.Drawing.Point(10, 10);
      this.tableLayoutPanel1.Name = "tableLayoutPanel1";
      this.tableLayoutPanel1.RowCount = 5;
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
      this.tableLayoutPanel1.Size = new System.Drawing.Size(476, 394);
      this.tableLayoutPanel1.TabIndex = 0;
      // 
      // tableLayoutPanel2
      // 
      this.tableLayoutPanel2.ColumnCount = 8;
      this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
      this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
      this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
      this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 4F));
      this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
      this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
      this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel2.Controls.Add(this.label1, 1, 0);
      this.tableLayoutPanel2.Controls.Add(this.label2, 3, 0);
      this.tableLayoutPanel2.Controls.Add(this.numInterest, 2, 0);
      this.tableLayoutPanel2.Controls.Add(this.label3, 5, 0);
      this.tableLayoutPanel2.Controls.Add(this.numStartingBalance, 6, 0);
      this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
      this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
      this.tableLayoutPanel2.Name = "tableLayoutPanel2";
      this.tableLayoutPanel2.RowCount = 1;
      this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel2.Size = new System.Drawing.Size(476, 30);
      this.tableLayoutPanel2.TabIndex = 0;
      // 
      // label1
      // 
      this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(58, 8);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(106, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "Interest Rate (APY):";
      // 
      // label2
      // 
      this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(220, 8);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(18, 13);
      this.label2.TabIndex = 2;
      this.label2.Text = "%";
      // 
      // numInterest
      // 
      this.numInterest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
      this.numInterest.DecimalPlaces = 2;
      this.numInterest.Location = new System.Drawing.Point(170, 4);
      this.numInterest.Name = "numInterest";
      this.numInterest.Size = new System.Drawing.Size(44, 21);
      this.numInterest.TabIndex = 3;
      // 
      // label3
      // 
      this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(248, 8);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(89, 13);
      this.label3.TabIndex = 4;
      this.label3.Text = "Starting Balance:";
      // 
      // numStartingBalance
      // 
      this.numStartingBalance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
      this.numStartingBalance.DecimalPlaces = 2;
      this.numStartingBalance.Location = new System.Drawing.Point(343, 4);
      this.numStartingBalance.Name = "numStartingBalance";
      this.numStartingBalance.Size = new System.Drawing.Size(74, 21);
      this.numStartingBalance.TabIndex = 5;
      // 
      // tableLayoutPanel3
      // 
      this.tableLayoutPanel3.ColumnCount = 8;
      this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
      this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
      this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
      this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
      this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
      this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
      this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel3.Controls.Add(this.label4, 1, 0);
      this.tableLayoutPanel3.Controls.Add(this.numDepositAmount, 2, 0);
      this.tableLayoutPanel3.Controls.Add(this.label5, 3, 0);
      this.tableLayoutPanel3.Controls.Add(this.cboFrequency, 4, 0);
      this.tableLayoutPanel3.Controls.Add(this.calStartDate, 6, 0);
      this.tableLayoutPanel3.Controls.Add(this.label6, 5, 0);
      this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 30);
      this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
      this.tableLayoutPanel3.Name = "tableLayoutPanel3";
      this.tableLayoutPanel3.RowCount = 1;
      this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel3.Size = new System.Drawing.Size(476, 30);
      this.tableLayoutPanel3.TabIndex = 1;
      // 
      // label4
      // 
      this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(44, 8);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(47, 13);
      this.label4.TabIndex = 0;
      this.label4.Text = "Deposit:";
      // 
      // numDepositAmount
      // 
      this.numDepositAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
      this.numDepositAmount.DecimalPlaces = 2;
      this.numDepositAmount.Location = new System.Drawing.Point(97, 4);
      this.numDepositAmount.Name = "numDepositAmount";
      this.numDepositAmount.Size = new System.Drawing.Size(64, 21);
      this.numDepositAmount.TabIndex = 1;
      // 
      // label5
      // 
      this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(167, 8);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(62, 13);
      this.label5.TabIndex = 2;
      this.label5.Text = "Frequency:";
      // 
      // cboFrequency
      // 
      this.cboFrequency.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
      this.cboFrequency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cboFrequency.Location = new System.Drawing.Point(235, 4);
      this.cboFrequency.Name = "cboFrequency";
      this.cboFrequency.Size = new System.Drawing.Size(64, 21);
      this.cboFrequency.TabIndex = 3;
      // 
      // calStartDate
      // 
      this.calStartDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
      this.calStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
      this.calStartDate.Location = new System.Drawing.Point(348, 4);
      this.calStartDate.Name = "calStartDate";
      this.calStartDate.Size = new System.Drawing.Size(84, 21);
      this.calStartDate.TabIndex = 4;
      // 
      // label6
      // 
      this.label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(305, 8);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(37, 13);
      this.label6.TabIndex = 5;
      this.label6.Text = "Begin:";
      // 
      // label7
      // 
      this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.label7.AutoSize = true;
      this.label7.Location = new System.Drawing.Point(3, 63);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(46, 13);
      this.label7.TabIndex = 2;
      this.label7.Text = "Results:";
      // 
      // gridResults
      // 
      this.gridResults.Dock = System.Windows.Forms.DockStyle.Fill;
      this.gridResults.Location = new System.Drawing.Point(3, 83);
      this.gridResults.Name = "gridResults";
      this.gridResults.Size = new System.Drawing.Size(470, 278);
      this.gridResults.TabIndex = 3;
      // 
      // tableLayoutPanel4
      // 
      this.tableLayoutPanel4.ColumnCount = 6;
      this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
      this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
      this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
      this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
      this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel4.Controls.Add(this.label8, 1, 0);
      this.tableLayoutPanel4.Controls.Add(this.numCalculateAmount, 2, 0);
      this.tableLayoutPanel4.Controls.Add(this.cboUnits, 3, 0);
      this.tableLayoutPanel4.Controls.Add(this.btnCalculate, 4, 0);
      this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 364);
      this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
      this.tableLayoutPanel4.Name = "tableLayoutPanel4";
      this.tableLayoutPanel4.RowCount = 1;
      this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel4.Size = new System.Drawing.Size(476, 30);
      this.tableLayoutPanel4.TabIndex = 4;
      // 
      // label8
      // 
      this.label8.Anchor = System.Windows.Forms.AnchorStyles.Right;
      this.label8.AutoSize = true;
      this.label8.Location = new System.Drawing.Point(110, 8);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(55, 13);
      this.label8.TabIndex = 0;
      this.label8.Text = "Calculate:";
      // 
      // numCalculateAmount
      // 
      this.numCalculateAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
      this.numCalculateAmount.Location = new System.Drawing.Point(171, 4);
      this.numCalculateAmount.Name = "numCalculateAmount";
      this.numCalculateAmount.Size = new System.Drawing.Size(44, 21);
      this.numCalculateAmount.TabIndex = 1;
      this.numCalculateAmount.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
      // 
      // cboUnits
      // 
      this.cboUnits.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
      this.cboUnits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cboUnits.Location = new System.Drawing.Point(221, 4);
      this.cboUnits.Name = "cboUnits";
      this.cboUnits.Size = new System.Drawing.Size(64, 21);
      this.cboUnits.TabIndex = 2;
      // 
      // btnCalculate
      // 
      this.btnCalculate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
      this.btnCalculate.Location = new System.Drawing.Point(291, 3);
      this.btnCalculate.Name = "btnCalculate";
      this.btnCalculate.Size = new System.Drawing.Size(74, 23);
      this.btnCalculate.TabIndex = 3;
      this.btnCalculate.Text = "Calculate";
      this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(496, 414);
      this.Controls.Add(this.tableLayoutPanel1);
      this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "MainForm";
      this.Padding = new System.Windows.Forms.Padding(10);
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Savings Account Calculator";
      this.tableLayoutPanel1.ResumeLayout(false);
      this.tableLayoutPanel1.PerformLayout();
      this.tableLayoutPanel2.ResumeLayout(false);
      this.tableLayoutPanel2.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.numInterest)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numStartingBalance)).EndInit();
      this.tableLayoutPanel3.ResumeLayout(false);
      this.tableLayoutPanel3.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.numDepositAmount)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.gridResults)).EndInit();
      this.tableLayoutPanel4.ResumeLayout(false);
      this.tableLayoutPanel4.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.numCalculateAmount)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.NumericUpDown numInterest;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.NumericUpDown numStartingBalance;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.NumericUpDown numDepositAmount;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.ComboBox cboFrequency;
    private System.Windows.Forms.DateTimePicker calStartDate;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.DataGridView gridResults;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.NumericUpDown numCalculateAmount;
    private System.Windows.Forms.ComboBox cboUnits;
    private System.Windows.Forms.Button btnCalculate;
  }
}

