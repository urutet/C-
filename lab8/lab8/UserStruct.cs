using System;
namespace lab8
{
    struct UserStruct
    {
        public int num;
        public double dub;
        public bool bul;

        public UserStruct(int num1, double dub1, bool bul1)
        {
            num = num1;
            dub = dub1;
            bul = bul1;
        }

        public override string ToString()
        {
            return @$"{num}
{dub}
{bul}
";
        }
    }
}
