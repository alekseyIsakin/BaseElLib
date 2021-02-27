using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using BaseLib;
using Lib.String;

namespace Lib
{
    static public class StringLib
    {
        static public List<ExternalLib> GetExternalLibs() 
        {
            List<ExternalLib> externalLibs = new List<ExternalLib>();

            ExternalLib dt = new ExternalLib(PageString.ID, PageString.Name,
                () => new PageString(),
                (pl) => new UIPageString(pl),
                XmlBehavior.ReadXMLPageString,
                XmlBehavior.WritePageStringToXml);

            externalLibs.Add(dt);

            return externalLibs;
        }
    }
}
