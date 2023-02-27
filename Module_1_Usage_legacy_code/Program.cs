using System;
using System.Runtime.InteropServices;



namespace Module_1_Usage_legacy_code
{
    internal class Program
    {
        public enum beepType
        {
            SimpleBeep = -1,
            OK = 0x00,
            Question = 0x20,
            Exclamation = 0x30,
            Asterisk = 0x40,
        }
        [DllImport("User32.dll")]
        private static extern bool MessageBeep(uint type);
        [DllImport("user32.dll")]
        public static extern int MessageBox(IntPtr hWnd, string lpText, string lpCaption, uint uType);
        [DllImport("user32.dll")]
        public static extern IntPtr FindWindow(string lpClassname, string lpwindowname);
        [DllImport("user32.dll")]
        public static extern long SendMessage(IntPtr Hwnd, uint Msg, int wParam, string lParam);
        
        const int MB_YESNOCANCEL = 0x03;
        static int MyFirstMessageBox(string text)
        {
            return MessageBox(IntPtr.Zero, text, "Нажмите ДА", MB_YESNOCANCEL);
        }
        static void Main(string[] args)
        {
            string text = "Меня зовут Павел,\n я из группы ПВ-111 !!!";
            int answer = 0;
            while ((answer = MyFirstMessageBox(text)) != 6)
            {
                if (answer == 2 || answer == 7)
                {
                    MessageBeep(0x030);
                    MyFirstMessageBox(text);
                }
            }
        }
    }
}