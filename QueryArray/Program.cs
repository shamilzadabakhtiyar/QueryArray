using QueryArray;

var arr = new[] { 1, 2, 3 };
QueryArray<int> q = arr;
QueryArray<int> q2 = new QueryArray<int>();
q2.LoadFromArray(arr);
q2.Add(4);
q2.Add(5);

//while (q.Next())
//{
//    Console.WriteLine(q.Current);
//}
//Console.WriteLine("----------");
//while (q.Previous())
//{
//    Console.WriteLine(q.Current);
//}
//foreach (var item in q)
//{
//
//   Console.WriteLine(item);
//}
foreach (var item in q2)
{
    Console.WriteLine(item);
}
//Console.WriteLine(q[1]);