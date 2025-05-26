public class Solution {
    public int LargestAltitude(int[] gain) {
        int largestAltitude = 0;
        int altitudeSum = 0;

        foreach(int item in gain){
            altitudeSum+=item;
            if(altitudeSum > largestAltitude)
                largestAltitude = altitudeSum;
        }

        return largestAltitude;
    }
}
