﻿/*
 * Copyright © 2023 Federation of State Medical Boards
 * 
 * Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated 
 * documentation files (the “Software”), to deal in the Software without restriction, including without limitation the
 * rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit
 * persons to whom the Software is furnished to do so, subject to the following conditions:
 * 
 * The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.
 * 
 * THE SOFTWARE IS PROVIDED “AS IS”, WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE
 * WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR
 * COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, 
 * ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
 */
using System;

namespace Fsmb.Api.Fcvs.ApiSample
{
    /// <summary>Options for writing objects.</summary>
    public struct ObjectWriterOptions
    {
        /// <summary>Initializes an instance of the <see cref="ObjectWriterOptions"/> structure.</summary>
        public ObjectWriterOptions ()
        { }

        /// <summary>Gets or sets the size of an indent level.</summary>
        public int IndentTabSize { get; set; } = 2;

        /// <summary>Gets or sets the maximum number of items to display in an array or collection.</summary>        
        /// <default>Default is all items.</default>
        public int MaxItemsLength { get; set; } = -1;

        /// <summary>Determines if properties with <see langword="null"/> values are shown.</summary>
        public bool ShowNullProperties { get; set; } = false;
    }
}
