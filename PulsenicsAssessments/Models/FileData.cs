using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace PulsenicsAssessments.Models
{
    public class FileData
    {
        public int FileDataId { get; set; }
        public string? Name { get; set; }
        public string? Extension { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
        public virtual ObservableCollectionListSource<User> Users { get; } = new();
    }
}
