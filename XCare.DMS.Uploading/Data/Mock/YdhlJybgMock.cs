using Bogus;
using XCare.DMS.Entity;

namespace XCare.DMS.Uploading.Data.Mock
{
    public class YdhlJybgMock
    {
        public static Faker<YdhlJybg> GetFaker()
        {
            return new Faker<YdhlJybg>();
        }
    }
}