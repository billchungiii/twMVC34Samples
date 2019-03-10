using System;
#nullable enable
namespace NullableReferenceSample001
{
    /// <summary>
    /// 使用 #nullable enable 宣告
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "ABC";
            string? s2 = null;
            string? s3 = null;
            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine(s3);

         //   var person = new Person(null, null);


        }
    }
}
