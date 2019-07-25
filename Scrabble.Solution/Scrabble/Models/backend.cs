using System;
using System.Collections.Generic;

namespace numberToWords
{
public class Item
{
     public static Dictionary<int,string> UnitNum = new Dictionary<int,string>() { {0,"Zero"},{1,"One"},{2,"Two"},{3,"Three"},{4,"Four"},{5,"Five"},{6,"Six"},{7,"Seven"},{8,"Eight"},{9,"Nine"} };

    public static Dictionary<int,string> TensException = new Dictionary<int,string>() { {10,"Ten"},{11,"Eleven"},{12,"Twelve"},{13,"thirteen"},{14,"fourteen"},{15,"fifteen"},{16,"sixteen"},{17,"seventeen"},{18,"eighteen"},{19,"nineteen"} }; 
    
    public static Dictionary<int,string> TensNum = new Dictionary<int,string>() { {2,"twenty"},{3,"thirty"},{4,"fourty"},{5,"fifty"},{6,"sixty"},{7,"seventy"},{8,"eighty"},{9,"ninety"} };

    public static Dictionary<int,string> HundredNum = new Dictionary<int,string>() { {1,"One hundred "}, {2,"Two hundred "},{3,"Three hundred "},{4,"Four hundred "},{5,"Five hundred "},{6,"Six hundred "},{7,"Seven hundred "},{8,"Eight hundred "},{9,"Nine hundred "} };

       public static Dictionary<int,string> thousandNum = new Dictionary<int,string>() { {1,"One Thousand "}, {2,"Two thousand "},{3,"Three thousand "},{4,"Four thousand "},{5,"Five thousand "},{6,"Six thousand "},{7,"Seven thousand "},{8,"Eight thousand "},{9,"Nine thousand "} };

    public string conversion (int num)
    {
        string unitSpell="";
        string tensSpell="";
        string hundredSpell="";
        string thousandSpell ="";
        if (num.ToString().Length == 1)
        {
            unitSpell= UnitNum[num];
            return unitSpell;

        }
        else if (num<=19)
        {
            return TensException[num];
        }
        else if (num.ToString().Length == 2)
        {
            int i= num/10;
            tensSpell= TensNum[i];
            int j= num%10;
            if (j!=0)
            {
             unitSpell = conversion(j);
            }
            return (tensSpell+unitSpell); 
        }
        else if(num.ToString().Length == 3)
        {
            int i= num/100;
            hundredSpell= HundredNum[i];
            int j= num%100;
            if (j!=0)
            {
             tensSpell = conversion(j);
            }
          
            return (hundredSpell+tensSpell); 
        }

        else
        {
            int i = num/1000;
            thousandSpell = thousandNum[i];
            int j = num%1000;
            if(j!= 0)
            {
                hundredSpell = conversion(j);
            }
            return (thousandSpell + hundredSpell + tensSpell);
        }
        
    }
}
}