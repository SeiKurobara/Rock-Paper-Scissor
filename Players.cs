namespace Rock_Paper_Scissor
{
    internal class Players
    {
        public int Health { get; set; }

        public Players(int Health)
        {
            this.Health = Health;

        }
    }

    class Potion
    {
        public int PotionCount { get; set; }
        public Potion(int PotionCount)
        {
            this.PotionCount = PotionCount;
        }
    }
}
