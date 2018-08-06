/**
 * @param {number[]} nums
 * @return {number}
 */
var removeDuplicates = function(nums) {
    // Base Case
    if(!nums || !nums.length){
        return 0;
    }
    
    var index = 1;
    
    for(var i = 1; i < nums.length; i++){
        if(nums[i] !== nums[i - 1]){
            nums[index] = nums[i];
            index++;
        }
    }
    
    return index;
    
};