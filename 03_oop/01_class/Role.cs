
using System.Threading.Channels;

namespace _01_class;

internal class Role
{
    public int id;
    public string title;

    public void Show() => Console.WriteLine($"id {id}, title {title}");
}
