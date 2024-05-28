using System.Text.Json;

namespace Json
{

   public class Program
    {
        public static void Main()
        {
            Person person = new Person { Name = "John", Age = 30 };
            string jsonString = JsonSerializer.Serialize(person);
            Console.WriteLine(jsonString);

             static void Main()
            {
                string jsonString = "{\"Name\":\"John\",\"Age\":30}";
                Person person = JsonSerializer.Deserialize<Person>(jsonString);
                Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");
            }
        }
    }

}

