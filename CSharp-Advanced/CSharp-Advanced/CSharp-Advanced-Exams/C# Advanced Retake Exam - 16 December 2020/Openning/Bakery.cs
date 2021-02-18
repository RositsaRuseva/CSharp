using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BakeryOpenning
{
    public class Bakery
    {
        private ICollection<Employee> data;
        public Bakery(string name, int capacity)
        {
            this.Name = name;
            this.Capacity = capacity;
            this.data = new List<Employee>();
        }
        public int Capacity { get; set; }
        public string Name { get; set; }

        public int Count => this.data.Count;

        public void Add(Employee employee)
        {
            if (this.data.Count < this.Capacity)
            {
                data.Add(employee);
            }
        }

        public bool Remove(string name)
        {
            var empoloyee = this.data.Where(
                x => x.Name.Contains(name)).FirstOrDefault();
            if (empoloyee != null)
            {
                this.data.Remove(empoloyee);
                return true;
            }
            return false;

            {

            }
        }

        public Employee GetOldestEmployee()
        {
            return this.data.Where(
                x => x.Age == this.data.Max(x => x.Age)).FirstOrDefault();
        }

        public Employee GetEmployee(string name)
        {
            return this.data.Where(
                x => x.Name == name).FirstOrDefault();
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Employees working at Bakery {this.Name}");

            foreach (var employee in this.data)
            {
                sb.AppendLine(employee.ToString());
            }
            return sb.ToString().TrimEnd();

        }

    }
}
