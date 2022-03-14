using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FirstASPTodo.Models
{
    public class Expenses
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [DisplayName("Expense")]
        public string ExpenseName { get; set; }
        [DisplayName("Amount")]
        public int ExpenseAmount { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        [DisplayName("Description")]
        public string ExpenseDescription { get; set; }
    }
}
