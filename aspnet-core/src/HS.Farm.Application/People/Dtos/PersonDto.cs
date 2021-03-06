﻿using Abp.Application.Services.Dto;
using Abp.AutoMapper;

namespace HS.Farm.People.Dtos
{
    [AutoMapFrom(typeof(Person))] //AutoMapFrom attribute maps Person -> PersonDto
    public class PersonDto : EntityDto
    {
        public string Name { get; set; }
    }
}
