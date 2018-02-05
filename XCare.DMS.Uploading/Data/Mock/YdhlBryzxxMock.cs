using Bogus;
using XCare.DMS.Entity;

namespace XCare.DMS.Uploading.Data.Mock
{
    public class YdhlBryzxxMock
    {
        public static Faker<YdhlBryzxx> GetFaker()
        {
           return new Faker<YdhlBryzxx>();
        }
    }
}