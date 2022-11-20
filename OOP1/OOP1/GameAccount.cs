using System;
using System.Collections.Generic;
namespace OOP1
{
    class GameAccount
    {
        public String UserName;
        public int CurrentRating;
        public int GamesCount;
        static Random random = new Random();
        static List<Game> history = new List<Game>();
        public GameAccount(String UserName)
        {
            this.UserName = UserName;
            CurrentRating = 1;
            GamesCount = 0;
        }

        static void WinGame(GameAccount User, GameAccount Opponent, int Rating)
        {
            Game game = new Game(User.UserName, Opponent.UserName, Rating, 1);
            User.CurrentRating += Rating;
            if (Opponent.CurrentRating - Rating >= 1)
            {
                Opponent.CurrentRating -= Rating;
            }
            else
                Opponent.CurrentRating = 1;
            history.Add(game);

        }
        static void LoseGame(GameAccount User, GameAccount Opponent, int Rating)
        {
            Game game = new Game(User.UserName, Opponent.UserName, Rating, 2);
            Opponent.CurrentRating += Rating;
            if (User.CurrentRating - Rating >= 1)
            {
                User.CurrentRating -= Rating;
            }
            else
                User.CurrentRating = 1;
            history.Add(game);

        }

        public static void GetStats()
        {
         foreach(var Game in history)
            {
                if (Game.flag == 1)
                {
                    Console.WriteLine("ID:" + Game.gameID + "  Гравець " + Game.player1 + " перемiг гравця " + Game.player2 + " та заробив " + Game.rating + " балiв рейтингу");
                }
                else if (Game.flag == 2)
                {
                    Console.WriteLine("ID:" + Game.gameID + "  Гравець " + Game.player1 + " програв гравцю " + Game.player2 + " та втратив " + Game.rating + " балiв рейтингу");
                } 
                else
                {
                    Console.WriteLine("ID:" + Game.gameID + "  Рейтинг гри не може будти вiд'ємним. Рейтинг обох гравцiв не змiниться");
                }
            }
        }

        public static void getGamesCount(GameAccount User)
        {
            Console.WriteLine("Кiлькiсть iгор гравця " + User.UserName + ": " + User.GamesCount);
        }

        public static void getRating(GameAccount User)
        {
            Console.WriteLine("Поточний рейтинг гравця " + User.UserName + ": " + User.CurrentRating);
        }
        public static void PlayGame(GameAccount User, GameAccount Opponent, int Rating)
        {
            if (Rating < 0)
            {
                Game game = new Game(User.UserName, Opponent.UserName);
                history.Add(game);
                return;
            }
            if (random.Next(2) == 1)
            {
                WinGame(User, Opponent, Rating);
            }
            else
            {
                LoseGame(User, Opponent, Rating);
            }
            User.GamesCount += 1;
            Opponent.GamesCount += 1;
        }
    }
}
