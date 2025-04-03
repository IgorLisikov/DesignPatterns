using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeSolution
{
    public interface IReportFormat
    {
        void OpenFile();
        void GenerateHeader();
        void GenerateBody();
        void CloseFile();
    }
}