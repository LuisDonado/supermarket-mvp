﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Supermarket_mvp.Models
{
    internal class PayModeModel
    {
        [DisplayName("Pay Model Id")]
        public int Id { get; set; }

        [DisplayName("Pay Mode Name")]
        [Required(ErrorMessage = "Pay Mode Name is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Pay Mode Name must be between 3 and 50 characters")]
        public string Name { get; set; }

        [DisplayName("Observation")]
        [Required(ErrorMessage = "Pay Mode observation is required")]
        [StringLength(200, MinimumLength = 3, ErrorMessage = "Pay Mode observation must be between 3 and 200 characters")]


        public string Observation { get; set; }
    }
}
