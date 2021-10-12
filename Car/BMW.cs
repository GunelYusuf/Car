using System;
namespace Car
{
    public class BMW :Car
    {
        public int MaximumVolumeBak = 70;
        public int BakdakiBenzin;
        public double BenzinPulu=1.10;
        public double Mushteripulu;
        public double vurbenzin;
        public int ToplamBenzin;

        public BMW(int bakdakibenzin,int vurulacaqbenzin)
        {
            BakdakiBenzin = bakdakibenzin;
            if(bakdakibenzin==MaximumVolumeBak)
            {
               Console.WriteLine($"{MaximumVolumeBak} Polnu Bak");
            }else if (bakdakibenzin<=70)
            {
                BenzinPulu = BenzinPulu * vurulacaqbenzin;
                ToplamBenzin = bakdakibenzin + vurulacaqbenzin;
                Console.WriteLine($"{vurulacaqbenzin}litr bak {BenzinPulu}  AZN'e vuruldu");
            }
            else 
            {
                Console.WriteLine("Bakin hecmi 70-den yuxari deyil");
            }
           

        }

        #region ödənilən məbləğə görə
        public BMW(double mushpul)
        {

            Mushteripulu = mushpul;
            vurbenzin = mushpul / BenzinPulu;
            Console.WriteLine((int)vurbenzin);
        }
        #endregion


    }
}
