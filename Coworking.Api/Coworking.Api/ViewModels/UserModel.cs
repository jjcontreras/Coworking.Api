﻿using Dicres.RepositoryService.Api.ViewModels;
using System;

namespace Coworking.Api.ViewModels
{
    public class UserModel : BaseModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public bool Active { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
