using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Nakladak
{
    public class Nakladak
    {
        public string Znacka { get; set; }
        public int Nosnost { get; set; }
        public int Nalozeno { get; set; }
        public int ObjemNadrz { get; set; }
        public int Palivo { get; set; }
        public int Spotreba { get; set; }
        public int Vzdalenost { get; set; }
        public Nakladak(int nosnost, int objem, int spotreba)
        {
            Znacka = "";
            Nosnost = nosnost;
            Nalozeno = 0;
            ObjemNadrz = objem;
            Palivo = 1500;
            Spotreba = spotreba;
            Vzdalenost = 0;

        }



        public void Jet(int Vzdalenost)
        {
            if (((((Vzdalenost / 100 * Spotreba)) + (25 * (Nalozeno / Nosnost))) < Palivo))
            {
                Palivo -= ((((Vzdalenost / 100) * Spotreba)) + (25 * (Nalozeno / Nosnost)));
            }

        }
        public void Naloz(int Nalozeni)
        {

            Nalozeno += Nalozeni;
            if (Nalozeni > Nosnost)
            {
                Nalozeni = Nosnost;
            }
        }
        public void Vyloz(int vylozeni)
        {
            Nalozeno -= vylozeni;
            if (Nalozeno > Nosnost)
            {
                Nalozeno = 0;
            }
            if (Nalozeno < 0)
            {
                Nalozeno = 0;
            }
        }
        public void Tankovat(int palivo)
        {

            Palivo += palivo;
            if (Palivo > ObjemNadrz)
            {
                Palivo = ObjemNadrz;
            }
        }
        public void Jezdit(int vzdalenost)
        {

            Vzdalenost += vzdalenost;
            if (Palivo <= 40)
            {
                Vzdalenost = vzdalenost;
            }    


        }
    }
}
