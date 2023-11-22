
class MyList<T>
{
    T[] array;
    public MyList()
    {
        array = new T[0];
    }

    public void Add(T item)
    {
        T[] tempArray = array;
        array=new T[array.Length+1];
        for (int i = 0; i < tempArray.Length; i++)
        {
            array[i] = tempArray[i];
        }
        array[array.Length-1] = item;
    }
    
    public int Count
    {
        get { return array.Length; }
    }
}