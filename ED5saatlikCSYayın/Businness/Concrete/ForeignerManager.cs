﻿using Businness.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Businness.Concrete;

public class ForeignerManager : IApplicantService
{
    public void ApplyForMask(Person person)
    {

    }
    public List<Person> GetList()
    {

        return null;
    }
    public bool CheckPerson(Person person)
    {
        return true;
    }

}
