using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_ticaret_Entites.Concreate
{
    public class Arac
    {
        public string? Marka { get; set; }
        public string? Model { get; set; }
        public int Yil { get; set; }
        public string? Renk { get; set; }
        public int MotorGucu { get; set; }
        public int MotorHacmi { get; set; }
        public int Km { get; set; }
        public Durum durum { get; set; }
        public Vites vites { get; set; }
        public YakitTipi yakitTipi { get; set; }

        public bool Start()
        {
            return true;
        }
        public bool Stop()
        {
            return true;
        }
        public enum YakitTipi
        {
            Benzinli,
            Mazot,
            Hibrit,
            Elektrik
        }
        public enum Durum
        {
            İkinciEl,
            Sıfır
        }
        public enum Vites:byte
         {
            Manuel,
            Otomatik,
            YariOtomatik
         }
    }
}
