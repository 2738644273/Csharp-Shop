using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayZdataassetsFcdatalabZdatamergetaskResponse.
    /// </summary>
    public class AlipayZdataassetsFcdatalabZdatamergetaskResponse : AopResponse
    {
        /// <summary>
        /// θΏεη»ζ
        /// </summary>
        [XmlElement("result")]
        public string Result { get; set; }
    }
}
