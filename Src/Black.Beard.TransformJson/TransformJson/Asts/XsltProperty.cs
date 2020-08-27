﻿namespace Bb.TransformJson.Asts
{

    public class XsltProperty : XsltJson
    {

        public XsltProperty()
        {
            this.Kind = XsltKind.Property;
        }

        public string Name{ get; set; }

        public XsltJson Value { get; set; }

        public override object Accept(IXsltJsonVisitor visitor)
        {
            return visitor.VisitProperty(this);
        }

    }

    public class XsltMapProperty : XsltJson
    {

        public XsltMapProperty()
        {
            this.Kind = XsltKind.Property;
        }

        public string Name { get; set; }

        public XsltJson Value { get; set; }

        public override object Accept(IXsltJsonVisitor visitor)
        {
            return visitor.VisitMapProperty(this);
        }

    }

}