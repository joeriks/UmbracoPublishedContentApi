using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Umbraco.Web.Mvc;
using Umbraco.Web.WebApi;

namespace OurPublishedContentApi
{
    [PluginController("PublishedContent")]
    public class NodeController : UmbracoApiController
    {
        public object GetNode(int? id=0)
        {            
            var node = umbraco.uQuery.GetNode(id??0);
            return ContentHelpers.NodeProperties(node);
        }
        public object GetNode(string path)
        {
            var node = umbraco.uQuery.GetNodeByUrl(path);
            return ContentHelpers.NodeProperties(node);
        }
        public object GetChildren(int? id = 0)
        {
            var node = umbraco.uQuery.GetNode(id ?? 0);
            return ContentHelpers.Children(node);
        }
        public object GetChildren(string path)
        {
            var node = umbraco.uQuery.GetNodeByUrl(path);
            return ContentHelpers.Children(node);
        }
        public object GetAncestors(int? id = 0)
        {
            var node = umbraco.uQuery.GetNode(id ?? 0);
            return ContentHelpers.Ancestors(node);
        }
        public object GetAncestors(string path)
        {
            var node = umbraco.uQuery.GetNodeByUrl(path);
            return ContentHelpers.Ancestors(node);
        }
        public object GetParent(int? id = 0)
        {
            var node = umbraco.uQuery.GetNode(id ?? 0);
            return ContentHelpers.Parent(node);
        }
        public object GetParent(string path)
        {
            var node = umbraco.uQuery.GetNodeByUrl(path);
            return ContentHelpers.Parent(node);
        }
    }


}
