// See //using
//operators project


namespace CA1;

public class Program
{
    static void Main(string[] args)
    {
        //int x = 5;
        //int y = 5;

        //int a = x++;
        //int b = ++y;

        //for (int i = 1; i <= 5; ++i)
        //{
        //    Console.WriteLine(i);
        //}

        //var c = 5 / 2; // integer division c = 2 no remainder
        //var d = 5.0 / 2; // dividing a double by int d = 2.5
        //var e = 5 / 3; //e = 1 ind 

        //double f = 5 / 2; //alrought f is double we are dividing 2 ints inside so it's 2 not 2.5

        //var daysInWeek = 7;
        //var daysToMyBirthDay = 23;
        //var weeksToBirthDay = daysToMyBirthDay / daysInWeek;
        //var days = daysInWeek % daysInWeek;
        //Console.WriteLine($" {weeksToBirthDay} weeks and {days} till my bday.");

        // Cicle throught 10 sprites split in 2 rows and 5 colums
        //const int NUM_ROWS = 2;
        //const int NUM_COLS = 5;
        //bool running = true; int row = 0;
        //int col = 0; int spriteNo = -1;
        //while (running)
        //{
        //    spriteNo = ++spriteNo % (NUM_ROWS * NUM_COLS);
        //    row = spriteNo / NUM_COLS;
        //    col = spriteNo % NUM_COLS;
        //}
        //starting at -1, we increment to 0 them mod 10 = 0, then we slecet row 0 col 0 item, and move down up+across
        //int j = 5, k =3, m = 4;
        //m += +j++ + ++k;
        // +j means j as positive so nothing changes,
        // then j++ so j is 6 next time // them ++k becomes 4
        // so 4 += 5 + 4; :. m = 4+5+4 m = 13
        bool isJumping = false;
        if (isJumping && EvenOff(2)){
            Console.WriteLine('A'); // this objiously wont run but
        }
        if (isJumping & EvenOff(2)) // this prints the B in even Off
        {
            Console.WriteLine('A'); // this 
        }
    }

    public static bool EvenOff(int num)
    {
        Console.WriteLine('B');
        return num % 2 == 0;
    }

    public static int FinSumDiv3and5(int n)
    {
        int sum = 0;
        for (int i = 0; i <= n; i++)
        {
            sum = i % 3 == 0 ? sum += i : i % 5 == 0 ? sum += i : sum += 0;
        }
        return sum;

        //return Enumerable.Range(1, n + 1).Where(c => c % 5 == 0 || c % 3 == 0).Sum();
        //one liner code
    }
}


