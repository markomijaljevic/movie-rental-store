﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using MovieRentalStore.Dtos;
using MovieRentalStore.Models;

namespace MovieRentalStore.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            Mapper.CreateMap<Customer, CustomerDto>();
            Mapper.CreateMap<CustomerDto, Customer>();

            Mapper.CreateMap<MovieDto, Movies>();
            Mapper.CreateMap<Movies, MovieDto>();
        }
    }
}