<<<<<<< HEAD
﻿class HaloGeneric
{
    public void SapaUser(string x)
    {
        Console.WriteLine("Halo user " + x);
=======
﻿class DataGeneric<T>
{
    private T data;
    public DataGeneric(T data)
    {
        this.data = data;
    }

    public void PrintData()
    {
        Console.WriteLine("Data yang tersimpan adalah: " + data);
>>>>>>> generic-class
    }
}

class main
{
    static void Main(string[] args)
    {
<<<<<<< HEAD
        String inputan = Console.ReadLine();
        HaloGeneric halo = new HaloGeneric();
        halo.SapaUser(inputan);
=======

        DataGeneric<String> data = new DataGeneric<string>("1302213067");
        data.PrintData();
>>>>>>> generic-class
    }
}