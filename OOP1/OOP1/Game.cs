using System;
namespace OOP1
{
    class Game
    {
        public String player1, player2;
        public int flag;  //1-player1 is winner , 2-player2 is winner , 0-rating<0
        public int rating;
        public int gameID;
        public static int currGameID = 0;
        public Game(String player1, String player2, int rating, int flag)
        {
            this.player1 = player1;
            this.player2 = player2;
            this.rating = rating;
            this.flag = flag;
            gameID = currGameID;
            currGameID++;
        }
        public Game(String player1, String player2)
        {
            this.player1 = player1;
            this.player2 = player2;
            flag = 0;
            gameID = currGameID;
            currGameID++;
        }
    }
}
