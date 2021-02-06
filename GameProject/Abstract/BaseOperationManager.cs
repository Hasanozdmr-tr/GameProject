using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Abstract
{
    public abstract class BaseOperationManager : IUserService
    {
        public virtual void Register(User user)
        {
            throw new NotImplementedException();
        }

        public virtual void Remove(User user)
        {
            throw new NotImplementedException();
        }

        public virtual void Update(User user, string newName)
        {
            throw new NotImplementedException();
        }
    }
}
