namespace BlazorWasmDemo.Utilities
{
    public class MyApplicationState
    {
        public int VisitorCounter { get; set; } = 0;

        public void IncrementCounter() => VisitorCounter++;
    }
}
