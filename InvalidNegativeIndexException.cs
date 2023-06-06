//using TempEssaiPckgDependantDunProjet;

namespace Transverse._Common.Exceptions;

public class InvalidNegativeIndexException : Exception
{
    public override string Message { get; }

    public InvalidNegativeIndexException(int negativeIndex)
    : base("")
    {
        Message = $"Negative index({negativeIndex}) unauthorized.";
        //Message = (new Class1()).GetData(negativeIndex);
    }
}