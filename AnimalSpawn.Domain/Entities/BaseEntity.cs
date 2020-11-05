using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalSpawn.Domain.Entities
{
    public abstract class BaseEntity : IEntity
    {
        // …
        public int SpeciesId { get; set; }
        public int FamilyId { get; set; }
        public int GenusId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool? Gender { get; set; }
        public DateTime? CaptureDate { get; set; }
        public string CaptureCondition { get; set; }
        public float? Weight { get; set; }
        public float? Height { get; set; }
        public int? EstimatedAge { get; set; }
        public abstract int Id { get; set; }
        public abstract bool Status { get; set; }
        public abstract DateTime CreateAt { get; set; }
        public abstract int? CreatedBy { get; set; }
        public abstract DateTime? UpdateAt { get; set; }
        public abstract int? UpdatedBy { get; set; }
    }
}
