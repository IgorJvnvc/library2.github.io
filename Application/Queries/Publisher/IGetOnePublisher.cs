﻿using Application.DataTransfer;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Queries.Publisher
{
    public interface IGetOnePublisher : IQuery<PublisherDto,int>
    {
    }
}
