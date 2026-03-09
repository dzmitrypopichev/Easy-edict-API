using System;
using System.Collections.Generic;

namespace EasyEdictWebApi.Models
{
    public class EntityModel
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? Type { get; set; }
        public string? Status { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public List<string> Tags { get; set; }
        public Dictionary<string, object> Metadata { get; set; }

        public EntityModel()
        {
            Tags = new List<string>();
            Metadata = new Dictionary<string, object>();
        }
    }
}

