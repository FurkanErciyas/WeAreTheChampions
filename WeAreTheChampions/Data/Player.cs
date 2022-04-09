using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeAreTheChampions.Data
{
    [Table("Players")]
    public class Player
    {
        public int Id { get; set; }

        [Required, MaxLength(100)]
        public string PlayerName { get; set; }

        [ForeignKey("Team")]
        public int? TeamId { get; set; }
        public virtual Team Team { get; set; }
        public override string ToString()
        {
            return PlayerName;
        }
    }
}
