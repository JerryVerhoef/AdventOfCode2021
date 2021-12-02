using System;
using System.Collections.Generic;

namespace AdventCode2
{
    public enum Direction
    {
        Forward,
        Down,
        Up
    }

    public class Move
    {
        public Direction direction { get; set; }
        public int amount { get; set; }
    }
    public class DataFile
    {
        private readonly List<string> _contents;

        public DataFile(string[] contents)
        {
            _contents = new List<string>(contents);
        }

        public List<Move> GetMoves()
        {
            return _contents.ConvertAll(StringToMove);
        }
        
        private static Move StringToMove(string s)
        {
            var action = new Move();

            var parse = s.Split(' ');

            var direction =parse[0].ToLower();
            var amount = int.Parse(parse[1]);
            switch (direction)
            {
                case "forward":
                    action.direction = Direction.Forward;
                    break;
                case "down":
                    action.direction = Direction.Down;
                    break;
                case "up":
                    action.direction = Direction.Up;
                    break;
                default:
                    throw new Exception("Invalid direction");
            }
            action.amount = amount;
            return action;
        }
    }
}