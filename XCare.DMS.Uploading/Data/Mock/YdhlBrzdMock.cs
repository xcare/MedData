using Bogus;
using XCare.DMS.Entity;

namespace XCare.DMS.Uploading.Data.Mock
{
    public class YdhlBrzdMock
    {
        public static Faker<YdhlBrzd> GetFaker()
        {
            return new Faker<YdhlBrzd>();
        }
    }
}