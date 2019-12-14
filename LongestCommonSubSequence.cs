// 1143. Longest Common Subsequence

// lets solve this problem using recursion first.

// Input - Text1 = "abcde" ;Text2 ="ace"

public class int LongestCommonSubsequence(String s1,String s2){
  int len1 = s1.Length-1;
  int len2 = s2.Length-1;
  int result = LongestcommonSubsequenceRecursion(s1,s2len1,len2);
}

public class int LongestcommonSubsequenceRecursion(String s1,String s2,int len1,int len2){
    if(len1==0 || len2==0)return 0;
    if(s1[len1] == s2[len2]){
        return LongestcommonSubsequenceRecursion(s1,s2,len1-1,len2-1);
    }
    else{
        return Math.Max(LongestcommonSubsequenceRecursion(s1,s2,len1-1,len2),LongestcommonSubsequenceRecursion(s1,s2,len1,len2-1));
    }
}

// Time complexity - O(2^(m+n)) where m= length of first string and n= length of the second string
// space complexity O(m+n)


public class int LongestCommonSubsequenceDnymicProgramming(String s1,String s2,int l1,int l2){
    int[,] mat =  new int[l1+1,l2+1];
    for(int i=1;i<=l1;i++){
      for(int j=1;j<=l2;j++){
        if(s1[i-1]==s2[j-1]){
          mat[i,j] = mat[i-1,j-1]+1;
        }
        else{
          mat[i,j] = mat[i-1,j] +mat[i,j-1];
        }
      }
    }
    return mat[l1,l2];
}

// m= length of the first string n = length of second string
// TimeComplexity - O(m*n) 
// space complexity - O(m*n)
