using Bogus;
using XCare.DMS.Entity;

namespace XCare.DMS.Uploading.Data.Mock
{
    public class YdhlJcbgMock
    {
        public static Faker<YdhlJcbg> GetFaker()
        {
            return new Faker<YdhlJcbg>();
        }
    }
}