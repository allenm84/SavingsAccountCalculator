using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SavingsAccountCalculator
{
  public class TransactionItem
  {
    public DateTime Date { get; set; }
    public TransactionItemType Type { get; set; }
    public decimal Amount { get; set; }
    public decimal Balance { get; set; }
  }
}
