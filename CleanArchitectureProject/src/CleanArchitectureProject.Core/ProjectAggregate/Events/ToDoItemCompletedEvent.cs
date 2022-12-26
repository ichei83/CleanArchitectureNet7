using CleanArchitectureProject.Core.ProjectAggregate;
using CleanArchitectureProject.SharedKernel;

namespace CleanArchitectureProject.Core.ProjectAggregate.Events
{
    public class ToDoItemCompletedEvent : BaseDomainEvent
    {
        public ToDoItem CompletedItem { get; set; }

        public ToDoItemCompletedEvent(ToDoItem completedItem)
        {
            CompletedItem = completedItem;
        }
    }
}