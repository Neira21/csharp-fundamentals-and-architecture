namespace review_opp.Inscripcion
{
  public class Collection<T>
  {
    private T[] _elements;
    private int _index;
    private int _capacity;

    public Collection(int capacity)
    {
      _index = 0;
      _capacity = capacity;
      _elements = new T[_capacity];
    }

    public void Add(T element)
    {
      if (_index < _capacity)
      {
        _elements[_index] = element;
        _index++;
      }
      else
      {
        throw new InvalidOperationException("Collection is full");
      }
    }

    public T[] Get()
    {
      return _elements;
    }

    // un set para setear toda una lista 
    public void Set(T[] elements)
    {
      if (elements.Length > _capacity)
      {
        throw new ArgumentNullException("The array exceeds the collection capacity");
      }

      // Limpiar el array actual
      Array.Clear(_elements, 0, _elements.Length);

      // Copiar los elementos
      Array.Copy(elements, _elements, elements.Length);

      // Actualizar el índice
      _index = elements.Length;

    }


    public T[] GetValid()
    {
      T[] result = new T[_index];
      Array.Copy(_elements, result, _index);
      return result;
    }

    // saber la cantidad de elementos actuales en la colección
    public int Count => _index;


  }


}