// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int sayi = 20;

string sonuc = sayi < 5 ? "5ten büyük" : "küçük";
Console.WriteLine(sonuc);


List<string> list = new List<string>();

MyDictionaryExample<int, string> dict = new MyDictionaryExample<int, string>();
dict.Add(25, "Player1");
dict.Add(28, "Player2");
dict.Add(32, "Player3");
dict.Add(33, "Player4");

Console.WriteLine(dict.Count);

class MyList<T> //generic class
{
    //dizimiz
    T[] _array;
    //geçici dizimiz
    T[] _tempArray;

    public MyList()
    {
        //constructorımız. class newlendiğinde çalışcak ve 0 elemanlı bir dizi oluşturcak.
        _array = new T[0];
    }
    public void Add(T item)
    {
        _tempArray = _array;
        _array = new T[_array.Length + 1];

        for (int i = 0; i < _tempArray.Length; i++)
        {
            _array[i] = _tempArray[i];
        }
        _array[_array.Length - 1] = item;

    }
    



}

class MyDictionary<T>
{
    T[,] _array;
    T[,] _tempArray;

    public MyDictionary()
    {
        _array = new T[0,0];
    }
    public void Add(T item1, T item2)
    {
        _array=_tempArray;
        _array= new T[_array.Length + 1,_array.Length+1];
        for (int i = 0; i < _array.Length; i++)
        {
            _array[i, i] = _tempArray[i, i];
        }
      
        
    }







}




class MyDictionaryExample<TKey, TValue>
{
    TKey[] keys;
    TValue[] values;

    TKey[] tempKeys;
    TValue[] tempValues;



    public MyDictionaryExample()
    {
        keys = new TKey[0];
        values = new TValue[0];
    }

    public void Add(TKey item1, TValue item2)
    {
        tempKeys = keys;
        tempValues = values;

        keys = new TKey[tempKeys.Length + 1];
        values = new TValue[tempValues.Length + 1];

        for (int i = 0; i < tempKeys.Length; i++)
        {
            keys[i] = tempKeys[i];
            values[i] = tempValues[i];

        }
        keys[keys.Length - 1] = item1;
        values[keys.Length - 1] =item2;
    }
    public int Count
    {
        //get { return keys.Length; }
        get { return values.Length; }
    }
}