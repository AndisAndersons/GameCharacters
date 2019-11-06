using System;
using System.Collections.Generic;
using System.Text;

namespace GameCharacters.Data
{
    public abstract class BaseCharacter // abstract - nozime ka obligati jamantojas!!! pa taisno nevar uztaisiit
    {
        public virtual int Step => 1;//liekam uz virtaul un tikai par 1 lai palielinaaas//abstracta īpašība janorāda cik būs vētība OBLIGĀTI
        public virtual int Stamina { get; set; }
        public int PostionX { get; protected  set; }
        public int PostionY { get; protected set; }

        public void Move(MoveDirectionEnum direction)
        {
            switch (direction)
            {
                case MoveDirectionEnum.Up:
                    PostionY -= Step;
                    break;
                case MoveDirectionEnum.Down:
                    PostionY += Step;
                    break;
                case MoveDirectionEnum.Left:
                    PostionX -= Step;
                    break;
                case MoveDirectionEnum.Right:
                    PostionX += Step;
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(direction),direction,"Not allowed movement");
            }


        }
        public string GetCurrentPossition()
        {
            return $"PositionX: {PostionX} PositionY: {PostionY}";
            }
    }
}
