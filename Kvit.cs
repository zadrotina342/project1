using System;

namespace pr_1
{
    class Kvit
    {
        public int Nom { set; get; }

        public string Data { set; get; }

        public float Sum { set; get; }

        public Kvit() { }

        public Kvit(int Nom, string Data, float Sum)
        {
            Nom = this.Nom;
            Data = this.Data;
            Sum = this.Sum;
        }

    }
}
