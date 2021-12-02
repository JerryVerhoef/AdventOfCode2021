using System.Collections.Generic;

namespace AdventCode2
{
    public class SubMarine
    {
        private List<Move> _actions;
        public SubMarine(List<Move> actions)
        {
            _actions = actions;
        }
        
        public int GetForwardDistance()
        {
            int distance = 0;
            foreach (var action in _actions)
            {
                if (action.direction == Direction.Forward)
                {
                    distance += action.amount;
                }
            }
            return distance;
        }

        public int GetDepth()
        {
            int depth = 0;
            foreach (var action in _actions)
            {
                if (action.direction == Direction.Up)
                {
                    depth -= action.amount;
                }
                else if (action.direction == Direction.Down ) 
                {
                    depth += action.amount;
                }
            }
            return depth;
        }

        public int GetTravelDistance()
        {
            return GetForwardDistance() * GetDepth();
        }
    }
}