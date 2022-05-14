using System;
using System.Collections.Generic;
using System.Text;

namespace StudentManagement
{
    class AddSubject
    {
        /// <summary>
        /// Public Variables
        /// </summary>
        public string subjectName;
        public int noOfSubject;
        public int subjectMarks;
        public int sum=0;
        public int result = 0;
        
        /// <summary>
        /// List for Storing Subject and Marks
        /// </summary>
        List<string> subject = new List<string>();
        List<int> marks = new List<int>();

        public void addsubject()
        {
            Console.WriteLine("Enter no of subject want to add: ");
            noOfSubject = Convert.ToInt32(Console.ReadLine());

            for(int i = 1; i <= noOfSubject; i++)
            {
                Console.WriteLine("Enter {0} subject", i);
                subjectName = Console.ReadLine();
                subject.Add(subjectName);

                Console.Write("Enter Marks: ");
                subjectMarks = Convert.ToInt32(Console.ReadLine());
                marks.Add(subjectMarks);
            }
        }
        
        public void getResult()
        {
            foreach(int i in marks)
            {
                sum += i;
            }
            result = sum / noOfSubject;
            Console.WriteLine(result + "%");

            if(result <= 40)
            {
                Console.WriteLine("D");
            }
            else if(result >40 || result <= 60)
            {
                Console.WriteLine("C");
            }
            else if(result>60 || result <= 80)
            {
                Console.WriteLine("B");
            }
            else if(result>80 || result <= 100)
            {
                Console.WriteLine("A");
            }
        }
    }
}
