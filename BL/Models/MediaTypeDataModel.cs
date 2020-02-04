using System;
using System.Collections.Generic;
using System.Text;

namespace BL.Models
{
    public class MediaTypeDataModel
    {
        public short MediaTypeId { get; set; }

        public short FkRefMediaGroupId { get; set; }

        public string MediaType { get; set; }

        public DateTime LastUpdated { get; set; }

        public bool Deleted { get; set; }
    }
}
