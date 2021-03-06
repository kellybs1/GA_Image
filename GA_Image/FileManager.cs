﻿using System;
using System.Drawing;



/*
 * Class: FileManager
 * Description: Static class to manage saving given bitmap to a uniqie file
 * Author: Brendan Kelly
 * Date: 10/10/2017
 */



namespace GA_Image
{
 
    public static class FileManager
    {
        //saves an image to a file in the build directory
        public static void SaveImage(Bitmap image, int generation, int cost)
        {
            String fileName = generateFileName(generation, cost);
            image.Save(fileName);
        }


        //generates a filename based on time, date, and program variables
        private static String generateFileName(int generation, int cost)
        {
            String fileName = "";
            //build time string
            DateTime date = DateTime.Now;
            String timeStr = date.ToString("HH:mm:ss.fff");
            String dateStr = date.ToString("MM/dd/yyyy");
            //remove characters filenames don't like
            timeStr = timeStr.Replace(':', '_');
            dateStr = dateStr.Replace('/', '_');
            //build string
            fileName += dateStr;
            fileName += "_";
            fileName += timeStr;
            fileName += "_Gen-";
            fileName += generation;
            fileName += "_Cost-";
            fileName += cost;
            fileName += ".bmp";

            ///no spaces
            fileName = fileName.Replace(" ", "_");

            return fileName;
        }
    }

}
