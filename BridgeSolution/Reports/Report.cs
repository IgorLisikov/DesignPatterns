using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeSolution
{
    public abstract class Report  // all interactions with IReportFormat must be through Report class
    {
        private IReportFormat reportFormat;  // bridge

        public Report(IReportFormat reportFormat)
        {
            this.reportFormat = reportFormat;
        }

        public abstract void GetData();

        public void OpenFile()
        {
            reportFormat.OpenFile();
        }
        public void GenerateHeader()
        {
            reportFormat.GenerateHeader();
        }
        public void GenerateBody()
        {
            reportFormat.GenerateBody();
        }
        public void CloseFile()
        {
            reportFormat.CloseFile();

        }

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
