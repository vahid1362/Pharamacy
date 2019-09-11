using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Pharamacy.ViewModels.Stock
{
    public class AddorUpdateShelfViewModel
    {
        public Guid  Id { get; set; }


        [Required(ErrorMessage = "کد قفسه ضرور  می باشد")]
        [Display(Name="کد قفسه")]
        public int Number { get; set; }

        [Required(ErrorMessage ="نام قفسه ضروری می باشد")]
        [Display(Name = "نام قفسه")]
        public string Name { get; set; }
    }
}
