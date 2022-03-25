using Homework3.Models;
using Homework3.Repositories;

namespace Homework3
{
    class Program
    {
        private static string _connectionString = @"Data Source=WIN-0PO8TPIL1T4\SQLEXPRESS;Initial Catalog=University;Pooling=true;Integrated Security=SSPI";

        static void Main( string[] args )
        {
            IStudentRepository studentRepository = new StudentRawSqlRepository( _connectionString );
            IGroupRepository groupRepository = new GroupRawSqlRepository( _connectionString );
            IStudentInGroup studentInGroupRepository = new StudentInGroupRawSqlRepository(_connectionString );

            Console.WriteLine( "Available commands:" );
            Console.WriteLine( "get-students - show a list of university students" );
            Console.WriteLine( "add-student - add-student" );
            Console.WriteLine( "add-student-in-group - add studend in group" );
            Console.WriteLine( "delete-student-from-group - delete student from group" );
            Console.WriteLine( "delete-student - delete student" );
            Console.WriteLine( "get-students-from-group - show a list of students in a group" );
            Console.WriteLine( "get-groups - show a list of university groups" );
            Console.WriteLine( "add-group - add group" );
            Console.WriteLine( "delete-group - delete group" );
            Console.WriteLine( "exit - exit the app" );

            while ( true )
            {
                string command = Console.ReadLine();

                if ( command == "get-students" )
                {
                    List<Student> students = studentRepository.GetStudents();
                    if (students.Count == 0)
                    {
                        Console.WriteLine( "Students have not been added yet" );
                        continue;
                    }
                    foreach ( Student student in students )
                    {
                        Console.WriteLine( $"Id: {student.Id}, Name: {student.Name}" );
                    }
                }
                else if ( command == "add-student" )
                {
                    Console.WriteLine( "Enter the student's name" );
                    string name = Console.ReadLine();
                    if ( String.IsNullOrEmpty( name ) )
                    {
                        Console.WriteLine( "Name cannot be empty" );
                    }
                    studentRepository.AddStudent( new Student
                    {
                        Name = name
                    } );
                    Console.WriteLine( "Success" );
                }
                else if ( command == "delete-student" )
                {
                    Console.WriteLine( "Enter the student's id" );
                    int studentId = int.Parse( Console.ReadLine() );
                    var student = studentRepository.GetStudent( studentId );
                    if ( student == null )
                    {
                        Console.WriteLine( "Student not found" );
                        continue;
                    }

                    studentRepository.DeleteStudent( student.Id );
                    Console.WriteLine( "Success" );
                }
                else if ( command == "get-groups" )
                {
                    List<Group> groups = groupRepository.GetGroups();
                    if (groups.Count == 0)
                    {
                        Console.WriteLine( "Groups haven't been added yet" );
                        continue;
                    }
                    foreach ( Group group in groups )
                    {
                        Console.WriteLine( $"Id: {group.Id}, Name: {group.Name}" );
                    }
                }
                else if ( command == "add-group" )
                {
                    Console.WriteLine( "Enter the group's name" );
                    string name = Console.ReadLine();
                    if ( String.IsNullOrEmpty( name ) )
                    {
                        Console.WriteLine( "Name cannot be empty" );
                    }
                    groupRepository.AddGroup( new Group
                    {
                        Name = name
                    } );
                    Console.WriteLine( "Success" );
                }
                else if ( command == "delete-group" )
                {
                    Console.WriteLine( "Enter the group's id" );
                    int groupId = int.Parse( Console.ReadLine() );
                    var group = groupRepository.GetGroup( groupId );
                    if ( group == null )
                    {
                        Console.WriteLine( "Group not found" );
                        continue;
                    }

                    groupRepository.DeleteGroup( group.Id );
                    Console.WriteLine( "Success" );
                }
                else if (command == "add-student-in-group")
                {
                    Console.WriteLine( "Enter the student's id" );
                    int studentId = int.Parse(Console.ReadLine());
                    var student = studentRepository.GetStudent( studentId );
                    if ( student == null )
                    {
                        Console.WriteLine( "Student not found" );
                        continue;
                    }
                    Console.WriteLine( "Enter the group's id" );
                    int groupId = int.Parse(Console.ReadLine() );
                    var group = groupRepository.GetGroup(groupId);
                    if ( group == null )
                    {
                        Console.WriteLine("Group not found");
                        continue;
                    }
                    List<StudentInGroup> studentInGroups = studentInGroupRepository.GetStudentsFromGroup(groupId);
                    if ((studentInGroups.Exists(x => x.StudentId == studentId)) & (studentInGroups.Exists(x => x.GroupId == groupId)))
                    {
                        Console.WriteLine( "This student has already been added to the group" );
                    }
                    studentInGroupRepository.AddStudentInGroup( new StudentInGroup
                    { 
                        StudentId = studentId,
                        GroupId = groupId
                    });
                    Console.WriteLine( "Success" );
                }
                else if (command == "delete-student-from-group" )
                {
                    Console.WriteLine( "Enter the student's id" );
                    int studentId = int.Parse( Console.ReadLine() );
                    var student = studentRepository.GetStudent( studentId );
                    if ( student == null )
                    {
                        Console.WriteLine( "Student not found" );
                        continue;
                    }
                    Console.WriteLine( "Enter the group's id" );
                    int groupId = int.Parse( Console.ReadLine() );
                    var group = groupRepository.GetGroup( groupId );
                    if ( group == null )
                    {
                        Console.WriteLine( "Group not found" );
                        continue;
                    }
                    studentInGroupRepository.DeleteStudentFromGroup( new StudentInGroup
                    {
                        StudentId = studentId,
                        GroupId = groupId
                    } );
                    Console.WriteLine( "Success" );
                }
                else if (command == "get-students-from-group" )
                {
                    Console.WriteLine( "Enter the group's id" );
                    int groupId = int.Parse( Console.ReadLine());
                    Student student = new Student();
                    List<StudentInGroup> studentsInGroup = studentInGroupRepository.GetStudentsFromGroup(groupId);
                    if (studentsInGroup.Count == 0)
                    {
                        Console.WriteLine( "Students are not added to this group" );
                    }
                    foreach ( StudentInGroup studentInGroup in studentsInGroup )
                    {
                        student = studentRepository.GetStudent( studentInGroup.StudentId );
                        Console.WriteLine( $"Id: {studentInGroup.StudentId}, name: {student.Name}" );
                    }
                }
                else if ( command == "exit" )
                {
                    return;
                }
                else
                {
                    Console.WriteLine( "Comand not found" );
                }
            }
        }
    }
}
