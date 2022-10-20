//Написать программу, которая из сформированного массива строк 
//содержащих символы и числа создать массив из строк, в который 
//попадут только символы, не являющиеcя цифрами int.

char[,] ArrayChar()
{
int rows = new Random().Next(5, 10);
int col = new Random().Next(5, 10);
char[,] str = new char[rows, col];
var r = new Random();
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < col; j++)
    {    do

                str[i,j] = (char)r.Next(127);
            while (str[i,j] < '!');
    }
}
    return str;
}    

