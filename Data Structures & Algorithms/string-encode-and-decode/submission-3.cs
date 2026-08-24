public class Solution {

    public string Encode(IList<string> strs) {
        List<string> result = new();
        foreach(var letter in strs)
        {
            result.Add(letter.Length.ToString());
            result.Add("#");
            result.Add(letter);
        }
        return String.Join("", result);
    }

    public List<string> Decode(string s) {
        List<string> result = new();
        int i = 0;
        while (i < s.Length)
        {
            int j = i;
            while (s[j] != '#')
            {
                j++;
            }
            int length = int.Parse(s[i..j]);
            i = j + 1;
            j = i + length;
            result.Add(s[i..j]);
            i = j;
        }
        return result;
   }
}
