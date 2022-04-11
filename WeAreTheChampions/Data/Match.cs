using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeAreTheChampions.Data
{
    [Table("Matches")]
    public class Match
    {
        public int Id { get; set; }
        public DateTime MatchTime { get; set; }
        public string Score1 { get; set; }
        public string Score2 { get; set; }
        public Result Result { get; set; }
        public virtual Team Team1 { get; set; }
        public virtual Team Team2 { get; set; }
    }
}
