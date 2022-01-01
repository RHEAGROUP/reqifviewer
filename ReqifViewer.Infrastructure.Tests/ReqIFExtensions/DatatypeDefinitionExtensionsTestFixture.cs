﻿// -------------------------------------------------------------------------------------------------
// <copyright file="DatatypeDefinitionExtensionsTestFixture.cs" company="RHEA System S.A.">
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

namespace ReqifViewer.Infrastructure.Tests.ReqIFExtensions
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;
    using System.Xml;

    using NUnit.Framework;

    using ReqIFSharp;
    using ReqifViewer.Infrastructure.ReqIFExtensions;

    /// <summary>
    /// Suite of tests for the <see cref="DatatypeDefinitionExtensions"/> class
    /// </summary>
    [TestFixture]
    public class DatatypeDefinitionExtensionsTestFixture
    {
        [Test]
        public void Verify_that_QueryDatatypeName_returns_expected_results()
        {
            var datatypeDefinitionBoolean = new DatatypeDefinitionBoolean();
            Assert.That(datatypeDefinitionBoolean.QueryDatatypeName(), Is.EqualTo("Boolean"));

            var datatypeDefinitionDate = new DatatypeDefinitionDate();
            Assert.That(datatypeDefinitionDate.QueryDatatypeName(), Is.EqualTo("Date"));

            var datatypeDefinitionEnumeration = new DatatypeDefinitionEnumeration();
            Assert.That(datatypeDefinitionEnumeration.QueryDatatypeName(), Is.EqualTo("Enumeration"));

            var datatypeDefinitionInteger = new DatatypeDefinitionInteger();
            Assert.That(datatypeDefinitionInteger.QueryDatatypeName(), Is.EqualTo("Integer"));

            var datatypeDefinitionReal = new DatatypeDefinitionReal();
            Assert.That(datatypeDefinitionReal.QueryDatatypeName(), Is.EqualTo("Real"));

            var datatypeDefinitionString = new DatatypeDefinitionString();
            Assert.That(datatypeDefinitionString.QueryDatatypeName(), Is.EqualTo("String"));

            var datatypeDefinitionXhtml = new DatatypeDefinitionXHTML();
            Assert.That(datatypeDefinitionXhtml.QueryDatatypeName(), Is.EqualTo("XHTML"));
        }
    }
}
