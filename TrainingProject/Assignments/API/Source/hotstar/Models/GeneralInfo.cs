using System;
using System.Collections.Generic;

#nullable disable

namespace hotstar.Models
{
    public partial class GeneralInfo
    {
        public int ContentId { get; set; }
        public string Title { get; set; }
        public string Language { get; set; }
        public string ObjectName { get; set; }
        public int? Views { get; set; }
        public string Description { get; set; }
        public string Url { get; set; }
        public int? Year { get; set; }
        public string ContentType { get; set; }
        public bool? IsPaid { get; set; }
    }
}
