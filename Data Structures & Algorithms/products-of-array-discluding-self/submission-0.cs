public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int product = 1,counIntZero = 0;
        foreach(int i in nums)
        {
            if(i != 0)
            {
                product *= i;
            }
            else{
                counIntZero++;
            }
        }

        for(int i = 0;i < nums.Length;i++)
        {
            if(nums[i] == 0)
            {   
                if(counIntZero < 2)
                    nums[i] = product;
                else
                    nums[i] = 0;
            }
            else
            {
                if(counIntZero > 0)
                    nums[i] = 0;
                else 
                    nums[i] = product /nums[i];     
            }
        }

        return nums;
    }
}
