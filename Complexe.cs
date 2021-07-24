using System;

namespace nombre_complexe
{
    class Complexe
    {
     //le nombre reel
       public double Reel{get;set;}
       //le nombre imaginaire i
       public double Image{get;set;}   
        //constructeur
       public Complexe(double reel=0,double image=0){
           Reel=reel;
           Image=image;
       } 
       //affichage
      public void afficher(){
           Console.WriteLine("c= "+Reel+" +"+Image+"i ");
       }
       public double Module(){
           return Math.Sqrt(Reel*Reel+Image*Image);
       }
       //somme de 2 nombres complexes
       public Complexe somme(Complexe c){
           Complexe plus=new Complexe();
           plus.Reel=Reel+c.Reel;
           plus.Image=Image+c.Image;
           return plus; 
       }
       //produit de 2 nombres complexes
       public Complexe produit(Complexe c){
           Complexe fois=new Complexe();
           fois.Reel=(Reel*c.Reel-Image*c.Image);
           fois.Image=(Reel*c.Image+Image*c.Reel);
           return fois;
       }
      

    }
}
