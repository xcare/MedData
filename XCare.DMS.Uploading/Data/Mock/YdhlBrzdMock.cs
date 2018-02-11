using System;
using Bogus;
using XCare.DMS.Entity;

namespace XCare.DMS.Uploading.Data.Mock
{
    public class YdhlBrzdMock
    {
        public static YdhlBrzd Mock(long zyh)
        {
            var jbmcs = YdhlJbbmDao.LoadJbmcs();
            var zdlbs = YdhlGyzdDao.GetZdlbs();

            return new Faker<YdhlBrzd>().StrictMode(false)
                .RuleFor(e => e.Id, Guid.NewGuid)
                .RuleFor(e => e.Zyh, zyh)
                .RuleFor(e => e.Zd, f => f.PickRandom(jbmcs))
                .RuleFor(e => e.Zdlb, f => f.PickRandom(zdlbs))
                .RuleFor(e => e.Zdsj, DateTime.Now)
                .FinishWith((f, e) => { e.Name = e.Zd; });
        }
    }
}