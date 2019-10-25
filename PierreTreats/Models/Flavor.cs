using System.Collections.Generic;

namespace PierreTreats.Models
{
    public class Flavor
    {
        public Flavor()
        {
            this.Treats = new HashSet<TreatFlavor>();
        }
        
        public string FlavorId { get; set; }
        public string FlavorNotes { get; set; }

        public ICollection<TreatFlavor> Treats { get; }
    }
}