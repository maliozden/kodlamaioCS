﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete;

public class Person
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public long Id { get; set; }
    public int BirthYear { get; set; }
}
