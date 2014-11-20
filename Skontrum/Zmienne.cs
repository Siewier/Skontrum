using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skontrum
{
    public class Zmienne
    {
        public static DataTable tabela = new DataTable();
        public static string plik = Directory.GetCurrentDirectory() + "\\";
        public static int minNumInw = 0;
        public static int maxNumInw = 0;
        public static bool zapisane = false;
    }
}
