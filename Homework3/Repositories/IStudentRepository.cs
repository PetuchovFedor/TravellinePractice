using Homework3.Models;

namespace Homework3.Repositories
{
    interface IStudentRepository
    {
        void AddStudent( Student student );
        void DeleteStudent( int id );
        Student GetStudent( int id );
        List<Student> GetStudents();
    }
}
