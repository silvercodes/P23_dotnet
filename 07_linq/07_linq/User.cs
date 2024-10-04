using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_linq;

internal class User
{
    public int Id { get; set; }
    public string Name { get; set; }
    public List<string>? Roles { get; set; } = null;
    public User(int id, string name)
    {
        Id = id;
        Name = name;
    }
    public override string ToString()
    {
        string res = $"Id: {Id}, Name: {Name}, roles: ";
        foreach (string role in Roles)
            res += $"{role}, ";

        return res;
    }
}
