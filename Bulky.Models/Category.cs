using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Bulky.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        [Required]
        [DisplayName("Category Name")]
        [MaxLength(30,ErrorMessage ="Max Length must be less than 30 charachter")]       
        public string Name { get; set; }
        [Required]
        [DisplayName("Dispaly Order")]
        [Range(1,100)]
        public int DispalyOrder { get; set; }
    }
}
