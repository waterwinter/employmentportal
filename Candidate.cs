using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmploymentPortal
{
    class Candidate:Icandidate
    {
        int CandidateId;
        string Name;
        DateTime DOB;
        string Gender;
        string City;
        double UGPercentage;
        string JobPosition;
       static int AutoId = 5000;
        public string Name1
        {
            get
            {
                return Name;
            }

            set
            {
                Name = value;
            }
        }

        public DateTime DOB1
        {
            get
            {
                return DOB;
            }

            set
            {
                DOB = value;
            }
        }

        public string Gender1
        {
            get
            {
                return Gender;
            }

            set
            {
                Gender = value;
            }
        }

        public string City1
        {
            get
            {
                return City;
            }

            set
            {
                City = value;
            }
        }

        public double UGPercentage1
        {
            get
            {
                return UGPercentage;
            }

            set
            {
                UGPercentage = value;
            }
        }

        public string JobPosition1
        {
            get
            {
                return JobPosition;
            }

            set
            {
                JobPosition = value;
            }
        }

        public int CandidateId1
        {
            get
            {
                return CandidateId;
            }

            set
            {
                CandidateId = value;
            }
        }

        public Candidate(string name, DateTime dOB, string gender, string city, double uGPercentage, string jobPosition)
        {
            Name1 = name;
            DOB1 = dOB;
            Gender1 = gender;
            City1 = city;
            UGPercentage1 = uGPercentage;
            JobPosition1 = jobPosition;

            CandidateId1 = AutoId++;
        }
    }
}
