using System.Net.Security;

namespace StartUp
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string[] peopleArr =
                Console.ReadLine()
                .Split(";",
                StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            string[] productsArr =
                Console.ReadLine()
                .Split(";",
                StringSplitOptions.RemoveEmptyEntries)
                .ToArray();


            List<Person> people = new List<Person>();
            List<Product> products = new List<Product>();
            try
            {
                foreach (string p in peopleArr)
                {
                    string[] splitted = p.Split("=");
                    string name = splitted[0];
                    decimal money = int.Parse(splitted[1]);
                    Person person = new Person(name, money);
                    people.Add(person);
                }

                foreach (string p in productsArr)
                {
                    string[] splitted = p.Split("=");
                    string name = splitted[0];
                    decimal cost = int.Parse(splitted[1]);
                    Product product = new Product(name, cost);
                    products.Add(product);

                }

                string input = string.Empty;

                while ((input = Console.ReadLine()) != "END")
                {
                    string[] splitted = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                    string nameInput = splitted[0];
                    string productInput = splitted[1];

                    foreach (var person in people)
                    {
                        if (nameInput == person.Name)
                        {
                            foreach (var product in products)
                            {
                                if (productInput == product.Name)
                                {
                                    person.BuyProduct(product);
                                }
                            }
                        }
                    }

                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);             
            }

            foreach (var person in people)
            {
                Console.WriteLine(person.ToString());
            }
            

        }
    }
}