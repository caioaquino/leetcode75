public class Solution {
    public IList<bool> KidsWithCandies(int[] candies, int extraCandies) {
        var result = new List<bool>();

        foreach(var candie in candies){
            result.Add(candies.All(x => candie+extraCandies >= x));
        }

        return result;
    }
}
