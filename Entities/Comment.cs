using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entities
{
    public class Comment
    {
        public int Id { get; set; }
        [DisplayName("Ürün")]
        public string Contents { get; set; }
        public int ProductId { get; set; }

        public virtual Product Product { get; set; }
        [DisplayName("Kullanıcı")]
        public int UserId { get; set; }
        public virtual User User { get; set; }

        public DateTime Date { get; set; }


    }
}
