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
    public class IndentString
    {
        public IndentString(int level, int tabSize)
        {
            _level = Math.Max(level, 0);
            _tabSize = Math.Max(tabSize, 1);

            ResetValue();
        }

        public void Indent()
        {
            ++_level;
            ResetValue();
        }

        public void Unindent()
        {
            if (_level > 0)
            {
                --_level;
                ResetValue();
            };
        }

        public override string ToString() => _value.Value;

        private void ResetValue()
        {
            _value = new Lazy<string>(() => new string(' ', _level * _tabSize));
        }

        private Lazy<string> _value;

        private int _level;
        private readonly int _tabSize;
    }
}
