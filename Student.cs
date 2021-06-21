using System;
using System.Collections.Generic;
using System.Text;

namespace Slotkin_StudentClassDemo
{
    class Student 
    {
        private string name;
        private int idNumber;
        private double score1;
        private double score2;
        private double averageScore;

        public string GetName()
        {
            return this.name;
        }

        public void SetName(string newName)
        {
            this.name = newName;
        }

        public int GetIdNumber()
        {
            return this.idNumber;
        }

        public void SetIdNumber(int newIdNumber)
        {
            this.idNumber = newIdNumber;
        }

        public double GetScore1()
        {
            return this.score1;
        }

        public void SetScore1(double newScore1)
        {
            this.score1 = newScore1;
            UpdateAverageScore();
        }

        public double GetScore2()
        {
            return this.score2;
        }

        public void SetScore2(double newScore2)
        {
            this.score2 = newScore2;
            UpdateAverageScore();
        }

        public double GetAverageScore()
        {
            return this.averageScore;
        }

        private void UpdateAverageScore()
        {
            this.averageScore = (score1 + score2) / 2;
        }

        public double GetHighScore()
        {
            if (score1 > score2)
            {
                return score1;
            }
            else
            {
                return score2;
            }
        }


        public Student()
        {

        }

        public static void DoStuff()
        {
            Student molly = new Student();
            molly.name = "Molly";
            molly.idNumber = 42;
            Console.WriteLine("Molly: {0}", molly.name);
            Console.WriteLine("Molly: {0}", molly.idNumber);

            Student someStudent = new Student();
            someStudent.name = "Unknown";
            someStudent.idNumber = -1;
            Console.WriteLine("someStudent: {0}", someStudent.name);
            Console.WriteLine("someStudent: {0}", someStudent.idNumber);

        }
    }
}
