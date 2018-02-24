using System;
using System.ComponentModel.DataAnnotations;

namespace XCare.DMS.Receiving.DTO
{
    public class BryzxxCreationDTO
    {
        [Required]
        public long Rowid { get; set; }

        [Required]
        public long Zyh { get; set; }

        public long? Sqdh { get; set; }

        [Required]
        public long Yzzh { get; set; }

        [Required]
        public byte Lsyz { get; set; }

        [Required]
        public string Yzmc { get; set; }

        [Required]
        public byte Yzlx { get; set; }

        [Required]
        public decimal Ycjl { get; set; }

        [Required]
        public string Jldw { get; set; }

        [Required]
        public decimal Sl { get; set; }

        [Required]
        public DateTime? Kssj { get; set; }

        public DateTime? Tzsj { get; set; }

        [Required]
        public string Gytj { get; set; }

        public string Sypc { get; set; }

        [Required]
        public short Mrcs { get; set; }

        public short? Mzcs { get; set; }
        public decimal Dj { get; set; }
        public DateTime? Zxsj { get; set; }
        public string Fysx { get; set; }
        public byte? Yjzx { get; set; }

        [Required]
        public short Xmlx { get; set; }

        public int? Code { get; set; }

        [Required]
        public string Pccode { get; set; }

        public byte Sybz { get; set; }
        public byte? Ystj { get; set; }
        public string Fysj { get; set; }
        public string Yysj { get; set; }
    }
}