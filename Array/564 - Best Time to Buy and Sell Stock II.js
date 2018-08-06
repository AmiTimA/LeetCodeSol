/**
 * @param {number[]} prices
 * @return {number}
 */
var maxProfit = function(prices) {
    // Base Case
    if(!prices || prices.length <= 1) {
        return 0;
    }
    
    var min = 0;
    var max = 0;
    var profit = 0;
    var index = 0;
    
    while (index < prices.length - 1) {
        // Find local minimum
        while (index < prices.length - 1 && prices[index] >= prices[index + 1]){
            index++;
        }
        
        // Check if we reached end
        if(index === prices.length - 1) {
            return profit;
        }
        
        // Save minimum index
        min = index++;
        
        // Find local maximum
        while(index < prices.length && prices[index] >= prices[index - 1]) {
            index++;
        }
        
        max = index - 1;
        
        profit = profit + prices[max] - prices[min];
    }
    
    return profit;
    
};