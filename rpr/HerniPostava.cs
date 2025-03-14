using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpr
{
    public class HerniPostava
    {
        public bool JeBoss=false;
        public string Prace = "Neznámá";
        public string Specializace = "Bojovník";
        public string Jmeno  = "test";
        public string Vlasy;
        public int X = 0;
        public int Y = 0;
        public int Level  = 1;
        public int XP  = 0;



        public void ZmenaPozice(int x, int y)
        {
           
        }

        public void PridatXP(int xp)
        {
            XP += xp;
            if (XP >= 100)
            {
                Level++;
                XP -= 100;
            }
        }
 
        public override string ToString()
        {
            return $"Jméno: {Jmeno}, Level: {Level}, XP: {XP}";
        }
    }

    
  
   
}
