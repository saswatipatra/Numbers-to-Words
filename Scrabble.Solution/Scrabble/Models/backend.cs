using System;
using System.Collections.Generic;

namespace numberToWords
{
public class Item
{
     public static Dictionary<int,string> UnitNum = new Dictionary<int,string>() { {0,"Zero"},{1,"One"},{2,"Two"},{3,"Three"},{4,"Four"},{5,"Five"},{6,"Six"},{7,"Seven"},{8,"Eight"},{9,"Nine"} };

    public static Dictionary<int,string> TensException = new Dictionary<int,string>() { {10,"Ten"},{11,"Eleven"},{12,"Twelve"},{13,"thirteen"},{14,"fourteen"},{15,"fifteen"},{16,"sixteen"},{17,"seventeen"},{18,"eighteen"},{19,"nineteen"} }; 
    
    public static Dictionary<int,string> TensNum = new Dictionary<int,string>() { {2,"twenty"},{3,"thirty"},{4,"fourty"},{5,"fifty"},{6,"sixty"},{7,"seventy"},{8,"eighty"},{9,"ninety"} };

    public string conversion (int num)
    {
        string unitSpell="";
        string tensSpell="";
        if (num.ToString().Length == 1)
        {
            unitSpell= UnitNum[num];
            return unitSpell;

        }
        else 
        {
            int index= num/10;
            tensSpell= TensNum[index];
            int j= num%10;
            unitSpell= UnitNum[j];
            return (tensSpell + unitSpell);
        }
        
    }
}
}