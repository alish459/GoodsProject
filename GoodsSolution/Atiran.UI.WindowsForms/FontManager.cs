using System;
using System.Drawing;
using System.Drawing.Text;
using System.Runtime.InteropServices;

namespace PersianUI
{
    public static class FontManager
    {
        [DllImport(@"gdi32.dll")]
        static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont, IntPtr pdv, [In] ref uint pcFonts);

        public static FontFamily IRNazanin { get; set; }
        public static PrivateFontCollection FontCollection = new PrivateFontCollection();


        public static Font GetDefaultTextFont()
        {
            return new Font("IRANSans(FaNum)",9.5f, FontStyle.Regular);
        }
     
        static bool AddFontFromResource(byte[] fontArray)
        {
            try
            {
                // getfontArray Length
                var dataLength = fontArray.Length;

                // allocate memory & copy byte[] array
                var ptrData = Marshal.AllocCoTaskMem(dataLength);
                Marshal.Copy(fontArray, 0, ptrData, dataLength);

                uint cFonts = 0;
                AddFontMemResourceEx(ptrData, (uint)fontArray.Length, IntPtr.Zero, ref cFonts);

                // pass font to private font collection
                FontCollection.AddMemoryFont(ptrData, dataLength);

                // free the unsafe memory
                Marshal.FreeCoTaskMem(ptrData);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static Font GetFont(string fontfamily, float size, FontStyle style)
        {
            return new Font(fontfamily, size, style);
        }
    }
}
