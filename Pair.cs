namespace Generic;

public class Pair<S,T>
{
    public S FirstValue { get; }
    public T SecondValue { get; }

    public Pair(S firstValue, T secondValue)
    {
        FirstValue = firstValue;
        SecondValue = secondValue;
    }
}