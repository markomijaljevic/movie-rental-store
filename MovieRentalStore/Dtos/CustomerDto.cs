﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using MovieRentalStore.Models;

namespace MovieRentalStore.Dtos
{
    public class CustomerDto
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public bool IsSubscribedToNewsLetter { get; set; }

       // [Min18YearsOld]
        public DateTime? Birthdate { get; set; }

        public byte MembershipTypeId { get; set; }
    }
}