# ImageQuantization
14 <sup>th</sup> December 2019
![Screenshot (7)](https://user-images.githubusercontent.com/48651088/72681185-b6ec5300-3ac9-11ea-81ed-c5609470cab3.png)

## Introduction :
The goal of this project is to reduce the number of colors in a full resolution digital color image (24 bits per pixel) to a smaller set of representative colors called color palette. Reduction should be performed so that the quantized image differs as little as possible from the original image. Algorithmic optimization task is to find such a color palette that the overall distortion is minimized.
Uses:
1.	It can be used in image compression by reducing the colors number without distorting the image.
2.	It can be used in displaying images on devices with limited number of colors.
3.	It processes extracting useful objects from an image.
## Technical Details :
Quantization used in reducing colors by replacing the nearest colors with an average color which reduces the different color representation in the image and this may distort the image in some cases. This project is divided into classes, The Main class is “ImageOperations” class which contains all the operations done on the image starting from opening the image, compressing it and finally showing it on the screen. The image colors (RGB) are imported in a 2d array called ImageMatrix.

This project is implemented in C#.
## Features:-
1- Quantize Image.

2- Filter using FloyedDither :-

+ Description : The Floyd‑Steinberg algorithm is an error diffusion algorithm aim is to use simple threshold dithering on each pixel

3- Filter using Atkinson Dithering :-

+ Description : The Atkinson dithering algorithm itself is a modified version of Floyd-Steinberg dithering, where the “error” between the intended gray level at each pixel and the black or white dot that is actually drawn at each pixel is distributed to neighboring points.

4- GaussianBlur :-
+	Description :- Gaussian filter is a filter of blurring an image. Gaussian blur has the effect of reducing the image's high-frequency 
 components. a Gaussian blur is thus a [low pass filter](https://en.wikipedia.org/wiki/Low-pass_filter).
 
 5- Median Filter :-
 + Description : Median filter is another very common filter,  which reduces noise and preserves edges. It can fix pixels or even small areas with damaged or missing color.

