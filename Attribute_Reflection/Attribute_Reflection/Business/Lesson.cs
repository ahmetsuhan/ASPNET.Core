using Attribute_Reflection.Abstract;
using Attribute_Reflection.CustomAttribute;
using Attribute_Reflection.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Attribute_Reflection.Business
{
    [RoleAccess(UserRole.Admin)]
    [RoleAccess(UserRole.Master)]

    public class Lesson
    {
        public int Id { get; set; }
        public string Name { get; set; }
        private User _user;

        public Lesson(int id,string name, User user )
        {

            var typeInfo = typeof(Lesson);
            RoleAccessAttribute[] roleAccessAttributes = typeInfo.GetCustomAttributes(typeof(RoleAccessAttribute), true) as RoleAccessAttribute[];
            if (roleAccessAttributes != null)
            {
                if (roleAccessAttributes.All(ra => ra.UserRole.ToString() != user.GetType().Name))
                {
                    throw new ArgumentNullException("Kullanıcı yeterli izne sahip değil");
                }
            }


            this.Id = id;
            this.Name = name;
            this._user = user;
        }







    }
}
