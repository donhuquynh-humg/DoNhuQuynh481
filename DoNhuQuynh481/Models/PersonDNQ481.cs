using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DoNhuQuynh481.Models
{
    public class PersonDNQ481
    {
        [Key]
        [Column(TypeName= "varchar")]
        [StringLength(20)]
        public int PersonId { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(50)]
        public int PersonName { get; set; }
    }
}
