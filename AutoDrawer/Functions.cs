using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace AutoDrawer
{
    internal static class Functions
    {
        [Flags]
        internal enum MOUSEEVENTF : uint
        {
            ABSOLUTE = 0x8000,
            HWHEEL = 0x01000,
            MOVE = 0x0001,
            MOVE_NOCOALESCE = 0x2000,
            LEFTDOWN = 0x0002,
            LEFTUP = 0x0004,
            RIGHTDOWN = 0x0008,
            RIGHTUP = 0x0010,
            MIDDLEDOWN = 0x0020,
            MIDDLEUP = 0x0040,
            VIRTUALDESK = 0x4000,
            WHEEL = 0x0800,
            XDOWN = 0x0080,
            XUP = 0x0100
        }

        [StructLayout(LayoutKind.Sequential)]
        internal struct MOUSEINPUT
        {
            internal int dx;
            internal int dy;
            internal int mouseData;
            internal MOUSEEVENTF dwFlags;
            internal uint time;
            internal UIntPtr dwExtraInfo;
        }

        [StructLayout(LayoutKind.Explicit)]
        internal struct InputUnion
        {
            [FieldOffset(0)]
            internal MOUSEINPUT mi;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct INPUT
        {
            internal uint type;
            internal InputUnion U;
            internal static int Size => Marshal.SizeOf(typeof(INPUT));
        }

        [DllImport("user32.dll")]
        internal static extern uint SendInput(uint nInputs, [MarshalAs(UnmanagedType.LPArray), In] INPUT[] pInputs, int cbSize);

        [DllImport("user32.dll")]
        internal static extern bool SetCursorPos(int X, int Y);

        [DllImport("User32.dll")]
        public static extern short GetAsyncKeyState(System.Windows.Forms.Keys vKey);

        [DllImport("User32.dll")]
        public static extern short GetAsyncKeyState(System.Int32 vKey);

        [DllImport("user32.dll", CharSet = CharSet.Ansi, SetLastError = true, ExactSpelling = true)]
        private static extern long GetAsyncKeyState(long vKey);

        public const int VK_D = 0x44;
        public const int VK_F = 0x46;

        public static Bitmap MakeBlackAndWhite(Image original, int threshold)
        {
            Bitmap _NewImage = new Bitmap(original);
            using (var _Graphics = Graphics.FromImage(_NewImage))
            {
                var _GrayMatrix = new[] 
                {
                    new[] { 0.299f, 0.299f, 0.299f, 0, 0 },
                    new[] { 0.587f, 0.587f, 0.587f, 0, 0 },
                    new[] { 0.114f, 0.114f, 0.114f, 0, 0 },
                    new[] { 0f, 0f, 0f, 1f, 0f },
                    new[] { 0f, 0f, 0f, 0f, 1f }
                };

                var _ImageAttributes = new ImageAttributes();
                _ImageAttributes.SetColorMatrix(new ColorMatrix(_GrayMatrix));
                _ImageAttributes.SetThreshold(threshold);

                var _Rectangle = new Rectangle(0, 0, original.Width, original.Height);
                _Graphics.DrawImage(original, _Rectangle, 0, 0, original.Width, original.Height, GraphicsUnit.Pixel, _ImageAttributes);
            }
            return _NewImage;
        }

        public static void MoveMouse(int x, int y)
        {
            SetCursorPos(x, y);
        }

        public static Image ScaleImage(Image image, int maxWidth, int maxHeight)
        {
            var _RatioX = (double)maxWidth / image.Width;
            var _RatioY = (double)maxHeight / image.Height;
            var _Ratio = Math.Min(_RatioX, _RatioY);

            var _NewWidth = (int)(image.Width * _Ratio);
            var _NewHeight = (int)(image.Height * _Ratio);

            var _NewImage = new Bitmap(_NewWidth, _NewHeight);
            using (var graphics = Graphics.FromImage(_NewImage))
            {
                graphics.DrawImage(image, 0, 0, _NewWidth, _NewHeight);
            }
            return _NewImage;
        }

        public static Stream ToStream(this Image image, ImageFormat format)
        {
            var _Stream = new MemoryStream();
            image.Save(_Stream, format);
            _Stream.Position = 0;
            return _Stream;
        }

        public static bool IsRecognisedImageFile(this string fileName)
        {
            var _TargetExtension = Path.GetExtension(fileName);
            if (string.IsNullOrEmpty(_TargetExtension))
                return false;

            _TargetExtension = "*" + _TargetExtension.ToLowerInvariant();

            var _RecognisedImageExtensions = new List<string>();
            foreach (var _ImageCodec in ImageCodecInfo.GetImageEncoders())
            {
                _RecognisedImageExtensions.AddRange(_ImageCodec.FilenameExtension.ToLowerInvariant().Split(";".ToCharArray()));
            }
            return _RecognisedImageExtensions.Any(_Extension => _Extension.Equals(_TargetExtension));
        }

        public static void ClickMouse(MouseButtons mouseButton, int x, int y, bool down)
        {
            var _Inputs2 = new INPUT { type = 0 };
            _Inputs2.U.mi.dx = x;
            _Inputs2.U.mi.dy = y;

            switch (mouseButton)
            {
                case MouseButtons.Left:
                    _Inputs2.U.mi.dwFlags = down ? MOUSEEVENTF.LEFTDOWN : MOUSEEVENTF.LEFTUP;
                    break;
                case MouseButtons.Right:
                    _Inputs2.U.mi.dwFlags = down ? MOUSEEVENTF.RIGHTDOWN : MOUSEEVENTF.RIGHTUP;
                    break;
            }

            var _Inputs1 = new INPUT[1];
            _Inputs1[0] = _Inputs2;
            SendInput(1, _Inputs1, INPUT.Size);
        }
    }
}
