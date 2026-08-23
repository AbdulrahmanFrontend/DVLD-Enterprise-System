using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Enterprise_System.Domain.Entities
{
    public class Country
    {
        public int CountryID { get; set; }

        public string CountryName { get; set; } = string.Empty;

        public ICollection<Person> People { get; set; } = new List<Person>();
    }
}
