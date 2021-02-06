using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Entity
{
    public class Game:IEntity
    {
        public int Id { get; set; }
        public string GameName { get; set; }
        public float Version { get; set; }
        public Decimal Price { get; set; }


    }
}
