using System;
using System.ComponentModel.DataAnnotations;

namespace MMK_IS.Atach.Domain.Entities
{
    public class Rating
    {
        public Guid RatingId { get; set; }

        [MaxLength(1)]
        public string Name { get; set; }
    }
}