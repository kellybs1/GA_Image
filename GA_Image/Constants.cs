using System.Drawing;

/*
 * Class: Constants
 * Description: Class holding constant values for Genetic Algorithm applications
 * Author: Brendan Kelly
 * Date: 10/10/2017
 */


namespace GA_Image
{
    public static class Constants
    {
        public const int SINGLE_ELITE = 1;


        //image reproduction
        public const int DRAW_EVERY = 1000;
        public static int[] ACCEPTED_IMAGE_SIZES = { 8, 16, 32, 64, 128, 256, 512 };


        //test arrays 
        public const int MAX_COLOUR_VAL = 255;

        public static Color grn = Color.FromArgb(56, 200, 17);
        public static Color blu = Color.FromArgb(2, 62, 196);
        public static Color wh = Color.FromArgb(255, 255, 255);
        public static Color bl = Color.FromArgb(0, 0, 0);
        public static Color db = Color.FromArgb(47, 54, 153);
        public static Color lb = Color.FromArgb(77, 109, 243);
        public static Color gr = Color.FromArgb(181, 165, 213);
        public static Color re = Color.FromArgb(237, 28, 36);
        public static Color ye = Color.FromArgb(253, 205, 45);
        public static Color pe = Color.FromArgb(254, 193, 154);
        public static Color sg = Color.FromArgb(11, 236, 213);

        public static Color[] TARGET_DRAW4 = { grn, blu, blu, grn };


        public static Color[] TARGET_DRAW16 = { wh, lb, db, bl,
                                                gr, re, gr, re,
                                                re, gr, re, gr,
                                                bl, db, lb, wh };


        public static Color[] TARGET_DRAWSMILEY = { ye, ye, ye, ye, ye, ye, ye, ye,
                                                    ye, ye, ye, ye, ye, ye, ye, ye,
                                                    ye, ye, bl, ye, ye, bl, ye, ye,
                                                    ye, ye, ye, ye, ye, ye, ye, ye,
                                                    bl, ye, ye, ye, ye, ye, ye, bl,
                                                    ye, bl, ye, ye, ye, ye, bl, ye,
                                                    ye, ye, bl, bl, bl, bl, ye, ye,
                                                    ye, ye, ye, ye, ye, ye, ye, ye, };


        //https://www.behance.net/gallery/32551489/8x8-100-superhero-faces-pico8-color-palette

        public static Color[] TARGET_DRAWTHEBAT = { db, bl, bl, bl, bl, bl, bl, db,
                                                    db, db, db, db, db, db, db, db,
                                                    db, bl, db, db, db, db, bl, db,
                                                    db, bl, bl, db, db, bl, bl, db,
                                                    db, wh, wh, bl, bl, wh, wh, db,
                                                    db, bl, bl, bl, bl, bl, bl, db,
                                                    db, pe, pe, wh, wh, pe, pe, db,
                                                    bl, db, pe, pe, pe, pe, db, bl, };


        //https://hama-girl.deviantart.com/art/16x16-Mario-Pixel-Art-Grid-264535799
        public static Color[] TARGET_BOMBER = { wh, wh, wh, wh, wh, bl, bl, bl, bl, wh, wh, wh, wh, wh, wh, wh,
                                                wh, wh, wh, bl, bl, db, db, db, db, bl, bl, wh, wh, wh, wh, wh,
                                                wh, wh, bl, lb, lb, lb, lb, lb, db, db, db, bl, wh, wh, wh, wh,
                                                wh, bl, lb, lb, lb, lb, lb, lb, lb, db, db, db, bl, wh, bl, bl,
                                                wh, bl, wh, lb, wh, lb, lb, lb, lb, lb, db, db, bl, bl, wh, bl,
                                                bl, db, wh, lb, wh, lb, lb, lb, lb, lb, db, db, bl, bl, wh, bl,
                                                bl, db, wh, lb, wh, lb, lb, lb, lb, lb, db, bl, wh, wh, wh, bl,
                                                bl, db, lb, lb, lb, lb, lb, lb, lb, lb, db, bl, gr, gr, wh, bl,
                                                bl, db, db, lb, lb, lb, lb, lb, lb, db, db, db, bl, bl, gr, bl,
                                                wh, bl, db, db, lb, lb, lb, lb, db, db, db, db, bl, bl, gr, bl,
                                                wh, bl, db, db, db, db, db, db, db, db, db, bl, wh, wh, bl, bl,
                                                wh, wh, bl, bl, db, db, db, db, db, db, bl, bl, wh, wh, wh, wh,
                                                wh, bl, re, re, bl, db, db, db, db, bl, re, re, bl, wh, wh, wh,
                                                wh, bl, re, re, re, bl, bl, bl, bl, re, re, re, bl, wh, wh, wh,
                                                wh, wh, bl, re, re, bl, wh, wh, bl, re, re, bl, wh, wh, wh, wh,
                                                wh, wh, wh, bl, bl, wh, wh, wh, wh, bl, bl, wh, wh, wh, wh, wh};


