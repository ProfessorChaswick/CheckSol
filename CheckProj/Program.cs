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
        Console.WriteLine("Result: " + CheckEquality("11", "11"));
    }
}