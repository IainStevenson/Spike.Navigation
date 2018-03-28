using System;
using System.ComponentModel.DataAnnotations;

namespace Spike.Navigation
{
    public class Resource
    {
        [Key]
        public string Id { get; set; } = Guid.NewGuid().ToString();

        [Required]
        public string Caption { get; set; } = string.Empty;

        public Uri Location { get; set; } = new Uri("/", UriKind.Relative);
    }
}