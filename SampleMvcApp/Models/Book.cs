using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SampleMvcApp.Models
{
    public class Book
    {
        [Key]
        [ScaffoldColumn(false)]
        public int Id { get; set; }

        [Display(Name ="Book Name")]
        [Required(ErrorMessage ="Book Name is required")]
        public string BookName { get; set; }

   
        [Required(ErrorMessage ="Author Name is required")]
        [MaxLength(20)]
        public string AuthorName { get; set; }

        
        [Required(ErrorMessage ="Publisher Name is required")]
        [MaxLength(40)]
        public string PublisherName { get; set; }

        [Required(ErrorMessage = "Publisher Date is required")]
        [DataType(DataType.Date)]
        public DateTime PublisherDate { get; set; }

        
        [Required(ErrorMessage = "Price is required")]
        [Range(minimum:100,maximum:1000,ErrorMessage ="Price should be between 100-100")]
        public double Price { get; set; }

    }
}