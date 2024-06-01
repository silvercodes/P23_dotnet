
using Newtonsoft.Json;


User user = new()
{
    Id = 101,
    Email = "vasia@mail.com",
    Age = 34
};

string json = JsonConvert.SerializeObject(user);
Console.WriteLine(json);

User? u = JsonConvert.DeserializeObject<User>(json);
u.Show();


class User
{
    public int Id { get; set; }
    public string Email { get; set; }
    public int Age { get; set; }

    public void Show() => Console.WriteLine($"{Id}\t{Email}\t{Age}");
}

