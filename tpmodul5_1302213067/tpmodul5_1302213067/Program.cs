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
    }
}

class main
{
    static void Main(string[] args)
    {

        DataGeneric<String> data = new DataGeneric<string>("1302213067");
        data.PrintData();
    }
}