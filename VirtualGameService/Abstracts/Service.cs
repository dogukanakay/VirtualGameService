using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VirtualGameService.Entities;

namespace VirtualGameService.Abstracts
{
    internal abstract class Service
    {
        public abstract void Add(BaseEntities entities);

        public abstract void Update(BaseEntities entities);

        
        public abstract void Delete(BaseEntities entities);
        
    }
}
