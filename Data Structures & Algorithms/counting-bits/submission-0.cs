public class Solution {
    public int[] CountBits(int n) {
        return Enumerable.Range(0, n + 1).Select(CountBit).ToArray();
    }

    public int CountBit(int num)
    {
        int count = 0;
        while (num > 0)  
        {
            count += (num & 1) == 1 ? 1 : 0;
            num >>= 1;
        }
        return count;
    }
}
