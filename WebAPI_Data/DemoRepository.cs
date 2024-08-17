using WebAPI_Data_Contract;

namespace WebAPI_Data
{
    public class DemoRepository : IDemoRepository
    {
        public DemoRepository()
        {
            
        }

        public string getdemovalue()
        {
            return "Test demo value";
        }
    }
}
