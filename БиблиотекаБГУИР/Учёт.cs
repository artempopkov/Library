namespace БиблиотекаБГУИР
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Учёт
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Учёт()
        {
            Карта_Читателя = new HashSet<Карта_Читателя>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        public int Книга_ID { get; set; }

        public int Статус_ID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Карта_Читателя> Карта_Читателя { get; set; }

        public virtual Книги Книги { get; set; }

        public virtual Статусы Статусы { get; set; }
    }
}
