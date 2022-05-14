using System;
using System.Collections.Generic;
using System.Text;

namespace StudentManagement
{
    class AddStudent
    {
        #region List
        /// <summary>
        /// Creating list to store Student Roll Number and STudent Name 
        /// </summary>
        List<int> roll_no = new List<int>();
        List<string> Name = new List<string>();
        #endregion

        /// <summary>
        /// Public Variables
        /// </summary>
        public string name;
        public int count = 101;

        #region Roll Number
        /// <summary>
        /// Incremention of roll number
        /// </summary>
        /// <returns></returns>
        public int Roll_no()
        { 
            return count++; 
        }
        #endregion

        /// <summary>
        /// Input values from user
        /// </summary>
        public void UserInput()
        {
            Console.WriteLine("Enter number of students want to add: ");
            int noOfStudents = Convert.ToInt32(Console.ReadLine());

            for(int i = 0; i < noOfStudents; i++)
            {
                roll_no.Add(Roll_no());

                Console.WriteLine("Enter Name: ");
                name = Console.ReadLine();
                Name.Add(name);
            }
            
        }

    }
}
