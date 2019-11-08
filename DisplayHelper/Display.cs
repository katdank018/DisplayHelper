using System;
using ArrayUnlimited;

namespace DisplayHelper
{
    public class Display
    {
        private UnlimitedArray _array;
        string _item;
        int _x, _y;
        const int xpadding = 3;
        const int ypadding = 1;
        const int border = 4;
        public Display(string item, int x, int y)
        {
            _array = new UnlimitedArray();
            _array.Add(item);

            _item = item;
            _x = x;
            _y = y;
        }

        public void AddItem(LabelItem item)
        {
            _array.Add(item);
        }

        public void Refresh()
        {
            Frame();
            object[] array = _array.GetAll();
            for (int i = 0; i < array.Length; i++)
            {
                Console.SetCursorPosition(_x + xpadding + border, _y - border);
                _y += 2;
                Console.Write(array[i]);
            }
        }

        public void Frame()
        {
            Console.SetCursorPosition(_x, _y);
            Console.Write("┌");
            for (int i = 0; i <= _item.Length + 2 * (xpadding + border); i++)
            {
                Console.Write("─");
            }
            Console.Write("┐");
            for (int i = 0; i < 2 * _array.Count + 2 * ypadding + 1; i++)
            {
                _y += 1;
                Console.SetCursorPosition(_x, _y);
                Console.Write("│");
                for (int j = 0; j <= _item.Length + 2 * (xpadding + border); j++)
                {
                    Console.Write(" ");
                }
                Console.Write("│");
            }
            Console.SetCursorPosition(_x, _y + 1);
            Console.Write("└");
            for (int i = 0; i <= _item.Length + 2 * (xpadding + border); i++)
            {
                Console.Write("─");
            }
            Console.Write("┘");
            Console.SetCursorPosition(_x + xpadding + border, _y - border);
        }
    }
}
