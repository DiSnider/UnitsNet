﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by \generate-code.bat.
//
//     Changes to this file will be lost when the code is regenerated.
//     The build server regenerates the code before each build and a pre-build
//     step will regenerate the code on each local build.
//
//     See https://github.com/angularsen/UnitsNet/wiki/Adding-a-New-Unit for how to add or edit units.
//
//     Add CustomCode\UnitClasses\MyUnit.extra.cs files to add code to generated unit classes.
//     Add Extensions\MyUnitExtensions.cs to decorate unit classes with new behavior.
//     Add UnitDefinitions\MyUnit.json and run GeneratUnits.bat to generate new units or unit classes.
//
// </auto-generated>
//------------------------------------------------------------------------------

// Copyright (c) 2007 Andreas Gullberg Larsen (angularsen@gmail.com).
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

// Windows Runtime Component does not support extension methods and method overloads: https://msdn.microsoft.com/en-us/library/br230301.aspx
#if !WINDOWS_UWP
namespace UnitsNet.Extensions.NumberToAreaMomentOfInertia
{
    public static class NumberToAreaMomentOfInertiaExtensions
    {
        #region CentimeterToTheFourth

        /// <inheritdoc cref="AreaMomentOfInertia.FromCentimetersToTheFourth(double)"/>
        public static AreaMomentOfInertia CentimetersToTheFourth(this int value) => AreaMomentOfInertia.FromCentimetersToTheFourth(value);

        /// <inheritdoc cref="AreaMomentOfInertia.FromCentimetersToTheFourth(double?)"/>
        public static AreaMomentOfInertia? CentimetersToTheFourth(this int? value) => AreaMomentOfInertia.FromCentimetersToTheFourth(value);

        /// <inheritdoc cref="AreaMomentOfInertia.FromCentimetersToTheFourth(double)"/>
        public static AreaMomentOfInertia CentimetersToTheFourth(this long value) => AreaMomentOfInertia.FromCentimetersToTheFourth(value);

        /// <inheritdoc cref="AreaMomentOfInertia.FromCentimetersToTheFourth(double?)"/>
        public static AreaMomentOfInertia? CentimetersToTheFourth(this long? value) => AreaMomentOfInertia.FromCentimetersToTheFourth(value);

        /// <inheritdoc cref="AreaMomentOfInertia.FromCentimetersToTheFourth(double)"/>
        public static AreaMomentOfInertia CentimetersToTheFourth(this double value) => AreaMomentOfInertia.FromCentimetersToTheFourth(value);

        /// <inheritdoc cref="AreaMomentOfInertia.FromCentimetersToTheFourth(double?)"/>
        public static AreaMomentOfInertia? CentimetersToTheFourth(this double? value) => AreaMomentOfInertia.FromCentimetersToTheFourth(value);

        /// <inheritdoc cref="AreaMomentOfInertia.FromCentimetersToTheFourth(double)"/>
        public static AreaMomentOfInertia CentimetersToTheFourth(this float value) => AreaMomentOfInertia.FromCentimetersToTheFourth(value);

        /// <inheritdoc cref="AreaMomentOfInertia.FromCentimetersToTheFourth(double?)"/>
        public static AreaMomentOfInertia? CentimetersToTheFourth(this float? value) => AreaMomentOfInertia.FromCentimetersToTheFourth(value);

        /// <inheritdoc cref="AreaMomentOfInertia.FromCentimetersToTheFourth(double)"/>
        public static AreaMomentOfInertia CentimetersToTheFourth(this decimal value) => AreaMomentOfInertia.FromCentimetersToTheFourth(Convert.ToDouble(value));

