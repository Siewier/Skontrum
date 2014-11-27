using System;
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

            int licznik = Zmienne.maxNumInw;
            do
            {
                Zmienne.tabela.Rows.Add(licznik, "brak", "");
                Zmienne.tabela.AcceptChanges();
                licznik--;
            } while (licznik > 0);

            KatalogKsiazek.PosortujKsiazki();

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
            bool rezultat;
            //doddawanie ksiazki
            if (Zmienne.tabela.Rows[numerInw - 1][1].ToString() == "brak")
            {
                Zmienne.tabela.Rows[numerInw - 1].SetField(1, stan);
                Zmienne.tabela.Rows[numerInw - 1].SetField(2, miejsce);
                Zmienne.tabela.AcceptChanges();
                Zmienne.zapisane = false;
                rezultat = true;
            }
            else
            {
                rezultat = false;
            }
            return rezultat;
        }
        public static int PoliczKsiazki()
        {
            int wynik = 0;
            //liczenie ksiazek
            wynik = Zmienne.tabela.Rows.Count;
            return wynik;
        }
        public static int PoliczNaPolkach()
        {
            int wynik = 0;
            //liczenie ksiazek na polkach
            wynik = Zmienne.tabela.Select("stan = 'polka'").Length;
            return wynik;
        }
        public static int PoliczWypozyczone()
        {
            int wynik = 0;
            //liczenie ksiazek wypozyczone
            wynik = Zmienne.tabela.Select("stan = 'wypozyczona'").Length;
            return wynik;
        }
        public static int PoliczUbytki()
        {
            int wynik = 0;
            //liczenie ubytkow
            wynik = Zmienne.tabela.Select("stan = 'ubytek'").Length;
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
            Zmienne.tabela.AcceptChanges();
            Zmienne.zapisane = false;
        }
        public static void SzukajBrakujacych()
        {
            PosortujKsiazki();
            Zmienne.tabelaBraki.Clear();
            foreach (DataRow row in Zmienne.tabela.Rows)
            {
                if (row["stan"].ToString() == "brak")
                {
                    Zmienne.tabelaBraki.Rows.Add(row.ItemArray);
                    Zmienne.tabelaBraki.AcceptChanges();
                }
            }
        }
        public static void OznaczJakoBrakujace()
        {
            PosortujKsiazki();
            List<int> lista = new List<int>();
            int poprzedniaKsiazka = int.Parse(Zmienne.tabela.Rows[0][0].ToString());
            foreach (DataRow row in Zmienne.tabela.Rows)
            {
                int numerInw = int.Parse(row["nrInw"].ToString());
                if (numerInw > poprzedniaKsiazka)
                {
                    for (int i = poprzedniaKsiazka + 1; i < numerInw; i++)
                    {
                        //Zmienne.tabela.Rows.Add(i, "brak", "brak danych");
                        lista.Add(i);
                    }
                    poprzedniaKsiazka = numerInw;
                }
            }
            foreach (int numer in lista)
            {
                Zmienne.tabela.Rows.Add(numer, "brak", "brak danych");
            }
            PosortujKsiazki();
        }
    }
}
