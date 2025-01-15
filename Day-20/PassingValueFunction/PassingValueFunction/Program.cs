using System;
using System.Diagnostics;
class PassingValue
{
    static void Main()
    {
        CaseStudy1();
        CaseStudy2();
        CaseStudy3();
    }
    private static void CaseStudy3()
    {
        int age = 40;
        UpdateAgeListItemsToZero(ref age);
        Console.WriteLine("age value is"+ age);
    }
    static void UpdateAgeListItemsToZero(ref int myage)
    {
        myage = 0;
    }
    private static void CaseStudy2()
    {
        int[] ageList = new int[4] { 40, 50, 60, 70 };
        Console.WriteLine($"hashcode of ageList is {ageList.GetHashCode()}");
        UpdateAgeListItemsToZero((int[])ageList.Clone());
        foreach (var age in ageList) {
            Console.WriteLine("age after calling UpdateAgeListItemsToZero" + age);
        }
    }
    static void UpdateAgeListItemsToZero(int[] myageList)
    {
        Console.WriteLine($"hashcode of ageList is {myageList.GetHashCode()}");
        for (int i = 0; i < myageList.Length; i++)
        {
            myageList[i] = 0;
        }
    }
    static void CaseStudy1()
    {
        int age = 30;
        UpdateAgeToZero(age);
        Console.WriteLine("age after calling UpdateAgeToZero:" + age);
    }
    static void UpdateAgeToZero(int agePassed)
    {
        agePassed = 0;
    }
}