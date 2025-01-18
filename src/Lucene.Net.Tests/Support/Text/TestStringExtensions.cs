﻿using Lucene.Net.Attributes;
using Lucene.Net.Util;
using NUnit.Framework;
#if !FEATURE_STRING_CONTAINS_STRINGCOMPARISON
using System;
#endif

namespace Lucene.Net.Support.Text
{
    /*
     * Licensed to the Apache Software Foundation (ASF) under one or more
     * contributor license agreements.  See the NOTICE file distributed with
     * this work for additional information regarding copyright ownership.
     * The ASF licenses this file to You under the Apache License, Version 2.0
     * (the "License"); you may not use this file except in compliance with
     * the License.  You may obtain a copy of the License at
     *
     *     http://www.apache.org/licenses/LICENSE-2.0
     *
     * Unless required by applicable law or agreed to in writing, software
     * distributed under the License is distributed on an "AS IS" BASIS,
     * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
     * See the License for the specific language governing permissions and
     * limitations under the License.
     */

    [TestFixture, LuceneNetSpecific]
    public class TestStringExtensions : LuceneTestCase
    {
        [Test]
        public void TestContainsAny()
        {
            Assert.IsTrue("hello".ContainsAny(new[] { 'h', 'e', 'l', 'o' }));
            Assert.IsFalse("hello".ContainsAny(new[] { 'x', 'y', 'z' }));
        }

#if !FEATURE_STRING_CONTAINS_STRINGCOMPARISON
        [Test]
        public void TestContainsWithStringComparison()
        {
            Assert.IsTrue("hello".Contains("ell", StringComparison.Ordinal));
            Assert.IsFalse("hello".Contains("world", StringComparison.Ordinal));
            Assert.IsTrue("hello".Contains("ELL", StringComparison.OrdinalIgnoreCase));
            Assert.IsFalse("hello".Contains("WORLD", StringComparison.OrdinalIgnoreCase));
        }
#endif
    }
}
