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
    }
}
