namespace Soccersolution
{
    public enum Position
    {
        Goalkeeper,
        Defender,
        Midfielder,
        Scorer
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Team team = new Team();
            Player[] players = RandomPlayers(100);

            for (int i = 0; i < players.Length; i++)
            {
                team.Include(players[i]);
            }

            for (int i = 0; i < team.Players.Length; i++)
            {
                Console.WriteLine(team.Players[i].ToString());
            }

            Console.ReadLine();
        }

        public static Player[] RandomPlayers(int count)
        {
            Player[] players = new Player[count];
            Random random = new Random();

            for (int i = 0; i < count; i++)
            {
                string name = ((char)('A' + random.Next(26))).ToString();
                Position position = (Position)random.Next(0, 4);

                players[i] = new Player(name, position);
            }

            return players;
        }
    }
}