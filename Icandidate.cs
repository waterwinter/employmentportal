using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmploymentPortal
{
    interface Icandidate
    {
        int CandidateId1 { get; set; }
        string Name1 { get; set; }
        DateTime DOB1 { get; set; }
        string Gender1 { get; set; }
        string City1 { get; set; }
        double UGPercentage1 { get; set; }
        string JobPosition1 { get; set; }
    }
}
