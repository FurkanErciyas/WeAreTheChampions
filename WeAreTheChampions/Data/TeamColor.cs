using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeAreTheChampions.Data
{
    public class TeamColor
    {
        public int TeamId { get; set; }
        public int ColorId { get; set; }
    }
}
