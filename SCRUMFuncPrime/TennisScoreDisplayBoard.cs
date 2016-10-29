using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCRUMFuncPrime
{
    public static class TennisScoreDisplayBoard
    {
        public static string TennisScoreDis(int PlayerA, int PlayerB)
        {
            string[] arrA=new string[4] {"Love","Fifteen","Thirty","Fourty"};
            string[] arrB = new string[4] { "Love", "Fifteen", "Thirty", "Fourty" };

            if (PlayerA == PlayerB)
            {
                if (PlayerA >= 3)
                    return "Deuce";
                return arrA[PlayerA] + " ALL";
            }
            if (PlayerA - PlayerB == 1)
            {
                if (PlayerB == 0 && PlayerA == 4)
                {
                    return "A Win";
                }
                else if(PlayerB > 0 && PlayerA >= 4)
                {
                    return "A Advantage";
                }
            }
            if (PlayerA - PlayerB > 1)
            {
                if (PlayerA >= 4)
                    return "A Win";
            }

            return arrA[PlayerA] + " " + arrB[PlayerB]; ;
        }



    }
}
