using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmploymentPortal
{
    class Program
    {
        static void Main(string[] args)
        {
            CandidateOperation canopobj = new CandidateOperation();
            int choice = 0;
            do
            {
            Console.WriteLine("***********Menu*************");
            Console.WriteLine("1.Registration");
            Console.WriteLine("2.View all candidates");
            Console.WriteLine("3.View Number of student registered for specific job");
            Console.WriteLine("4.Cancel the Registration");
            Console.WriteLine("Enter your choice");
             choice = Convert.ToInt32(Console.ReadLine());

           
                switch(choice)
                {
             
                    case 1:
                        Console.WriteLine("enter your name");
                        string Name = Console.ReadLine();
                        Console.WriteLine("Enter your DOB");
                        DateTime DOB = Convert.ToDateTime(Console.ReadLine());
                        Console.WriteLine("Enter Gender");
                        string Gender = Console.ReadLine();
                        Console.WriteLine("Enter your City");
                        string City = Console.ReadLine();
                        Console.WriteLine("Enter your UG Percentage");
                        double UGPercentage = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Enter Job Position(ASET,ASE,SE,ITA)");
                        string jobposition = Console.ReadLine();
                        string JobPosition = jobposition.ToUpper();
                        if (JobPosition == "ASET" || JobPosition == "ASE" || JobPosition == "SE" || JobPosition == "ITA")
                        {
                            Candidate canobj = new Candidate(Name, DOB, Gender, City, UGPercentage, JobPosition);
                            int CandidateId = canopobj.Register(canobj);
                            Console.WriteLine("Candidate id is" + CandidateId);
                        }
                        else
                            Console.WriteLine("you have entered wrong job position");
                        Console.ReadKey();
                        break;

                    case 2:
                        Console.WriteLine("Enter the position to Search");
                        string position = Console.ReadLine();
                        string Position = position.ToUpper();
                        if (Position == "ASET" || Position == "ASE" || Position == "SE" || Position == "ITA")
                        {
                            List<Icandidate> icanlst = canopobj.ViewByJobPosition(Position);
                            foreach (Icandidate ican in icanlst)
                            {
                                Console.WriteLine("Name   "  +ican.Name1);
                                Console.WriteLine("dob  "  +ican.DOB1);
                                Console.WriteLine("Gender  " +ican.Gender1);
                                Console.WriteLine("City  "  +ican.City1);
                                Console.WriteLine("UGPercentage  "  +ican.UGPercentage1);
                                Console.WriteLine("Job Position  "  +ican.JobPosition1);
                             }

                        }
                        else
                            Console.WriteLine("you entered wrong position");
                        
                    
                        break;


                    case 3:
                        Console.WriteLine("Enter the job position");
                        string jposition = Console.ReadLine().ToUpper();
                        int noofstudent=0;
                        if (jposition == "ASET" || jposition == "ASE" || jposition == "SE" || jposition == "ITA")
                        {
                           noofstudent = canopobj.NumberOfStudents(jposition);
                        }

                        Console.WriteLine("total count of student is " + noofstudent);

                        break;


                    case 4:
                        Console.WriteLine("Enter the id to delete the records");
                        int id = Convert.ToInt32(Console.ReadLine());
                        canopobj.CancelRegistration(id);
                        break;
                }

            } while (choice<5);
            Console.ReadKey();
        }
       
    }
}
