using System.ComponentModel.DataAnnotations;

namespace WebApplicationBook.Models
{
    public class Book
    {
        public int Id { get; set; } //主键
        [Required(ErrorMessage = "书籍名称必填")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "3-20个字符")]
        [Display(Name = "书籍名称")]
        public string? Title { get; set; } //书籍名称
        [Required(ErrorMessage = "作者必填")]
        [StringLength(10, MinimumLength = 2, ErrorMessage = "2-10个字符以内")]
        [Display (Name = "作者")]
        public string? Author { get; set; } //作者
        [Required(ErrorMessage = "出版社名必填")]
        [StringLength(20, MinimumLength = 2, ErrorMessage = "2-20个字符以内")]
        [Display(Name = "出版社名类型")]
        public string? Publisher { get; set; } //出版社名
        [Required(ErrorMessage = "出版日期必填")]
        [Display(Name = "出版日期")]
        [DataType(DataType.Date)]
        public DateTime PublishingTime { get; set; } //出版日期
        [Display(Name = "价格")]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; } //价格
    }
}
