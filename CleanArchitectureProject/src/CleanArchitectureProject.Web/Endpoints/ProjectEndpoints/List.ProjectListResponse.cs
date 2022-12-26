using CleanArchitectureProject.Core.ProjectAggregate;
using System.Collections.Generic;

namespace CleanArchitectureProject.Web.Endpoints.ProjectEndpoints
{
    public class ProjectListResponse
    {
        public List<ProjectRecord> Projects { get; set; } = new();
    }
}
