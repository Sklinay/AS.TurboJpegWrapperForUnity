// <copyright file="TjSize.cs" company="Autonomic Systems, Quamotion">
// Copyright (c) Autonomic Systems. All rights reserved.
// Copyright (c) Quamotion. All rights reserved.
// </copyright>

namespace TurboJpegWrapper
{
    /// <summary>
    /// Represents a size.
    /// </summary>
    internal struct TjSize
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TjSize"/> struct.
        /// </summary>
        /// <param name="width">Width of the size.</param>
        /// <param name="height">Height of the size.</param>
        public TjSize(int width, int height)
        {
            this.Width = width;
            this.Height = height;
        }

        /// <summary>
        /// Gets or sets the width of the size.
        /// </summary>
        public int Width { get; set; }

        /// <summary>
        /// Gets or sets the height of the size.
        /// </summary>
        public int Height { get; set; }
    }
}