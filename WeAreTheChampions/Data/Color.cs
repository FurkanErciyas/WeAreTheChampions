using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeAreTheChampions.Data
{
    [Table("Colors")]
    public class Color
    {
        public int Id { get; set; }

        [Required, MaxLength(50)]
        public string ColorName { get; set; }

        [Range(0, 255)]
        public int Red { get; set; }

        [Range(0, 255)]
        public int Green { get; set; }

        [Range(0, 255)]
        public int Blue { get; set; }

        public virtual ICollection<Team> Teams { get; set; }

        public override string ToString()
        {
            return ColorName;
        }

    }
}
