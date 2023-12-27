internal class Program
{
    private static void Main()
    {
        //int x;                инициализация НЕ НУЖНА для сл. строки
        //  GetVal(out x);
        //  Console.WriteLine(x);
        //  = 10

        int x = 5; //           инициализаия НУЖНА для сл. строки
        AddVal(ref x);
        Console.WriteLine(x);
        //  = 15
    }


    private static void GetVal(out int v)
    {
        v = 10; // сначала нужно инициализовать
        v += 10;
    }

    private static void AddVal(ref int v)
    { 
        v += 10; // можно использовать сразу
    }
}

// Для CLR и IL кода, методы out и ref не отличаются
// они нужны только для компилятора, тем что помогают гарантировать
// корректность кода