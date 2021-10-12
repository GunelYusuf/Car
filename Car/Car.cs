using System;
namespace Car
{
    public class Car 
    {

        public string BMW { get; set; }
        public int YanacaqTutumu { get; set; }
        public int MaximumVolumeBak { get; set; }
        public double GedilenYol { get; set; }
        public double SerfolunanYanacaq { get; set; }
        public double MaxYanacaq { get; set; }
        

        public Car()
        {

        }
        #region // yanacaq
        public Car(int gedilenyol)
        {
            GedilenYol = gedilenyol;
            // 100 km-e 15 litr
            SerfolunanYanacaq = gedilenyol * 0.15;
            Console.WriteLine($"{gedilenyol} km yola {SerfolunanYanacaq} litr benzin istifade olundu");
        }
        #endregion

        #region  Max Gedilen yol
     
        public double ComfortMode(int maxoil)
        {
            MaxYanacaq = maxoil;
            GedilenYol = maxoil / 0.15;
            return GedilenYol;
        }

        public double SportMode(int maxoil)
        {
            MaxYanacaq = maxoil;
            GedilenYol = maxoil / 0.3;
            return GedilenYol;

        }
        #endregion

        







    }
}
