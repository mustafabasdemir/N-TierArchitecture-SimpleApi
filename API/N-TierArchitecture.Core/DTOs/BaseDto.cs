using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N_TierArchitecture.Core.DTOs
{
    public class BaseDto
    {
        /*
         
        dto  : veri tabanından  gelen bilginin hepsini değilde bizim kullanıcıya vermek ıstediklerimiizi belirleriz 
         
        public class UserDto
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Email { get; set; }
        }


        Bu UserDto sınıfı, bir User veritabanı modelindeki tüm verileri değil, sadece API aracılığıyla dış dünyaya gösterilmesi gereken kısımları içerir.
         
         
         */


        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
