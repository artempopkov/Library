namespace БиблиотекаБГУИР
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Читатели
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Читатели()
        {
            Карта_Читателя = new HashSet<Карта_Читателя>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [Required]
        [StringLength(30)]
        public string Иия { get; set; }

        [Required]
        [StringLength(30)]
        public string Фамилия { get; set; }

        public bool? Пол { get; set; }

        [StringLength(13)]
        public string Номер_телефона { get; set; }

        public int Адрес_ID { get; set; }

        public virtual Адреса Адреса { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Карта_Читателя> Карта_Читателя { get; set; }
    }
}
