﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace HouseRentManagement
{
    public static class mdiProperties
    {
        [DllImport("user32.dll")]
        private static extern int GetWindowLong(IntPtr hWnd, int nIndex);
        [DllImport("user32.dll")]
        private static extern int SetWindowLong(IntPtr hwnd, int nIndex, int dwLong);
        [DllImport("user32.dll")]
        private static extern int SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int x, int y,
        int cx, int cy, uint uFlags);
        private const int GWL_EXSTYKE = -20;
        private const int WS_EX_CLIENTEDGE = 0x200;
        private const uint SWP_NOSIZE = 0x0001;
        private const uint SWP_NOMOVE = 0x0002;
        private const uint SWP_NOZORDER = 0x0004;
        private const uint SWP_NOACTIVATE = 0x0010;
        private const uint SWP_FRAMECHANGED = 0x0020;
        private const uint SWP_NOOWNERZORDER = 0x0200;
        public static bool SetBevel(this Form form, bool show)
        {
            foreach (Control c in form.Controls) 
            {
                MdiClient mdiClient = c as MdiClient;
                if (mdiClient!=null)
                {
                    int windowLong = GetWindowLong(c.Handle, GWL_EXSTYKE);
                    if(show)
                    {
                        windowLong |= WS_EX_CLIENTEDGE;
                    }
                    else
                    {
                        windowLong &= WS_EX_CLIENTEDGE;
                    }
                    SetWindowLong(c.Handle,GWL_EXSTYKE, windowLong);
                    SetWindowPos(mdiClient.Handle, IntPtr.Zero, 0, 0, 0, 0,
                    SWP_NOACTIVATE | SWP_NOMOVE | SWP_NOSIZE | SWP_NOZORDER | 
                    SWP_NOOWNERZORDER | SWP_FRAMECHANGED);
                    return true;
                }
            }return false;
        }
    }
}
