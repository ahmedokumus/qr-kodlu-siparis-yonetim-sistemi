﻿using Core.Entities;

namespace Dto.TestimonialDto;

public class CreateTestimonialDto : IDto
{
    public string Name { get; set; }
    public string Title { get; set; }
    public string Comment { get; set; }
    public string ImageUrl { get; set; }
    public bool Status { get; set; }
}