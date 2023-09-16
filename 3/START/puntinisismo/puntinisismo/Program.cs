using System;
using System.Drawing;
using System.IO;
using System.Net;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

namespace ConvertImageFromUrlToAscii
{
    public static string GrayscaleImageToASCII(System.Drawing.Image img)
    {
        StringBuilder html = new StringBuilder();
        Bitmap bmp = null;

        try
        {
            // Create a bitmap from the image

            bmp = new Bitmap(img);

            // The text will be enclosed in a paragraph tag with the class

            // ascii_art so that we can apply CSS styles to it.

            html.Append("&lt;br/&rt;");

            // Loop through each pixel in the bitmap

            for (int y = 0; y < bmp.Height; y++)
            {
                for (int x = 0; x < bmp.Width; x++)
                {
                    // Get the color of the current pixel

                    Color col = bmp.GetPixel(x, y);

                    // To convert to grayscale, the easiest method is to add

                    // the R+G+B colors and divide by three to get the gray

                    // scaled color.

                    col = Color.FromArgb((col.R + col.G + col.B) / 3,
                        (col.R + col.G + col.B) / 3,
                        (col.R + col.G + col.B) / 3);

                    // Get the R(ed) value from the grayscale color,

                    // parse to an int. Will be between 0-255.

                    int rValue = int.Parse(col.R.ToString());

                    // Append the "color" using various darknesses of ASCII

                    // character.

                    html.Append(getGrayShade(rValue));

                    // If we're at the width, insert a line break

                    if (x == bmp.Width - 1)
                        html.Append("&lt;br/&rt");
                }
            }

            // Close the paragraph tag, and return the html string.

            html.Append("&lt;/p&rt;");

            return html.ToString();
        }
        catch (Exception exc)
        {
            return exc.ToString();
        }
        finally
        {
            bmp.Dispose();
        }
    }
}
