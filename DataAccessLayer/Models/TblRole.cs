﻿using System;
using System.Collections.Generic;

namespace DataAccessLayer.Models;

public partial class TblRole
{
    public string Roleid { get; set; } = null!;

    public string? Name { get; set; }
}
