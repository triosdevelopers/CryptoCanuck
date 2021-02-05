using System.Collections.Generic;
using System;

namespace CryptoCanuck.Models {
    public class Prices    {
        public double USD { get; set; } 
        public double JPY { get; set; } 
        public double CAD { get; set; } 
        public double EUR { get; set; }  

        public void CalcTotal(int amount){
            this.CAD = Math.Truncate((amount * this.CAD) * 100)/ 100;
            this.USD = Math.Truncate((amount * this.USD) * 100)/ 100;
            this.JPY = Math.Truncate((amount * this.JPY) * 100)/ 100;
            this.EUR = Math.Truncate((amount * this.EUR) * 100)/ 100;
        }
    }

    
}