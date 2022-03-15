using Homework3.Models;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace Homework3.Repositories
{
    class GroupRawSqlRepository : IGroupRepository
    {
        private readonly string _connectionString;

        public GroupRawSqlRepository( string connectionString )
        {
            _connectionString = connectionString;
        }

        public List<Group> GetGroups()
        {
            var result = new List<Group>();

            using ( var connection = new SqlConnection( _connectionString ) )
            {
                connection.Open();
                using ( SqlCommand command = connection.CreateCommand() )
                {
                    command.CommandText = "select [Id], [Name] from [Groups]";

                    using ( var reader = command.ExecuteReader() )
                    {
                        while ( reader.Read() )
                        {
                            result.Add( new Group
                            {
                                Id = Convert.ToInt32( reader[ "Id" ] ),
                                Name = Convert.ToString( reader[ "Name" ] )
                            } );
                        }
                    }
                }
            }

            return result;
        }

        public void AddGroup( Group group )
        {
            using ( var connection = new SqlConnection( _connectionString ) )
            {
                connection.Open();
                using ( SqlCommand command = connection.CreateCommand() )
                {
                    command.CommandText =
                        @"insert into [Groups]
                            ([Name])
                        values
                            (@name)
                        select SCOPE_IDENTITY()";

                    command.Parameters.Add( "@name", SqlDbType.NVarChar ).Value = group.Name;

                    group.Id = Convert.ToInt32( command.ExecuteScalar() );
                }
            }
        }

        public Group GetGroup( int id )
        {
            using ( var connection = new SqlConnection( _connectionString ) )
            {
                connection.Open();
                using ( SqlCommand command = connection.CreateCommand() )
                {
                    command.CommandText =
                        @"select [Id], [Name]
                        from [Groups]
                        where [Id] = @id";

                    command.Parameters.Add( "@id", SqlDbType.Int ).Value = id;
                    using ( var reader = command.ExecuteReader() )
                    {
                        if ( reader.Read() )
                        {
                            return new Group
                            {
                                Id = Convert.ToInt32( reader[ "Id" ] ),
                                Name = Convert.ToString( reader[ "Name" ] )
                            };
                        }
                        else
                        {
                            return null;
                        }
                    }
                }
            }
        }

        public void DeleteGroup( int id )
        {
            using ( var connection = new SqlConnection( _connectionString ) )
            {
                connection.Open();
                using ( SqlCommand command = connection.CreateCommand() )
                {
                    command.CommandText =
                        @"delete [Groups]
                        where [Id] = @id";

                    command.Parameters.Add( "@id", SqlDbType.Int ).Value = id;

                    command.ExecuteNonQuery();
                }
            }
        }
    }
}