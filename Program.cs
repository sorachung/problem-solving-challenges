namespace ProblemSolving
{

  public class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine(String.Join(" ", HackerRank.Solution.compareTriplets(new List<int>() { 5, 6, 7 }, new List<int>() { 3, 6, 10 }))); // expected output: 1, 1
      Console.WriteLine(LeetCode.Solution.LongestCommonPrefix(new string[] { "fl", "flower", "flow" })); // expected output: "fl"

    }
  }

  namespace HackerRank
  {
    public class Solution
    {

      // https://www.hackerrank.com/challenges/compare-the-triplets/problem?isFullScreen=true
      public static List<int> compareTriplets(List<int> a, List<int> b)
      {
        var scores = new List<int>()
        {0,0};
        for (int i = 0; i < a.Count; i++)
        {
          if (a[i] > b[i]) scores[0]++;
          else if (a[i] < b[i]) scores[1]++;
        }
        return scores;
      }
    }

  }

  namespace LeetCode
  {
    public class Solution
    {

      // https://leetcode.com/problems/longest-common-prefix/
      public static string LongestCommonPrefix(string[] strs)
      {
        String prefix = "";
        bool isInPrefix = false;
        for (int j = 0; j < strs[0].Length; j++)
        {
          char c = strs[0][j];
          for (int i = 0; i < strs.Length; i++)
          {
            if (j > strs[i].Length - 1 || c != strs[i][j])
            {
              isInPrefix = false;
              break;
            }
            else
            {
              isInPrefix = true;
            }

          }
          if (isInPrefix)
          {
            prefix += c;
          }
          else
          {
            break;
          }
        }

        return prefix;
      }

      //https://leetcode.com/problems/palindrome-number/
      public static bool IsPalindrome(int x)
      {
        if (x < 0)
        {
          return false;
        }

        String str = x.ToString();
        for (int i = 0; i < str.Length / 2; i++)
        {
          if (str[i] != str[str.Length - 1 - i])
          {
            return false;
          }
        }
        return true;
      }

      //https://leetcode.com/problems/binary-search/
      public static int BinarySearch(int[] nums, int target, int lo, int hi)
      {
        if (hi < lo)
        {
          return -1;
        }

        int mid = lo + (hi - lo) / 2;
        int midValue = nums[mid];
        if (target < midValue)
        {
          return BinarySearch(nums, target, lo, mid - 1);
        }
        else if (target > midValue)
        {
          return BinarySearch(nums, target, mid + 1, hi);
        }
        else
        {
          return mid;
        }
      }


    }
  }
}

