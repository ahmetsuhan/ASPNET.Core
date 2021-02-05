using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Valdiation;

namespace WebApi.Abstract
{
    public abstract  class Person
    {
        [Required(ErrorMessage ="Id boş bırakılamaz")]
        [Range(1,100000,ErrorMessage ="Belirtilen değer uygun aralıklarda değil")]
        public int  Id { get; set; }
        [StringLength(50,ErrorMessage ="FirstName maksimum 50 karakter olabilir.")]
        public string FirstName { get; set; }
        [StringLength(50, ErrorMessage = "LastName maksimum 50 karakter olabilir.")]
        public string LastName { get; set; }
        public string Address { get; set; }

        [CityValidation("Türkiye",ErrorMessage = "Türkiye'de böyle bir şehir ismi yok!")]
        public string City { get; set; }
        [CountryValidation("Türkiye",ErrorMessage ="Bu ülke Türkiye değil :)")]
        public string Country { get; set; }
        public DateTime BirthDate { get; set; }

    }
}
