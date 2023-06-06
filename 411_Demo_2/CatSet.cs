using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _411_Demo_2
{
    internal class CatSet
    {
        public static string[] CreditKey { get; set; }
        public static string[] FoodBevKey { get; set; }
        public static string[] OtherBusinessKey { get; set; }
        public static string[] PersonalKey { get; set; }
        public static string[] UtilRentKey { get; set; }

        public static void ReadInKeys()
        {
            CreditKey = File.ReadAllLines(FileStuff.DirPath + "//creditkey.txt");
            FoodBevKey = File.ReadAllLines(FileStuff.DirPath + "//foodbevkey.txt");
            OtherBusinessKey = File.ReadAllLines(FileStuff.DirPath + "//otherbusinesskey.txt");
            PersonalKey = File.ReadAllLines(FileStuff.DirPath + "//personalkey.txt");
            UtilRentKey = File.ReadAllLines(FileStuff.DirPath + "//utilrentkey.txt");
        }
    }
}
