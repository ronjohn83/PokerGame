using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerGame
{
    public static class DrawCard
    {
        public static void Player()
        {
            for (int i = 0; i < 5; i++)
            {

                WriteAt(" ____________ ", 20 * i, 0);
                Console.WriteLine("");
                for (int j = 0; j < 10; j++)
                {
                    
                    WriteAt("|", 20 * i, 1 * j + 1);
                    WriteAt("           |", 20 * i + 2, 1 * j + 1);
                   
                }
                WriteAt(" ____________ ", 20 * i, 10);
            }
        }

        public static void Computer()
        {
            for (int i = 0; i < 5; i++)
            {

                WriteAt(" ____________ ", 20 * i, 12);
                for (int j = 0; j < 10; j++)
                {

                    WriteAt("|", 20 * i, 13 + j);
                    WriteAt("           |", 20 * i + 2, 13 + j);

                }
                WriteAt(" ____________ ", 20 * i, 22);
            }
        }

        public static void WriteAt(object write, int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(write);
        }
    }
}
