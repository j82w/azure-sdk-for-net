﻿//
// Copyright (c) Microsoft.  All rights reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//

using System.Threading;
using System.Threading.Tasks;
using Microsoft.Azure.Management.DataFactories.Common.Models;
using Microsoft.Azure.Management.DataFactories.Conversion;
using Microsoft.Azure.Management.DataFactories.Models;

namespace Microsoft.Azure.Management.DataFactories
{
    /// <summary>
    /// Operations for managing tables.
    /// </summary>
    public interface ITableOperations : ITypeRegistrationOperations<Table>
    {
        /// <summary>
        /// Create a new table instance or update an existing instance.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The resource group name of the data factory.
        /// </param>
        /// <param name='dataFactoryName'>
        /// A unique data factory instance name.
        /// </param>
        /// <param name='parameters'>
        /// The parameters required to create or update a table.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The CreateOrUpdate table operation response.
        /// </returns>
        Task<TableCreateOrUpdateResponse> BeginCreateOrUpdateAsync(
            string resourceGroupName,
            string dataFactoryName,
            TableCreateOrUpdateParameters parameters,
            CancellationToken cancellationToken);

        /// <summary>
        /// Create a new table instance or update an existing instance with raw
        /// json content.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The resource group name of the data factory.
        /// </param>
        /// <param name='dataFactoryName'>
        /// A unique data factory instance name.
        /// </param>
        /// <param name='tableName'>
        /// A unique table instance name.
        /// </param>
        /// <param name='parameters'>
        /// The parameters required to create or update a table.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The CreateOrUpdate table operation response.
        /// </returns>
        Task<TableCreateOrUpdateResponse> BeginCreateOrUpdateWithRawJsonContentAsync(
            string resourceGroupName,
            string dataFactoryName,
            string tableName,
            TableCreateOrUpdateWithRawJsonContentParameters parameters,
            CancellationToken cancellationToken);

        /// <summary>
        /// Delete a table instance.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The resource group name of the data factory.
        /// </param>
        /// <param name='dataFactoryName'>
        /// A unique data factory instance name.
        /// </param>
        /// <param name='tableName'>
        /// Name of the table.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// A standard service response for long running operations.
        /// </returns>
        Task<LongRunningOperationResponse> BeginDeleteAsync(
            string resourceGroupName,
            string dataFactoryName,
            string tableName,
            CancellationToken cancellationToken);

        /// <summary>
        /// Create a new table instance or update an existing instance.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The resource group name of the data factory.
        /// </param>
        /// <param name='dataFactoryName'>
        /// A unique data factory instance name.
        /// </param>
        /// <param name='parameters'>
        /// The parameters required to create or update a table.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The CreateOrUpdate table operation response.
        /// </returns>
        Task<TableCreateOrUpdateResponse> CreateOrUpdateAsync(
            string resourceGroupName,
            string dataFactoryName,
            TableCreateOrUpdateParameters parameters,
            CancellationToken cancellationToken);

        /// <summary>
        /// Create a new table instance or update an existing instance with raw
        /// json content.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The resource group name of the data factory.
        /// </param>
        /// <param name='dataFactoryName'>
        /// A unique data factory instance name.
        /// </param>
        /// <param name='tableName'>
        /// A unique table instance name.
        /// </param>
        /// <param name='parameters'>
        /// The parameters required to create or update a table.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The CreateOrUpdate table operation response.
        /// </returns>
        Task<TableCreateOrUpdateResponse> CreateOrUpdateWithRawJsonContentAsync(
            string resourceGroupName,
            string dataFactoryName,
            string tableName,
            TableCreateOrUpdateWithRawJsonContentParameters parameters,
            CancellationToken cancellationToken);

        /// <summary>
        /// Delete a table instance.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The resource group name of the data factory.
        /// </param>
        /// <param name='dataFactoryName'>
        /// A unique data factory instance name.
        /// </param>
        /// <param name='tableName'>
        /// Name of the table.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// A standard service response for long running operations.
        /// </returns>
        Task<LongRunningOperationResponse> DeleteAsync(
            string resourceGroupName,
            string dataFactoryName,
            string tableName,
            CancellationToken cancellationToken);

        /// <summary>
        /// Gets a table instance.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The resource group name of the data factory.
        /// </param>
        /// <param name='dataFactoryName'>
        /// A unique data factory instance name.
        /// </param>
        /// <param name='tableName'>
        /// Name of the table.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The Get table operation response.
        /// </returns>
        Task<TableGetResponse> GetAsync(
            string resourceGroupName,
            string dataFactoryName,
            string tableName,
            CancellationToken cancellationToken);

        /// <param name='operationStatusLink'>
        /// Location value returned by the Begin operation.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The CreateOrUpdate table operation response.
        /// </returns>
        Task<TableCreateOrUpdateResponse> GetCreateOrUpdateStatusAsync(
            string operationStatusLink,
            CancellationToken cancellationToken);

        /// <summary>
        /// Gets all the table instances in a data factory with the link to the
        /// next page.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The resource group name of the data factory.
        /// </param>
        /// <param name='dataFactoryName'>
        /// A unique data factory instance name.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The List tables operation response.
        /// </returns>
        Task<TableListResponse> ListAsync(
            string resourceGroupName,
            string dataFactoryName,
            CancellationToken cancellationToken);

        /// <summary>
        /// Gets the next page of table instances with the link to the next
        /// page.
        /// </summary>
        /// <param name='nextLink'>
        /// The url to the next tables page.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The List tables operation response.
        /// </returns>
        Task<TableListResponse> ListNextAsync(string nextLink, CancellationToken cancellationToken);
    }
}
