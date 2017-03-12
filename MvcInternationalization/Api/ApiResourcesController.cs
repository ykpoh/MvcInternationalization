using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Web.Http;
using MvcInternationalization.Helpers;

namespace MvcInternationalization.Api
{
    public class ApiResourcesController : ApiController
    {
        [HttpGet]
        public IHttpActionResult GetResources(string cultureName)
        {
            cultureName = CultureHelper.GetImplementedCulture(cultureName);

            // Modify current thread's cultures            
            Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo(cultureName);
            Thread.CurrentThread.CurrentUICulture = Thread.CurrentThread.CurrentCulture;

            var resources =
                Resources.Resources.ResourceManager.GetResourceSet(CultureInfo.CurrentUICulture,
                    true, true);
            var resDictionary = new Dictionary<string, string>();

            foreach (DictionaryEntry resource in resources)
            {
                resDictionary.Add(resource.Key.ToString(), resource.Value.ToString());
            }

            return Ok(resDictionary);
        }
    }
}