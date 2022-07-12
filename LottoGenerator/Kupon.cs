using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LottoGenerator {
    public class Kupon {

        List<string> LottoRaekke    = new List<string>();
        List<string> JokerRakke     = new List<string>();

        bool MedJoker { get; set; }
        DateTime Dato { get; set; }

        public Kupon(bool medjoker) {
            this.MedJoker = medjoker;
            Dato = DateTime.Today;
            LavKupon();
        }

        public void LavKupon() {
            LavLottoRaekker();
            LavJokerRaekker();
        }

        private void LavJokerRaekker() {
            if (this.MedJoker)
            {
            int hoejesteJokerTal = SpilleRegler.HoejesteJokerTal;
            int jokerRakker = SpilleRegler.JokerRakker;
            LavTalRaekke(hoejesteJokerTal, jokerRakker);
            }
        }

        private void LavLottoRaekker() {
            int hoejesteLottoTal = SpilleRegler.HoejesteLottoTal;
            int lottoRaekker = SpilleRegler.LottoRaekker;
            LavTalRaekke(hoejesteLottoTal, lottoRaekker);            
        }

        private void LavTalRaekke(int hoejsteTal, int antalRaekker) {
            for (int i = 0; i < antalRaekker; i++)
            {
                int[] raekkeTal = new int[SpilleRegler.RaekkeLaenge];
                for (int j = 0; j < raekkeTal.Length; j++)
                {
                    raekkeTal[j] = HentRandomTal(hoejsteTal);
                    while (raekkeTal.Contains(raekkeTal[j]))
                    {
                        raekkeTal[j] = HentRandomTal(hoejsteTal);
                    }
                    Array.Sort(raekkeTal);
                    // lav det om til en string række og derefter udform LavLotto  LavJoker så  rækkerner gemmes på de rigtige listProperties
                    // metoden skal måske laves om til at retunere en List<string> som så smides på propertien?
                }
            }
        }

        private int HentRandomTal(int hoejsteTal) {
            return SpilleRegler.random.Next(1, hoejsteTal);
        }

    }
}
