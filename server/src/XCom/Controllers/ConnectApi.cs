/*
 * XCom.API
 *
 * This API is responsible for enabling communication with SendGrid. It implements additional features such as data retention and A/B Testing for specific templates.
 *
 * The version of the OpenAPI document: 4.0
 * Contact: phil.hotchkiss@veteransunited.com
 * Generated by: https://openapi-generator.tech
 */

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Swashbuckle.AspNetCore.Annotations;
using Swashbuckle.AspNetCore.SwaggerGen;
using Newtonsoft.Json;
using XCom.Attributes;
using XCom.Models;

namespace XCom.Controllers
{ 
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    public abstract class ConnectApiController : ControllerBase
    { 
        /// <summary>
        /// Webhook for SendGrid Events
        /// </summary>
        /// <remarks>Webhook to Receive SendGrid Events</remarks>
        /// <param name="sendgridWebhook">Webhook</param>
        /// <response code="200">Webhook Event Receive</response>
        /// <response code="400">Webhook Event Not Receive</response>
        [HttpPost]
        [Route("/connect")]
        [Consumes("application/json")]
        [ValidateModelState]
        [SwaggerOperation("Connect")]
        [SwaggerResponse(statusCode: 200, type: typeof(string), description: "Webhook Event Receive")]
        [SwaggerResponse(statusCode: 400, type: typeof(string), description: "Webhook Event Not Receive")]
        public abstract IActionResult Connect([FromBody]List<SendgridWebhook> sendgridWebhook);
    }
}
