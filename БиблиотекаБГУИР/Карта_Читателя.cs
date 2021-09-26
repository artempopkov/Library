namespace БиблиотекаБГУИР
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Карта_Читателя
    {
        [StringLength(10)]
        public string ID { get; set; }

        public int Читатель_ID { get; set; }

        public int Книга_ID { get; set; }

        [Column(TypeName = "date")]
        public DateTime Дата_заказа { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Дата_возврата { get; set; }

        public virtual Учёт Учёт { get; set; }

        public virtual Читатели Читатели { get; set; }
    }
}
