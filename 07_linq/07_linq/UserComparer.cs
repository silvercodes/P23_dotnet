using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_linq;

internal class UserComparer : IComparer<User>
{
    public int Compare(User? x, User? y)
    {
        if (x is null && y is null)
            return 0;

        if (x is null || y is null)
            throw new ArgumentException(nameof(x));

        return x.Id - y.Id;
    }
}
