using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppMVCBasica.Models
{
    public abstract class Entity
    {
        public Entity()
        {
            this.Id = new Guid();
        }

        public Guid Id { get; set; }
    }
}