        /// <inheritdoc cref="AreaMomentOfInertia.FromCentimetersToTheFourth(double?)"/>
        public static AreaMomentOfInertia? CentimetersToTheFourth(this decimal? value) => AreaMomentOfInertia.FromCentimetersToTheFourth(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region DecimeterToTheFourth

        /// <inheritdoc cref="AreaMomentOfInertia.FromDecimetersToTheFourth(double)"/>
        public static AreaMomentOfInertia DecimetersToTheFourth(this int value) => AreaMomentOfInertia.FromDecimetersToTheFourth(value);

        /// <inheritdoc cref="AreaMomentOfInertia.FromDecimetersToTheFourth(double?)"/>
        public static AreaMomentOfInertia? DecimetersToTheFourth(this int? value) => AreaMomentOfInertia.FromDecimetersToTheFourth(value);

        /// <inheritdoc cref="AreaMomentOfInertia.FromDecimetersToTheFourth(double)"/>
        public static AreaMomentOfInertia DecimetersToTheFourth(this long value) => AreaMomentOfInertia.FromDecimetersToTheFourth(value);

        /// <inheritdoc cref="AreaMomentOfInertia.FromDecimetersToTheFourth(double?)"/>
        public static AreaMomentOfInertia? DecimetersToTheFourth(this long? value) => AreaMomentOfInertia.FromDecimetersToTheFourth(value);

        /// <inheritdoc cref="AreaMomentOfInertia.FromDecimetersToTheFourth(double)"/>
        public static AreaMomentOfInertia DecimetersToTheFourth(this double value) => AreaMomentOfInertia.FromDecimetersToTheFourth(value);

        /// <inheritdoc cref="AreaMomentOfInertia.FromDecimetersToTheFourth(double?)"/>
        public static AreaMomentOfInertia? DecimetersToTheFourth(this double? value) => AreaMomentOfInertia.FromDecimetersToTheFourth(value);

        /// <inheritdoc cref="AreaMomentOfInertia.FromDecimetersToTheFourth(double)"/>
        public static AreaMomentOfInertia DecimetersToTheFourth(this float value) => AreaMomentOfInertia.FromDecimetersToTheFourth(value);

        /// <inheritdoc cref="AreaMomentOfInertia.FromDecimetersToTheFourth(double?)"/>
        public static AreaMomentOfInertia? DecimetersToTheFourth(this float? value) => AreaMomentOfInertia.FromDecimetersToTheFourth(value);

        /// <inheritdoc cref="AreaMomentOfInertia.FromDecimetersToTheFourth(double)"/>
        public static AreaMomentOfInertia DecimetersToTheFourth(this decimal value) => AreaMomentOfInertia.FromDecimetersToTheFourth(Convert.ToDouble(value));

        /// <inheritdoc cref="AreaMomentOfInertia.FromDecimetersToTheFourth(double?)"/>
        public static AreaMomentOfInertia? DecimetersToTheFourth(this decimal? value) => AreaMomentOfInertia.FromDecimetersToTheFourth(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region FootToTheFourth

        /// <inheritdoc cref="AreaMomentOfInertia.FromFeetToTheFourth(double)"/>
        public static AreaMomentOfInertia FeetToTheFourth(this int value) => AreaMomentOfInertia.FromFeetToTheFourth(value);

        /// <inheritdoc cref="AreaMomentOfInertia.FromFeetToTheFourth(double?)"/>
        public static AreaMomentOfInertia? FeetToTheFourth(this int? value) => AreaMomentOfInertia.FromFeetToTheFourth(value);

        /// <inheritdoc cref="AreaMomentOfInertia.FromFeetToTheFourth(double)"/>
        public static AreaMomentOfInertia FeetToTheFourth(this long value) => AreaMomentOfInertia.FromFeetToTheFourth(value);

        /// <inheritdoc cref="AreaMomentOfInertia.FromFeetToTheFourth(double?)"/>
        public static AreaMomentOfInertia? FeetToTheFourth(this long? value) => AreaMomentOfInertia.FromFeetToTheFourth(value);

        /// <inheritdoc cref="AreaMomentOfInertia.FromFeetToTheFourth(double)"/>
        public static AreaMomentOfInertia FeetToTheFourth(this double value) => AreaMomentOfInertia.FromFeetToTheFourth(value);

        /// <inheritdoc cref="AreaMomentOfInertia.FromFeetToTheFourth(double?)"/>
        public static AreaMomentOfInertia? FeetToTheFourth(this double? value) => AreaMomentOfInertia.FromFeetToTheFourth(value);

        /// <inheritdoc cref="AreaMomentOfInertia.FromFeetToTheFourth(double)"/>
        public static AreaMomentOfInertia FeetToTheFourth(this float value) => AreaMomentOfInertia.FromFeetToTheFourth(value);

        /// <inheritdoc cref="AreaMomentOfInertia.FromFeetToTheFourth(double?)"/>
        public static AreaMomentOfInertia? FeetToTheFourth(this float? value) => AreaMomentOfInertia.FromFeetToTheFourth(value);

        /// <inheritdoc cref="AreaMomentOfInertia.FromFeetToTheFourth(double)"/>
        public static AreaMomentOfInertia FeetToTheFourth(this decimal value) => AreaMomentOfInertia.FromFeetToTheFourth(Convert.ToDouble(value));

        /// <inheritdoc cref="AreaMomentOfInertia.FromFeetToTheFourth(double?)"/>
        public static AreaMomentOfInertia? FeetToTheFourth(this decimal? value) => AreaMomentOfInertia.FromFeetToTheFourth(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region InchToTheFourth

        /// <inheritdoc cref="AreaMomentOfInertia.FromInchesToTheFourth(double)"/>
        public static AreaMomentOfInertia InchesToTheFourth(this int value) => AreaMomentOfInertia.FromInchesToTheFourth(value);

        /// <inheritdoc cref="AreaMomentOfInertia.FromInchesToTheFourth(double?)"/>
        public static AreaMomentOfInertia? InchesToTheFourth(this int? value) => AreaMomentOfInertia.FromInchesToTheFourth(value);

        /// <inheritdoc cref="AreaMomentOfInertia.FromInchesToTheFourth(double)"/>
        public static AreaMomentOfInertia InchesToTheFourth(this long value) => AreaMomentOfInertia.FromInchesToTheFourth(value);

        /// <inheritdoc cref="AreaMomentOfInertia.FromInchesToTheFourth(double?)"/>
        public static AreaMomentOfInertia? InchesToTheFourth(this long? value) => AreaMomentOfInertia.FromInchesToTheFourth(value);

        /// <inheritdoc cref="AreaMomentOfInertia.FromInchesToTheFourth(double)"/>
        public static AreaMomentOfInertia InchesToTheFourth(this double value) => AreaMomentOfInertia.FromInchesToTheFourth(value);

        /// <inheritdoc cref="AreaMomentOfInertia.FromInchesToTheFourth(double?)"/>
        public static AreaMomentOfInertia? InchesToTheFourth(this double? value) => AreaMomentOfInertia.FromInchesToTheFourth(value);

        /// <inheritdoc cref="AreaMomentOfInertia.FromInchesToTheFourth(double)"/>
        public static AreaMomentOfInertia InchesToTheFourth(this float value) => AreaMomentOfInertia.FromInchesToTheFourth(value);

        /// <inheritdoc cref="AreaMomentOfInertia.FromInchesToTheFourth(double?)"/>
        public static AreaMomentOfInertia? InchesToTheFourth(this float? value) => AreaMomentOfInertia.FromInchesToTheFourth(value);

        /// <inheritdoc cref="AreaMomentOfInertia.FromInchesToTheFourth(double)"/>
        public static AreaMomentOfInertia InchesToTheFourth(this decimal value) => AreaMomentOfInertia.FromInchesToTheFourth(Convert.ToDouble(value));

        /// <inheritdoc cref="AreaMomentOfInertia.FromInchesToTheFourth(double?)"/>
        public static AreaMomentOfInertia? InchesToTheFourth(this decimal? value) => AreaMomentOfInertia.FromInchesToTheFourth(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region MeterToTheFourth

        /// <inheritdoc cref="AreaMomentOfInertia.FromMetersToTheFourth(double)"/>
        public static AreaMomentOfInertia MetersToTheFourth(this int value) => AreaMomentOfInertia.FromMetersToTheFourth(value);

        /// <inheritdoc cref="AreaMomentOfInertia.FromMetersToTheFourth(double?)"/>
        public static AreaMomentOfInertia? MetersToTheFourth(this int? value) => AreaMomentOfInertia.FromMetersToTheFourth(value);

        /// <inheritdoc cref="AreaMomentOfInertia.FromMetersToTheFourth(double)"/>
        public static AreaMomentOfInertia MetersToTheFourth(this long value) => AreaMomentOfInertia.FromMetersToTheFourth(value);

        /// <inheritdoc cref="AreaMomentOfInertia.FromMetersToTheFourth(double?)"/>
        public static AreaMomentOfInertia? MetersToTheFourth(this long? value) => AreaMomentOfInertia.FromMetersToTheFourth(value);

        /// <inheritdoc cref="AreaMomentOfInertia.FromMetersToTheFourth(double)"/>
        public static AreaMomentOfInertia MetersToTheFourth(this double value) => AreaMomentOfInertia.FromMetersToTheFourth(value);

        /// <inheritdoc cref="AreaMomentOfInertia.FromMetersToTheFourth(double?)"/>
        public static AreaMomentOfInertia? MetersToTheFourth(this double? value) => AreaMomentOfInertia.FromMetersToTheFourth(value);

        /// <inheritdoc cref="AreaMomentOfInertia.FromMetersToTheFourth(double)"/>
        public static AreaMomentOfInertia MetersToTheFourth(this float value) => AreaMomentOfInertia.FromMetersToTheFourth(value);

        /// <inheritdoc cref="AreaMomentOfInertia.FromMetersToTheFourth(double?)"/>
        public static AreaMomentOfInertia? MetersToTheFourth(this float? value) => AreaMomentOfInertia.FromMetersToTheFourth(value);

        /// <inheritdoc cref="AreaMomentOfInertia.FromMetersToTheFourth(double)"/>
        public static AreaMomentOfInertia MetersToTheFourth(this decimal value) => AreaMomentOfInertia.FromMetersToTheFourth(Convert.ToDouble(value));

        /// <inheritdoc cref="AreaMomentOfInertia.FromMetersToTheFourth(double?)"/>
        public static AreaMomentOfInertia? MetersToTheFourth(this decimal? value) => AreaMomentOfInertia.FromMetersToTheFourth(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region MillimeterToTheFourth

        /// <inheritdoc cref="AreaMomentOfInertia.FromMillimetersToTheFourth(double)"/>
        public static AreaMomentOfInertia MillimetersToTheFourth(this int value) => AreaMomentOfInertia.FromMillimetersToTheFourth(value);

        /// <inheritdoc cref="AreaMomentOfInertia.FromMillimetersToTheFourth(double?)"/>
        public static AreaMomentOfInertia? MillimetersToTheFourth(this int? value) => AreaMomentOfInertia.FromMillimetersToTheFourth(value);

        /// <inheritdoc cref="AreaMomentOfInertia.FromMillimetersToTheFourth(double)"/>
        public static AreaMomentOfInertia MillimetersToTheFourth(this long value) => AreaMomentOfInertia.FromMillimetersToTheFourth(value);

        /// <inheritdoc cref="AreaMomentOfInertia.FromMillimetersToTheFourth(double?)"/>
        public static AreaMomentOfInertia? MillimetersToTheFourth(this long? value) => AreaMomentOfInertia.FromMillimetersToTheFourth(value);

        /// <inheritdoc cref="AreaMomentOfInertia.FromMillimetersToTheFourth(double)"/>
        public static AreaMomentOfInertia MillimetersToTheFourth(this double value) => AreaMomentOfInertia.FromMillimetersToTheFourth(value);

        /// <inheritdoc cref="AreaMomentOfInertia.FromMillimetersToTheFourth(double?)"/>
        public static AreaMomentOfInertia? MillimetersToTheFourth(this double? value) => AreaMomentOfInertia.FromMillimetersToTheFourth(value);

        /// <inheritdoc cref="AreaMomentOfInertia.FromMillimetersToTheFourth(double)"/>
        public static AreaMomentOfInertia MillimetersToTheFourth(this float value) => AreaMomentOfInertia.FromMillimetersToTheFourth(value);

        /// <inheritdoc cref="AreaMomentOfInertia.FromMillimetersToTheFourth(double?)"/>
        public static AreaMomentOfInertia? MillimetersToTheFourth(this float? value) => AreaMomentOfInertia.FromMillimetersToTheFourth(value);

        /// <inheritdoc cref="AreaMomentOfInertia.FromMillimetersToTheFourth(double)"/>
        public static AreaMomentOfInertia MillimetersToTheFourth(this decimal value) => AreaMomentOfInertia.FromMillimetersToTheFourth(Convert.ToDouble(value));

        /// <inheritdoc cref="AreaMomentOfInertia.FromMillimetersToTheFourth(double?)"/>
        public static AreaMomentOfInertia? MillimetersToTheFourth(this decimal? value) => AreaMomentOfInertia.FromMillimetersToTheFourth(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

    }
}
#endif
