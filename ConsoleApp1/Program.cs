using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Channels;
using Castle.Components.DictionaryAdapter;
using Moq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var asd = new People()
            {
                Name = null
            };

            Console.WriteLine(asd.Name);
        }
    }

    public class People
    {
        [NotNull]
        [RemoveIfEmpty]
        public string Name { get; set; }
        public string Age { get; set; }
        public string Lastname { get; set; }
        public Work Work { get; set; }
    }

    public class Work
    {
        public string WorkName { get; set; }
        public string AnotherField { get; set; }
    }
}