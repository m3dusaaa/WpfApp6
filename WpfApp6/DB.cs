using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp6
{
    public static class DB
    {
        private static ExamContext instance;
        public static ExamContext Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ExamContext();
                }
                return instance;
            }
        }
    }
}
