namespace Methods
{
    public class Calculator
    {

        public int Add(int[] numbers)
        {
            var sum = 0;
            foreach (var number in numbers)
                sum += number;
            return sum;
        }
    }
}