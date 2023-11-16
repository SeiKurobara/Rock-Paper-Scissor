namespace Rock_Paper_Scissor
{
    internal class Battle
    {
        Random rng = new Random();
        Messages msg = new Messages();
        Potion potion = new Potion(1);


        public void StartMatch(Players player, Players enemy)
        {
            msg.Title();
            string playerName = msg.NameInput();
            int ctr = 1;

            while (player.Health != 0 && enemy.Health != 0)
            {
                msg.RoundCount(ref ctr);
                msg.PlayerChoices(potion);
                int playerInput = msg.PlayerInput();

                switch (playerInput)
                {
                    case 4:
                        if (potion.PotionCount > 0)
                        {
                            msg.PlayerUsePotion(player, potion, playerName);
                            PlayerHeal(player);
                            PotionDecrease(potion);
                        }
                        if (potion.PotionCount == 0) msg.NoPotion();
                        break;
                    default:
                        break;
                }
                Match(potion, player, enemy, playerInput, playerName);

                msg.BattleStatus(player, enemy, playerName);
                SecondChance(player, potion, playerName);
            }
            msg.BattleMessages(player, enemy);
        }

        public int EnemyAttack()
        {
            return rng.Next(1, 3);
        }

        public int RNGPotion()
        {
            return rng.Next(0, 1);
        }



        public void Match(Potion potion, Players player, Players enemy, int playerInput, string name)
        {
            //1. Rock 2.Paper 3.Scissor
            int enemyInput = EnemyAttack();

            if (playerInput == enemyInput) msg.Tie();
            else
            {
                switch (playerInput)
                {
                    case 1:
                        //Player Wins
                        if (enemyInput == 3)
                        {
                            msg.PlayerWinsTheRound(name);
                            EnemyDamage(enemy);
                        }
                        //Player Lose
                        if (enemyInput == 2)
                        {
                            msg.EnemyWinsTheRound();
                            PlayerDamage(player);
                        }
                        break;
                    case 2:
                        //Player Wins
                        if (enemyInput == 1)
                        {
                            msg.PlayerWinsTheRound(name);
                            EnemyDamage(enemy);
                        }
                        //Player Lose
                        if (enemyInput == 3)
                        {
                            msg.EnemyWinsTheRound();
                            PlayerDamage(player);
                        }
                        break;
                    case 3:
                        //Player Wins
                        if (enemyInput == 3)
                        {
                            msg.PlayerWinsTheRound(name);
                            EnemyDamage(enemy);
                        }
                        //Player Lose
                        if (enemyInput == 2)
                        {
                            msg.EnemyWinsTheRound();
                            PlayerDamage(player);
                        }
                        break;

                    default:
                        msg.ErrorMessages();
                        break;
                }
            }
        }

        public void PlayerHeal(Players player)
        {
            player.Health++;
        }
        public void PlayerDamage(Players player)
        {
            player.Health--;
        }
        public void EnemyDamage(Players enemy)
        {
            enemy.Health--;
        }
        public void PotionDecrease(Potion potion)
        {
            potion.PotionCount--;
        }

        public void SecondChance(Players player, Potion potion, string name)
        {
            if (potion.PotionCount > 0 && player.Health == 0)
            {
                PlayerHeal(player);
                PotionDecrease(potion);
                msg.PlayerUse2ndChance(player, potion, name);

            }
            if (potion.PotionCount == 0 && player.Health == 0)
            {
                msg.NoPotion();
            } 
        }
    }
}



