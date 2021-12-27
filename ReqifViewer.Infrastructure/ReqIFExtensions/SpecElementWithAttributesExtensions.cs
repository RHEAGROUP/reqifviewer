﻿// -------------------------------------------------------------------------------------------------
// <copyright file="SpecElementWithAttributesExtensions.cs" company="RHEA System S.A.">
//
//   Copyright 2021 RHEA System S.A.
//
//   Licensed under the Apache License, Version 2.0 (the "License");
//   you may not use this file except in compliance with the License.
//   You may obtain a copy of the License at
//
//       http://www.apache.org/licenses/LICENSE-2.0
//
//   Unless required by applicable law or agreed to in writing, software
//   distributed under the License is distributed on an "AS IS" BASIS,
//   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//   See the License for the specific language governing permissions and
//   limitations under the License.
//
// </copyright>
// -------------------------------------------------------------------------------------------------

namespace ReqifViewer.Infrastructure.ReqIFExtensions
{
    using System.Linq;

    using Microsoft.AspNetCore.Components;

    using ReqIFSharp;

    /// <summary>
    /// The <see cref="SpecElementWithAttributesExtensions"/> class provides a number of extension methods for the <see cref="SpecElementWithAttributes"/> class
    /// </summary>
    public static class SpecElementWithAttributesExtensions
    {
        /// <summary>
        /// Extracts the name (value to be displayed to the user) of the <see cref="SpecElementWithAttributes"/>
        /// </summary>
        /// <param name="specElementWithAttributes">
        /// The subject <see cref="SpecElementWithAttributes"/>
        /// </param>
        /// <returns>
        /// an object that represents the <see cref="specElementWithAttributes"/> name (value to be displayed to the user)
        /// </returns>
        /// <remarks>
        /// 1. The <see cref="Identifiable.LongName"/> is returned in case it is not empty or null
        /// 2. The first <see cref="AttributeValue"/> is returned in case it is not null (order matters, results may be unexpected and are determined on order in the original ReqIF document)
        /// 3. The <see cref="Identifiable.Identifier"/> is returned in case the <see cref="Identifiable.LongName"/> is empty or null and no <see cref="AttributeValue"/>s are present
        /// </remarks>
        public static object ExtractDisplayName(this SpecElementWithAttributes specElementWithAttributes)
        {
            if (string.IsNullOrEmpty(specElementWithAttributes.LongName))
            {
                var attributeValue = specElementWithAttributes.Values.FirstOrDefault();
                if (attributeValue != null)
                {
                    if (attributeValue is AttributeValueXHTML attributeValueXhtml)
                    {
                        var markupString = new MarkupString(attributeValueXhtml.TheValue);
                        return markupString;
                    }
                    else
                    {
                        return attributeValue.ObjectValue.ToString();
                    }
                }
                else
                {
                    return specElementWithAttributes.Identifier;
                }
            }
            else
            {
                return specElementWithAttributes.LongName;
            }
        }
    }
}