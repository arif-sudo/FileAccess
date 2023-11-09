using System;

class Program
{
    public static void Main()
    {
        string filePath = @"C:\Users\USER\Desktop\file.txt";

        string[] lines = File.ReadAllLines(filePath);
        string[] items = new string[5];

        List<Person> people = new List<Person>();
        //Person[] people1 = new Person[3];
        foreach (string line in lines)
        {
            items = line.Split(",");
            Person p = new Person(items[0], items[1], items[2]);

            p.Username = items[3];
            p.Password = encrypt(items[4]);

            people.Add(p);
        }
        

        foreach (Person s in people)
        {
            Console.WriteLine(s.Name + " " + s.LastName + " " + s.Email + " " + s.Username + " " + s.Password);
        }

    }
    public static String encrypt(String password)
    {
        var hashedPassword = "";
        foreach (char c in password)
        {
            hashedPassword += Char.ToString((char)(c + 5));
        }
        return hashedPassword;
    }

}
