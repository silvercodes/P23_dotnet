


IHandler dbHandler = new DbHandler();
IHandler domainHandler = new DomainHandler();
IHandler deployHandler = new DeployHandler();

dbHandler
    .SetNext(domainHandler)
    .SetNext(deployHandler);

try
{
    dbHandler.Processing();
}
catch (Exception ex)
{
    Console.WriteLine($"ERROR: {ex.Message}");
}



interface IHandler
{
    public IHandler SetNext(IHandler handler);
    public void Processing();
    public void Rolback();

}


abstract class Handler: IHandler
{
    protected IHandler? Next { get; set; } = null;
    public IHandler SetNext(IHandler handler)
    {
        Next = handler;

        return Next;
    }

    public abstract void Processing();
    public abstract void Rolback();
}


class DbHandler : Handler
{
    public override void Processing()
    {
        throw new NotImplementedException();
    }

    public override void Rolback()
    {
        throw new NotImplementedException();
    }
}

class DomainHandler : Handler
{
    public override void Processing()
    {
        throw new NotImplementedException();
    }

    public override void Rolback()
    {
        throw new NotImplementedException();
    }
}

class DeployHandler : Handler
{
    public override void Processing()
    {
        throw new NotImplementedException();
    }

    public override void Rolback()
    {
        throw new NotImplementedException();
    }
}


