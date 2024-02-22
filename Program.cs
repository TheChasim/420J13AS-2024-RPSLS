using _420J13AS_2024_RPSLS.AI.Dummy;
using _420J13AS_2024_RPSLS.AI.Student;

namespace _420J13AS_2024_RPSLS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var game = Game.Create<CHAS>();

            game.Challenge<RockOnlyAI>();
            game.Challenge<GenericOneAI>();
            game.Challenge<CircularAI>();
            game.Challenge<FavoriteOneAI>();

            //game.Challenge<CHAJ9>();


            game.End();
        }
    }
}
