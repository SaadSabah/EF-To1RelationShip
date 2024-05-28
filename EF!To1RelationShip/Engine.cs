using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_To1RelationShip
{
    internal class Engine
    {
        public int Id { get; set; }
        public int Volume { get; set; }
        public int NumberOfPistons { get; set; }
        public int CarId { get; set; } //Foreign Key
        public Car Car { get; set; }
    }
}
