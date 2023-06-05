using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.EntityLayer.Concrete
{
    public class Testimonial
    {
        public int TestimonialID { get; set; }
        public int Name { get; set; }
        public int Title { get; set; }
        public int Description { get; set; }
        public int Image { get; set; }
    }
}
