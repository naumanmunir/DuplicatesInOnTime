using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximumProduct
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = {-1,-2,1,2,3};

            //MaximumProduct(nums);
            string[] emails = { "j+ezsorqlmc@rfpycgjuf.com", "j+k+ri+rigt.ad@rfpycgjuf.com", "hfmeqzk.isx+i@fiidmdrsu.com", "j+p+h+d+d+p+z.j.k.g@rfpycgjuf.com", "zygekdy.l.w+s@snh.owpyu.com", "j+m.l+ia+qdgv+w@rfpycgjuf.com", "r+hwbjwefkp@wcjaki.n.com", "zygekdy.l.w+d@snh.owpyu.com", "bizdm+sz.f.a.k@il.cjjlp.com", "hfmeqzk.isx+t@fiidmdrsu.com", "hfmeqzk.isx+i@fiidmdrsu.com", "bizdm+f+j+m.l.l@il.cjjlp.com", "zygekdy.l.w+g@snh.owpyu.com", "r+evgvxmksf@wcjaki.n.com", "hfmeqzk.isx+h@fiidmdrsu.com", "bizdm+lov+cy@il.cjjlp.com", "hfmeqzk.isx+o@fiidmdrsu.com", "bizdm+hs+qao@il.cjjlp.com", "r+v+z+rcuznrj@wcjaki.n.com", "j+r.kn+h.w.a.h+bh@rfpycgjuf.com", "hfmeqzk.isx+t@fiidmdrsu.com", "hfmeqzk.isx+a@fiidmdrsu.com", "zygekdy.l.w+o@snh.owpyu.com", "zygekdy.l.w+i@snh.owpyu.com", "r+vy.u.y+f.er+aw@wcjaki.n.com", "zygekdy.l.w+c@snh.owpyu.com", "bizdm+wztzg@il.cjjlp.com", "j+h.fwbsr+chp@rfpycgjuf.com", "zygekdy.l.w+s@snh.owpyu.com", "zygekdy.l.w+d@snh.owpyu.com", "bizdm+qq.o.q+p@il.cjjlp.com", "zygekdy.l.w+o@snh.owpyu.com", "j+c+zqbq+h.dyt@rfpycgjuf.com", "r+hl.b.i+fz.hz.t@wcjaki.n.com", "r+cbabpf.k+w+e@wcjaki.n.com" };

            Console.WriteLine(NumUniqueEmails(emails));

            Console.ReadLine();
        }

        public static int MaximumProduct(int[] nums)
        {
            int ret = 1;

            for (int i = 0; i < nums.Length-1; i++)
            {
                ret *= nums[i];
            }

            string gg = "ggt.weer.";

            Dictionary<string, int> tmp = new Dictionary<string, int>();

            //tmp.co
            return ret;
        }

        public static int NumUniqueEmails(string[] emails)
        {

            Dictionary<string, int> mails = new Dictionary<string, int>();

            for (int i = 0; i < emails.Length; i++)
            {
                var locale = emails[i].Split('@')[0];
                var domain = emails[i].Split('@')[1];

                var t = locale.Any(x=> (


               


                var newEmail = tmpLocalName + "@" + tmpDomain;

                if (mails.ContainsKey(newEmail))
                {
                    mails[newEmail] = 2;
                }
                else
                {
                    mails.Add(newEmail, 1);
                }
            }

            return mails.Count();

        }
    }
}
