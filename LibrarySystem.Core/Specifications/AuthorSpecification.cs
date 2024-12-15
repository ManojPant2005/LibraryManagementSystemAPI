﻿using LibrarySystem.Core.Entitties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem.Core.Specifications
{
    public class AuthorSpecification : BaseSpecification<Auther>
    {
        public AuthorSpecification() : base()
        {
            Includes.Add(a => a.Books);
        }
    }
}
