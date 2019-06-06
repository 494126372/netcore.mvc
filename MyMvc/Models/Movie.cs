using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MyMvc.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string  Title { get; set; }

        //DataType 属性指定数据的类型(Date)。 通过此特性：
        //用户无需在数据字段中输入时间信息。
        //仅显示日期，而非时间信息。
        [Display(Name = "发布 Date")]  //显示的字段名 而不是字段表中名称
        [DataType(DataType.Date)]  // 只显示到天 中文类型
        public DateTime ReleaseDate { get; set; }
        // 分类 流派
        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$")]  // 校验
        [Required]  // 必填
        [StringLength(30)]
        public string  Genre { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }
    }
}
