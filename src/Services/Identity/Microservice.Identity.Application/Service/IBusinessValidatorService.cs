﻿using Microservice.Identity.Domain.Model.Identity;
using Microservices.Core.Utilities.Result.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microservice.Identity.Application.Service
{
    public interface IBusinessValidatorService
    {
        #region Proje içerisinde yürütülecek olan business kuralları
        public Task ExecuteRegisterRules(RegisterRequest request);
        public Task ExecuteConfirmEmailRules();
        public Task ExecuteForgotPasswordRules();
        public Task ExecuteResetPasswordRules();
        public Task ExecuteLoginUserRules(UserLoginRequest request);
        public Task ExecuteLoginWithRefreshTokenRules();
        public Task ExecuteLoginClientRules(ClientLoginRequest request);
        #endregion
    }
}