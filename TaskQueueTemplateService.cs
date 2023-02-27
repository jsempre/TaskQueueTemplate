using System.Linq;
using System.Threading.Tasks;

namespace TaskQueueTemplate
{
    public class TaskQueueTemplateService : ITaskQueueTemplateService
    {
        private Context _dbContext;
        private IValidator<TaskDetail> _queueItemValidator;
        public TaskQueueTemplateService(Context context, IValidator<TaskDetail> qItemValidator)
        {
            _queueItemValidator = qItemValidator;
            _dbContext = context;
        }

        public async Task AddQueueItemAsync(string taskDetails)
        {
            await _dbContext.AddTaskQueueItem(taskDetails);
        }

        public TaskQueueItem GetNextTaskQueueTemplateItem(string claimant)
        {
        }

        public void CancelTaskQueueTemplateItem(int queueId)
        {
        }

        public void CompleteTaskQueueTemplateItem(int queueId, int completionId)
        {
        }

        public void FailTaskQueueTemplateItem(int queueId, string claimant)
        {
        }

        public TaskDetails GetTaskDetails(int taskId)
        {
        }

        public int CallResource(TaskDetails taskDetails)
        {
        }
