using System;
using System.Collections.Generic;
using System.Linq;
using Bogus;
using Bogus.Extensions.Denmark;
using Dapper;
using XCare.DMS.Entity;
using XCare.DMS.Uploading.Utils;

namespace XCare.DMS.Uploading.Data.Mock
{
    public class YdhlJbxxMock
    {
        public static List<YdhlJbxx> Mock(int count = 1)
        {
            var dicts = LoadGyzds();
            var jbmcs = YdhlJbbmDao.LoadJbmcs();
            return new Faker<YdhlJbxx>().StrictMode(false)
                .RuleFor(e => e.Zyhm, f => f.Random.Int().ToString())
                .RuleFor(e => e.Brxm, f => f.Name.FullName())
                .RuleFor(e => e.Xb, f => f.PickRandom(dicts.Where(e => e.Dmlb == 15 && e.Dmsb != 0).Select(e => e.Dmsb)))
                .RuleFor(e => e.Nl, f => f.Random.Int(8, 120))
                .RuleFor(e => e.Brqk,
                    f => f.PickRandom(dicts.Where(e => e.Dmlb == 10 && e.Dmlb != 0).Select(e => e.Dmsb)))
                .RuleFor(e => e.Brxx,
                    f => f.PickRandom(dicts.Where(e => e.Dmlb == 21 && e.Dmsb != 0).Select(e => e.Dmsb)))
                .RuleFor(e => e.Ryqk,
                    f => f.PickRandom(dicts.Where(e => e.Dmlb == 10 && e.Dmlb != 0).Select(e => e.Dmsb)))
                .RuleFor(e => e.Ryzd, f => f.PickRandom(jbmcs))
                .RuleFor(e => e.Zyzt, f => f.PickRandom(new short[] {0, 1, 2, 4, 8}))
                .RuleFor(e => e.Sfzh, f => f.Person.Cpr())
                .RuleFor(e => e.Ysqk,
                    f => f.PickRandom(dicts.Where(e => e.Dmlb == 20 && e.Dmsb != 0).Select(e => e.Dmmc)))
                .RuleFor(e => e.Ywgm, f => f.PickRandom(new byte[] {0, 1}))
                .RuleFor(e => e.Ryrq, f => DateTime.Now.AddSeconds(-f.Random.Int(0, 30000000)))
                .FinishWith((f, e) =>
                {
                    e.Brzt = dicts.First(v => v.Dmlb == 10 && v.Dmsb == e.Ryqk).Dmmc;
                    e.Xx = dicts.First(v => v.Dmlb == 21 && v.Dmsb == e.Brxx).Dmmc;
                    e.Cyrq = ResolveRyrq(e, f);
                }).Generate(count);
        }

        private static DateTime? ResolveRyrq(YdhlJbxx e, Faker f)
        {
            if (DateTime.Now < e.Ryrq.AddDays(30))
                return null;
            return e.Ryrq.AddSeconds(f.Random.Int(0, 2592000));
        }

        private static List<YdhlGyzd> LoadGyzds()
        {
            using (var conn = DbUtil.GetDbConnection())
            {
                return
                    conn.Query<YdhlGyzd>(
                        @"SELECT * FROM dbo.YDHL_GYZD WHERE (DMLB=15 OR DMLB=10 OR DMLB=21 OR DMLB=20) AND DMSB!=0")
                        .AsList();
            }
        }
    }
}