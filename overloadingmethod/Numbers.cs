public class Numbers
{
    public int FindMinimum(int number1,int number2)
    {
    int jumlahmin;

    if (number1 < number2){
            jumlahmin = number1;
        }
    else {
          jumlahmin = number2;
        }

    return jumlahmin;

    }
    public int FindMinimum(int number1,int number2,float number3)
    {
    int jumlahmin;

    if(number1 < number2 && number1 < number3){
         jumlahmin = number1;
      }  
    else if (number2 < number1 && number2 < number3){
         jumlahmin = number2;
    }  
    else {
        jumlahmin = (int)number3;
    }
    return jumlahmin; 
}
    public int FindMaximum(int number1,int number2)
    {
    int jumlahmax;
        if (number1 > number2){
            jumlahmax = number1;
        }
        else {
          jumlahmax = number2;
        }
        return jumlahmax; 
    }
    public int FindMaximum(int number1,int number2,float number3)
    {
    int jumlahmax;

    if(number1 > number2 && number1 > number3){
         jumlahmax = number1;
      }  
    else if (number2 > number1 && number2 > number3){
         jumlahmax = number2;
    }  
    else {
        jumlahmax = (int)number3;
    }
    return jumlahmax; 
}
 








}