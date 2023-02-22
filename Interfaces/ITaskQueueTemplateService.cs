using TaskQueueTemplate.Models;
using System;

namespace TaskQueueTemplate.Interfaces
{
    public interface ITaskQueueTemplateService
    {
        TaskQueueItem GetNextTaskQueueTemplateItem(string claimant);

        void CancelTaskQueueTemplateItem(int queueId);

        void CompleteTaskQueueTemplateItem(int queueId, int completionId);

        void FailTaskQueueTemplateItem(int queueId, string claimant);

        TaskDetails GetTaskDetails(int taskId);

        int CallResource(TaskDetails taskDetails);
    }
}
