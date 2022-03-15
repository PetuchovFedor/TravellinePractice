using Homework3.Models;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Windows.Input;

namespace Homework3.Repositories
{
    class StudentInGroupRawSqlRepository: IStudentInGroup
    {
        private readonly string _connectionString;

        public StudentInGroupRawSqlRepository( string connectionString )
        {
            _connectionString = connectionString;
        }

        public List<StudentInGroup> GetStudentsFromGroup( int groupId )
        {
            var result = new List<StudentInGroup>();

            using ( var connection = new SqlConnection( _connectionString ) )
            {
                connection.Open();
                using ( SqlCommand command = connection.CreateCommand() )
                {
                    command.CommandText =
                        @"select [StudentId]
                        from [StudentInGroup]
                        where [GroupId] = @groupId";
                    command.Parameters.Add( "@groupId", SqlDbType.Int ).Value = groupId;

                    using ( var reader = command.ExecuteReader() )
                    {
                        while ( reader.Read() )
                        {
                            result.Add( new StudentInGroup
                            {
                                StudentId = Convert.ToInt32( reader[ "StudentId" ] )
                            } );
                        }
                    }
                }
            }

            return result;
        }

        public void AddStudentInGroup( StudentInGroup studentInGroup )
        {
            using ( var connection = new SqlConnection( _connectionString ) )
            {
                connection.Open();
                using ( SqlCommand command = connection.CreateCommand() )
                {
                    command.CommandText =
                        @"insert into [StudentInGroup]
                            ([StudentId], [GroupId])
                        values
                            (@studentId, @groupId)
                        select SCOPE_IDENTITY()";

                    command.Parameters.Add( "@studentId", SqlDbType.Int ).Value = studentInGroup.StudentId;
                    command.Parameters.Add( "@groupId", SqlDbType.Int ).Value = studentInGroup.GroupId;
                }
            }
        }
        public void DeleteStudentFromGroup( StudentInGroup studentInGroups )
        {
            using ( var connection = new SqlConnection( _connectionString ) )
            {
                connection.Open();
                using ( SqlCommand command = connection.CreateCommand() )
                {
                    command.CommandText =
                        @"delete [StudentInGroup]
                        where [StudentId] = @studentId and [GroupId] = @groupId";

                    command.Parameters.Add( "@studentId", SqlDbType.Int ).Value = studentInGroups.StudentId;
                    command.Parameters.Add( "@groupId", SqlDbType.Int ).Value = studentInGroups.GroupId;

                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
