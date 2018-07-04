using ContactManagement.Lib.AbstractRepository;
using ContactManagement.Lib.Context;
using ContactManagement.Lib.Model;

namespace ContactManagement.Lib.Repository
{

    public class ContactRepository : BaseRepository<Contact>, IContactRepository
    {
        public ContactRepository(ContactContext context)
            : base(context)
        { }
    }
}
