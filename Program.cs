// Задача 34. Задайте массив заполненный случайными трехзначными числами и напишите программу, которая покажет кол-во четных чисел в массиве.
Console.Clear();
Console.WriteLine("This programm create array which contains only three-digit positive numbers and find all even numbers.");
Console.Write("Enter array dimension:");
int arrayDim = Convert.ToInt32(Console.ReadLine());//enter dimension of an array
int [] newArray = FillArray(arrayDim);// get the filled array
EvenDigits(newArray);// try to find even numbers


//***********************************************//
int [] FillArray(int dim)
{
 int [] arrayWarning ={0};
    if(dim>0)// if dimension>0 then continue with filling
      { 
        int [] array = new int[dim];
        Console.Write("Your array is: ");
          for(int index=0; index<dim; index++)
             {
              Console.Write($"{array[index]=new Random().Next(100,1000)} ");
             }
        Console.WriteLine();
        return array;
      }
      else
      {
        Console.WriteLine("Warning! The entered dimesion is wrong. Please check and try again!"); 
        return arrayWarning;
      }
 
}
//***********************************************//

void EvenDigits (int [] array)
{
 int counter=0;
 Console.Write("Your array contains the following even numbers: ");
    for(int index=0; index<array.Length; index++)
       {
        int flag=array[index]%2;//check current element of the array for even
            if (flag==0)
              {
               counter++;
               Console.Write(array[index]+" ");
              }
       }
Console.WriteLine();
Console.WriteLine($"The total number of even numbers is {counter}.");
Console.WriteLine($"The total number of odd numbers is {array.Length-counter}.");
}
//***********************************************//