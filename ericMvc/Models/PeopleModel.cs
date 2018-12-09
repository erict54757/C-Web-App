using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace ericMvc.Models
{
    public class PeopleModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Age { get; set; }
    }

    public class Coffee
    {

      
        public int ID { get; set; }

        public string Name { get; set; }

        public string Origin { get; set; }

        // public string Roast { get; set; }

        // // [Display(Name = "Roaster")]
        public string Brand { get; set; }

        // // [Display(Name = "Expiration Date")]
        // public string ExpirationDate
        // {
        //     get; set;
        // }
    }

}

