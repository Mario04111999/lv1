using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project1
{
    class Biljeska
    {
        private String tekst;
        private String autor;
        private int vaznost;

        public string GetAutor()
       { return this.autor;
        }
        private void SetAutor(string autor)
        {this.autor = autor; 
        }

        public string GetTekst()
        {
            return this.tekst;
        }
        public int GetVaznost()
        {
            return this.vaznost;
        }
        public void SetTekst(string tekst)
        {
            this.tekst = tekst;
        }
        public void SetVaznost(int vaznost)
        {
            this.vaznost = vaznost;
        }

        public Biljeska(string autor, string tekst, int vaznost)
        {
            this.autor = autor;
            this.tekst = tekst;
            this.vaznost = vaznost;
        }
        public Biljeska(string autor, string tekst)
        {
            this.autor = autor;
            this.tekst = tekst;
            vaznost = 1;
        }
        public Biljeska(string tekst)
        {

            this.tekst = tekst;
            autor = "autor";
            vaznost = 0;
        }

        // Z3 atribut postavljen na prazan string 
        public Biljeska()
        {
            tekst = " ";
            autor = " ";
            vaznost = 5;
        }

        public override string ToString()
        {
            return this.autor + " , " + this.vaznost;
        }


    }
}
