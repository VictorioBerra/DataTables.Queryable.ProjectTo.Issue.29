using System;
using System.Collections.Generic;

namespace EFCore.Models
{
    public class Cat : IAuditable
    {

        public int Id { get; set; }

        public int MeowLoudness { get; set; }

        public int? CatBreedId { get; set; }

        public CatBreed Breed { get; set; }

        public string CreatedByWUPeopleId { get; set; }
        public string CreatedByDisplayName { get; set; }
        public DateTime CreatedOnUtc { get; set; }
        public string UpdatedByWUPeopleId { get; set; }
        public string UpdatedByDisplayName { get; set; }
        public DateTime UpdatedOnUtc { get; set; }
    }
}
