using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.Write("Enter songs count : ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter songs length : ");
        string firstLine = Console.ReadLine();
        int[] songs = new int[n];

        for (int i = 0; i < n; i++)
            songs[i] = int.Parse(firstLine.Split()[i]);

        Console.WriteLine(FindLongestQ(songs));

        Console.ReadKey();
    }

    static int FindLongestQ(int[] songs)
    {
        HashSet<int> songSet = new HashSet<int>();
        int maxLength = 0;
        int left = 0;

        for (int right = 0; right < songs.Length; right++)
        {
            while (songSet.Contains(songs[right]))
            {
                songSet.Remove(songs[left]);
                left++;
            }
            songSet.Add(songs[right]);
            maxLength = Math.Max(maxLength, right - left + 1);
        }

        return maxLength;
    }
}
