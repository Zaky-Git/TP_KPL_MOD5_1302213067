class HaloGeneric
{
    public void SapaUser(string x)
    {
        Console.WriteLine("Halo user " + x);
    }
}

class main
{
    static void Main(string[] args)
    {
        String inputan = Console.ReadLine();
        HaloGeneric halo = new HaloGeneric();
        halo.SapaUser(inputan);
    }
}