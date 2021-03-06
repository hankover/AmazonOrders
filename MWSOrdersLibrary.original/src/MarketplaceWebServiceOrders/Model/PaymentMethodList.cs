/*******************************************************************************
 * Copyright 2009-2013 Amazon Services. All Rights Reserved.
 * Licensed under the Apache License, Version 2.0 (the "License"); 
 *
 * You may not use this file except in compliance with the License. 
 * You may obtain a copy of the License at: http://aws.amazon.com/apache2.0
 * This file is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR 
 * CONDITIONS OF ANY KIND, either express or implied. See the License for the 
 * specific language governing permissions and limitations under the License.
 *******************************************************************************
 * Payment Method List
 * API Version: 2011-01-01
 * Library Version: 2013-11-01
 * Generated: Fri Nov 08 21:29:21 GMT 2013
 */


using System;
using System.Xml;
using System.Collections.Generic;
using System.Xml.Serialization;
using MWSClientCsRuntime;

namespace MarketplaceWebServiceOrders.Model
{
    [XmlTypeAttribute(Namespace = "https://mws.amazonservices.com/Orders/2011-01-01")]
    [XmlRootAttribute(Namespace = "https://mws.amazonservices.com/Orders/2011-01-01", IsNullable = false)]
    public class PaymentMethodList : AbstractMwsObject
    {

        private List<string> _method;

        /// <summary>
        /// Gets and sets the Method property.
        /// </summary>
        [XmlElementAttribute(ElementName = "Method")]
        public List<string> Method
        {
            get
            {
                if(this._method == null)
                {
                    this._method = new List<string>();
                }
                return this._method;
            }
            set { this._method = value; }
        }

        /// <summary>
        /// Sets the Method property.
        /// </summary>
        /// <param name="method">Method property.</param>
        /// <returns>this instance.</returns>
        public PaymentMethodList WithMethod(string[] method)
        {
            this._method.AddRange(method);
            return this;
        }

        /// <summary>
        /// Checks if Method property is set.
        /// </summary>
        /// <returns>true if Method property is set.</returns>
        public bool IsSetMethod()
        {
            return this.Method.Count > 0;
        }


        public override void ReadFragmentFrom(IMwsReader reader)
        {
            _method = reader.ReadList<string>("Method");
        }

        public override void WriteFragmentTo(IMwsWriter writer)
        {
            writer.WriteList("Method", _method);
        }

        public override void WriteTo(IMwsWriter writer)
        {
            writer.Write("https://mws.amazonservices.com/Orders/2011-01-01", "PaymentMethodList", this);
        }

        public PaymentMethodList() : base()
        {
        }
    }
}
