namespace placeholder
{
// make a grid with different values for different objects
public class Direction 
    {

       public readonly static Direction left = new direction (0, -1)
       public readonly static Direction right = new direction (0, 1)
       public readonly static Direction up = new direction (-1, 0)
       public readonly static Direction down = new direction (1, 0)
    public int RowOffset { get; }
    public int ColOffset { get; }

private Direction(int RowOffset, int ColOffset)
        {
        
        RowOffset= rowOffset;
        ColOffset = colOffset;

        }
    }
}