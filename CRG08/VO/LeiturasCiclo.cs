﻿
namespace CRG08.VO
{
    public class LeiturasCiclo
    {
        public int idLeiturasCiclo { set; get; }
        public string horario { set; get; }
        public double T1 { set; get; }
        public double T2 { set; get; }
        public double T3 { set; get; }
        public double T4 { set; get; }
        public Ciclos ciclo { set; get; }
    }
}
