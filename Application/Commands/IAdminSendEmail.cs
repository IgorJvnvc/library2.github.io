﻿using Application.Email;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Commands
{
    public interface IAdminSendEmail : ICommand<SendEmailDto>
    {
    }
}
