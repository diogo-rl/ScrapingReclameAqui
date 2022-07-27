using System;
using System.Collections.Generic;
using System.Text;

namespace ScrapingReclameAqui
{
    class Complaint
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Status { get; set; }
        public string CreationDate { get; set; }
        public string Text  { get; set; }
        public string Company { get; set; }
        public string Url { get; set; }
        public string Type { get; set; }
    }
}
