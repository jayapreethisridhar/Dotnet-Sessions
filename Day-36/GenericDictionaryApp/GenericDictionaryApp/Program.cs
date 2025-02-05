using GnericDictionaryApp.Model;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace GnericDictionaryApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // CaseStudy1();

            //CaseStudy2();


            CaseStudy3();
        }
        private static void CaseStudy3()
        {
            var map = new Dictionary<string, string>();
            map.Add("MH", "Mahasthara");
            map.Add("TN", "TamilNadu");
            map.Add("KL", "Kerala");
            map.Add("AP", "AndhraPradesh");

            Console.WriteLine(map["TN"].ToUpper());
            map["TN"] == "Tamil ==> Nadu";
        }