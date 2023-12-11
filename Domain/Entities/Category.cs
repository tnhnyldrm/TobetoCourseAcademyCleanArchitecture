using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tobeto.Core.Persistence.Repositories;

namespace Domain.Entities
{
    public class Category:Entity<Guid>
    {
        public Category(string name)
        {
            Name = name;
        }

        public string Name { get; set; }
    }
}
