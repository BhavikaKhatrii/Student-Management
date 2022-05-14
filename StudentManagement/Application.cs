using System;
using System.Collections.Generic;
using System.Text;

namespace StudentManagement
{
    class Application
    {
        #region Console Application
        public void ConsoleApp()
        {
            
            Console.WriteLine("1. Add Student");
            Console.WriteLine("2. Add Subject and Marks ");
            Console.WriteLine("3. Exit");
            this.UserChoice();
        }
        #endregion

        #region Public Variable
        public int choice;
        #endregion

        #region Switch case for adding details
        /// <summary>
        /// Method to take input for adding student , marks and subject
        /// </summary>
        public void UserChoice()
        {
            choice = Convert.ToInt32(Console.ReadLine());
            Application menu = new Application();

            switch (choice)
            {
                case 1:
                    addStudent.UserInput();
                    Console.WriteLine("\nStudent added successfully...");
                    menu.ConsoleApp();
                    break;

                case 2:
                    addSubject.addsubject();
                    addSubject.getResult();
                    menu.ConsoleApp();
                    //Console.WriteLine("\n Subject added successfully...");
                    break;

                case 3:
                    Environment.Exit(0);
                    break;

                default:
                    break;
            }
        }
        #endregion

        /// <summary>
        /// Object class of AddStudent and Add Subject
        /// </summary>
        AddStudent addStudent = new AddStudent();
        AddSubject addSubject = new AddSubject();
    }
}
