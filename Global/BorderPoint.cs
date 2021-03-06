﻿//******************************
// Copyright 2012 Yaqiang Wang,
// yaqiang.wang@gmail.com
//******************************

using System;
using System.Collections.Generic;
using System.Text;

namespace wContour
{
    /// <summary>
    /// Border point
    /// </summary>
    public class BorderPoint
    {
        /// <summary>
        /// Identifer
        /// </summary>
        public int Id;
        /// <summary>
        /// Border index
        /// </summary>
        public int BorderIdx;
        /// <summary>
        /// Border inner index
        /// </summary>
        public int BInnerIdx;
        /// <summary>
        /// Point
        /// </summary>
        public PointD Point = new PointD();
        /// <summary>
        /// Value
        /// </summary>
        public double Value;

        #region Method
        /// <summary>
        /// Clone
        /// </summary>
        /// <returns>cloned borderpoint</returns>
        public object Clone()
        {
            BorderPoint aBP = new BorderPoint();
            aBP.Id = Id;
            aBP.BorderIdx = BorderIdx;
            aBP.BInnerIdx = BInnerIdx;
            aBP.Point = Point;
            aBP.Value = Value;

            return aBP;
        }

        #endregion
    }
}
