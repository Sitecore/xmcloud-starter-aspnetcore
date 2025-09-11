using Sitecore.LayoutService.Configuration;
using Sitecore.LayoutService.ItemRendering.ContentsResolvers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Sitecore.Data.Items;
using Sitecore.Mvc.Presentation;

namespace XmCloudAspNetCoreStarter.ContentResolvers
{
    public class CardResolver : RenderingContentsResolver
    {
        public override object ResolveContents(Rendering rendering, IRenderingConfiguration renderingConfig)
        {

            return new
            {
                Title = rendering.Item?.Fields["Title"]?.Value ?? string.Empty,
                Description = rendering.Item?.Fields["Description"]?.Value ?? string.Empty,
                Image = rendering.Item?.Fields["Image"]?.Value ?? string.Empty,
                Link = rendering.Item?.Fields["Link"]?.Value ?? string.Empty

            };    
        }
    }
}