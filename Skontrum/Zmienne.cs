using System;
using System.Data;
using System.IO;

namespace Skontrum
{
    public class Zmienne
    {
        public static DataTable tabela = new DataTable();
        public static DataTable tabelaBraki = new DataTable();
        //public static string plik = Directory.GetCurrentDirectory() + "\\";
        public static string plik = Path.Combine(Environment.ExpandEnvironmentVariables("%userprofile%"), "Documents") + "\\";
        public static int minNumInw = 1;
        public static int maxNumInw = 0;
        public static bool zapisane = false;
        public static bool wczytane = false;
    }
}
