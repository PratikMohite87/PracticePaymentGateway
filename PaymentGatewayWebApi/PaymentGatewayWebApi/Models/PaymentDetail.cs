using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PaymentGatewayWebApi.Models
{
    public class PaymentDetail
    {
        [Key]
        public int PaymentDetailId { set; get; }
        [Column(TypeName ="nvarchar(100)")]
        public string CardOwnerName { set; get; }
        [Column(TypeName = "nvarchar(16)")]
        public string CardNumber { set; get; }
        [Column(TypeName = "nvarchar(5)")]
        public string ExpirationDate { set; get; }
        [Column(TypeName = "nvarchar(3)")]
        public string SecurityCode { set; get; }
    }
}