        //https://nz.pinterest.com/pin/318348267385957544/
                                              // 1   2   3   4   5   6   7   8   9  10  11  12  13  14  15  16  17  18  19  20  21  22  23  24  25  26  27  28  29  30  31  32
        public static Color[] TARGET_MEGA = {   wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, //1
                                                wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, //2
                                                wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, //3
                                                wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, bl, bl, bl, wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, //4
                                                wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, bl, bl, bl, sg, sg, bl, wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, //5
                                                wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, bl, db, db, db, bl, sg, sg, bl, wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, //6
                                                wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, bl, db, db, db, db, db, bl, bl, bl, bl, wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, //7
                                                wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, bl, db, db, db, db, db, bl, sg, sg, db, bl, wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, //8
                                                wh, wh, wh, wh, wh, wh, wh, wh, wh, bl, sg, db, db, db, db, db, db, bl, bl, db, bl, wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, //9
                                                wh, wh, wh, wh, wh, wh, wh, bl, bl, bl, sg, db, db, pe, wh, wh, wh, db, db, wh, bl, wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, //10
                                                wh, wh, wh, wh, wh, bl, bl, sg, sg, bl, sg, db, pe, wh, wh, bl, bl, pe, bl, wh, bl, wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, //11
                                                wh, wh, wh, wh, bl, sg, sg, sg, sg, sg, bl, db, pe, wh, wh, bl, bl, pe, bl, wh, bl, wh, wh, wh, bl, bl, bl, bl, wh, wh, wh, wh, //12
                                                wh, wh, wh, bl, db, sg, sg, sg, sg, sg, bl, db, pe, pe, wh, wh, wh, pe, wh, pe, bl, bl, bl, bl, db, db, db, bl, bl, bl, wh, wh, //13
                                                wh, wh, wh, bl, db, db, db, sg, bl, sg, sg, bl, db, pe, bl, bl, bl, bl, pe, bl, bl, sg, sg, bl, db, lb, lb, lb, bl, lb, bl, wh, //14
                                                wh, wh, wh, bl, db, db, db, bl, db, bl, sg, sg, bl, pe, pe, pe, pe, pe, bl, sg, sg, sg, sg, bl, db, db, db, db, bl, db, bl, wh, //15
                                                wh, wh, wh, wh, bl, db, db, bl, db, db, bl, sg, sg, bl, bl, bl, bl, bl, sg, sg, sg, sg, sg, bl, db, db, db, bl, bl, bl, wh, wh, //16
                                                wh, wh, wh, wh, wh, bl, db, db, db, db, bl, sg, sg, sg, sg, sg, sg, sg, bl, bl, bl, bl, bl, wh, bl, bl, bl, bl, wh, wh, wh, wh, //17
                                                wh, wh, wh, wh, wh, wh, bl, db, db, bl, sg, sg, sg, sg, sg, sg, sg, bl, wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, //18
                                                wh, wh, wh, wh, wh, wh, wh, bl, bl, db, db, sg, sg, sg, sg, sg, bl, wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, //19
                                                wh, wh, wh, wh, wh, wh, wh, wh, bl, db, db, db, db, db, db, db, bl, wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, //20
                                                wh, wh, wh, wh, wh, wh, wh, bl, sg, db, db, db, db, db, db, sg, bl, wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, //21
                                                wh, wh, wh, wh, wh, wh, bl, sg, sg, sg, db, db, db, db, sg, sg, sg, bl, wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, //22
                                                wh, wh, wh, wh, wh, bl, db, sg, sg, sg, sg, bl, bl, sg, sg, sg, db, db, bl, wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, //23
                                                wh, wh, wh, bl, bl, db, db, db, sg, sg, bl, wh, wh, bl, db, db, db, db, bl, wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, //24
                                                wh, bl, bl, db, db, db, db, db, db, bl, wh, wh, wh, bl, db, db, db, bl, bl, bl, wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, //25
                                                bl, db, db, db, db, db, db, db, bl, wh, wh, wh, bl, db, db, db, db, db, db, db, bl, wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, //26
                                                bl, bl, bl, bl, bl, bl, bl, bl, bl, wh, wh, wh, bl, bl, bl, bl, bl, bl, bl, bl, bl, wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, //27
                                                wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, //28
                                                wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, //29
                                                wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, //30
                                                wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, //31
                                                wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, wh, //32
                                            };

        //others
        //https://en.wikipedia.org/wiki/The_Persistence_of_Memory
        //http://supermeatboy.wikia.com/wiki/Meat_Boy_(character)
        //https://en.wikipedia.org/wiki/The_Son_of_Man


    }
}
