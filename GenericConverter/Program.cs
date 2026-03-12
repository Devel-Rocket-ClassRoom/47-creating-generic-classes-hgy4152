using System;

// README.md를 읽고 아래에 코드를 작성하세요.



Converter<string, int> converter1 = new Converter<string, int>((msg) => msg.Length);

Console.WriteLine("=== 문자열 -> 길이 변환 ===");

int strlength = converter1.Convert("Hello");
Console.WriteLine($"Hello -> {strlength}");

string[] strs = new string[3];
strs[0] = "Hello";
strs[1] = "World";
strs[2] = "C#";

int[] ints = converter1.ConvertAll(strs);

Console.WriteLine($"전체 변환: {string.Join(", ", ints)}");

Console.WriteLine();


Converter<int, string> converter2 = new Converter<int, string>((x) => $"{x}번");
Console.WriteLine("=== 정수 -> 문자열 변환 ===");

string str = converter2.Convert(1);
Console.WriteLine($"1 -> {str}");

int[] nums = new int[3];
nums[0] = 1;
nums[1] = 2;
nums[2] = 3;

string[] strings = converter2.ConvertAll(nums);
Console.WriteLine($"전체 변환: {string.Join(", ", strings)}");
Console.WriteLine();


Converter<double, int> converter3 = new Converter<double, int>((x) => (int)x) ;
Console.WriteLine("=== 실수 -> 정수 변환 ===");

int k = converter3.Convert(3.7);
Console.WriteLine($"3.7 -> {k}");

double[] numbers = new double[3];
numbers[0] = 3.7;
numbers[1] = 1.5;
numbers[2] = 9.5;

int[] dTOi= converter3.ConvertAll(numbers);
Console.WriteLine($"전체 변환: {string.Join(", ", dTOi)}");
Console.WriteLine();