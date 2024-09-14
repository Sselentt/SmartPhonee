using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartPhonee.Domain.Entities
{
    public class Image
    {
        public int ImageID { get; set; }
        public string Image1Url { get; set; }
        public string Image2Url { get; set; }
        public string Image3Url { get; set; }
        public string Image4Url { get; set; }
        public int ProductID { get; set; }
        public Product Product { get; set; }
    }
}
