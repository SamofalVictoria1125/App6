using System;
using System.Collections.Generic;
using System.Text;

namespace App6
{
    public class Cat
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Breed { get; set; }

        public int ShelterId { get; set; }
        public Shelters Shelters { get; set; }
    }
}
