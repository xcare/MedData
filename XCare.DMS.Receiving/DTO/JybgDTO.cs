using System;
using System.Collections.Generic;

namespace XCare.DMS.Receiving.DTO
{
    public class JybgCreationDTO
    {
        public long? Zyh { get; set; }
        public string Txm { get; set; }
        public string Kzxm { get; set; }
        public string Ybh { get; set; }
        public DateTime DateTest { get; set; }
        public long Rowid { get; set; }
        public string Jcmd { get; set; }
        public virtual List<JybgxqCreateionDTO> Items { get; set; }
    }

    public class JybgxqCreateionDTO
    {
        public string Xmmc { get; set; }
        public string Xmcdz { get; set; }
        public string Ts { get; set; }
        public string Ckfw { get; set; }
        public string Dw { get; set; }
        public DateTime? DateTest { get; set; }
        public string Ybh { get; set; }
    }
}