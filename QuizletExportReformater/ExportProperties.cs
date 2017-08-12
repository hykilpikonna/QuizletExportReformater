using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizletExportReformater
{
    class ExportProperties : ImportProperties
    {
        private bool showTerm;
        private bool showDefination;
        private bool sort;
        private bool sortAz;

        private bool autoSpace;
        private int spaces;

        private bool changeCase;
        private bool allUpperCase;
        private bool allLowerCase;

        public ExportProperties() : base()
        {
            showTerm = true;
            showDefination = true;
            sort = false;
            sortAz = true;

            autoSpace = false;
            Spaces = 15;

            ChangeCase = false;
            AllUpperCase = true;
            AllLowerCase = false;
        }
       
        public bool ShowTerm { get => showTerm; set => showTerm = value; }
        public bool ShowDefination { get => showDefination; set => showDefination = value; }
        public bool Sort { get => sort; set => sort = value; }
        public bool SortAz { get => sortAz; set => sortAz = value; }
        public bool AutoSpace { get => autoSpace; set => autoSpace = value; }
        public int Spaces { get => spaces; set => spaces = value; }
        public bool ChangeCase { get => changeCase; set => changeCase = value; }
        public bool AllUpperCase { get => allUpperCase; set => allUpperCase = value; }
        public bool AllLowerCase { get => allLowerCase; set => allLowerCase = value; }
    }
}
