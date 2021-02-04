using Attribute_Reflection.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Attribute_Reflection.CustomAttribute
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Constructor | AttributeTargets.Method , AllowMultiple =true)]
    public class RoleAccessAttribute:Attribute
    {

        public UserRole UserRole { get; set; }

        public RoleAccessAttribute(UserRole userRole)
        {
            UserRole = userRole;
        }


    }
}
