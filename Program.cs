using System;

namespace nombre_complexe
{
    class Program
    {
        static void Main(string[] args)
        {
            Complexe c1=new Complexe(1,1);                      
            Complexe c2=new Complexe(2,3);       
            Complexe c3=c1.somme(c2);
            Complexe c4=c1.produit(c2);
            c1.afficher();
            c2.afficher();
            c3.afficher();
            c4.afficher();          
            Console.WriteLine(c1.Module());
            Console.ReadKey();
            

        }
    }
}
