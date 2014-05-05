using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitutionPrinciple.Example1
{
    /// <summary>
    /// Do you notice anything wrong with this class?
    /// 
    /// if not, what happens when we comment out the if statement? Does it become aparent now?
    /// 
    /// The if statement is distinguishing between new and existing entities. This means that this class has to be aware of the state of the entity
    /// and would thus need to compensate for one state or the other
    /// 
    /// this violates the LSP in a very simple way. We're not dealing purely with IEntity but we rather dealing with super versions of it.
    /// 
    /// LSP states that when a base object is used, like it is here, we only deal with whats available to us for that base object
    /// in laymens terms i like to state it like this. If all the code cannot be applied to all the versions of super classes that inherit off the base class,
    /// you're violiating the LSP. Here we exactly that. If you remove the if statement, the code will only work for new entities, not existing ones.
    /// 
    /// Solution: There are many and there are many patterns that solve this, but the simplest is that the date logic get extracted to the super classes. Let this method, in this case,
    /// only deal with the save.
    /// </summary>
    class DAL
    {
        private EntityConnection DBConnection { get; set; }

        public void SaveEntity(IEntity entity)
        {
            DateTime saveDate = DateTime.Now;

            if (entity.IsNew)
                entity.CreatedDate = saveDate;

            entity.UpdateDate = saveDate;

            DBConnection.Save(entity);
        }
    }
}
