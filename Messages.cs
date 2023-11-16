namespace Rock_Paper_Scissor
{
    internal class Messages
    {
        public void Title()
        {
            Console.WriteLine("Welcome to the Rock Paper Scissor");
        }

        public void PlayerChoices(Potion potion)
        {
            Console.WriteLine();
            Stars();
            Console.WriteLine("1.Rock \n" +
                "2.Paper \n" +
                "3.Scissor\n" +
                $"4.Potion({potion.PotionCount})");
            Console.Write("What is your Choice?: \n" +
                "You can Only type 1 2 3 4: ");
        }

        public int PlayerInput()
        {
            int choice = int.Parse(Console.ReadLine());
            Console.WriteLine();

            return choice;
        }

        public string NameInput()
        {
            Console.WriteLine("What is your Name?: ");
            string playerName = Console.ReadLine();
            return playerName;
        }

        public void BattleStatus(Players player, Players enemy, string name)
        {
            Stars();
            Console.WriteLine($"{name} Total Health is {player.Health}");
            Percent();
            Console.WriteLine($"Enemy Total Health is {enemy.Health}");
            Stars();
        }
        public void PlayerWinsTheRound(string name)
        {
            Percent();
            Console.WriteLine($"{name} Wins");
            Percent();
        }
        public void EnemyWinsTheRound()
        {
            Percent();
            Console.WriteLine("Enemy Wins");
            Percent();
        }
        public void Tie()
        {
            Percent();
            Console.WriteLine("Its a Tie");
            Percent();
        }

        public void BattleMessages(Players player, Players enemy)
        {
            if (player.Health == 0)
            {
                Console.WriteLine("Enemy Wins");
            }
            if (enemy.Health == 0)
            {
                Console.WriteLine("Player Wins");
            }
        }

        public void ErrorMessages()
        {
            Console.WriteLine("You can Only Input 1-3");
        }

        public void RoundCount(ref int ctr)
        {

            Percent();
            Console.WriteLine($"Turn: {ctr}");
            Percent();
            ctr++;

        }


        public void PlayerUsePotion(Players player, Potion potion, string name)
        {
            Console.WriteLine($"{name} gained 1 hp \n" +
                $"{name}'s Remaining Health : {player.Health} \n" +
                $"Total Potion Count: {potion.PotionCount}");
        }

        public void PlayerUse2ndChance(Players player, Potion potion, string name)
        {
            Console.WriteLine("The Magical potion Works");
            PlayerUsePotion(player, potion, name);
        }
        public void NoPotion()
        {
            Console.WriteLine("Not Enough Potion");
        }

        public void Stars()
        {
            Console.WriteLine("**********************");
        }
        public void Percent()
        {
            Console.WriteLine("%%%%%%%%");
        }
    }
}
