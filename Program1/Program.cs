//class Adder
//{
//    public int a;
//    public int b;
//}
//class Program
//{
//    private static int OverallTotal; 
//    private int tempTotal;
//    static void Main(string[] args)
//    {
//        Adder a;
//        a = new Adder();
//        a.a = 10; a.b = 20;
//        int c, d;
//        c = AddMul(a);
//        d = Multiply(a.a, a.b);
//        Console.WriteLine("Sum = " + c + "- Product = " + d);
//    }
//    public static int AddMul(Adder a)
//    {
//        int count;
//        count = a.a + a.b * a.a;
//        return count;
//    }
//    public static int Multiply(int a, int b)
//    {
//        return (a * b);
//    }
//}

////quiz question
////in this program there are 4 constants
////How many local variable are there in code? - eight
////how many instance variables are there ? -  three //variable is created only when object is created.
////how many class variables? - 1 //class can have two types one is static(class level variable)and instance (object level variable)
////what is the value of c after circle code is executed? - 210
////AddMul() invocation in main function is Call by reference.
//Multiply() invocation in main function is a call by value.
//how many ref type variables are present in the code? - string is a local variable of type ref answer is 3
//can you access the variable count in main() function? - no //scope is limited it is aavailable only till method executes.
//can you access the variable temptotal in main()? - no //first create instance then we can access. no direct access.
//how many function declaration are available in the above code snippet? - 0 //only declaration just specifies the name and parameters
//how many function definition are available in the above code snippet? - 3
//how many function invocation are available in the above code snippet? - 4 //adder is also a function invocation.
//how many objects of adder class is created in heap memory in this code snippet? - 1// two ref variable and 1 object







