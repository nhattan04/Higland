//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CSDL.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblBill
    {
        public tblBill()
        {
            this.tblDetailBills = new HashSet<tblDetailBill>();
        }
    
        public int IDBill { get; set; }
        public Nullable<System.DateTime> BillDate { get; set; }
        public Nullable<int> IDStaff { get; set; }
        public Nullable<int> UserID { get; set; }
        public Nullable<double> TotalPay { get; set; }
        public string codeCus { get; set; }
    
        public virtual tblCustumer tblCustumer { get; set; }
        public virtual tblStaff tblStaff { get; set; }
        public virtual ICollection<tblDetailBill> tblDetailBills { get; set; }
    }
}
