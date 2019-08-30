using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Infragistics.Web;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1 ()
        {
            InitializeComponent();
        }
        
        // leetcode NO.1
        private void button1_Click (object sender, EventArgs e)
        {
            int[] nums = { 2, 7, 11, 15 };
            int target = 9;
            getAnswer(nums, target);
        }

        private int[] getAnswer(int[] nums, int target)
        {
            int[] answer = new int[2];
            for(int outerCount = 0; outerCount < nums.Length; outerCount++)
            {
                for(int innerCount = outerCount + 1; innerCount < nums.Length; innerCount++)
                {
                    if (nums[outerCount] + nums[innerCount] == target)
                    {
                        answer[0] = outerCount;
                        answer[1] = innerCount;
                        break;
                    }
                }
            }
            return answer;
        }

        // leetcode No.7
        private void button2_Click (object sender, EventArgs e)
        {
            int a = 120;
            getReverse(a);
        }

        private int getReverse(int x)
        {
            string a = x.ToString();
            string b = "";
            bool flag = false;
            for(int count = a.Length; count > 0; count--)
            {
                if (count == a.Length && a[count - 1] == '0')
                {

                }
                else if (count == 1 && a[count - 1] == '-')
                {
                    flag = true;
                }
                else
                {
                    b += a[count - 1].ToString();
                }
            }
            int c = 0;
            c = int.Parse(b);
            if (flag == true)
            {
                c = c * (-1);
            }
            return c;
        }

        // leetcode No.9
        private void button3_Click (object sender, EventArgs e)
        {
            IsPalindrome(10);
        }

        private bool IsPalindrome (int x)
        {
            bool answer = false;
            string str = x.ToString();
            string a = String.Empty;
            for (int count = str.Length; count > 0; count--)
            {
                a += str[count - 1].ToString();
            }
            if(str == a)
            {
                answer = true;
            }
            return answer;
        }

        /// <summary>
        /// leetcode No.13
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Click (object sender, EventArgs e)
        {
            string s = "MCMXCIV";
            RomanToInt(s);
        }

        /// <summary>
        /// RomanToInt
        /// </summary>
        /// <param name="s">string</param>
        /// <returns>int</returns>
        private int RomanToInt(string s)
        {
            int answer = 0;
            char previous = 'a';
            // 1文字ごと回す
            for(int count = 0; count < s.Length; count++)
            {
                // 1つ前の文字を照合
                char current = s[count];
                switch(current)
                {
                    // 今がI
                    case 'I':
                        answer++;
                        break;
                    // 今がV
                    case 'V':
                    // 今がVで1つ前がIの場合4
                        if (previous == 'I')
                        {
                            answer -= 1;
                            answer += 4;
                        }
                        else
                        {
                            answer += 5;
                        }
                        break;
                    // 今がX
                    case 'X':
                        // 今がXで1つ前がIの場合9
                        if (previous == 'I')
                        {
                            answer -= 1;
                            answer += 9;
                        }
                        else
                        {
                            answer += 10;
                        }
                        break;
                    // 今がL
                    case 'L':
                        // 今がLで1つ前がXの場合40
                        if (previous == 'X')
                        {
                            answer -= 10;
                            answer += 40;
                        }
                        else
                        {
                            answer += 50;
                        }
                        break;
                    // 今がC
                    case 'C':
                        // 今がCで1つ前がXの場合90
                        if(previous == 'X')
                        {
                            answer -= 10;
                            answer += 90;
                        }
                        else
                        {
                            answer += 100;
                        }
                        break;
                    // 今がD
                    case 'D':
                        // 今がDで1つ前がCの場合400
                        if (previous == 'C')
                        {
                            answer -= 100;
                            answer += 400;
                        }
                        else
                        {
                            answer += 500;
                        }
                        break;
                    // 今がM
                    case 'M':
                        // 今がMで1つ前がCの場合900
                        if (previous == 'C')
                        {
                            answer -= 100;
                            answer += 900;
                        }
                        else
                        {
                            answer += 1000;
                        }
                        break;
                }
                // 現在の文字を保存
                previous = current;
            }
            return answer;
        }


        /// <summary>
        /// leetcode No.14
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button5_Click (object sender, EventArgs e)
        {
            string[] strs = { "flower", "flow", "flight" };
            LongestCommonPrefix(strs);
        }

        /// <summary>
        /// LongestCommonPrefix
        /// </summary>
        /// <param name="strs">string[]</param>
        /// <returns>string</returns>
        private string LongestCommonPrefix(string[] strs)
        {
            string answer = "";
            // 一番目の文字数で回す
            for(int outerCount = 0; outerCount < strs[0].Length; outerCount++)
            {   
                string current0 = strs[0][outerCount].ToString();
                bool flag = true;
                // 配列の数で回す
                for(int innerCount = 1; innerCount < strs.Length; innerCount++)
                {
                    if(current0 != strs[innerCount][outerCount].ToString())
                    {
                        flag = false;
                        break;
                    }
                }
                if(flag == true)
                {
                    answer += current0;
                }
                else
                {
                    break;
                }

            }
            return answer;
        }

        //private bool IsSymmetric(TreeNode root)
        //{

        //}

        //private void button6_Click (object sender, EventArgs e)
        //{

        //}

        //private ListNode MargeTwoLists(ListNode l1, ListNode l2)
        //{
        //    var res = new ListNode(0);
        //    var head = res;

        //    while (l1 != null && l2 != null)
        //    {
        //        res.next = new ListNode(0);
        //        res = res.next;

        //        if (l1.val <= l2.val)
        //        {
        //            res.val = l1.val;
        //            l1 = l1.next;
        //        }
        //        else
        //        {
        //            res.val = l2.val;
        //            l2 = l2.next;
        //        }
        //    }

        //    if (l1 != null)
        //    {
        //        res.next = l1;
        //    }
        //    else
        //    {
        //        res.next = l2;
        //    }
        //}
    }
}
