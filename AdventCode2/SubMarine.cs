using System.Collections.Generic;

namespace AdventCode2
{
    public class SubMarine
    {
        private List<Move> _actions;
        
        public int Distance { get; private set; }
        public int Depth { get; private set; }

        private int aim = 0;

        public SubMarine(List<Move> actions, bool withAim = false)
        {
            _actions = actions;
            ProcessMoves(withAim);
        }

        private void ProcessMoves(bool withAim)
        {
            foreach (var action in _actions)
            {
                if (action.direction == Direction.Forward)
                {
                    Distance += action.amount;
                    if (withAim)
                    {
                        Depth += aim * action.amount;
                    }
                }
                else if (action.direction == Direction.Up)
                {
                    if (withAim)
                    {
                        aim -= action.amount;
                    }
                    else
                    {
                        Depth -= action.amount;    
                    }

                }
                else if (action.direction == Direction.Down ) 
                {
                    if (withAim)
                    {
                        aim += action.amount;
                    }
                    else
                    {
                        Depth += action.amount;    
                    }
                }
            }
        }

        public int GetTravelDistance()
        {
            return Distance * Depth;
        }
    }
}