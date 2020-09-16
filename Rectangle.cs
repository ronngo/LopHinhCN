using System;
namespace LopHCN
{

    internal class Rectangle{
         double width,height;

        public Rectangle(){           
        }
    public Rectangle(double width, double height){
        this.width = width;
        this.height = height;
    }


    public double GetArea()
    {
        return this.width * this.height;
    }

    public double GetPerimeter()
    {
        return (this.width + this.height);
    } 

    public string Display()
    {
        return "Rectangle{"+ "width = " + width + ", height = " + height +"}";
    }
    }       
}
