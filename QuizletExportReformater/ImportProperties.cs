using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizletExportReformater
{
    class ImportProperties
    {
        private String termAndDefinationSeparator;
        private bool customTermAndDefinationSeparator;

        private String rowSeparator;
        private bool customRowSeparator;

        public ImportProperties()
        {
            TermAndDefinationSeparator = "\t";
            CustomTermAndDefinationSeparator = false;

            RowSeparator = "\n";
            CustomRowSeparator = false;
        }

        public string TermAndDefinationSeparator { get => termAndDefinationSeparator; set => termAndDefinationSeparator = value; }
        public bool CustomTermAndDefinationSeparator { get => customTermAndDefinationSeparator; set => customTermAndDefinationSeparator = value; }
        public string RowSeparator { get => rowSeparator; set => rowSeparator = value; }
        public bool CustomRowSeparator { get => customRowSeparator; set => customRowSeparator = value; }
    }
}
