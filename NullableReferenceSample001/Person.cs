using System;
using System.Collections.Generic;
using System.Text;
#nullable enable
namespace NullableReferenceSample001
{
    /// <summary>
    /// 使用 ? 宣告 MiddleName 為 nullable
    /// None-null 的欄位必須要在建構式設定初始值，且不能傳入 null
    /// </summary>
    public class Person
    {
        public string FirstName { get; set; }
        public string? MiddleName { get; set; }
        public string LastName { get; set; }

        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
    }
}
