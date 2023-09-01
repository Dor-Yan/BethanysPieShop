using Microsoft.AspNetCore.Components;

namespace BethanysPieShop.Components
{
    public partial class InboxCounter
    {
        private int MessageCount;

        [Inject]
        public ApplicationState ApplicationState { get; set; }

        protected override void OnInitialized()
        {
            MessageCount = new Random().Next(10);
            ApplicationState.NumberOfMessages = MessageCount;
        }
    }
}
