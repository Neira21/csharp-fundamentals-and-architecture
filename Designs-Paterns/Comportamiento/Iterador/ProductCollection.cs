using System.Collections;
using System.Collections.Generic;

namespace IteradorDemo
{
  public class ProductCollection : IEnumerable<string>
  {
    private List<string> _products = new List<string>();

    public void Add(string product)
    {
      _products.Add(product);
    }

    public IEnumerator<string> GetEnumerator()
    {
      return _products.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
      return GetEnumerator();
    }
  }
}
