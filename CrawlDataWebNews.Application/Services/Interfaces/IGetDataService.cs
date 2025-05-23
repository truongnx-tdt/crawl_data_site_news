﻿// "-----------------------------------------------------------------------
//  <copyright file="IGetDataService.cs" author=TDT>
//      Copyright (c) TDT. All rights reserved.
//  </copyright>
// -----------------------------------------------------------------------"

using CrawlDataWebNews.Data.Response;

namespace CrawlDataWebNews.Application.Services.Interfaces
{
    public interface IGetDataService 
    {
        Task<ICollection<CategoriesResponse>> GetData(string url);
        Task<CategoriesResponse> GetByCtg(string url, string extension);
    }
}
