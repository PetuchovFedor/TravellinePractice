using Homework3.Models;

namespace Homework3.Repositories
{
    interface IStudentInGroup
    {
        void AddStudentInGroup( StudentInGroup studentInGroup );
        void DeleteStudentFromGroup( StudentInGroup studentInGroup );
        List<StudentInGroup> GetStudentsFromGroup(int groupId);
    }
}
