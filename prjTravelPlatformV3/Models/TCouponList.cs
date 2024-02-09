﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace prjTravelPlatformV3.Models;

public partial class TCouponList
{
    public int FCouponId { get; set; }

    public string FCouponCode { get; set; }

    public string FCouponName { get; set; }

    public decimal? FAmount { get; set; }

    public DateTime? FStartDate { get; set; }

    public DateTime? FEndDate { get; set; }

    public string FRule { get; set; }

    public int? FProductType { get; set; }

    public decimal? FDiscount { get; set; }

    public string FNote { get; set; }

    public bool? FEnable { get; set; }

    public virtual TProductType FProductTypeNavigation { get; set; }

    public virtual ICollection<TCusCouponQty> TCusCouponQties { get; set; } = new List<TCusCouponQty>();

    public virtual ICollection<TForder> TForders { get; set; } = new List<TForder>();

    public virtual ICollection<THorder> THorders { get; set; } = new List<THorder>();

    public virtual ICollection<TIorder> TIorders { get; set; } = new List<TIorder>();

    public virtual ICollection<TRcarRentOrder> TRcarRentOrders { get; set; } = new List<TRcarRentOrder>();

    public virtual ICollection<TVorder> TVorders { get; set; } = new List<TVorder>();

    public virtual ICollection<TdestinationOrder> TdestinationOrders { get; set; } = new List<TdestinationOrder>();

    public virtual ICollection<TtravelOrder> TtravelOrders { get; set; } = new List<TtravelOrder>();
}