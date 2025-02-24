namespace exercise1431
{
    public class Solution
    {
        public IList<bool> KidsWithCandies(int[] candies, int extraCandies)
        {

            int maxCandy = candies[0];

            foreach (int candy in candies)
            {
                if (candy > maxCandy)
                    maxCandy = candy;
            }

            List<bool> result = candies.Select(candy => (candy + extraCandies) >= maxCandy).ToList();

            return result;
        }
    }
}