using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmploymentPortal
{
    interface ICandidateOperation
    {
        int Register(Icandidate obj);
       List<Icandidate> ViewByJobPosition(string jobposition);
        int NumberOfStudents(string jobposition);
        void CancelRegistration(int id);
    }
}
