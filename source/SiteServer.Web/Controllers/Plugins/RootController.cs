﻿using System;
using System.Web.Http;
using SiteServer.CMS.Controllers.Plugins;
using SiteServer.CMS.Core;
using SiteServer.CMS.Plugin;
using SiteServer.Plugin.Hooks;

namespace SiteServer.API.Controllers.Plugins
{
    [RoutePrefix("api")]
    public class RootController : ApiController
    {
        [HttpGet, Route(Root.Route)]
        public IHttpActionResult Get(string pluginId)
        {
            try
            {
                var restful = PluginCache.GetHook<IRestful>(pluginId);

                if (restful == null)
                {
                    return NotFound();
                }

                var body = new RequestBody();

                return Ok(restful.Get(body));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost, Route(Root.Route)]
        public IHttpActionResult Post(string pluginId)
        {
            try
            {
                var restful = PluginCache.GetHook<IRestful>(pluginId);

                if (restful == null)
                {
                    return NotFound();
                }

                var body = new RequestBody();

                return Ok(restful.Post(body));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut, Route(Root.Route)]
        public IHttpActionResult Put(string pluginId)
        {
            try
            {
                var restful = PluginCache.GetHook<IRestful>(pluginId);

                if (restful == null)
                {
                    return NotFound();
                }

                var body = new RequestBody();

                return Ok(restful.Put(body));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete, Route(Root.Route)]
        public IHttpActionResult Delete(string pluginId)
        {
            try
            {
                var restful = PluginCache.GetHook<IRestful>(pluginId);

                if (restful == null)
                {
                    return NotFound();
                }

                var body = new RequestBody();

                return Ok(restful.Delete(body));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPatch, Route(Root.Route)]
        public IHttpActionResult Patch(string pluginId)
        {
            try
            {
                var restful = PluginCache.GetHook<IRestful>(pluginId);

                if (restful == null)
                {
                    return NotFound();
                }

                var body = new RequestBody();

                return Ok(restful.Patch(body));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
