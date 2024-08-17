using WebAPI_Data_Contract;
using WebAPI_Domain_Contract;

namespace WebAPI_Domain
{
    public class DemoManager : IDemoManager
    {
        private readonly IDemoRepository _demorepo;
        public DemoManager(IDemoRepository demorepo)
        {
            _demorepo = demorepo;
        }

        public string getdemovalue()
        {
            return _demorepo.getdemovalue();
        }
    }
}
