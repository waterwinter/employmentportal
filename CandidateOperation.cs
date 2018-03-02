using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmploymentPortal
{
        class CandidateOperation :ICandidateOperation
    {

        List<Icandidate> icanlst = new List<Icandidate>();



        public int Register(Icandidate obj)
        {
            icanlst.Add(obj);
            return obj.CandidateId1;
        }
       public List<Icandidate> ViewByJobPosition(string jobposition)
       {
         List<Icandidate> templist = new List<Icandidate>();
          foreach(Icandidate ican in icanlst)
            {
                if(ican.JobPosition1==jobposition)
                {
                    templist.Add(ican);
                }
            }
            return templist;
       }
       public int NumberOfStudents(string jobposition)
        {
            int count = 0;
            List<Icandidate> templist1 = new List<Icandidate>();
            foreach(Icandidate ican1 in icanlst)
            {
                if(ican1.JobPosition1==jobposition)
                {
                 templist1.Add(ican1);
                    count++;
                }
                
            }
            return count;
        }
       public void CancelRegistration(int id)
        {
            foreach(Icandidate ic in icanlst)
            {
                if(ic.CandidateId1==id)
                {
                    icanlst.Remove(ic);
                    Console.WriteLine("Your account is deactivate");
                }
            }
        }
    }
}
