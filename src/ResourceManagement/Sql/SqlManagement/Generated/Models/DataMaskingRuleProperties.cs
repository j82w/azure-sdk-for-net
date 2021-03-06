// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;

namespace Microsoft.Azure.Management.Sql.Models
{
    /// <summary>
    /// Represents the properties of an Azure SQL Database data masking rule.
    /// </summary>
    public partial class DataMaskingRuleProperties
    {
        private string _columnName;
        
        /// <summary>
        /// Optional. Gets or sets the column name on which the data masking
        /// rule is applied.
        /// </summary>
        public string ColumnName
        {
            get { return this._columnName; }
            set { this._columnName = value; }
        }
        
        private string _id;
        
        /// <summary>
        /// Required. Gets or sets the rule Id.
        /// </summary>
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }
        
        private string _maskingFunction;
        
        /// <summary>
        /// Required. Gets or sets the masking function that is used for the
        /// data masking rule.
        /// </summary>
        public string MaskingFunction
        {
            get { return this._maskingFunction; }
            set { this._maskingFunction = value; }
        }
        
        private string _numberFrom;
        
        /// <summary>
        /// Optional. Gets or sets the numberFrom property of the masking rule.
        /// </summary>
        public string NumberFrom
        {
            get { return this._numberFrom; }
            set { this._numberFrom = value; }
        }
        
        private string _numberTo;
        
        /// <summary>
        /// Optional. Gets or sets the numberTo property of the data masking
        /// rule.
        /// </summary>
        public string NumberTo
        {
            get { return this._numberTo; }
            set { this._numberTo = value; }
        }
        
        private string _prefixSize;
        
        /// <summary>
        /// Optional. Gets or sets the prefixSize property that is used for the
        /// data masking rule.
        /// </summary>
        public string PrefixSize
        {
            get { return this._prefixSize; }
            set { this._prefixSize = value; }
        }
        
        private string _replacementString;
        
        /// <summary>
        /// Optional. Gets or sets the replacementString property that is used
        /// for the data masking rule.
        /// </summary>
        public string ReplacementString
        {
            get { return this._replacementString; }
            set { this._replacementString = value; }
        }
        
        private string _schemaName;
        
        /// <summary>
        /// Optional. Gets or sets the schema name on which the data masking
        /// rule is applied.
        /// </summary>
        public string SchemaName
        {
            get { return this._schemaName; }
            set { this._schemaName = value; }
        }
        
        private string _suffixSize;
        
        /// <summary>
        /// Optional. Gets or sets the suffixSize property that is used for the
        /// data masking rule.
        /// </summary>
        public string SuffixSize
        {
            get { return this._suffixSize; }
            set { this._suffixSize = value; }
        }
        
        private string _tableName;
        
        /// <summary>
        /// Optional. Gets or sets the table name on which the data masking
        /// rule is applied.
        /// </summary>
        public string TableName
        {
            get { return this._tableName; }
            set { this._tableName = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the DataMaskingRuleProperties class.
        /// </summary>
        public DataMaskingRuleProperties()
        {
        }
        
        /// <summary>
        /// Initializes a new instance of the DataMaskingRuleProperties class
        /// with required arguments.
        /// </summary>
        public DataMaskingRuleProperties(string id, string maskingFunction)
            : this()
        {
            if (id == null)
            {
                throw new ArgumentNullException("id");
            }
            if (maskingFunction == null)
            {
                throw new ArgumentNullException("maskingFunction");
            }
            this.Id = id;
            this.MaskingFunction = maskingFunction;
        }
    }
}
