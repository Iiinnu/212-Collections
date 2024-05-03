using System.Collections;
using System;

List<int> numbers = new List<int>();
numbers.Add(137);
numbers.Add(1000);
numbers.Add(-200);

for (int i = 0; i < numbers.Count; i++)
{
    Console.WriteLine(numbers[i]);
}

ArrayList arrayList = new ArrayList();

arrayList.Add(true);               
arrayList.Add("forsbergs");        
arrayList.Add("a");                
arrayList.Add(1000);               
arrayList.Add(.12f);               

for (int i = 0; 1 < arrayList.Count; i++)
{
    Console.WriteLine(arrayList[i]);
}