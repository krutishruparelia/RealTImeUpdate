namespace Scheduler.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_downloadhistory
    {
        public int ID { get; set; }

        [StringLength(1000)]
        public string FileName { get; set; }

        [StringLength(500)]
        public string Msg { get; set; }

        public DateTime? Date { get; set; }
    }
}
