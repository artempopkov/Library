namespace БиблиотекаБГУИР
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Библиотекари
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [Required]
        [StringLength(30)]
        public string Имя { get; set; }

        [Required]
        [StringLength(30)]
        public string Фамилия { get; set; }

        [StringLength(13)]
        public string Номер_телефона { get; set; }
    }
}
