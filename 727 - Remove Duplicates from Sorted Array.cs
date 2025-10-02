// First Style
public class Solution {
    public int RemoveDuplicates(int[] nums) {
        // Base Case
        if(nums == null || nums.Length == 0){
            return 0;
        }
        
        int index = 1;
        
        for(int i = 1; i < nums.Length; i++){
            if(nums[i - 1] != nums[i]){
                nums[index] = nums[i];
                index++;
            }
        }
        
        return index;
    }
}

// Second Style
public class Solution {
    public int RemoveDuplicates(int[] nums) {
        // Base Case
	    if(nums == null) {
		    return 0;
	    }
	    if(nums.Length <= 1) {
		    return nums.Length;
	    }
	
	    int first = 0;
	    int second = 0;
	
	    while(second < nums.Length - 1) {
		    second++;
		    if(nums[first] != nums[second]) {
			    first++;
			    nums[first] = nums[second];
		    }
	    }
        
        return first + 1;
    }
}