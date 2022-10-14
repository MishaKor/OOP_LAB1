namespace OOP1
{
    internal class Lab1
    {
        static void Main(string[] args)
        {
            GameAccount User1 = new GameAccount("Bob");
            GameAccount User2 = new GameAccount("Tom");

            GameAccount.PlayGame(User1, User2, 50);
            GameAccount.PlayGame(User1, User2, 32);
            GameAccount.PlayGame(User1, User2, 17);
            GameAccount.PlayGame(User1, User2, 22);
            GameAccount.PlayGame(User1, User2, 10);
            GameAccount.PlayGame(User1, User2, -2);
            GameAccount.PlayGame(User1, User2, 14);
            GameAccount.GetStats(User1);
            GameAccount.GetStats(User2);
        }
    }
}
