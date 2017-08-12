using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizletExportReformater
{
    class QuizletList
    {
        private List<String> terms;
        private List<String> definations;

        public QuizletList()
        {
            terms = new List<string>();
            definations = new List<string>();
        }

        public QuizletList(List<String> terms, List<String> definations)
        {
            this.terms = terms;
            this.definations = definations;
        }

        public List<string> Terms { get => terms; set => terms = value; }
        public List<string> Definations { get => definations; set => definations = value; }
    }
}
