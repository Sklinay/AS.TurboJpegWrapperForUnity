// <copyright file="DecompressedImage.cs" company="Autonomic Systems, Quamotion">
// Copyright (c) Autonomic Systems. All rights reserved.
// Copyright (c) Quamotion. All rights reserved.
// </copyright>

namespace TurboJpegWrapper
{
    /// <summary>
    /// Decompressed Image.
    /// </summary>
    public class DecompressedImage
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DecompressedImage"/> class.
        /// </summary>
        /// <param name="width">Width of image in pixels.</param>
        /// <param name="height">Height of image in pixels.</param>
        /// <param name="stride">
        /// Bytes per line in the source image.
        /// Normally, this should be <c>width * BytesPerPixel</c> if the image is unpadded,
        /// or <c>TJPAD(width * BytesPerPixel</c> if each line of the image
        /// is padded to the nearest 32-bit boundary, as is the case for Windows bitmaps.
        /// You can also be clever and use this parameter to skip lines, etc.
        /// Setting this parameter to 0 is the equivalent of setting it to
        /// <c>width * BytesPerPixel</c>.</param>
        /// <param name="data">Decompressed Image array containing RGB, grayscale, or CMYK pixels.</param>
        /// <param name="pixelFormat">Pixel format of the source image (see <see cref="PixelFormat"/> "Pixel formats").</param>
        public DecompressedImage(int width,  int height, int stride, byte[] data, TJPixelFormat pixelFormat)
        {
            this.Width = width;
            this.Height = height;
            this.Stride = stride;
            this.Data = data;
            this.PixelFormat = pixelFormat;
        }

        /// <summary>
        /// Gets the PixelFormat of the image.
        /// </summary>
        public TJPixelFormat PixelFormat { get; }

        /// <summary>
        /// Gets the Width of the image.
        /// </summary>
        public int Width { get; }

        /// <summary>
        /// Gets the Height of the image.
        /// </summary>
        public int Height { get; }

        /// <summary>
        /// Gets the Stride of the image.
        /// </summary>
        public int Stride { get; }

        /// <summary>
        /// Gets the data of the image.
        /// </summary>
        public byte[] Data { get; }
    }
}
