using Homework3.Models;

namespace Homework3.Repositories
{
    interface IGroupRepository
    {
        void AddGroup( Group group );
        void DeleteGroup( int id );
        Group GetGroup( int id );
        List<Group> GetGroups();
    }
}
