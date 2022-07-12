using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LottoGenerator {
    public static class SpilleRegler {

        public static Random random = new Random();
        public static int HoejesteLottoTal{
            get { return 37; }
        }

        public static int HoejesteJokerTal{
            get { return 10; }
        }

        public static int LottoRaekker{
            get { return 7; }
        }

        public static int JokerRakker{
            get { return 2; }
        }

        public static int RaekkeLaenge{
            get { return 7; }
        }
    }
}
