public class ExampleClass
{
    public int MyProperty { get; set; }

    // Constructor to initialize the property
    public ExampleClass()
    {
        MyProperty = 0; // Initialize to a default value
    }

    public void MyMethod()
    {
        // Check for null before accessing the property. This is not needed if a constructor initialized it.
        //if (MyProperty != null)
        //{
            int value = MyProperty * 2; 
       // }
    }
}