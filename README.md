# .NET wrapper for libjpeg-turbo compatible with Unity.

libjpeg-turbo is a JPEG image codec that uses processor instructions to accelerate JPEG compression
and decompression.

This library provides .NET wrappers for libjpeg-turbo, allowing you to use it from any .NET language,
such as C# and also in Unity.

The original library has some difficulties to be used in Unity because of missing dependencies. This fork proposes an implementation that no longer uses them.

You can find an sample Unity project that uses this fork here : [AS.TurboJpegWrapperForUnity](https://github.com/Sklinay/AS.TurboJpegWrapperForUnity)

## Credits
The code in this repository is forked from https://github.com/quamotion/AS.TurboJpegWrapper