﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace prjTravelPlatformV3.Models;

public partial class TRcarRentOrderDetail
{
    public int FOrderDetailId { get; set; }

    public string FOrderId { get; set; }

    public int? FCarId { get; set; }

    public int? FDriverId { get; set; }

    public DateTime? FFromDateTime { get; set; }

    public DateTime? FRentDateTime { get; set; }

    public int? FDropLocId { get; set; }

    public decimal? FPrice { get; set; }

    public virtual TRcarInfo FCar { get; set; }

    public virtual TRdriverInfo FDriver { get; set; }

    public virtual TRservicePoint FDropLoc { get; set; }

    public virtual TRcarRentOrder FOrder { get; set; }
}