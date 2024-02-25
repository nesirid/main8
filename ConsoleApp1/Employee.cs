



public class Employee
{
    //Field Employee
    public int Id { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public string Address { get; set; }
    public string Email { get; set; }
    public int Age { get; set; }


    // Konstuktor yeni Fieldin skileti
    public Employee(int id, string name, string surname, string address, string email, int age)
    { 
    Id = id;
    Name = name;    
    Surname = surname;  
    Address = address;
    Email = email;  
    Age = age;

    }
    // iscilerin siyahisini gosteren metod
    public void DisplayInfo()
    {
        Console.WriteLine($"ID: {Id}");
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Surname: {Surname}");
        Console.WriteLine($"Address: {Address}");
        Console.WriteLine($"Email: {Email}");
        Console.WriteLine($"Age: {Age}");
    }


}

