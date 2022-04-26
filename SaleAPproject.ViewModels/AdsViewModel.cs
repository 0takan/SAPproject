using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SaleAPproject.ViewModels
{
    public class AdsViewModel
    {


        [Required(ErrorMessage = "Введите название товара")]
        [MinLength(2, ErrorMessage = "Минимальная длинна названия должна быть 2 символа")]
        [MaxLength(200, ErrorMessage = "Максимальная длинна должна названия быть 200 символа")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Введите цену $")]
        public decimal Price { get; set; }

        [MinLength(1, ErrorMessage = "Минимально количество фотографий 1")]
        [MaxLength(3, ErrorMessage = "Максимальное количество фотографий 3")]
        public List<string> Img { get; set; }

        [Required(ErrorMessage = "Введите название товара")]
        [MinLength(2, ErrorMessage = "Минимальная длинна описания должна быть 2 символа")]
        [MaxLength(1000, ErrorMessage = "Максимальная длинна описания должна быть 200 символа")]
        public string Desc { get; set; }
    }
}

