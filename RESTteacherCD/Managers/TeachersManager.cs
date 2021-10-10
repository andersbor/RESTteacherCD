using System.Collections.Generic;
using System.Linq;
using RESTteacherCD.Models;

namespace RESTteacherCD.Managers
{
    public class TeachersManager
    {
        private static int _nextId = 1;
        private static readonly List<Teacher> Data = new List<Teacher>
        {
            new Teacher() {Id = _nextId++, Name = "Anders"},
            new Teacher {Id=_nextId++, Name = "Morten"}
        };

        public List<Teacher> GetAll()
        {
            return Data;
        }

        public Teacher GetById(int id)
        {
            return Data.FirstOrDefault(teacher => teacher.Id == id);
        }

        public Teacher Add(Teacher teacher)
        {
            teacher.Id = _nextId++;
            Data.Add(teacher);
            return teacher;
        }

        public Teacher Delete(int id)
        {
            Teacher teacher = Data.FirstOrDefault(teacher1 => teacher1.Id == id);
            if (teacher == null) return null;
            Data.Remove(teacher);
            return teacher;
        }
    }
}
