using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace LottoGenerator {
    public static class TekstBehandler {

        public static StringBuilder Linjebehandling(Kupon kupon) {
            StringBuilder builder = new StringBuilder();
            builder.Append("*****************\n");
            builder.Append("Lotto Uge 28");
            builder.Append($"{kupon.Dato.ToShortDateString()}\n");
            builder.Append("\n");
            for (int i = 0; i < kupon.LottoRaekke.Count; i++)
            {
                builder.Append($"{(i+1).ToString()}. {kupon.LottoRaekke[i]}\n");
            }
            if (kupon.MedJoker)
            {
                foreach (string raekke in kupon.JokerRakke)
                {
                    builder.Append($"{raekke}\n");
                }
            }
            builder.Append("*****************");
            return builder;
        }

  
    }
}
