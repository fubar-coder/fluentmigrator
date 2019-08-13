#region License
//
// Copyright (c) 2007-2018, Sean Chambers <schambers80@gmail.com>
// Copyright (c) 2010, Nathan Brown
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//   http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//
#endregion

using System;

using FluentMigrator.Runner.BatchParser;
using FluentMigrator.Runner.Generators.SqlAnywhere;
using FluentMigrator.Runner.Initialization;

using JetBrains.Annotations;

using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace FluentMigrator.Runner.Processors.SqlAnywhere
{
    // ReSharper disable once ClassNeverInstantiated.Global
    public sealed class SqlAnywhere16Processor : SqlAnywhereProcessor
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SqlAnywhere16Processor"/> class.
        /// </summary>
        /// <param name="factory">The DB provider factory.</param>
        /// <param name="generator">The migration generator.</param>
        /// <param name="logger">The logger.</param>
        /// <param name="options">The processor options.</param>
        /// <param name="connectionStringAccessor">The connection string accessor.</param>
        /// <param name="batchParserFactory">The SQL batch parser factory.</param>
        public SqlAnywhere16Processor(
            [NotNull] SqlAnywhereDbFactory factory,
            [NotNull] SqlAnywhere16Generator generator,
            [NotNull] ILogger<SqlAnywhere16Processor> logger,
            [NotNull] IOptionsSnapshot<ProcessorOptions> options,
            [NotNull] IConnectionStringAccessor connectionStringAccessor,
            [NotNull] ISqlBatchParserFactory batchParserFactory)
            : base(
                "SqlAnywhere16",
                () => factory.Factory,
                generator,
                logger,
                options,
                connectionStringAccessor,
                batchParserFactory)
        {
        }

        [Obsolete]
        public SqlAnywhere16Processor(
            [NotNull] SqlAnywhereDbFactory factory,
            [NotNull] SqlAnywhere16Generator generator,
            [NotNull] ILogger<SqlAnywhere16Processor> logger,
            [NotNull] IOptionsSnapshot<ProcessorOptions> options,
            [NotNull] IConnectionStringAccessor connectionStringAccessor,
            [NotNull] IServiceProvider serviceProvider)
            : base(
                "SqlAnywhere16",
                () => factory.Factory,
                generator,
                logger,
                options,
                connectionStringAccessor,
                serviceProvider)
        {
        }
    }
}
