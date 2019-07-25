using Microsoft.VisualStudio.TestTools.UnitTesting;
using numberToWords;
using System.Collections.Generic;
using System;


namespace numberToWords.TestTools{
    [TestClass]
   public class ItemTest
   {
       [TestMethod]

       public void ItemConversion_createSpelling_number()
       {
           Item newItem = new Item();
           string actualValue = newItem.conversion(9);
           Assert.AreEqual("Nine", actualValue);

       }
        [TestMethod]
         public void ItemConversion_createDouble_Doublenumber()
       {
           Item newItem = new Item();
           string actualValue = newItem.conversion(99);
           Assert.AreEqual("ninetyNine", actualValue);

       }
   }
}
