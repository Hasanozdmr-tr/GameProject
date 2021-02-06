using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Abstract
{
    public interface IUserService
    {
        void Register(User user);
        void Update(User user, string newName);
        void Remove(User user);

    }
}
