namespace _420J13AS_2024_RPSLS.AI.Student
{
    internal class CHAJ9: BaseAI
    {
        public string Nickname { get; set; } = "trouve un nom";
        static Move[] possibleMoves;
        private List<string> movesHistory = new List<string>();
        //    private Dictionary<string, List<string>> beats = new Dictionary<string, List<string>>()
        //{
        //    {"Roche", new List<string> {"Ciseaux", "Lézard"}},
        //    {"Papier", new List<string> {"Roche", "Spock"}},
        //    {"Ciseaux", new List<string> {"Papier", "Lézard"}},
        //    {"Lézard", new List<string> {"Papier", "Spock"}},
        //    {"Spock", new List<string> {"Roche", "Ciseaux"}}
        //};

        public CHAJ9()
        {
            Nickname = "trouve un nom";
            possibleMoves = (Move[])(Enum.GetValues(typeof(Move)));
        }

        public override Move Play()
        {
            return ChooseAMove();
        }

        public override void Observe(Move opponentMove)
        {
            AddAdversaireMove(opponentMove);

        }


        private void AddAdversaireMove(Move opponentMove)
        {
            movesHistory.Add(opponentMove.ToString());
            if (movesHistory.Count > 20)
            {
                movesHistory.RemoveAt(0);
            }
        }

        private string PreditMove()
        {
            if (movesHistory.Count == 0)
            {
                return possibleMoves[Game.SeededRandom.Next(possibleMoves.Length)].ToString();
            }
            else
            {
                //Move communMove = Move.Rock;
                List<string> tempList = new List<string>();
                tempList = movesHistory;
                tempList.GroupBy(x => x);
                tempList.OrderByDescending(g => g.Count());

                //switch (tempList.FirstOrDefault())
                //{
                //    case "Rock":
                //        communMove = Move.Rock;
                //        break;
                //    case "Paper":
                //        communMove = Move.Paper;
                //        break;
                //    case "Scissors":
                //        communMove = Move.Scissors;
                //        break;
                //    case "Spock":
                //        communMove = Move.Spock;
                //        break;
                //    case "Lizard":
                //        communMove = Move.Lizard;
                //        break;
                //}

                return tempList.FirstOrDefault();
            }
        }

        private Move ChooseAMove()
        {

            string movePredit = PreditMove();
            Move moveChoosed = Move.Spock;
            string bestMove = null;

            switch (movePredit)
            {
                case "Rock":
                    moveChoosed = Move.Paper;
                    break;
                case "Paper":
                    moveChoosed = Move.Scissors;
                    break;
                case "Scissors":
                    moveChoosed = Move.Spock;
                    break;
                case "Spock":
                    moveChoosed = Move.Lizard;
                    break;
                case "Lizard":
                    moveChoosed = Move.Rock;
                    break;
            }









            //foreach (var move in beats)
            //{
            //    if (move.Value.Contains(movePredit))
            //    {
            //         bestMove = move.Key; 
            //    }
            //}

            //switch (bestMove)
            //{
            //    case "Rock":
            //        moveChoosed = Move.Rock;
            //        break;
            //    case "Paper":
            //        moveChoosed = Move.Paper;
            //        break;
            //    case "Scissors":
            //        moveChoosed = Move.Scissors;
            //        break;
            //    case "Spock":
            //        moveChoosed = Move.Spock;
            //        break;
            //    case "Lizard":
            //        moveChoosed = Move.Lizard;
            //        break;
            //}

            return moveChoosed;
        }

        public override string ToString()
        {
            return Nickname;
        }

        public virtual string GetAuthor()
        {
            return GetType().Name;
        }
    }
}
