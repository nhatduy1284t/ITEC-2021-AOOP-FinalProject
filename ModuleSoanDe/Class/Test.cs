using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleSoanDe.Class
{
    class ScoreDescendingComparer : IComparer<Test>
    {
        public int Compare(Test t1, Test t2)
        {
            int result = DateTime.Compare(Convert.ToDateTime(t1.Date), Convert.ToDateTime(t2.Date));
            if(result !=0)
            {
                return -1;
            }
            if (t1.Score > t2.Score) // giữ nguyên
                return -1;
            if (t1.Score < t2.Score) // swap
                return +1;
            return 0;
        }
    }
    class DateDescendingComparer : IComparer<Test>
    {
        public int Compare(Test t1, Test t2)
        {
            int result = DateTime.Compare(Convert.ToDateTime(t1.Date), Convert.ToDateTime(t2.Date));
            if (result < 0) // giữ nguyên
                return -1;
            if (result > 0) // swap
                return +1;
            return 0;
        }
    }
    class Test
    {
        public List<string> lstAnswer = new List<string>();
        public string Name;
        public string Id;
        public string Date;
        public string Code;
        public int NumberOfTrueAnswer=0;
        public int Score;

        
    }
}
