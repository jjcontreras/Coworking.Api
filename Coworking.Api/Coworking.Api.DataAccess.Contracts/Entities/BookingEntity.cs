﻿using Dicres.RepositoryService.DataAccess.Contracts.Entities;
using System;

namespace Coworking.Api.DataAccess.Contracts.Entities
{
    public class BookingEntity : IBaseWithIdEntity
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public DateTime BookingDate { get; set; }
        public DateTime CreateDate { get; set; }
        public int OfficeId { get; set; }
        public bool RentWorkSpace { get; set; }
        public int? RoomId { get; set; }

        public virtual UserEntity User { get; set; }
        public virtual OfficeEntity Office { get; set; }
    }
}
