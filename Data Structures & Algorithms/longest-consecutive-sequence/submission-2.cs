public class Solution {
    public int LongestConsecutive(int[] arr) {
        if (arr.Length == 0)
            return 0;
        // Sort the array
        Array.Sort(arr);

        int res = 1, cnt = 1;

        // Find the maximum length by traversing the array
        for (int i = 1; i < arr.Length; i++) {

            // Skip duplicates
            if (arr[i] == arr[i - 1])
                continue;

            // Check if the current element is equal
            // to previous element + 1
            if (arr[i] == arr[i - 1] + 1) {
                cnt++;
            }
            else {
                // Reset the count
                cnt = 1;
            }

            // Update the result
            res = Math.Max(res, cnt);
        }
        return res;
    }
}
