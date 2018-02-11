using System;
using Bogus;
using XCare.DMS.Entity;

namespace XCare.DMS.Uploading.Data.Mock
{
    public class YdhlJybgMock
    {
        public static YdhlJybg Mock(long zyh)
        {
            var jybgxqFaker = BuildJybgxqFaker();

            return new Faker<YdhlJybg>().StrictMode(false)
                .RuleFor(e => e.Id, Guid.NewGuid)
                .RuleFor(e => e.Zyh, zyh)
                .RuleFor(e => e.Txm, f => f.PickRandom("0380099518",
                    "0980080966",
                    "0180067144",
                    "0380099767",
                    "0280041553",
                    "0880031151",
                    "0480069856",
                    "0480069681",
                    "0480069965",
                    "0480069690"))
                .RuleFor(e => e.Kzxm, f => f.PickRandom("血细胞分析(三分类以上)",
                    "尿液分析(尿9联及以上)",
                    "葡萄糖测定",
                    "血清胱抑素(CystatinC)测定",
                    "肾功能★",
                    "单项补体测定(透射比浊法)",
                    "视黄醇结合蛋白测定",
                    "肝功能★",
                    "超氧化物歧化酶(SOD)测定",
                    "血清肌钙蛋白T测定"))
                .RuleFor(e => e.Ybh, f => f.PickRandom("LM0064",
                    "LI0037",
                    "SA0241",
                    "MA0066",
                    "XN0044",
                    "LD0023",
                    "MC0159",
                    "MI0008",
                    "MC5502",
                    "WS0019"))
                .RuleFor(e => e.DateTest, f => DateTime.Now.AddDays(f.Random.Int(-100, 0)))
                .RuleFor(e => e.Jcmd, f => f.PickRandom("血细胞分析(三分类以上)",
                    "尿液分析(尿9联及以上)",
                    "超氧化物歧化酶(SOD)测定,葡萄糖测定,电解质A★,肝功能★,肾功能★,血清胱抑素(CystatinC)测定,单项补体测定(透射比浊法),视黄醇结合蛋白测定",
                    "血清肌钙蛋白T测定",
                    "DIC筛查★,血浆抗凝血酶活性测定(AT—A)(仪器法)",
                    "血气分析(血液化学检验 )",
                    "甲胎蛋白测定(AFP),癌胚抗原测定(CEA),糖类抗原测定CA19－9,总前列腺特异性抗原测定(TPSA),游离前列腺特异性抗原测定(FPSA)",
                    "戊型肝炎抗体测定（HEV）(IgM),甲型肝炎抗体IgM测定(Anti-HAV,戊型肝炎抗体测定（HEV）(IgG),乙型肝炎病毒外膜蛋白前S1抗原测定",
                    "丙型肝炎抗体测定(Anti-HCV),乙肝两对半★,乙型肝炎标志物★,乙型肝炎表面抗原测定(HBsAg),乙型肝炎表面抗体测定(Anti-HBs),乙型肝炎核心抗体测定(Anti-HBc)",
                    "丁型肝炎抗体测定(Anti-HDV),庚型肝炎IgG抗体测定(Anti-HGV"))
                .FinishWith((f, e) =>
                {
                    var rdm = new Random();
                    e.Items = jybgxqFaker.Generate(rdm.Next(1, 20));
                    e.Items.ForEach(v =>
                    {
                        v.Ybh = e.Ybh;
                        v.DateTest = e.DateTest;
                    });
                })
                .Generate();
        }

        private static Faker<YdhlJybgxq> BuildJybgxqFaker()
        {
            return new Faker<YdhlJybgxq>().StrictMode(false)
                .RuleFor(e => e.Id, Guid.NewGuid())
                .RuleFor(e => e.Xmmc, f => f.PickRandom("纤维蛋白原水平",
                    "血凝块溶解百分比",
                    "提示",
                    "凝血综合指数",
                    "纤维蛋白原",
                    "血凝块幅度减少速率",
                    "血小板活性",
                    "凝血因子(普通)",
                    "AA抑制率",
                    "ADP抑制率"))
                .RuleFor(e => e.Xmcdz, f => f.PickRandom("67.7",
                    "7.2",
                    "凝血因子活性高",
                    "1.3",
                    "1.6",
                    "7.2",
                    "60.4",
                    "4.4",
                    "14.6",
                    "92.4"))
                .RuleFor(e => e.Ckfw, f => f.PickRandom("53-72",
                    "0-15",
                    " ",
                    "-3-+3",
                    "1-3",
                    "0-8",
                    "50-70",
                    "5-10",
                    "50-90",
                    "30-90"))
                .RuleFor(e => e.Dw, f => f.PickRandom("deg",
                    "%",
                    " ",
                    " ",
                    "min",
                    "%",
                    "mm",
                    "min",
                    "%",
                    "%"));
        }
    }
}