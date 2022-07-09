global using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

//Trolls are attacking your comment section!

//A common way to deal with this situation is to remove all of the vowels from the trolls' comments, neutralizing the threat.

//Your task is to write a function that takes a string and return a new string with all vowels removed.

//For example, the string "This website is for losers LOL!" would become "Ths wbst s fr lsrs LL!".

//Note: for this kata y isn't considered a vowel.

//a, e, i, o, u


//Assert.AreEqual("Ths wbst s fr lsrs LL!", Kata.Disemvowel("This website is for losers LOL!"));
public static class Kata
{
    public static string Disemvowel(string str)
    {
        char[]  vowels = { 'a','A', 'e','E', 'i','I', 'o','O', 'u','U'};
        return string.Join("", str.Where(strChar => !vowels.Contains(strChar)));

        //return Regex.Replace(str,"[aeiou]", "", RegexOptions.IgnoreCase);
        //return string.Concat(str.Where(ch => !"aeiouAEIOU".Contains(ch)));

        //char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
        //return string.Concat(str.Split(vowels));
    }
}
