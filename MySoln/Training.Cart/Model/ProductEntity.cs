﻿using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;

namespace DataLayer.Entities
{
    public class ProductEntity
    {
        [Required]
        [Key]
        public int ProductId { get; set; }
        [Required(ErrorMessage = "Please enter your Full Name")]
        [Display(Name = "Product Name")]
        public string ProductName { get; set; }

        [Required(ErrorMessage = "Please enter Description")]
        [Display(Name = "Product Description")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Please enter Category")]
        [Display(Name = "Product Category")]
        public string Category { get; set; }

        [Required(ErrorMessage = "Please enter Qunatity")]
        [Display(Name = "Quantity")]
        public int Quantity { get; set; }

        [Required(ErrorMessage = "Please enter price")]
        [Display(Name = "Price")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "Please enter Discount")]
        [Display(Name = "Discount")]
        public int Discount { get; set; }

        [Required(ErrorMessage = "Please enter specification")]
        [Display(Name = "Product Specification")]
        public string Specification { get; set; }
        public string Data { get; set; }

    }
}
