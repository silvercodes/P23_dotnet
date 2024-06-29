

Console.WriteLine();
User u = new User();

try
{
    u.ValidateEmail("vasia@m");
}
catch (Exception ex)
{
    Console.WriteLine($"ERROR: {ex.Message}");
}

Console.WriteLine("End of Main()");


[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method | AttributeTargets.Parameter)]
class EmailValidatorAttribute : Attribute
{
    public int MaxLength { get; set; }
    public EmailValidatorAttribute(int maxLength)
    {
        MaxLength = maxLength;
    }
}



[EmailValidator(10)]
class User
{

    [EmailValidator(10)]
    public void ValidateEmail([EmailValidator(10)] string email)
    {
        Type type = typeof(User);

        object[] attributes = type.GetCustomAttributes(false);

        foreach (object attr in attributes)
        {
            if (attr is EmailValidatorAttribute eva)
            {
                int len = eva.MaxLength;
                if (email.Length < len)
                    throw new Exception("Invalid email length");
            }
                
        }
    }
}

