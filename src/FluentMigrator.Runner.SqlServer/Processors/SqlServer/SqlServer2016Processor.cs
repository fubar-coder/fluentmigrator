#region License
// Copyright (c) 2018, FluentMigrator Project
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
// http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
#endregion

using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;

using FluentMigrator.Runner.BatchParser;
using FluentMigrator.Runner.Generators.SqlServer;
using FluentMigrator.Runner.Initialization;

using JetBrains.Annotations;

using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace FluentMigrator.Runner.Processors.SqlServer
{
    public class SqlServer2016Processor : SqlServerProcessor
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SqlServer2016Processor"/> class.
        /// </summary>
        /// <param name="logger">The logger.</param>
        /// <param name="quoter">The quoter.</param>
        /// <param name="generator">The migration generator.</param>
        /// <param name="options">The processor options.</param>
        /// <param name="connectionStringAccessor">The connection string accessor.</param>
        /// <param name="batchParserFactory">The batch parser factory.</param>
        public SqlServer2016Processor(
            [NotNull] ILogger<SqlServer2016Processor> logger,
            [NotNull] SqlServer2008Quoter quoter,
            [NotNull] SqlServer2016Generator generator,
            [NotNull] IOptionsSnapshot<ProcessorOptions> options,
            [NotNull] IConnectionStringAccessor connectionStringAccessor,
            [NotNull] SqlServerBatchParserFactory batchParserFactory)
            : base(new[] { "SqlServer2016", "SqlServer" }, SqlClientFactory.Instance, generator, quoter, logger, options, connectionStringAccessor, batchParserFactory)
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SqlServer2016Processor"/> class.
        /// </summary>
        /// <param name="logger">The logger.</param>
        /// <param name="quoter">The quoter.</param>
        /// <param name="generator">The migration generator.</param>
        /// <param name="options">The processor options.</param>
        /// <param name="connectionStringAccessor">The connection string accessor.</param>
        /// <param name="serviceProvider">The service provider</param>
        [Obsolete]
        public SqlServer2016Processor(
            [NotNull] ILogger<SqlServer2016Processor> logger,
            [NotNull] SqlServer2008Quoter quoter,
            [NotNull] SqlServer2016Generator generator,
            [NotNull] IOptionsSnapshot<ProcessorOptions> options,
            [NotNull] IConnectionStringAccessor connectionStringAccessor,
            [NotNull] IServiceProvider serviceProvider)
            : this(
                SqlClientFactory.Instance,
                logger,
                quoter,
                generator,
                options,
                connectionStringAccessor,
                serviceProvider)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SqlServer2016Processor"/> class.
        /// </summary>
        /// <param name="databaseTypes">The database type identifiers</param>
        /// <param name="factory">The DB provider factory.</param>
        /// <param name="logger">The logger.</param>
        /// <param name="quoter">The quoter.</param>
        /// <param name="generator">The migration generator.</param>
        /// <param name="options">The processor options.</param>
        /// <param name="connectionStringAccessor">The connection string accessor.</param>
        /// <param name="batchParserFactory">The batch parser factory.</param>
        protected SqlServer2016Processor(
            [NotNull] IEnumerable<string> databaseTypes,
            [NotNull] DbProviderFactory factory,
            [NotNull] ILogger logger,
            [NotNull] SqlServer2008Quoter quoter,
            [NotNull] SqlServer2016Generator generator,
            [NotNull] IOptionsSnapshot<ProcessorOptions> options,
            [NotNull] IConnectionStringAccessor connectionStringAccessor,
            [NotNull] SqlServerBatchParserFactory batchParserFactory)
            : base(
                databaseTypes,
                factory,
                generator,
                quoter,
                logger,
                options,
                connectionStringAccessor,
                batchParserFactory)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SqlServer2016Processor"/> class.
        /// </summary>
        /// <param name="factory">The DB provider factory.</param>
        /// <param name="logger">The logger.</param>
        /// <param name="quoter">The quoter.</param>
        /// <param name="generator">The migration generator.</param>
        /// <param name="options">The processor options.</param>
        /// <param name="connectionStringAccessor">The connection string accessor.</param>
        /// <param name="serviceProvider">The service provider</param>
        [Obsolete]
        protected SqlServer2016Processor(
            [NotNull] DbProviderFactory factory,
            [NotNull] ILogger logger,
            [NotNull] SqlServer2008Quoter quoter,
            [NotNull] SqlServer2016Generator generator,
            [NotNull] IOptionsSnapshot<ProcessorOptions> options,
            [NotNull] IConnectionStringAccessor connectionStringAccessor,
            [NotNull] IServiceProvider serviceProvider)
            : base(
                new[] { "SqlServer2016", "SqlServer" },
                factory,
                generator,
                quoter,
                logger,
                options,
                connectionStringAccessor,
                serviceProvider)
        {
        }
    }
}
