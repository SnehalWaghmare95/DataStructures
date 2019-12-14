// 300. Longest Increasing Subsequence

// Input - [10,9,2,5,3,7,101,18]

//recursive apporach

public int LongestIncreasingSubSequence(int[] nums){
  int prev = Int32.MinValue;
  int current = 0;
  return LIS(nums,prev,current);
}

public int LIS(int[] nums,int prev,int current){
    if(current >= nums.Length)return 0;
    int count = 0;
    if(nums[current] > prev){
      count = 1+LIS(nums,nums[current],current+1);
    }
    int notMatch = LIS(nums,prev,current+1);
    return Math.Max(nonMatch,count);

}

// Time Complexity = O(2^n) and space complexity = O(n^2)

// Dynamic Programming approach
  
  public int LISDynamicProgramming(int[] nums){
  
  int [] dp = new int[nums.Length+1];
    for(int k=0;k<=nums.Legnth;k++){
      dp[k] = 1;
    }
  int max = 0;
    for(int i=1;i<nums.Length;i++){
      for(int j=0;j<i;j++){
        if(nums[i] > nums[j]){
            dp[i] = Math.max(dp[j]+1,dp[i]);
        }
      }
      max = Math.max(max,dp[i]);
    }
    return max;
  }
 // Time complexity - O(n2)
 // space complexity  - O(n)
  

  
