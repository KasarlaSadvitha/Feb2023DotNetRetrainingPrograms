using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Code_First_Approach
{
    internal class Customer
    {
        private int id;
        private string name, city;

        [Key]
        public int CID
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }
        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }
        public string City
        {
            get
            {
                return city;
            }

            set
            {
                city = value;
            }

        }
    }
}
