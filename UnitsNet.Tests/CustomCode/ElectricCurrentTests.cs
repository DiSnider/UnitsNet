﻿// Copyright(c) 2007 Andreas Gullberg Larsen
// https://github.com/angularsen/UnitsNet
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.

using System;

namespace UnitsNet.Tests.CustomCode
{
    public class ElectricCurrentTests : ElectricCurrentTestsBase
    {
        protected override double PicoamperesInOneAmpere => 1e12;

        protected override double NanoamperesInOneAmpere => 1e9;

        protected override double MicroamperesInOneAmpere => 1e6;

        protected override double MilliamperesInOneAmpere => 1e3;

        protected override double AmperesInOneAmpere => 1;

        protected override double KiloamperesInOneAmpere => 1e-3;

        protected override double MegaamperesInOneAmpere => 1e-6;

    }
}