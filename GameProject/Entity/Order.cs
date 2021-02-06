using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Entity
{
   public class Order
    {
        public int Id { get; set; }
        public Decimal Price { get; set; }
        public int Quanity { get; set; }
        public int MemberId { get; set; }
    }
}
