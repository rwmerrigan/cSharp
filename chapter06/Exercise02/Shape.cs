using System;

    public class Shape{

        public double Height {get; set;}
        public double Width {get; set;}
        public virtual double Area (){
            return Height * Width;
        }
    }
