﻿using System;
using System.IO;

namespace _411_Demo_2
{
    internal class FileStuff
    {
        public static string DirPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/Daddy's Tracker Files";

        public static void CheckFiles()
        {
            if (!Directory.Exists(DirPath))
            {
                Directory.CreateDirectory(DirPath);
            }

            if (!File.Exists(DirPath + "//creditkey.txt"))
            {
                
            }
            if (!File.Exists(DirPath + "//daily.csv"))
            {
                File.Copy("daily.csv", DirPath + "//daily.csv");
            }
            if (!File.Exists(DirPath + "//foodbevkey.txt"))
            {
               
            }
            if (!File.Exists(DirPath + "//master.csv"))
            {
                File.Copy("master.csv", DirPath + "//master.csv");
            }
            if (!File.Exists(DirPath + "//otherbusinesskey.txt"))
            {
                
            }
            if (!File.Exists(DirPath + "//personalkey.txt"))
            {
               
            }
            if (!File.Exists(DirPath + "//utilrentkey.txt"))
            {
               
            }
        }
    }
}
