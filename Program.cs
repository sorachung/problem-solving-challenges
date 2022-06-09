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
    }
  }
}

