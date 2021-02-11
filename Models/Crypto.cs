using System.Collections.Generic;

// classes converte from API interface
// Create By Rui
namespace CryptoCanuck.Models
{
    public class PriceDatum    {
        public int time { get; set; } 
        public double high { get; set; } 
        public double low { get; set; } 
        public double open { get; set; } 
        public double volumefrom { get; set; } 
        public double volumeto { get; set; } 
        public double close { get; set; } 
        public string conversionType { get; set; } 
        public string conversionSymbol { get; set; } 
    }
    public class Datum    {
        public bool Aggregated { get; set; } 
        public int TimeFrom { get; set; } 
        public int TimeTo { get; set; } 
        public List<PriceDatum> Data { get; set; } 
    }

    public class Crypto    {
        public string Response { get; set; } 
        public string Message { get; set; } 
        public bool HasWarning { get; set; } 
        public int Type { get; set; } 
        public Datum Data { get; set; } 
    }
}

