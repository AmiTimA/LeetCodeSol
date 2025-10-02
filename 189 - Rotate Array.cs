//// First Style ////
// Use a secondary array

//// Second Style - Three Reverse ////
// nums = [1,2,3,4,5,6,7] and k = 3, 
//      first we reverse [1,2,3,4], it becomes[4,3,2,1]; 
//      then we reverse[5,6,7], it becomes[7,6,5], 
//      finally we reverse the array as a whole, 
//      it becomes[4,3,2,1,7,6,5] ---> [5,6,7,1,2,3,4].
public class Solution {

    public void Rotate(int[] nums, int k) {
        // Base Case
        if(nums == null || nums.Length <= 1) {
            return;
        }

        // Adjust the k
        if(k < 0 || k >= nums.Length) {
            k = k % nums.Length;

            if(k < 0) {
                k = k + nums.Length;
            }
        }

        if(k == 0) {
            return;
        }

        // Reverse first part
        Reverse(nums, 0, nums.Length - k - 1);
        Reverse(nums, nums.Length - k, nums.Length - 1);
        Reverse(nums, 0, nums.Length - 1);
    }

    public void Reverse(int[] nums, int start, int end) {

        int times = ((end - start) / 2 ) + 1;
        for(int i = 0; i < times; i++) {
            int temp = nums[start];
            nums[start] = nums[end];
            nums[end] = temp;

            start++;
            end--;
        }
    }
}


//// Third Style ////
// In place replace
public void Rotate(int[] arr, int k)
{
    if (arr == null || arr.Length <= 0)
    {
        return;
    }

    int length = arr.Length;

    if (k < 0 || k >= length)
    {
        k %= length;

        if (k < 0)
        {
            k += length;
        }
    }

    if (k == 0)
    {
        return;
    }

    int tmp = 0;

    for (int v = 0, c = 0; c < length; v++)
    {
        int t = v;
        int tp = v + k;
        tmp = arr[v];
        c++;

        while (tp != v)
        {
            arr[t] = arr[tp];
            t = tp;
            tp += k;

            if (tp >= length)
            {
                tp -= length;
            }

            c++;
        }

        arr[t] = tmp;
    }
}