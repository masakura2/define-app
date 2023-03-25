using System;

public static class Hoge
{
    public static void Run()
    {
        Console.WriteLine("------------------------------");
#if SAMPLE
        Console.WriteLine("SAMPLE");
#endif
#if UNITY_EDITOR_OSX
        Console.WriteLine("UNITY_EDITOR_OSX");
#endif
#if UNITY_EDITOR_WIN
        Console.WriteLine("UNITY_EDITOR_WIN");
#endif
    }
}