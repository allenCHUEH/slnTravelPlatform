﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace prjTravelPlatformV3.Models;

public partial class TEmployeeStaff
{
    public int FStaffId { get; set; }

    public string FStaff { get; set; }

    public virtual ICollection<TEmployee> TEmployees { get; set; } = new List<TEmployee>();
}