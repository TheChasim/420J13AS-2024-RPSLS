﻿namespace _420J13AS_2024_RPSLS.AI
{
    internal class RockOnlyAI : DummyAI
    {
        public RockOnlyAI()
        {
            Nickname = "Rock Lee";
        }

        public override Move Play()
        {
            return Move.Rock;
        }
    }
}
