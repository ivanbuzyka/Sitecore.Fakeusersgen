using System;

namespace fakeusersgen
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName = "contactslist.csv";
            string headerLine = "FirstName,LastName,Email";
            int usersCount = 50;

            var faker = new Bogus.Faker();

            if (args.Length > 0 && !string.IsNullOrEmpty(args[0]))
            {
                fileName = args[0];
            }

            var filePath = $".\\{fileName}";
            var csvFile = System.IO.File.Create(filePath);
            using (var csvWriter = new System.IO.StreamWriter(csvFile))
            {
                csvWriter.WriteLine(headerLine);

                for (int i = 0; i < usersCount; i++)
                {
                    csvWriter.WriteLine($"{faker.Name.FirstName()},{faker.Name.LastName()},{faker.Internet.ExampleEmail()}");
                }
            }
        }
    }
}
