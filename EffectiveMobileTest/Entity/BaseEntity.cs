using System.ComponentModel.DataAnnotations;

namespace EffectiveMobileTest.Entity
{
    public class BaseEntity
    {
        [Key]
        public Guid Id { get; set; }

    }
}
