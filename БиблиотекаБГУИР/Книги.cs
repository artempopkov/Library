namespace БиблиотекаБГУИР
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Книги
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Книги()
        {
            Учёт = new HashSet<Учёт>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        public string Наименовние { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Дата_издания { get; set; }

        public int Автор_ID { get; set; }

        public int? Шифр { get; set; }

        public int? Категория_ID { get; set; }

        public virtual Авторы Авторы { get; set; }

        public virtual Категории Категории { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Учёт> Учёт { get; set; }
    }
}
