using System;
using System.Collections.Generic;
namespace IntergenicResearchLibray
{
    class Program
    {
        static void Main(string[] args)
        {

                Library library1 = new Library(27, 6, 2020, 29, 6, 2020, "Phibie", "100 level", "The Hard Way", "QW345", "Ahmed","Pride of Barbados", "Pl345");
                Library library2 = new Library(4, 8, 2020, 7, 8, 2020, "Faruk", "200 level", "Why we struck", "DF478", "Blessing","Say Hello", "GT657");
                Library library3 = new Library(24, 4, 2020, 28, 4, 2020, "Mohammed", "300 level", "Medicine in the", "CCR345", "Wella","Metallurgy", "DS358");
                Library library4 = new Library(1, 2, 2020, 8, 2, 2020, "Carson", "100 level", "Woman in the Mirror", "RE345", "Floyd","A day to Remember", "CD347");
                Library library5 = new Library(5, 7, 2020, 10, 7, 2020, "Billy", "100 level", "Literature of History", "BB435", "Carren","Pale Yellow", "AR123");


            GenericDefaulterList<IDefaulters> library = new GenericDefaulterList<IDefaulters>(6); 


               library.Add(library1);                     
               library.Add(library2);                     
               library.Add(library3);                     
               library.Add(library4);                     
               library.Add(library5);  
             

            library.GetDefaulter();
        }
    }
}
