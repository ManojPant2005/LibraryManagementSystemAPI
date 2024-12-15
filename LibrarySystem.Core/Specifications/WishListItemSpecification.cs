﻿using LibrarySystem.Core.Entitties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem.Core.Specifications
{
    public class WishListItemSpecification : BaseSpecification<WishlistItem>
    {
        public WishListItemSpecification(int bookId): base(wi => wi.BookId == bookId)
        {
            
        }
    }
}