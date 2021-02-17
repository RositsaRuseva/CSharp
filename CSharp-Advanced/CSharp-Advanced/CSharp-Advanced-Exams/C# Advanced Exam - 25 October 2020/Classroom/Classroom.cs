using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassroomProject
{
    public class Classroom
    {
        private ICollection<Student> data;

        public Classroom(int capacity)
        {
            this.Capacity = capacity;
            this.data = new List<Student>();
        }
        public int Capacity { get; set; }
        public int Count
        {
            get => this.data.Count;
        }

        public string RegisterStudent (Student student)
        {
            if (this.data.Count < this.Capacity)
            {
                this.data.Add(student);
                return $"Added student {student.FirstName} {student.LastName}";
            }
            return $"No seats in the classroom";
        }
    
        public string DismissStudent (string firstName, string lastName)
        {
            var student = this.data.Where(
                x => x.FirstName == firstName && x.LastName == lastName)
                .FirstOrDefault();
            if (student!= null)
            {
                this.data.Remove(student);
                return $"Dismissed student {student.FirstName} {student.LastName}";
            }
            return $"Student not found";
        }
        
        public string GetSubjectInfo(string subject)
        {
            StringBuilder sb = new StringBuilder();
            var subjectInfo = this.data.Where(
                x => x.Subject == subject).ToList();
            if (subjectInfo.Count == 0)
            {
                return $"No students enrolled for the subject";
            }
            sb.AppendLine($"Subject: {subject}");
            sb.AppendLine($"Students:");
            foreach (var student in subjectInfo)
            {
                sb.AppendLine($"{student.FirstName} {student.LastName}");
            }
            return sb.ToString().TrimEnd();
        }
    
        public int GetStudentsCount()
        {
            return this.data.Count;
        }

        public Student GetStudent(string firstName, string lastName)
        {
            return data.Where(x => x.FirstName == firstName &&
            x.LastName == lastName).FirstOrDefault();
        }
    }
}
