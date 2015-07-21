using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SavingsAccountCalculator
{
  public partial class MainForm : Form
  {
    private BindingList<TransactionItem> items;

    public MainForm()
    {
      InitializeComponent();
      InitializeGui();
    }

    private void InitializeGui()
    {
      // initialize the dropdowns
      cboFrequency.DataSource = Enum
        .GetValues(typeof(Frequency))
        .Cast<Frequency>()
        .Select(f => new { Value = f, Display = f.ToString() })
        .ToArray();
      cboFrequency.DisplayMember = "Display";
      cboFrequency.ValueMember = "Value";

      cboUnits.DataSource = Enum
        .GetValues(typeof(DateUnit))
        .Cast<DateUnit>()
        .Select(d => new { Value = d, Display = d.ToString() })
        .ToArray();
      cboUnits.DisplayMember = "Display";
      cboUnits.ValueMember = "Value";
    }

    private DateTime GetEndDate(DateTime start)
    {
      var nullUnit = cboUnits.SelectedValue as DateUnit?;
      var unit = nullUnit.GetValueOrDefault(DateUnit.Years);
      var amount = (int)numCalculateAmount.Value;
      if (unit == DateUnit.Months)
      {
        return start.AddMonths(amount);
      }
      return start.AddYears(amount);
    }

    private bool IsLastDayOfMonth(DateTime date)
    {
      DateTime first = new DateTime(date.Year, date.Month, 1);
      return first.AddMonths(1).AddDays(-1) == date;
    }

    private void CalculateResults()
    {
      using (items.DeferBinding())
      {
        items.Clear();

        var start = calStartDate.Value.Date;
        var end = GetEndDate(start);
        var date = start;

        var deposit = (decimal)numDepositAmount.Value;
        var balance = (decimal)numStartingBalance.Value;
        var percentage = (decimal)numInterest.Value / 1200m;
        var interest = 0m;

        items.Add(new TransactionItem
        {
          Amount = balance,
          Balance = balance,
          Date = start,
          Type = TransactionItemType.SetBalance,
        });

        var nullFrequency = cboFrequency.SelectedValue as Frequency?;
        var frequency = nullFrequency.GetValueOrDefault(Frequency.Biweekly);

        Func<DateTime, DateTime> morph = null;
        switch (frequency)
        {
          case Frequency.Biweekly:
            morph = (x) => x.AddDays(14);
            break;
          case Frequency.Daily:
            morph = (x) => x.AddDays(1);
            break;
          case Frequency.Monthly:
            morph = (x) => x.AddMonths(1);
            break;
          case Frequency.Weekly:
            morph = (x) => x.AddDays(7);
            break;
          default:
            morph = (x) => x.AddYears(1);
            break;
        }

        var qualifyingDates = new List<DateTime>();
        for (date = start; date <= end; date = morph(date))
        {
          qualifyingDates.Add(date);
        }

        for (date = start; date <= end; date = date.AddDays(1))
        {
          if (qualifyingDates.Count > 0 && qualifyingDates[0] == date)
          {
            balance += deposit;
            items.Add(new TransactionItem
            {
              Amount = deposit,
              Balance = balance,
              Date = date,
              Type = TransactionItemType.Deposit,
            });
            qualifyingDates.RemoveAt(0);
          }

          if (IsLastDayOfMonth(date))
          {
            interest = balance * percentage;
            interest = Math.Truncate(interest * 100m) / 100m;

            balance += interest;
            items.Add(new TransactionItem
            {
              Amount = interest,
              Balance = balance,
              Date = date,
              Type = TransactionItemType.Interest,
            });
          }
        }
      }
    }

    protected override void OnLoad(EventArgs e)
    {
      base.OnLoad(e);
      cboFrequency.SelectedValue = Frequency.Biweekly;
      cboUnits.SelectedValue = DateUnit.Years;

      items = new BindingList<TransactionItem>();
      gridResults.AllowUserToAddRows = false;
      gridResults.AllowUserToDeleteRows = false;
      gridResults.AllowUserToOrderColumns = false;
      gridResults.AllowUserToResizeColumns = true;
      gridResults.AllowUserToResizeRows = false;
      gridResults.AutoGenerateColumns = true;
      gridResults.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
      gridResults.BackgroundColor = SystemColors.Window;
      gridResults.BorderStyle = BorderStyle.Fixed3D;
      gridResults.CellBorderStyle = DataGridViewCellBorderStyle.None;
      gridResults.ColumnHeadersVisible = true;
      gridResults.CellFormatting += gridResults_CellFormatting;
      gridResults.DataSource = items;
    }

    private void gridResults_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
    {
      try
      {
        var row = gridResults.Rows[e.RowIndex];
        var item = row.DataBoundItem as TransactionItem;
        if (item.Type == TransactionItemType.Interest)
        {
          e.CellStyle.Font = new Font(e.CellStyle.Font, FontStyle.Bold);
          e.CellStyle.ForeColor = Color.SlateBlue;
        }
      }
      catch { }
    }

    private void btnCalculate_Click(object sender, EventArgs e)
    {
      CalculateResults();
    }
  }
}
