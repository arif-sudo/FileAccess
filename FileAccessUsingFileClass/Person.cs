internal class Person
{
    public String Name { get; set; }
    public String LastName { get; set; }
    public String Email { get; set; }
    public String Username { get; set; }
    public String Password { get; set; }
    public Person(string name, string lastname, string email)
    {
        Name = name;
        LastName = lastname;
        Email = email;
    }
    public Person(string name, string lastname, string email, string username, string password)
    {
        Name = name;
        LastName = lastname;
        Email = email;
        Username = username;
        Password = password;
    }
}