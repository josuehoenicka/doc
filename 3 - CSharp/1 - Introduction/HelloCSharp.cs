using System;

namespace HelloCSharpVar
{
    class HelloCShap
    {
        static void Main(string[] args)
        {
            string HelloCSharpText = "Hello C#!";
            Console.WriteLine(HelloCSharpText);

            int firstNumber = 7;
            float secondNumber = 1.5f;
            double thirdNumer = 1.5;
            Console.WriteLine(firstNumber + secondNumber + thirdNumer);

            dynamic dynamicVariable = 10;
            dynamicVariable = "it's 10";
            Console.WriteLine(dynamicVariable);

            string responseSummary = dynamicVariable;
            Console.WriteLine($"{firstNumber} + {secondNumber} + {thirdNumer}, {responseSummary}");

            const string MyCamelVar = "Hi";
            Console.WriteLine(MyCamelVar);

            var myArray = new string[] {"Josue", "Hoenicka"};
            Console.WriteLine(myArray[1]);

            var myDictionary = new Dictionary<string, int>
            {
                {"Josue", 22},
                {"Chaina", 1}
            };
            Console.WriteLine(myDictionary["Josue"]);

            var myTuple = ("Josue", "Chaina");
            Console.WriteLine(myTuple);

            // BUCLES

            for(int index = 0; index <= 10; index++)
            {
               Console.WriteLine(index); 
            }

            foreach (var item in myArray)
            {
               Console.WriteLine(item);  
            }

            // ALTERNATIVE CONDITIONAL 

            int myInt = 12;

            if(myInt == 11)
            {
                // It's false
            } 
            else 
            {
                Console.WriteLine("It's true");
            };

            // FUNCTIONS

            MyFunction();
            
            Console.WriteLine(MyFunctionWithReturn(5));

            // CLASS

            var myClassVar = new MyClass("Josue");
            Console.WriteLine(myClassVar.myName);
        }
        static void MyFunction() 
        {
            Console.WriteLine("MyFunction works!");
        }

        static int MyFunctionWithReturn(int param) 
        {
            return 95 + param;
        }

        class MyClass
        {
            public string myName { get; set; }

            public MyClass(string myCurrentName)
            {
                this.myName = myCurrentName;
            }
        }
    }
}
