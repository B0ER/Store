﻿using System.ComponentModel.DataAnnotations;

namespace Store.BusinessLogic.Model.User.Request
{
    public class UserChangePasswordModel
    {
        [Required]
        public string OldPassword { get; set; }

        public string NewPassword { get; set; }

        [Compare("NewPassword")] public string NewPasswordRepeate { get; set; }
    }
}