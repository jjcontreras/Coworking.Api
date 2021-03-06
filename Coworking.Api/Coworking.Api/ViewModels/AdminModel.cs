﻿using Dicres.RepositoryService.Api.ViewModels;

namespace Coworking.Api.ViewModels
{
    public class AdminModel : BaseModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
    }
}
