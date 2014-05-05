using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LiskovSubstitutionPrinciple.Example1
{
    class EntityConnection
    {
        internal void Save(IEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
