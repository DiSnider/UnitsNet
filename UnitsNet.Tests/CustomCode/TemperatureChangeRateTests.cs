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

namespace UnitsNet.Tests.CustomCode
{
    public class TemperatureChangeRateTests : TemperatureChangeRateTestsBase
    {
        protected override double DegreesCelsiusPerSecondInOneDegreeCelsiusPerSecond => 1;

        protected override double DecadegreesCelsiusPerSecondInOneDegreeCelsiusPerSecond => 1E-1;

        protected override double HectodegreesCelsiusPerSecondInOneDegreeCelsiusPerSecond => 1E-2;

        protected override double KilodegreesCelsiusPerSecondInOneDegreeCelsiusPerSecond => 1E-3;

        protected override double DecidegreesCelsiusPerSecondInOneDegreeCelsiusPerSecond => 1E1;

        protected override double CentidegreesCelsiusPerSecondInOneDegreeCelsiusPerSecond => 1E2;

        protected override double MillidegreesCelsiusPerSecondInOneDegreeCelsiusPerSecond => 1E3;

        protected override double MicrodegreesCelsiusPerSecondInOneDegreeCelsiusPerSecond => 1E6;

        protected override double NanodegreesCelsiusPerSecondInOneDegreeCelsiusPerSecond => 1E9;
		
		protected override double DegreesCelsiusPerMinuteInOneDegreeCelsiusPerSecond => 60;
    }
}