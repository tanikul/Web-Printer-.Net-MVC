//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebPrinter.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class DetailDataPrinter
    {
        public int id { get; set; }
        public int id_headdataprinter { get; set; }
        public string id_printer { get; set; }
        public string id_paper { get; set; }
        public string id_finishing { get; set; }
        public Nullable<int> id_job_type { get; set; }
        public Nullable<int> id_transfer { get; set; }
        public Nullable<int> quantity { get; set; }
        public Nullable<int> lose { get; set; }
        public Nullable<int> color_print { get; set; }
        public Nullable<int> black_print { get; set; }
        public Nullable<double> width { get; set; }
        public Nullable<double> height { get; set; }
        public Nullable<double> vat { get; set; }
        public Nullable<double> discount { get; set; }
        public Nullable<double> paper_cost { get; set; }
        public Nullable<double> printer_cost { get; set; }
        public Nullable<double> finishing_cost { get; set; }
        public Nullable<double> profit { get; set; }
        public Nullable<System.DateTime> recieve_date { get; set; }
    
        public virtual HeadDataPrinter HeadDataPrinter { get; set; }
    }
}