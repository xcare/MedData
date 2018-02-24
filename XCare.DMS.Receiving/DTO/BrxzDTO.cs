using System.ComponentModel.DataAnnotations;

namespace XCare.DMS.Receiving.DTO
{
    public class BrxzCreationDTO
    {
        /// <summary>
        ///     编码
        /// </summary>
        [Required]
        public int Brxz { get; set; }

        /// <summary>
        ///     名称
        /// </summary>
        [Required]
        public string Xzmc { get; set; }

        /// <summary>
        ///     拼音首字母代码
        /// </summary>
        [Required]
        public string Pydm { get; set; }

        [Required]
        public int Sjxz { get; set; }

        [Required]
        public int Gsxz { get; set; }
    }
}