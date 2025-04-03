using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeProblem
{
    public abstract class Report
    {
        public abstract void GetData();
        public abstract void OpenFile();
        public abstract void GenerateHeader();
        public abstract void GenerateBody();
        public abstract void CloseFile();

        public void DoReport()
        {
            GetData();
            OpenFile();
            GenerateHeader();
            GenerateBody();
            CloseFile();
        }
    }
}
