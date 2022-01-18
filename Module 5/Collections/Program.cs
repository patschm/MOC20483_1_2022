using System.Collections;
using System.Collections.Specialized;
using System.Collections.Generic;
using Collections;

CollectiesUitDeOudeDoos();



void CollectiesUitDeOudeDoos()
{
    //ArrayList list = new ArrayList();
    List<int> list = new List<int>();
    list.Add(1);
    list.Add(2);
    list.Add(3);

    int gt = list[2];

    foreach(int nr2 in list)
    {
        System.Console.WriteLine(nr2);
    }

    //Hashtable ht = new Hashtable();
    Dictionary<string, int> ht = new Dictionary<string, int>();
    ht.Add("een", 1);

    //Queue queue = new Queue();
    Queue<int> queue = new Queue<int>();
    queue.Enqueue(1);
    int nr = queue.Dequeue();

    //Stack stakc = new Stack();
    Stack<int> stakc = new Stack<int>();
    stakc.Push(4);
    nr = stakc.Pop();

    LinkedList<int> ll = new LinkedList<int>();
    SortedList<string, int> sl = new SortedList<string, int>();

    MijnCollectie<int?> col = new MijnCollectie<int?>();
    col.Add(1);
    col.Add(2);

    foreach(var item in col)
    {
        System.Console.WriteLine(item);
    }
}