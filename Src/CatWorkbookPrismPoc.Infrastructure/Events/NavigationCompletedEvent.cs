using Microsoft.Practices.Prism.Events;

namespace CatWorkbookPrismPoc.Infrastructure.Events
{
    /// <summary>
    /// A composite Presentation event 
    /// </summary>
    public class NavigationCompletedEvent : CompositePresentationEvent<string>
    {
    }
}