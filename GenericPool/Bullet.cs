using System;
using System.Collections.Generic;
using System.Text;

class Bullet : IPoolable
{
    public bool IsActive;
    public int X {  get; set; }
    public int Y { get; set; }


    public void Fire(int x, int y)
    {
        IsActive = true;
        X = x;
        Y = y;
        Console.WriteLine($"총알 발사! 위치: ({X}, {Y})");
    }
    public void Reset()
    {
        IsActive=false;
        X = 0;
        Y = 0;
    }
}