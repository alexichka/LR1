namespace SequenceLibrary
{
    public class NumberSequence
    {
        public bool СheckIfSequenceIncreasing (int[] numbers)
        {
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] <= numbers[i - 1])
                {
                    return false;
                }
            }
            return true;
        }

    }
}
