using static System.Console;
using static System.Convert;
using static System.Math;



int number, fenceHeight,resWidths = 0;
int[] friendsHeights = new int[1005];

string str1 = ReadLine();
var arr1 = str1.Split(" ");
number = ToInt32(arr1[0]);
fenceHeight = ToInt32(arr1[1]);
string str2 = ReadLine();
var arr2 = str2.Split(" ");
for(int i = 0; i < number; i++)
{
    friendsHeights[i] = ToInt32(arr2[i]);
    if (friendsHeights[i] > fenceHeight)
    {
        resWidths += 2;
    }
    else
    {
        resWidths += 1;
    }
}

WriteLine(resWidths);

