using umbraco.NodeFactory;
using System.Linq;
using umbraco;

namespace OurPublishedContentApi
{
    public class ContentHelpers
    {
        public static object Children(Node node)
        {
            return node.ChildrenAsList.Select(n => NodeProperties(n as Node));
        }
        public static object Parent(Node node)
        {
            return NodeProperties(node.Parent as Node);
        }
        public static object Ancestors(Node node)
        {
            return node.GetAncestorNodes().Select(n => NodeProperties(n));
        }
        public static object Descendants(Node node)
        {
            return node.GetDescendantNodes().Select(n => NodeProperties(n));
        }
        public static object NodeProperties(Node node)
        {
            return
            new
            {
                node.Id,
                node.Level,
                node.NiceUrl,
                node.Name,
                node.UrlName,
                node.NodeTypeAlias,
                node.CreatorName,
                node.template,
                /*Template = template.Alias,*/
                Properties = node.PropertiesAsList.Select(p => new { p.Alias, Value = p.Value }).ToDictionary(k => k.Alias, k => k.Value),
                node.CreateDate,
                node.UpdateDate,
                node.SortOrder,
                node.Url,
                ParentId = (node.Parent != null) ? node.Parent.Id : -1,
                ChildIds = node.ChildrenAsList.Select(n => n.Id)
            };
        }
    }
}