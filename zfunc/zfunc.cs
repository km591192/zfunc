using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;

namespace zfunc
{
    class zfunc
    {
        public void zf(RichTextBox rtb, TextBox tb)
        {
            string s = rtb.Text.ToString();
            int n = rtb.Text.Length;
            int l = 0, r = 0;
            int[] zf = new int[10000000];

            for (int i = 1; i < n; ++i)
            {
                /* if (i <= r)
                 {
                     int x = r - i + 1;
                     int y = zf[i - 1];
                     int res = 0;
                     if (x < y) res = x; else res = y;
                     zf[i] = res;
                 }*/
                while (i + zf[i] < n && s[zf[i]] == s[i + zf[i]])
                    ++zf[i];
                /* if (i + zf[i] - 1 > r)
                 {
                     l = i;
                     r = i + zf[i] - 1;
                 }*/
            }

            for (int i = 0; i < n; ++i)
            {
                tb.Text += zf[i].ToString() + "  ";
            }

        }

        public void preff(RichTextBox rtb, TextBox tb)
        {
            string s = rtb.Text.ToString();
            int n = rtb.Text.Length;
            int[] pi = new int[n];
            for (int i = 1; i < n; ++i)
            {
                int j = pi[i - 1];
                while (j > 0 && s[i] != s[j])
                    j = pi[j - 1];
                if (s[i] == s[j]) ++j;
                pi[i] = j;
            }
            for (int i = 0; i < n; ++i)
            {
                tb.Text += pi[i].ToString() + "  ";
            }
        }
    }
}


