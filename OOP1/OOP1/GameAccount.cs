using System;
using System.Collections.Generic;

namespace OOP1
{
    public class GameAccount
    {
        public String UserName;
        public int CurrentRating;
        public int GamesCount;
        public String History = "";
        static int gameID = 0;
        static Random random = new Random();
        public GameAccount(String UserName)
        {
            this.UserName = UserName;
            CurrentRating = 1;
            GamesCount = 0;
        }

        public static void WinGame(GameAccount User, GameAccount Opponent, int Rating)
        {
            User.CurrentRating += Rating;
            if (Opponent.CurrentRating - Rating >= 1)
            {
                Opponent.CurrentRating -= Rating;
            }
            else
                Opponent.CurrentRating = 1;
            User.History += "\nID:" + gameID + "   Перемiг гравця " + Opponent.UserName + " та отримав " + Rating + " балiв рейтингу." + " Поточний рейтинг: " + User.CurrentRating;
            Opponent.History += "\nID:" + gameID + "   Програв гравцю " + User.UserName + " та втратив " + Rating + " балiв рейтингу." + " Поточний рейтинг: " + Opponent.CurrentRating;
            Console.WriteLine("Гравець " + User.UserName + " перемiг та отримав " + Rating + " балiв рейтингу." + " Поточний рейтинг: " + User.CurrentRating);
        }
        public static void LoseGame(GameAccount User, GameAccount Opponent, int Rating)
        {
            Opponent.CurrentRating += Rating;
            if (User.CurrentRating - Rating >= 1)
            {
                User.CurrentRating -= Rating;
            }
            else
                User.CurrentRating = 1;
            User.History += "\nID:" + gameID + "   Програв гравцю " + Opponent.UserName + " та втратив " + Rating + " балiв рейтингу." + " Поточний рейтинг: " + User.CurrentRating;
            Opponent.History += "\nID:" + gameID + "   Перемiг гравця " + User.UserName + " та отримав " + Rating + " балiв рейтингу." + " Поточний рейтинг: " + Opponent.CurrentRating;
            Console.WriteLine("Гравець " + User.UserName + " програв та втратив " + Rating + " балiв рейтингу." + " Поточний рейтинг: " + User.CurrentRating);
        }

        public static void GetStats(GameAccount User)
        {
            Console.WriteLine("\nСтатистика гравця " + User.UserName + User.History);
            Console.WriteLine("Кiлькiсть iгор: " + User.GamesCount + "\nРейтинг: " + User.CurrentRating);

        }


        public static void PlayGame(GameAccount User, GameAccount Opponent, int Rating)
        {
            
            if (Rating <= 0)
            {
                Console.WriteLine("Рейтинг гри не може будти вiд'ємним. Гра не зарахується.");
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
            gameID++;

        }
    }
}
