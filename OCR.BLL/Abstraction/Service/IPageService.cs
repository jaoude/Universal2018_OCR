﻿using OCR.BLL.Dto.Request;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OCR.BLL.Abstraction.Service
{
    public interface IPageService
    {
        Task UploadPages(List<PageUploadDto> pages, CancellationToken ct);
    }
}