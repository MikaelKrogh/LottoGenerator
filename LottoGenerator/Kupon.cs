using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LottoGenerator {
    public class Kupon {

        public List<string> LottoRaekke = new List<string>();
        public List<string> JokerRakke = new List<string>();
        public bool MedJoker { get; set; }
        public DateTime Dato { get; set; }

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
                JokerRakke = LavTalRaekke(SpilleRegler.HoejesteJokerTal, SpilleRegler.JokerRakker);
        }

        private void LavLottoRaekker() {
            LottoRaekke = LavTalRaekke(SpilleRegler.HoejesteLottoTal, SpilleRegler.LottoRaekker);
        }

        private List<string> LavTalRaekke(int hoejsteTal, int antalRaekker) {
            List<string> result = new List<string>();
            for (int i = 0; i < antalRaekker; )
            {
                while (i < antalRaekker)
                {
                    int[] raekkeTal = new int[SpilleRegler.RaekkeLaenge];
                    int j = 0;
                    while (j < raekkeTal.Length)
                    {
                        int temp = HentRandomTal(hoejsteTal);
                        bool alreadyExist = false;
                        foreach (int item in raekkeTal)
                        {
                            if (item == temp)
                            {
                                alreadyExist = true;
                                break;
                            }
                        }
                        if (alreadyExist)
                            continue;

                        raekkeTal[j] = temp;
                        j++;
                    }
                    Array.Sort(raekkeTal);
                    string faerdigRakke = string.Join(" ", raekkeTal);
                    if (result.Contains(faerdigRakke))
                    {
                        continue;
                    }
                    result.Add(faerdigRakke);
                    i++;
                }
            }
            return result;
        }

        private int HentRandomTal(int hoejsteTal) {
            return SpilleRegler.random.Next(1, hoejsteTal);
        }
    }
}
