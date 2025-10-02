public class Solution564
{
    public int MaxProfit(int[] prices)
    {
        // Base Case
        if (prices == null || prices.Length <= 1)
        {
            return 0;
        }

        int min = 0;
        int max = 0;
        int result = 0;
        int index = 0;

        while (index < prices.Length - 1)
        {

            // Find local minimum
            while (index < prices.Length - 1 && prices[index] >= prices[index + 1])
            {
                index++;
            }

            // Break if we have reached end
            if (index == prices.Length - 1)
            {
                return result;
            }

            // Save min value
            min = index++;

            // Find local maximum
            while (index < prices.Length && prices[index] >= prices[index - 1])
            {
                index++;
            }

            max = index - 1;

            result = result + prices[max] - prices[min];
        }

        return result;
    }
}