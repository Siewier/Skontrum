﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data;
using ClosedXML.Excel;

namespace Skontrum
{
    public static class KatalogKsiazek
    {
        public static bool NoweSkontrum(string nazwa)
        {
            bool rezultat = true;
            //tworzenie pliku i uzupelnianie tabeli
            Zmienne.tabela.TableName = "Ksiazki";
            Zmienne.tabela.Columns.Add("nrInw", typeof(int));
            Zmienne.tabela.Columns.Add("stan", typeof(string));
            Zmienne.tabela.Columns.Add("miejsce", typeof(string));
            Zmienne.tabela.AcceptChanges();
            try
            {
                //File.Create(nazwa);
                Zmienne.tabela.WriteXml(nazwa, XmlWriteMode.WriteSchema);
            }
            catch (Exception e)
            {
                if (e != null)
                {
                    rezultat = false;
                }
            }
            Zmienne.wczytane = true;
            return rezultat;
        }

        public static bool PobierzDane()
        {
            bool rezultat = false;
            //pobieranie danych
            return rezultat;
        }

        public static bool DodajKsiazke(int numerInw, string stan, string miejsce)
        {
            bool rezultat = false;
            //doddawanie ksiazki
            Zmienne.tabela.Rows.Add(numerInw, stan, miejsce);
            Zmienne.tabela.AcceptChanges();
            Zmienne.zapisane = false;
            return rezultat;
        }

        public static int PoliczKsiazki()
        {
            int wynik = 0;
            //liczenie ksiazek
            wynik = Zmienne.tabela.Rows.Count;
            return wynik;
        }

        public static bool ZapiszXML(string nazwa)
        {
            bool rezultat = true;
            //zapisywanie danych
            Zmienne.tabela.WriteXml(Zmienne.plik, XmlWriteMode.WriteSchema);
            Zmienne.zapisane = true;
            return rezultat;
        }
        public static bool WczytajXML(string nazwa)
        {
            bool result = true;
            //wczytywanie danych
            Zmienne.tabela.ReadXml(Zmienne.plik);
            Zmienne.wczytane = true;
            return result;
        }

        public static void ZapiszDoExcela()
        {
            XLWorkbook wb = new XLWorkbook();
            wb.Worksheets.Add(Zmienne.tabela, "Skontrum");
            wb.SaveAs(Directory.GetCurrentDirectory() + "\\Skontrum.xlsx");
        }
        public static void PosortujKsiazki()
        {
            DataView dv = Zmienne.tabela.DefaultView;
            dv.Sort = "nrInw ASC";
            //DataTable sortedDT = dv.ToTable();
            Zmienne.tabela = dv.ToTable();
            Zmienne.zapisane = false;
        }
    }
}
