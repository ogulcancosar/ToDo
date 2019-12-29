using System;
using System.ComponentModel.DataAnnotations;

namespace Inveon.DataManagement
{
    public class Todo
    {
        public Todo()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }

        [Required]
        public string Task { get; set; }
        [Required]
        public string Who { get; set; }
        [Required]
        public string Description { get; set; }
        //[Required]
        public DateTime DueDate { get; set; }
        public bool IsDone { get; set; }

    }
}
