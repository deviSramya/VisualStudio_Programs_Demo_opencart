namespace opencart_register
{
    internal interface IWebDriver
    {
        object FindElement(object value);
        object Navigate();
        void Quit();

    }
}