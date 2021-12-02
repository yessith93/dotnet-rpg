namespace dotnet_rpg.Models
{
    public class Character
    {
        public int Id {get;set;}
        public string Name {get; set;}="frodo";
        public int HitPoints {get;set;} = 100;
        public int Stregnth {get;set;} = 10;
        public int Defense  {get;set;} = 10;
        public int intelligence {get;set;} = 10;
        public RpgClass Class {get;set; }=RpgClass.knight;

            

    }
}