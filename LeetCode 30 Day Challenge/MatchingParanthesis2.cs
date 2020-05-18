//using System;
//using System.Text.RegularExpressions;

//namespace LeetCode_30_Day_Challenge
//{
//    class Program
//    {

//        static void Main(string[] args)
//        {
//            Console.WriteLine("Hello World!");
//            string s = "((((()(()()()*()(((((*)()*(**(())))))(())()())(((())())())))))))(((((())*)))()))(()((*()*(*)))(*)()";
//            bool isValid = CheckValidString(s);
//        }

//        private static bool CheckValidString(string s)
//        {
//            if (s.Length > 0 && (s[0] == '(' || s[0] == '*') && (s[s.Length - 1] == ')' || s[s.Length - 1] == '*') && (s.Contains('(') || s.Contains(')')))
//            {
//                while (s.Contains("()"))
//                {
//                    s = s.Replace("()", string.Empty);
//                }
//                int leftPCountp = 0;
//                int rightPCountp = 0;
//                foreach (char chr in s)
//                {
//                    if (chr == '(')
//                        leftPCountp++;
//                    else if (chr == ')')
//                        rightPCountp++;
//                }
//                if (leftPCountp == rightPCountp)
//                    return true;
//                bool isValid = true;
//                string pattern = @"\({1,}\*{1,}\){1,}";
//                Regex rgx = new Regex(pattern);
//                while (rgx.IsMatch(s))
//                {
//                    Match match = Regex.Match(s, pattern);
//                    int leftPCount = 0;
//                    int rightPCount = 0;
//                    int starCount = 0;
//                    foreach (char chr in match.Value)
//                    {
//                        if (chr == '(')
//                            leftPCount++;
//                        else if (chr == ')')
//                            rightPCount++;
//                        else
//                            starCount++;
//                    }
//                    int max = Math.Max(leftPCount, rightPCount);
//                    int min = Math.Min(leftPCount, rightPCount);
//                    if (min + starCount >= max)
//                    {
//                        s = rgx.Replace(s, string.Empty, 1);
//                        isValid = isValid && true;
//                    }
//                    else
//                    {
//                        isValid = isValid && false;
//                        break;
//                    }
//                }
//                if (!string.IsNullOrWhiteSpace(s) && isValid == true)
//                {
//                    string patternRm = @"^[(*]{1,}.*[*)]$";
//                    Regex rgxRm = new Regex(patternRm);
//                    if (rgxRm.IsMatch(s))
//                    {
//                        int leftPCount = 0;
//                        int rightPCount = 0;
//                        int starCount = 0;
//                        foreach (char chr in s)
//                        {
//                            if (chr == '(')
//                                leftPCount++;
//                            else if (chr == ')')
//                                rightPCount++;
//                            else
//                                starCount++;
//                        }
//                        int max = Math.Max(leftPCount, rightPCount);
//                        int min = Math.Min(leftPCount, rightPCount);
//                        if (min + starCount >= max)
//                            isValid = isValid && true;
//                        else
//                            isValid = isValid && false;
//                    }
//                    else
//                    {
//                        isValid = isValid && false;
//                    }

//                }
//                return isValid;
//            }
//            else if (s == string.Empty)
//                return true;
//            else if (!s.Contains('(') && !s.Contains(')'))
//                return true;
//            return false;
//        }
//    }
//}
