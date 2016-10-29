namespace SCRUMFuncPrime
{
    public static class TennisScoreDisplayBoard
    {
        public static string TennisScoreDis(int playerA, int playerB)
        {
            var arrA=new string[] {"Love","Fifteen","Thirty","Fourty"};
            var arrB = new string[] { "Love", "Fifteen", "Thirty", "Fourty" };

            if (playerA == playerB)
            {
                if (playerA >= 3)
                    return "Deuce";
                return arrA[playerA] + " ALL";
            }
            if (playerA - playerB == 1)
            {
                if (playerB == 0 && playerA == 4)
                {
                    return "A Win";
                }
                else if(playerB > 0 && playerA >= 4)
                {
                    return "A Advantage";
                }
            }
            if (playerA - playerB > 1)
            {
                if (playerA >= 4)
                    return "A Win";
            }

            return arrA[playerA] + " " + arrB[playerB]; ;
        }
    }
}
