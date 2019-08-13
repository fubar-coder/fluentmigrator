#region License
// Copyright (c) 2019, FluentMigrator Project
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

using JetBrains.Annotations;

using Microsoft.Extensions.DependencyInjection;

namespace FluentMigrator.Runner.BatchParser
{
    /// <summary>
    /// Factory to create a <see cref="SqlBatchParser"/> for SQL Server.
    /// </summary>
    public class SqlServerBatchParserFactory : ISqlBatchParserFactory
    {
        [CanBeNull]
        private readonly IServiceProvider _serviceProvider;

        /// <summary>
        /// Initializes a new instance of the <see cref="SqlServerBatchParserFactory"/> class.
        /// </summary>
        /// <param name="serviceProvider">The service provider.</param>
        public SqlServerBatchParserFactory([CanBeNull] IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        /// <inheritdoc />
        public SqlBatchParser Create()
        {
            return _serviceProvider?.GetService<SqlServerBatchParser>()
             ?? new SqlServerBatchParser();
        }
    }
}
