﻿using BlogDotNetCore.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlogDotNetCore.Repository
{
    public class ArticleInfoRepository : EFCoreBaseRepository<articleInfoDto>, IArticleInfoRepository
    {
        public ArticleInfoRepository(IEFCoreUnitOfWork efCoreUnitOfWork) : base(efCoreUnitOfWork)
        {

        }
    }
}