﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.EntityLayer.Concrate
{
    public class Testimonial
    {
        public int TestimonialID { get; set; }
        public string UserName { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
    }
}
