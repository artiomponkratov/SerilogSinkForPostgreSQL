﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="TestObjectType2.cs" company="Haemmer Electronics">
// The project is licensed under the MIT license.
// </copyright>
// <summary>
//   This class is used as an example test object.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace SerilogSinksPostgreSQL.IntegrationTests.Objects
{
    using System;

    /// <summary>
    ///     This class is used as an example test object.
    /// </summary>
    public class TestObjectType2
    {
        /// <summary>
        ///     Gets or sets the date property.
        /// </summary>
        /// <value>
        ///     The date property.
        /// </value>
        // ReSharper disable once UnusedAutoPropertyAccessor.Global
        public DateTime DateProp { get; set; }

        /// <summary>
        ///     Gets or sets the nested property.
        /// </summary>
        /// <value>
        ///     The nested property.
        /// </value>
        // ReSharper disable once UnusedAutoPropertyAccessor.Global
        public TestObjectType1 NestedProp { get; set; }
    }
}