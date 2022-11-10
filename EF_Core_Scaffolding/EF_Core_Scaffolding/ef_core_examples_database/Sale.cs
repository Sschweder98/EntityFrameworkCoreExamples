using System;
using System.Collections.Generic;

namespace EF_Core_Scaffolding.ef_core_examples_database
{
    public partial class Sale
    {
        public int Id { get; set; }
        public string? CostumerName { get; set; }
        public int? OrderNumber { get; set; }
        public string? ShippingAdress { get; set; }
        public string? Product { get; set; }
        public int? Quantity { get; set; }
        public decimal? Value { get; set; }
        public bool? IsPaymentRecieved { get; set; }
        public bool? IsShiped { get; set; }
        public bool? IsDelivered { get; set; }
    }
}
