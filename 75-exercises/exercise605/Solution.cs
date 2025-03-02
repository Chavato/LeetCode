namespace exercise605
{
    public class Solution
    {
        public bool CanPlaceFlowers(int[] flowerbed, int n)
        {
            for (int i = 0; i < flowerbed.Length; i++)
            {
                if (flowerbed.Length == 1)
                {
                    if (flowerbed[i] == 0)
                    {
                        flowerbed[i] = 1;
                        n -= 1;
                    }
                }

                else if (i == 0)
                {
                    if (flowerbed[i] == 0 && flowerbed[i + 1] == 0)
                    {
                        flowerbed[i] = 1;
                        n -= 1;
                    }
                }

                else if (i == flowerbed.Length - 1)
                {
                    if (flowerbed[i] == 0 && flowerbed[i - 1] == 0)
                    {
                        flowerbed[i] = 1;
                        n -= 1;
                    }
                }

                else if (flowerbed[i] == 0 && flowerbed[i - 1] == 0 && flowerbed[i + 1] == 0)
                {
                    flowerbed[i] = 1;
                    n -= 1;
                }

                if (n <= 0)
                    return true;
            }

            return false;
        }
    }
}