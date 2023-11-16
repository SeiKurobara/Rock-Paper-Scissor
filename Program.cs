namespace Rock_Paper_Scissor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Players player = new Players(3);
            Players enemy = new Players(3);
            Battle battle = new Battle();


            battle.StartMatch(player, enemy);



        }
    }
}