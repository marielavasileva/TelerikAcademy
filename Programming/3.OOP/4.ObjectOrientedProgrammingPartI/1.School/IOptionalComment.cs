using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1.School
{
    public interface IOptionalComment
    {
        void AddComment(string comment);
        string ShowComment();
    }
}
