using System.Collections.Generic;
using Bogus;
using XCare.DMS.Entity;

namespace XCare.DMS.Uploading.Data.Mock
{
    public class YdhlBryzxxMock
    {
        public static List<YdhlBryzxx> Mock(long zyh, int count = 3)
        {
            var ypmcs = YdhlYpzdDao.LoadYpmcs();
            return new Faker<YdhlBryzxx>().StrictMode(false)
                .RuleFor(e => e.Zyh, zyh)
                .RuleFor(e => e.Lsyz, f => f.PickRandom(new byte[] {0, 1}))
                .RuleFor(e => e.Yzmc, f => f.PickRandom(ypmcs))
                //1,输液 2，注射 4，口服
                .RuleFor(e => e.Yzlx, f => f.PickRandom(1, 2, 4))
                .RuleFor(e => e.Ycjl, f => f.Random.Decimal(0.25M, 500))
                .Generate(3);
        }
    }
}