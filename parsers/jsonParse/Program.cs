﻿//Imports from web framework goes here
using System;

namespace jsonParse
{
    class Program
    {
        static void Main(string[] args)
        {
            var exampel1 = @"{""name"": ""John Doe"",""age"":20}";
			var JSONObj = new JavaScriptSerializer().Deserialize<Dictionary<string, string>> (example1);
			console.WriteLine("Name: "+ JSONObj["name"]);
			console.WriteLine("Age: "+ JSONObj["age"]);
        }
    }
}
