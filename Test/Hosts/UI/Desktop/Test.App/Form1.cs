using Microsoft.Extensions.DependencyInjection;
using Test.BusinessLogic.Interfaces;

namespace Test.App
{
    public partial class Form1 : Form
    {

        private readonly IMessageManager _messageManager;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private  async void button1_Click(object sender, EventArgs e)
        {
            var message = new Context.Message()
            {

            };
            var service = serviceProvider.GetRequiredService<IMessageManager>();

            var result = await _messageManager.Create(message);
        }
    }
}