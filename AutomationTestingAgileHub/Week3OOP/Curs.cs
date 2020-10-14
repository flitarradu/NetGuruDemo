using System;
using System.Collections.Generic;
using System.Text;

namespace Week3OOP
{
    class Curs
    {

        private int CursId { get; set; }
        private string Nume { get; set; }
        private int Durata { get; set; }

        //public Curs(int id, string nume, int durata)
        //{
        //    CursId = id;
        //    Nume = nume;
        //    Durata = durata;
        //}

        //public Curs(int id, string nume)
        //{
        //    CursId = id;
        //    Nume = nume;
        //    Durata = 12;
        //}


        public void SetCurs(int id, string nume, int durata)
        {
            CursId = id;
            Nume = nume;
            Durata = durata;
        }
    }
}
