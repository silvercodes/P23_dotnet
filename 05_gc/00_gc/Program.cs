
//GC.Collect();
//GC.Collect(1);
//GC.Collect();

//int a = 45;
//int b = 12;

//Console.WriteLine(GC.GetTotalMemory(false));

//GC.AddMemoryPressure(1024);
//GC.RemoveMemoryPressure(1024);



#region Destructor / Финализатор

//void Exec()
//{
//    FileReader fr = new FileReader();

//}

//Exec();
//GC.Collect();
//Console.ReadLine();


//class FileReader
//{
//    public string Path { get; set; }
//    public int Mode { get; set; }

//    ~FileReader()
//    {
//        Console.WriteLine("FileReader dctor");
//    }

//    //protected override void Finalize()
//    //{
//    //    try
//    //    {
//    //        Console.WriteLine("FileReader dctor");
//    //    }
//    //    finally
//    //    {
//    //        base.Finalize();
//    //    }
//    //}

//}


#endregion


#region IDisposable


//void Exec()
//{
//    FileReader? fr = null;

//    try
//    {
//        fr = new FileReader();
//        //
//        //
//        //
//    }
//    finally
//    {
//        fr?.Dispose();
//    }
//}

//Exec();

//class FileReader: IDisposable
//{
//    public string Path { get; set; }
//    public int Mode { get; set; }

//    public void Dispose()
//    {
//        Console.WriteLine("FileReader Dispose()");
//        GC.SuppressFinalize(this);                      // <---- !!!!
//    }
//}






class FileReader: IDisposable
{
    public string Path { get; set; }
    public int Mode { get; set; }

    private bool isDisposed = false;



    protected virtual void FreeMemory(bool needDisposing)
    {
        if (isDisposed)
            return;

        if (needDisposing)
        {
            // ОЧИСТКА УПРАВЛЯЕМЫХ РЕСУРСОВ
            Console.WriteLine("ОЧИСТКА УПРАВЛЯЕМЫХ РЕСУРСОВ");
        }

        // ОЧИСТКА НЕУПРАВЛЯЕМЫХ РЕСУРСОВ
        Console.WriteLine("ОЧИСТКА УПРАВЛЯЕМЫХ РЕСУРСОВ");

        isDisposed = true;
    }

    public void Dispose()
    {
        FreeMemory(true);
        GC.SuppressFinalize(this);
    }

    ~FileReader()
    {
        FreeMemory(false);
    }
}



#endregion