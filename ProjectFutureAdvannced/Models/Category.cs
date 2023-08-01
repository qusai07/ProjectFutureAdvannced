using ProjectFutureAdvannced.Models.Enums;
using System.ComponentModel.DataAnnotations;

namespace ProjectFutureAdvannced.Model
    {
    public class Category
        {

        public int Id { get; set; }
        [Required]
        public Categorys Name { get; set; }
        [Required]
        [RegularExpression(@"\b\w+\.(jpg|JPG|PNG|png)\b",ErrorMessage ="This Image not supported")]
        public string CategoryImg { get; set; }
        }
    }
