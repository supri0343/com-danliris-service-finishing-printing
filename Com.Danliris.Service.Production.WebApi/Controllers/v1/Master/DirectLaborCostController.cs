﻿using AutoMapper;
using Com.Danliris.Service.Finishing.Printing.Lib.BusinessLogic.Interfaces.Master;
using Com.Danliris.Service.Finishing.Printing.Lib.Models.Master.DirectLaborCost;
using Com.Danliris.Service.Finishing.Printing.Lib.ViewModels.Master.DirectLaborCost;
using Com.Danliris.Service.Production.Lib.Services.IdentityService;
using Com.Danliris.Service.Production.Lib.Services.ValidateService;
using Com.Danliris.Service.Production.WebApi.Utilities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Com.Danliris.Service.Finishing.Printing.WebApi.Controllers.v1.Master
{
    [Produces("application/json")]
    [ApiVersion("1.0")]
    [Route("v{version:apiVersion}/master/direct-labor-cost")]
    [Authorize]
    public class DirectLaborCostController : BaseController<DirectLaborCostModel, DirectLaborCostViewModel, IDirectLaborCostFacade>
    {
        public DirectLaborCostController(IIdentityService identityService, IValidateService validateService, IDirectLaborCostFacade facade, IMapper mapper) : base(identityService, validateService, facade, mapper, "1.0.0")
        {
        }
    }
}
