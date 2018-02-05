using Bogus;
using XCare.DMS.Entity;

namespace XCare.DMS.Uploading.Data.Mock
{
    public class YdhlTwdMock
    {
        public static Faker<YdhlTwd> GetFaker()
        {
            return new Faker<YdhlTwd>();
        }
    }
}