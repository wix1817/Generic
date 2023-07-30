namespace Generic;

public class ComparablePair<T,U> : Pair<T,U>, IComparable<ComparablePair<T, U>>
    where T: IComparable
    where U: IComparable
{
    public ComparablePair(T firstValue, U secondValue) : base(firstValue, secondValue)
    {

    }

    public int CompareTo(ComparablePair<T, U>? other)
    {
        if (other == null) return 0;
        if (FirstValue.CompareTo(other.FirstValue) == 0)
            return SecondValue.CompareTo(other.SecondValue);
        return FirstValue.CompareTo(other.FirstValue);
    }
}
