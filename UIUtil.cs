using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace StudentApplication
{
    class UIUtil
    {
        /*调用系统级Win32 API实现拖拽移动窗体*/
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("user32.dll")]
        public static extern bool SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);
        public const int WM_SYSCOMMAND = 0x0112;
        public const int SC_MOVE = 0xF010;
        public const int HTCAPTION = 0x0002;

        public static void DragForm(Form form)
        {
            /*调用系统级Win32 API实现拖拽移动窗体*/
            ReleaseCapture();
            SendMessage(form.Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0);
        }

        /*调用系统级Win32 API实现淡入淡出窗体*/
        public const Int32 AW_HOR_POSITIVE = 0x00000001; // 从左到右打开窗口
        public const Int32 AW_HOR_NEGATIVE = 0x00000002; // 从右到左打开窗口
        public const Int32 AW_VER_POSITIVE = 0x00000004; // 从上到下打开窗口
        public const Int32 AW_VER_NEGATIVE = 0x00000008; // 从下到上打开窗口
        public const Int32 AW_CENTER = 0x00000010; //若使用了AW_HIDE标志，则使窗口向内重叠；若未使用AW_HIDE标志，则使窗口向外扩展。
        public const Int32 AW_HIDE = 0x00010000; //隐藏窗口，缺省则显示窗口。
        public const Int32 AW_ACTIVATE = 0x00020000; //激活窗口。在使用了AW_HIDE标志后不要使用这个标志。
        public const Int32 AW_SLIDE = 0x00040000; //使用滑动类型。缺省则为滚动动画类型。当使用AW_CENTER标志时，这个标志就被忽略。
        public const Int32 AW_BLEND = 0x00080000; //使用淡出效果。只有当hWnd为顶层窗口的时候才可以使用此标志。
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern bool AnimateWindow(IntPtr hwnd, int dwTime, int dwFlags);//窗体句柄,动画时长,动画类型

        /*淡入窗体*/
        public static void OperForm(Form form)
        {
            AnimateWindow(form.Handle, 500, AW_BLEND);
        }

        /*淡入窗体*/
        public static void CloseForm(Form form)
        {
            AnimateWindow(form.Handle, 500, AW_SLIDE | AW_HIDE | AW_BLEND);
        }

        /*窗体居中*/
        public static void SetMidForm(Form form)
        {
            form.SetBounds((Screen.GetBounds(form).Width / 2) - (form.Width / 2),
                (Screen.GetBounds(form).Height / 2) - (form.Height / 2),
                form.Width, form.Height, BoundsSpecified.Location);
        }

        /*设置窗体的圆角矩形*/
        [DllImport("gdi32.dll")]
        public static extern int CreateRoundRectRgn(int x1, int y1, int x2, int y2, int x3, int y3);

        [DllImport("user32.dll")]
        public static extern int SetWindowRgn(IntPtr hwnd, int hRgn, Boolean bRedraw);

        [DllImport("gdi32.dll", EntryPoint = "DeleteObject", CharSet = CharSet.Ansi)]
        public static extern int DeleteObject(int hObject);

        public static void SetFormRoundRectRgn(Form form, int rgnRadius)
        {
            //前4个参数分别是左上角和右下角2个点的x,y坐标，后面2个是圆角矩形的圆角的长和高
            int hRgn = CreateRoundRectRgn(0, 0, form.Width + 1, form.Height + 1, rgnRadius, rgnRadius);
            SetWindowRgn(form.Handle, hRgn, true);
            DeleteObject(hRgn);
        }

        internal static void OperForm(object login)
        {
            throw new NotImplementedException();
        }
    }
}
