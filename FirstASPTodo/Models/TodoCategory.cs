using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FirstASPTodo.Models
{
    public class TodoCategory
    {
        //this key will say when you create a script to create this table, make sure the ID a primary key.
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [DisplayName("Display Order")]
        //[Range(1,100,ErrorMessage="Display Order must be between 1 and 100 only.")]
        public DateTime CreatedDateTime { get; set; } = DateTime.Now;
        public int DisplayOrder { get; set; }
    }
}
