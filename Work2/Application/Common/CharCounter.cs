namespace Common
{
    public class CharCounter
    {
        public int CountChars(string text, char symbol)
        {
            int numberOfChars = 0;
            foreach (char c in text)
            {
                if (c == symbol) numberOfChars++;
            }
            return numberOfChars;
        }
    }
}