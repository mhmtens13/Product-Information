//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class Order
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Order()
        {
            this.MyCarts = new HashSet<MyCart>();
        }
    
        public int OrderID { get; set; }
        public string Address { get; set; }
        public Nullable<int> ProductCode { get; set; }
        public Nullable<int> CustomerID { get; set; }
        public Nullable<int> SupplierID { get; set; }
        public Nullable<int> CategoryID { get; set; }
        public Nullable<int> TypeID { get; set; }
        public Nullable<int> ProductID { get; set; }
        public Nullable<int> BrandID { get; set; }
        public Nullable<int> ModelID { get; set; }
        public Nullable<int> CountryID { get; set; }
        public Nullable<int> CityID { get; set; }
        public Nullable<int> ShipperID { get; set; }
    
        public virtual Brands Brand { get; set; }
        public virtual Category Category { get; set; }
        public virtual City City { get; set; }
        public virtual Country Country { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual Models Model { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MyCart> MyCarts { get; set; }
        public virtual Product Product { get; set; }
        public virtual Shipper Shipper { get; set; }
        public virtual Supplier Supplier { get; set; }
        public virtual ProductTypes ProductType { get; set; }
    }
}
