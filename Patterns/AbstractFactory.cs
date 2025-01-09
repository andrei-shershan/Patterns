namespace Patterns.Patterns
{
    internal class Application
    {
        private readonly IButton _button;

        public Application(IGUIFactory factory)
        {
            _button = factory.CreateButton();
        }

        public void RenderElement()
        {
            _button.Render();
        }
    }

    internal interface IButton
    {
        void Render();
    }

    internal class WindowsButton : IButton
    {
        public void Render()
        {
            Console.WriteLine("Windows button");
        }
    }

    internal class LinuxButton : IButton
    {
        public void Render()
        {
            Console.WriteLine("Linux button");
        }
    }

    internal interface IGUIFactory
    {
        IButton CreateButton();
    }

    internal class WindowsFactory : IGUIFactory
    {
        public IButton CreateButton()
        {
            return new WindowsButton();
        }
    }

    internal class LinuxFactory : IGUIFactory
    {
        public IButton CreateButton()
        {
            return new LinuxButton();
        }
    }
}

