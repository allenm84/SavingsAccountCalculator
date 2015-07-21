using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SavingsAccountCalculator
{
  public static class Extensions
  {
    private class BindingListOperation<T> : IDisposable
    {
      private BindingList<T> list;

      public BindingListOperation(BindingList<T> list)
      {
        this.list = list;
        list.RaiseListChangedEvents = false;
      }

      void IDisposable.Dispose()
      {
        list.RaiseListChangedEvents = true;
        list.ResetBindings();
        list = null;
      }
    }

    public static IDisposable DeferBinding<T>(this BindingList<T> list)
    {
      return new BindingListOperation<T>(list);
    }

    public static void AddRange<T>(this IList<T> list, IEnumerable<T> values)
    {
      foreach (var value in values)
      {
        list.Add(value);
      }
    }
  }
}
