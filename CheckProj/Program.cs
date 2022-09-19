public class Program
{
    public static bool CheckEquality(object a, object b)
    {
        TypeCode aType = Type.GetTypeCode(a.GetType());
        TypeCode bType = Type.GetTypeCode(b.GetType());
        Console.WriteLine("a is type {0}", aType);
        Console.WriteLine("b is type {0}", bType);
        Console.WriteLine("+++++++++++++++++++");
        Console.WriteLine("a = {0} ", a);
        Console.WriteLine("b = {0} ", b);
        Console.WriteLine("+++++++++++++++++++");
        Console.WriteLine("+++++++++++++++++++");
        if (aType.Equals(bType) && a.Equals(b)) 
            return true;
        else
            return false;
    }
    public static void Main()
    {
        int number;
        double dnum;
        bool Success = int.TryParse("66 ", out number);
        bool Dsuccess = double.TryParse("23.0", out dnum);
        Console.Write(Success + ": ");
        Console.WriteLine(number);
        Console.Write(Dsuccess + ": ");
        Console.WriteLine(dnum);
        Console.WriteLine("Result: " + CheckEquality("11", "11"));
    }
}