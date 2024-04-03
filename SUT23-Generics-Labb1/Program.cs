using System.ComponentModel.DataAnnotations;

namespace SUT23_Generics_Labb1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            boxCollection boxes = new boxCollection();
            boxes.Add(new Box(10, 10, 10));
            boxes.Add(new Box(5, 2, 10));
            boxes.Add(new Box(15, 20, 30));
            boxes.Add(new Box(2, 4, 2));
            boxes.Add(new Box(2, 2, 4));
            boxes.Add(new Box(2, 2, 4));


            displayBoxes(boxes);



            //remove 
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("Remove Box with values 10 10 10");
            Console.WriteLine("-------------------------------------------");
            boxes.Remove(new Box(10, 10, 10));
            displayBoxes(boxes);



            //Contains
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Does the list contain Box with Values: 10 10 10 ? ");
            
            Box boxCheck = new Box(10, 10, 10);
            if (boxes.Contains(boxCheck))
            {
                Console.WriteLine("boxList Contains a box with:  \nWidth: {0}, \nHeight: {1} \nLength: {2}, \nVolume: {3}",
                boxCheck.Width.ToString(), boxCheck.Height.ToString(), boxCheck.Length.ToString(), boxCheck.Volume.ToString());
               
            }
            else
            {
                Console.WriteLine("nuhuuu no box with those values");
            }
            Console.ReadKey();
        }


        public static void displayBoxes(boxCollection boxes)
        {
            Console.WriteLine("\tHeight \tWidth \tLength \tVolume");
            foreach (Box box in boxes)
            {
                Console.WriteLine("\t{0}\t{1}\t{2}\t{3}",
                box.Height.ToString(), box.Width.ToString(), box.Length.ToString(), box.Volume.ToString());
            }
        }
    }
}