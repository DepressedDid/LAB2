using System.Data.Common;
using System.Linq;

//Person alice = new Person("Alice", 456789);
//Person adam = new Person("Adam", 567898);
//Person helen = new Person("Helen", 678345);
//List<Person> persons = new List<Person>();

//persons.Add(alice);
//persons.Add(adam);
//persons.Add(helen);

//Console.WriteLine("Search ID");

//int ID = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine(IDSearch(persons, ID));


//Console.ReadLine();


//string IDSearch(List<Person> list, int MyID)
//{
//    foreach (Person person in list)
//    {
//        if (MyID == person.Id)
//        {
//            return person.name;
//        }
//    }
//    return "Person not Found";
//}
//internal class Person
//{
//    public string name = "NoName";

//    public Person(string name, int iid)
//    {
//        this.name = name;
//        Id = iid;
//    }

//    public int Id { get; }



//}




//Dictionary<int, string> MyDictionary = new Dictionary<int, string>()
//{
//    [4] = "Keni",
//    [65] = "Adam",
//    [34] = "Yor",
//    [69] = "Keni",
//    [13] = "Adam",
//    [35] = "Helen",
//    [98] = "Larry",
//    [67] = "Polly"
//};
//void RemoveExcess(ref Dictionary<int, string> Dictionary)
//{
//    int MaxKey = 0;
//    foreach (var highKey in Dictionary.Keys)
//    {
//        if (MaxKey < highKey)
//        {
//            MaxKey = highKey;
//        }
//    }
//    foreach (var t in Dictionary.Keys)
//    {
//        for (int y = 0; y < MaxKey; y++)
//        {
//            if (Dictionary.ContainsKey(y))
//            {

//                if (Dictionary[t] == Dictionary[y] && t != y)
//                {
//                    Dictionary.Remove(y);
//                }
//            }
//        }
//    }

//}
//RemoveExcess(ref MyDictionary);
//foreach(var t in MyDictionary.Values)
//{
//    Console.WriteLine(t);
//}


int[] numbers = new int[] { 1, 2, 3, 1, 4, 5, 2, 2, 1 };

//numbers.GroupBy(n => n).Select(g => g.Count() > 1 ? 0 : g.Key).ToList();
var gty = numbers.GroupBy(x => x).Select(t => t.Count() > 1 ? 0 : t.Key).ToArray();

for(int i = 0; i < gty.Length; i++)
{
    Console.WriteLine(gty[i]);
}







