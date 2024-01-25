namespace Semifinals.Filters.Policies.Nodes;

public class XSetUrl : XElement
{
    public XSetUrl(string url) : base("set-url")
    {
        Add(url);
    }
}