using System;
using System.Collections.Generic;
using System.Security.Principal;
using System.Threading.Tasks;

namespace MemoTime.Core.Domain
{
    public class Label: Entity
    {
        public IEnumerable<TodoTask> Tasks { get; protected set; }
        public User User { get; protected set; }
        public string Name { get; protected set; }

        protected Label()
        {
            
        }
        
        public Label(Guid id, User user, string name)
        {
            Id = id;
            User = user;
            Name = name;
        }
    }
}