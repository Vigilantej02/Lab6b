using System;

class MainClass {
  //Method for Calculation
  public static double CalculateBMI(int heightA, int weightA)
  {
    double BMI = (weightA * 703) / (heightA * heightA);
    return BMI;
                }
  //Method for Printing The Result
  public static string BMIResults()
  //yay for using code you have already written.
  //also I took your advice about the else if loops, so much more readable
  { double BMI;
    if (BMI <= 18.5) {
      Console.WriteLine("You are underweight.");}
      else if (BMI <= 24.9){
          Console.WriteLine("You are a healthy weight.");}
          else if (BMI <= 29.9){
              Console.WriteLine("You are overweight.");}
              else { Console.WriteLine("You are obese.");};
                  return Convert.ToString(BMI);
                  }           
  public static void Main (string[] args) {
    //declaring my variables
    int i;
    double BMI;
    //declaring my arrays
    int[] height = new int [10];
    int[] weight = new int [10];
    //obtaining user input
    for(i = 0; i < 10; i++)
    {
      Console.WriteLine("Please enter Height in Inches.");
      int heightA = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("Please enter Weight in Pounds.");
      int weightA = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine(BMIResults());
    }
    //Alright I've been bashing my head against this problem for a couple days now and I can not figure out how to pass the //double BMI// to the result function. I'm just going to submit it like this and take the lost points to get an explanation.
  }
}