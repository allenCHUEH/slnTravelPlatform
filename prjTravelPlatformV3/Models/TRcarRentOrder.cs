﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace prjTravelPlatformV3.Models;

public partial class TRcarRentOrder
{
    public string FOrderId { get; set; }

    public int? FMemberId { get; set; }

    public int? FCouponId { get; set; }

    public int? FPaymentId { get; set; }

    public int? FPaymentStatusId { get; set; }

    public int? FOrderStatusId { get; set; }

    public string FOrderDate { get; set; }

    public string FContractDocPath { get; set; }

    public virtual TCouponList FCoupon { get; set; }

    public virtual TCustomer FMember { get; set; }

    public virtual TRorderStatus FOrderStatus { get; set; }

    public virtual TRpaymentMethod FPayment { get; set; }

    public virtual TRpaymentStatus FPaymentNavigation { get; set; }

    public virtual ICollection<TRcarRentOrderDetail> TRcarRentOrderDetails { get; set; } = new List<TRcarRentOrderDetail>();
}